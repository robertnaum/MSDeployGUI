using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSDeployGUI.Provider;
using Microsoft.WindowsAPICodePack.Dialogs;
using MSDeployGUI.Model;
using MSDeployGUI.Model.Command;

namespace MSDeployGUI
{
    partial class MainForm
    {

        private void DatabindDumpTab()
        {
            var dumpCmd = new DumpCommand();
            dumpsourceProviderBox.DataBindings.Add("Text", dumpCmd, "SourceProvider", true, DataSourceUpdateMode.OnPropertyChanged);
            _commands[Verb.dump] = dumpCmd;
            dumpsourceProviderBox.SelectedIndex = 0;
        }

        private void dumpsourceProviderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCommand?.RefreshCommandBox(commandBox);
        }

        private void dumpSourceFileFolderDialogBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = dumpsourceProviderBox.SelectedItem.ToString();
            if (selectedItem == SourceProvider.contentPath || 
                selectedItem == SourceProvider.filePath)
            {
                using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
                {
                    //                        dialog.IsFolderPicker = true;
                    if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                    {
                        dumpsourcePathToPOBox.Text = dialog.FileName;
                        CurrentCommand?.RefreshCommandBox(commandBox);
                    }
                }
            }
            else if (selectedItem == SourceProvider.dirPath)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        dumpsourcePathToPOBox.Text = fbd.SelectedPath;
                        CurrentCommand?.RefreshCommandBox(commandBox);
                    }
                }
            }
        }
    }
}
