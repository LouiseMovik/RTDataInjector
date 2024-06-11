using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using RTDataInjector.Properties;

namespace RTDataInjector
{
    public partial class MainForm : Form
    {
        private Prioritizer prioritizer;
        IEnumerable<DirectoryInfo> patientDirectories;
        int dcmCount;
        List<string> injectedDcmFiles;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Optional for user: Reset previous property settings. 
            // Settings.Default.Reset();

            prioritizer = new Prioritizer();
            UpdateDICOMSettings();
            injectedDcmFiles = new List<string>();
            toolTipInjection.SetToolTip(btnStart, "Plans and Structure Sets will be given the status Unapproved.\nReferenced plans will be removed from the DICOM tags.");
            txtPath.Select();
        }

        /// <summary>
        /// Event handler method for the Start button is clicked. 
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            if (dcmCount > 0)
            {
                injectedDcmFiles = prioritizer.StartPrioritizedStore(patientDirectories, this);
                DeleteFiles();
            }
            else
            {
                MessageBox.Show("No DICOM files to inject in the selected folder", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnStart.Enabled = true;
        }

        /// <summary>
        /// Method for updating the DICOM settings in the GUI.
        /// </summary>
        private void UpdateDICOMSettings()
        {
            lblDaemonAEResult.Text = prioritizer.Injector.Daemon.AeTitle;
            lblDaemonIPResult.Text = prioritizer.Injector.Daemon.IpAddress;
            lblDaemonPortResult.Text = prioritizer.Injector.Daemon.Port.ToString();

            lblLocalAEResult.Text = prioritizer.Injector.Local.AeTitle;
            lblLocalIPResult.Text = prioritizer.Injector.Local.IpAddress;
            lblLocalPortResult.Text = prioritizer.Injector.Local.Port.ToString();
        }

        /// <summary>
        /// Event handler method for when the TestConnection button is clicked. 
        /// </summary>
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            bool contactOK = prioritizer.Injector.Echo();

            if (contactOK)
            {
                MessageBox.Show("Successful", "Testing DICOM Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed", "Testing DICOM Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Event handler method for when the SelectFolder button is clicked. 
        /// </summary>
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        /// <summary>
        /// Event handler method for when txtPath has been edited. 
        /// </summary>
        private void txtPath_Leave(object sender, EventArgs e)
        {
            try
            {
                // Counts subfolders containing dicom files
                DirectoryInfo mainDirectory = new DirectoryInfo(txtPath.Text);
                patientDirectories = mainDirectory.EnumerateDirectories().Where(r => Directory.EnumerateFiles(r.FullName, "*.dcm", SearchOption.AllDirectories).Count() > 0);
                lblIdentifiedFolders.Text = patientDirectories.Count().ToString();

                // Reading dicom files in specified folder including subdirectories
                dcmCount = Directory.EnumerateFiles(txtPath.Text, "*.dcm", SearchOption.AllDirectories).Count();
                lblIdentifiedDICOMFiles.Text = dcmCount.ToString();

                if (dcmCount > 0) // Edited .Length removed 3 places
                {
                    prgBar.Maximum = dcmCount - 1;
                }
            }
            catch (Exception exc)
            {
                if (txtPath.Text.Length > 0) lblIdentifiedDICOMFiles.Text = exc.Message.Substring(0, Math.Min(exc.Message.Length, 59)) + "...";
            }
        }

        /// <summary>
        /// Event handler method for when the MainForm is clicked. 
        /// </summary>
        private void MainForm_Click(object sender, EventArgs e)
        {
            txtPath_Leave(this, new EventArgs());
        }

        /// <summary>
        /// Event handler method for when entered is pressed in txtPath. 
        /// </summary>
        private void txtPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPath_Leave(this, new EventArgs());
            }
        }

        /// <summary>
        /// Updates the progress bar.
        /// </summary>
        public void UpdateProgressBar(int value)
        {
            prgBar.Value = value;
        }

        /// <summary>
        /// Writes the message used as argument in the output textbox. 
        /// </summary>
        public void WriteErrorMessage(string message)
        {
            txbOutput.AppendText(message);
            txbOutput.AppendText(Environment.NewLine);
        }

        /// <summary>
        /// Asks the user if the files should be deleted. 
        /// </summary>
        private void DeleteFiles()
        {
            DialogResult closeForm = MessageBox.Show("Injection successful for " + injectedDcmFiles.Count.ToString() + "/" + dcmCount.ToString() + " DICOM files.\nWould you like to delete the successfully injected files?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (closeForm == DialogResult.Yes)
            {
                foreach (string file in injectedDcmFiles)
                {
                    File.Delete(file);
                }

                foreach (string directory in Directory.GetDirectories(txtPath.Text))
                {
                    if (Directory.GetFiles(directory, "*", SearchOption.AllDirectories).Length == 0)
                    {
                        Directory.Delete(directory, false);
                    }
                }
            }
        }

        private void editLocalButton_Click(object sender, EventArgs e)
        {
            LocalEntitiesForm LocalEntitiesForm = new LocalEntitiesForm(); 
            LocalEntitiesForm.ShowDialog();
            prioritizer = new Prioritizer();
            UpdateDICOMSettings();
        }

        private void editDaemonButton_Click(object sender, EventArgs e)
        {
            DaemonEntitiesForm daemonEntitiesForm = new DaemonEntitiesForm();
            daemonEntitiesForm.ShowDialog();
            prioritizer = new Prioritizer();
            UpdateDICOMSettings();
        }
    }
}
