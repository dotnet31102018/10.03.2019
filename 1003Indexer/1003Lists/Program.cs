using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage g = new Garage();
            g.Add(new Car("Honda", 200_000, "Black"));
            g.Add(new Car("Mitsubishi", 160_000, "Orange"));
            g.Add(new Car("Renault", 200_000, "Blue"));
            g.Add(new Car("Fiat", 200_000, "Red"));

            foreach(Car c in g)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();
            Console.WriteLine( g[100000] );

            //g[1] = new Car()
        }
    }
}
