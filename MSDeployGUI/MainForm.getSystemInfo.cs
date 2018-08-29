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
        private void DatabindGetSystemInfoTab()
        {
            var getSystemInfo = new GetSystemInfoCommand();

            _commands[Verb.getSystemInfo] = getSystemInfo;
        }


    }
}
