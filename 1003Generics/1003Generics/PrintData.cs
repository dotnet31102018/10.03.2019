using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003Generics
{
    class PrintData
    {
        private int _data;

        public PrintData(int data)
        {
            _data = data;
        }

        public void Print()
        {
            Console.WriteLine("!============ " + _data + "============!");
        }
    }
}
