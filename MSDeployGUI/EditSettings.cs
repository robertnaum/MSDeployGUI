using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSDeployGUI.Model;

namespace MSDeployGUI
{
    public partial class EditSettings : Form
    {
        private const string MsDeployPathKey = "msdeployPath";
        public EditSettings()
        {
            InitializeComponent();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;

            MsdeployPathTxt.Text = app.Settings[MsDeployPathKey].Value;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            app.Settings.Remove(MsDeployPathKey);
            app.Settings.Add(MsDeployPathKey, MsdeployPathTxt.Text);
            config.Save(ConfigurationSaveMode.Modified);
            this.Close();
        }
    }
}
