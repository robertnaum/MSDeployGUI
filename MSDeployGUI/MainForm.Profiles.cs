using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSDeployGUI.Model;

namespace MSDeployGUI
{
    partial class MainForm
    {
        private void LoadProfiles(string BaseDirectory)
        {
            DirectoryInfo di = new DirectoryInfo(Path.Combine(BaseDirectory, "Profiles"));
            foreach (FileInfo fi in di.EnumerateFiles())
            {
                Profile p = Profile.LoadProfile(fi.FullName);
                _profiles.Add(p);
                ProfileListBox.Items.Add(p.Name);
            }
        }

        private void addProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new EditProfile(null))
            {
                form.ShowDialog();
            }
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

    }
}
