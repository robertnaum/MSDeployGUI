using System.Text;

namespace MSDeployGUI.Model.Command
{
    public class DumpCommand : Command
    {
        public override Verb Verb => Verb.dump;
        protected override void BuildCommand(StringBuilder sb)
        {
            sb.Append(" -verb=dump");
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
