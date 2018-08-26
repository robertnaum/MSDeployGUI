using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSDeployGUI.Model;

namespace MSDeployGUI
{
    public partial class MainForm : Form
    {
        private readonly IList<Profile> _profiles = new List<Profile>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo di = new DirectoryInfo(Path.Combine(BaseDirectory, "Profiles"));
            foreach (FileInfo fi in di.EnumerateFiles())
            {
                Profile p = Profile.LoadProfile(fi.FullName);
                _profiles.Add(p);
                ProfileListBox.Items.Add(p.Name);
            }

            SetupMenuItems();
            RefreshCommand();
        }
        private void SetupMenuItems()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);

            ToolStripMenuItem helpMenu = menuStrip1.Items[1] as ToolStripMenuItem;
            if (helpMenu != null)
            {
                helpMenu.DropDownItems[0].Text = principal.IsInRole(WindowsBuiltInRole.Administrator) ? "Running as Administrator" : "Running as Non-Administrator";
            }
        }

        private string GenerateCommand()  //pass in Designer object?
        {
            const string DEPLOY_COMMAND = "msdeploy.exe";
            StringBuilder cmd = new StringBuilder();
            cmd.Append($"{DEPLOY_COMMAND}");
            if (!string.IsNullOrEmpty(VerbBox.SelectedItem?.ToString()))
            {
                cmd.Append($" -verb:{VerbBox.SelectedItem.ToString()}");
            }
            if (!string.IsNullOrEmpty(sourceProviderBox.SelectedItem?.ToString()))
            {
                cmd.Append($" -source:{sourceProviderBox.SelectedItem.ToString()}");
            }
            if (!string.IsNullOrEmpty(destProviderBox.SelectedItem?.ToString()))
            {
                cmd.Append($" -dest:{destProviderBox.SelectedItem.ToString()}");
            }

            if (WhatIfChkBox.Checked)
            {
                cmd.Append(" -whatif");
            }

            return cmd.ToString();
        }

        private void RefreshCommand()
        {
            commandBox.Text = GenerateCommand();
        }

        private void addProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new EditProfile(null))
            {
                form.ShowDialog();
            }
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CancelEventArgs f = new CancelEventArgs();
            Application.Exit(f);
            //check f.Cancel ???
        }


        private void ProfileListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ProfileListBox.SelectedItem != null)
            {
                var p = _profiles.FirstOrDefault(pro => pro.Name == ProfileListBox.SelectedItem.ToString());
                if (p != null)
                {
                    using (var form = new EditProfile(p))
                    {
                        form.ShowDialog();
                    }
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (var form = new EditSettings())
            {
                form.ShowDialog();
            }
        }
        private void VerbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sourceProviderBox.Enabled = VerbBox.SelectedItem.ToString() != Verb.delete;
            destProviderBox.Enabled = $@"{Verb.delete},{Verb.sync}".Contains(VerbBox.SelectedItem.ToString());
            RefreshCommand();
        }

        private void sourceProviderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCommand();
        }
        private void destProviderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCommand();
        }
        private void WhatIfChkBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCommand();
        }

    }
}
