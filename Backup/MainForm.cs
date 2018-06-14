using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace AccessControlDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = filenameTextBox.Text;
            if (File.Exists(filename))
            {
                aceInformationTextBox.Text = GetAccessControlInformation(filename);
            }
            else
            {
                MessageBox.Show("Given file does not exist.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private string GetAccessControlInformation(string filename)
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("ACE entries for the file \"" + filename + "\":");
            info.AppendLine();
            FileSecurity security = File.GetAccessControl(filename);
            AuthorizationRuleCollection acl = security.GetAccessRules(true, true,
                typeof(System.Security.Principal.NTAccount));
            foreach (FileSystemAccessRule ace in acl)
            {
                string aceInfo = GetAceInformation(ace);
                info.AppendLine(aceInfo);
            }
            return info.ToString();
        }

        private string GetAceInformation(FileSystemAccessRule ace)
        {
            StringBuilder info = new StringBuilder();
            string line = string.Format("Account: {0}", ace.IdentityReference.Value);
            info.AppendLine(line);
            line = string.Format("Type: {0}", ace.AccessControlType);
            info.AppendLine(line);
            line = string.Format("Rights: {0}", ace.FileSystemRights);
            info.AppendLine(line);
            line = string.Format("Inherited ACE: {0}", ace.IsInherited);
            info.AppendLine(line);
            return info.ToString();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (browseFileDialog.ShowDialog() == DialogResult.OK)
            {
                filenameTextBox.Text = browseFileDialog.FileName;
            }
        }

        private void addSelfToAclButton_Click(object sender, EventArgs e)
        {
            string filename = filenameTextBox.Text;
            if (File.Exists(filename))
            {
                AddSelfToAcl(filename);
                aceInformationTextBox.Text = GetAccessControlInformation(filename);
            }
            else
            {
                MessageBox.Show("Given file does not exist.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private static void AddSelfToAcl(string filename)
        {
            // create a rule for self
            WindowsIdentity self = System.Security.Principal.
                WindowsIdentity.GetCurrent();
            FileSystemAccessRule rule = new FileSystemAccessRule(
                self.Name, FileSystemRights.FullControl,
                AccessControlType.Allow);
            // add the rule to the file's existing ACL list
            FileSecurity security = File.GetAccessControl(filename);
            AuthorizationRuleCollection acl = security.GetAccessRules(true, true,
                typeof(System.Security.Principal.NTAccount));
            security.AddAccessRule(rule);
            // persist changes and update view
            File.SetAccessControl(filename, security);
        }
    }
}