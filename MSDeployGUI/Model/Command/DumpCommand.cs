using System.Text;
using MSDeployGUI.Provider;

namespace MSDeployGUI.Model.Command
{
    public class DumpCommand : Command
    {
        public override Verb Verb => Verb.dump;
        protected override void BuildCommand(StringBuilder sb)
        {
            sb.Append(" -verb=dump");
            sb.Append($" -source:{sourceProvider}");
            if (sourceProvider != SourceProvider.webServer)
            {
                sb.Append($" {SourcePathToPOBox}");
            }
        }

        private string _sourceProvider;
        public string sourceProvider
        {
            get => _sourceProvider;
            set
            {
                if (Equals(value, _sourceProvider)) return;
                _sourceProvider = value;
                OnPropertyChanged();
            }
        }

        private string _sourcePathToPOBox;
        public string SourcePathToPOBox
        {
            get => _sourcePathToPOBox;
            set
            {
                if (Equals(value, _sourcePathToPOBox)) return;
                _sourcePathToPOBox = value;
                OnPropertyChanged();
            }
        }

    }
}
