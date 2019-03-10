using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003Generics
{
    class PrintDataFloat
    {
        private float _data;

        public PrintDataFloat(float data)
        {
            _data = data;
        }

        public void Print()
        {
            Console.WriteLine("!============ " + _data + "============!");
        }
    }
}
