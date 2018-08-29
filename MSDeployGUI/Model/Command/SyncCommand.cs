using System.Text;

namespace MSDeployGUI.Model.Command
{
    public class SyncCommand : Command
    {

        public override Verb Verb => Verb.sync;
        protected override void BuildCommand(StringBuilder sb)
        {
            sb.Append(" -verb=sync");
            if (!string.IsNullOrEmpty(SourceProvider))
            {
                sb.Append($" -source:{SourceProvider}=");
            }
        }

        private string _sourceProvider;
        public string SourceProvider {
            get => _sourceProvider;
            set {
                if (Equals(value, _sourceProvider)) return;
                _sourceProvider = value;
                OnPropertyChanged();
            } }

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
