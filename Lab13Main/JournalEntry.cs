using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Main
{
    internal class JournalEntry
    {
        public string name;
        public string changeType;
        public string changed;

        public JournalEntry(string name, string changeType, string changed)
        {
            this.name = name;
            this.changeType = changeType;
            this.changed = changed;
        }

        public override string ToString()
        {
            return "name - " + name + ", changeType - " + changeType + ", changed - " + changed;
        }
    }
}