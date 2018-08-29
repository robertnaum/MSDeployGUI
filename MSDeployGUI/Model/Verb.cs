using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDeployGUI.Model
{
    //This is a SUPER Enum, designed to be better than standard enums.
    public class Verb
    {
        protected int index;
        protected string name;
        protected static readonly IDictionary<int, Verb> values = new Dictionary<int, Verb>();

        public static readonly Verb sync = new Verb(0, "sync");
        public static readonly Verb dump = new Verb(1, "dump");
        public static readonly Verb delete = new Verb(2, "delete");
        public static readonly Verb getSystemInfo = new Verb(3, "getSystemInfo");
        public static readonly Verb getDependencies = new Verb(4, "getDependencies");

        protected Verb(int index, string name)
        {
            this.index = index;
            this.name = name;
            values.Add(index, this);
        }

        public static implicit operator int(Verb verb) => verb.index;
        public static implicit operator Verb(int index) => values.TryGetValue(index, out var verb) ? verb : null;
        public override string ToString() => this.name;
        public static implicit operator string(Verb verb) => verb?.ToString();

        public static implicit operator Verb(string name) => name == null
            ? null
            : values.Values.FirstOrDefault(item => name.Equals(item.name, StringComparison.CurrentCultureIgnoreCase));

    }
}
