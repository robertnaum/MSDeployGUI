using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDeployGUI.Provider
{
    public class SourceProvider
    {
        protected int index;
        protected string name;
        protected static readonly IDictionary<int, SourceProvider> values = new Dictionary<int, SourceProvider>();

        public static readonly SourceProvider contentPath = new SourceProvider(0, "contentPath");
        public static readonly SourceProvider filePath = new SourceProvider(1, "filePath");
        public static readonly SourceProvider dirPath = new SourceProvider(2, "dirPath");
        public static readonly SourceProvider webServer = new SourceProvider(3, "webServer");

        protected SourceProvider(int index, string name)
        {
            this.index = index;
            this.name = name;
            values.Add(index, this);
        }

        public static implicit operator int(SourceProvider sp) => sp.index;
        public static implicit operator SourceProvider(int index) => values.TryGetValue(index, out var sp) ? sp : null;
        public override string ToString() => this.name;
        public static implicit operator string(SourceProvider sp) => sp?.ToString();

        public static implicit operator SourceProvider(string name) => name == null
            ? null
            : values.Values.FirstOrDefault(item => name.Equals(item.name, StringComparison.CurrentCultureIgnoreCase));
    }
}
