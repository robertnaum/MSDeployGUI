using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSDeployGUI.Model;
using MSDeployGUI.Model.Command;

namespace MSDeployGUI
{
    partial class MainForm
    {
        private void DatabindSyncTab()
        {
            var syncCmd = new SyncCommand();
            syncsourceProviderBox.DataBindings.Add("Text", syncCmd, "SourceProvider", true, DataSourceUpdateMode.OnPropertyChanged);
            syncdestProviderBox.DataBindings.Add("Text", syncCmd, "DestProvider", true, DataSourceUpdateMode.OnPropertyChanged);            
            _commands[Verb.sync] = syncCmd;

        }

    }
}
