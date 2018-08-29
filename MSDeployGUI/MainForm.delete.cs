using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSDeployGUI.Model;
using MSDeployGUI.Model.Command;

namespace MSDeployGUI
{
    partial class MainForm
    {

        private void DatabindDeleteTab()
        {
            var deleteCmd = new DeleteCommand();

            _commands[Verb.delete] = deleteCmd;
        }
    }
}