using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MSDeployGUI.Model;

namespace MSDeployGUI
{
    public partial class EditProfile : Form
    {
        public EditProfile(Profile p)
        {
            InitializeComponent();
            if (p != null)
            {
                NameTxt.Text = p.Name;
                ServerTxt.Text = p.Server;
                SiteNameTxt.Text = p.SiteName;
                UserNameTxt.Text = p.UserName;
                PasswordTxt.Text = p.Password;
                DestinationURL.Text = p.DestinationURL;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTxt.Text))
            {
                await InvalidText(NameTxt);
                return;
            }
            if (string.IsNullOrEmpty(ServerTxt.Text))
            {
                await InvalidText(ServerTxt);
                return;
            }
            if (string.IsNullOrEmpty(SiteNameTxt.Text))
            {
                await InvalidText(SiteNameTxt);
                return;
            }
            if (string.IsNullOrEmpty(UserNameTxt.Text))
            {
                await InvalidText(UserNameTxt);
                return;
            }

            if (string.IsNullOrEmpty(PasswordTxt.Text))
            {
                await InvalidText(PasswordTxt);
                return;
            }

            SaveProfile();
            this.Close();
        }

        private async Task InvalidText(TextBox tb)
        {
            Color originalColor = tb.BackColor;
            Color invalidColor = ColorTranslator.FromHtml("#FF0000");
            tb.BackColor = invalidColor;
            await Task.Delay(500);
            tb.BackColor = originalColor;
        }
        private void SaveProfile()
        {
            Profile p = new Profile
            {
                Name = NameTxt.Text,
                Server = ServerTxt.Text,
                SiteName = SiteNameTxt.Text,
                UserName = UserNameTxt.Text,
                Password = PasswordTxt.Text,
                DestinationURL = DestinationURL.Text
            };
            p.SaveProfile(AppDomain.CurrentDomain.BaseDirectory);
        }

    }
}
