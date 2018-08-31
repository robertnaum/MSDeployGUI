using Microsoft.WindowsAPICodePack.Dialogs;
using MSDeployGUI.Model;
using MSDeployGUI.Model.Command;
using MSDeployGUI.Provider;
using System;
using System.Windows.Forms;

namespace MSDeployGUI
{
    partial class MainForm
    {

        private void DatabindDumpTab()
        {
            var dumpCmd = new DumpCommand();
            dumpsourceProviderBox.DataBindings.Add("Text", dumpCmd, "sourceProvider", true, DataSourceUpdateMode.OnPropertyChanged);
            dumpsourcePathToPOBox.DataBindings.Add("Text", dumpCmd, "SourcePathToPOBox", true, DataSourceUpdateMode.OnPropertyChanged);
            _commands[Verb.dump] = dumpCmd;
            //dumpsourceProviderBox.SelectedIndex = 0;
        }

        private void dumpsourceProviderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            if (box?.SelectedItem.ToString() == SourceProvider.webServer)
            {
                dumpSourceFileFolderDialogBtn.Enabled = false;
            }
            else
            {
                dumpSourceFileFolderDialogBtn.Enabled = true;
            }
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
