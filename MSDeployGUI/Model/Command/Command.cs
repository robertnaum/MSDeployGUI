using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSDeployGUI.Annotations;

namespace MSDeployGUI.Model.Command
{
    public abstract class Command : INotifyPropertyChanged
    {
        public abstract Verb Verb { get; }
        protected abstract void BuildCommand(StringBuilder sb);
        public string GenerateCommand()
        {
            var sb = new StringBuilder();
            sb.Append("msdeploy.exe");
            BuildCommand(sb);
            return sb.ToString();
        }

        public void RefreshCommandBox(ComboBox box)
        {
            box.Text = GenerateCommand();
        }
        public bool WhatIf { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
