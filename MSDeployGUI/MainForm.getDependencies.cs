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
        private void DatabindGetDependenciesTab()
        {
            var getDependenciesCmd = new GetDependenciesCommand();

            _commands[Verb.getDependencies] = getDependenciesCmd;
        }



    }
}
