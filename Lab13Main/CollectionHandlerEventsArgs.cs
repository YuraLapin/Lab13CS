using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Main
{
    internal class CollectionHandlerEventsArgs: System.EventArgs
    {
        public string name;
        public string change;
        public Transport source;

        public CollectionHandlerEventsArgs(string name, string change, Transport source)
        {
            this.name = name;
            this.change = change;
            this.source = source;
        }

        public override string ToString()
        {
            return "name - " + name.ToString() + ", change - " + change.ToString() + ", source - [" + source.ToString() + "]";
        }
    }
}