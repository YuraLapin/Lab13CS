using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Main
{
    internal class Journal
    {
        public List<JournalEntry> list = new List<JournalEntry>();
        public void Add(CollectionHandlerEventsArgs args)
        {
            list.Add(new JournalEntry(args.name, args.change, args.source.name));
        }

        public void Print()
        {
            Console.WriteLine("[");
            foreach(JournalEntry je in list)
            {
                Console.WriteLine(je.ToString());
            }
            if (list.Count == 0)
            {
                Console.WriteLine("-");
            }
            Console.WriteLine("]");
        }
    }    
}