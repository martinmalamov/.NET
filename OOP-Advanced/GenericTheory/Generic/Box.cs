using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> items;

        public Box()
        {
            this.items = new List<T>();
        }

        public int Count
        {
            get { return this.items.Count; }
            //   set { count = value; }
        }

        public T Remove()
        {
            var item = items[items.Count - 1];
            this.items.RemoveAt(items.Count - 1);
            return item;
        }
        public void Add(T element)
        {
            this.items.Add(element);
        }
    }
}
