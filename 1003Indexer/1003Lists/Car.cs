using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003Lists
{
    class Car
    {
        public string Name { get; private set;}
        public int Price { get; private set; }
        public string Color { get; private set; }

        public Car(string name, int price, string color)
        {
            Name = name;
            Price = price;
            Color = color;
        }

        public override string ToString()
        {
            return $"Car Name : {Name} Price : {Price} Color : {Color} ";
        }
    }
}
