using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Main
{
    internal class MyNewCollection: MyCollection
    {
        public string? Name
        {
            get;
            set;
        }

        public delegate void CollectionHandler(CollectionHandlerEventsArgs args);
        public event CollectionHandler? CollectionCountChanged;
        public event CollectionHandler? CollectionReferenceChanged;

        public MyNewCollection(string? name)
        {
            this.Name = name;
        }

        public virtual void OnCollectionCountChanged(CollectionHandlerEventsArgs args)
        {
            if (CollectionCountChanged != null)
            {
                CollectionCountChanged(args);
            }
        }

        public virtual void OnCollectionReferenceChanged(CollectionHandlerEventsArgs args)
        {
            if (CollectionReferenceChanged != null)
            {
                CollectionReferenceChanged(args);
            }
        }

        public override bool Remove(int index)
        {
            OnCollectionCountChanged(new CollectionHandlerEventsArgs(Name, "remove", this[index]));
            return base.Remove(index);
        }

        public override void Add(Transport t)
        {
            OnCollectionCountChanged(new CollectionHandlerEventsArgs(Name, "add", t));
            base.Add(t);
        }

        public override Transport this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                OnCollectionReferenceChanged(new CollectionHandlerEventsArgs(Name, "changed", value));
                base[index] = value;
            }
        }        
    }
}