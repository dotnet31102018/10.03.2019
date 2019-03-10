using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003Generics
{
    class PrintDataDouble
    {
        private double _data;

        public PrintDataDouble(double data)
        {
            _data = data;
        }

        public void Print()
        {
            Console.WriteLine("!============ " + _data + "============!");
        }
    }
}
