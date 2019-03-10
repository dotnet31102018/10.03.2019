using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003Generics
{
    class PrintDataGeneric<T> where T : new()
    {
        private T _data;
        private T _mydata;

        public T this [int index]
        {
            get
            {
                return _data;
            }
        }
        public PrintDataGeneric(T data)
        {
            _data = data;
            _mydata = new T();
        }

        public T data2
        {
            get; private set;
        } 
        public T data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
        public void Print()
        {
            Console.WriteLine("!============ " + _data + "============!");
        }

    }
}
