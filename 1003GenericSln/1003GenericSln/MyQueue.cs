using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003GenericSln
{
    class MyQueue<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            T item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public override string ToString()
        {
            string result = $"My Queue {items.Count}";
            foreach(T t in items)
            {
                result += t + "\n";
            }
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
        }

        
    }
}
