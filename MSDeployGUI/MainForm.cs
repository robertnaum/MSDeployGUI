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
using MSDeployGUI.Model.Command;

namespace MSDeployGUI
{
    public partial class MainForm : Form
    {
        private readonly IList<Profile> _profiles = new List<Profile>();
        private readonly Command[] _commands = new Command[5];
        private Command CurrentCommand;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            LoadProfiles(BaseDirectory);
            SetupMenuItems();
            //setup all the different TAB databinding
            DatabindSyncTab();
            DatabindDumpTab();
            DatabindDeleteTab();
            DatabindGetSystemInfoTab();
            DatabindGetDependenciesTab();

            CurrentCommand = _commands[Verb.dump];
            CurrentCommand.RefreshCommandBox(commandBox);
            //            RefreshCommand();
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

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CancelEventArgs f = new CancelEventArgs();
            Application.Exit(f);
            //check f.Cancel ???
        }



        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (var form = new EditSettings())
            {
                form.ShowDialog();
            }
        }

        private void tabCentralControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = sender as TabControl;
            CurrentCommand = _commands[tab.SelectedIndex];
            CurrentCommand.RefreshCommandBox(commandBox);
        }

    }
}
