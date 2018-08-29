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
    public class DeleteCommand : Command
    {
        public override Verb Verb => Verb.delete;
        protected override void BuildCommand(StringBuilder sb)
        {
            sb.Append(" -verb=delete");
        }

        private string _destProvider;
        public string DestProvider
        {
            get => _destProvider;
            set
            {
                if (Equals(value, _destProvider)) return;
                _destProvider = value;
                OnPropertyChanged();
            }
        }
    }
}
