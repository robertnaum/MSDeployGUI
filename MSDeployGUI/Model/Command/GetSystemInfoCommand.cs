using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MSDeployGUI.Annotations;

namespace MSDeployGUI.Model.Command
{
    public class GetSystemInfoCommand : Command
    {
        public override Verb Verb => Verb.getSystemInfo;
        protected override void BuildCommand(StringBuilder sb)
        {
            sb.Append(" -verb=getSystemInfo");
        }

        private string _sourceProvider;
        public string SourceProvider
        {
            get => _sourceProvider;
            set
            {
                if (Equals(value, _sourceProvider)) return;
                _sourceProvider = value;
                OnPropertyChanged();
            }
        }
    }
}
