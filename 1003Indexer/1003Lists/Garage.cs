using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003Lists
{
    class Garage : IEnumerable<Car>
    {
        private List<int> numbers = new List<int>() { 55, 100, 2003 };
        private List<Car> cars = new List<Car>();
        internal Car this[string name]
        {
            get
            {
                // search for car with this name
                foreach(Car c in cars)
                {
                    if (c.Name == name)
                        return c;
                }
                return null;
            }
        }
        internal Car this [int index]
        {
            get
            {
                //return new Car("new", index, "black");
                if (index >= cars.Count)
                    return null;
                return cars[index];
            }
            set
            {
                if (index >= cars.Count)
                    return;
                cars[index] = value;
            }
        }

        public Garage()
        {
        }

        public void Add(Car c)
        {
            cars.Add(c);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            //List<int> arr = new List<int>() { 1, 2, 3 };
            //return arr.GetEnumerator();

            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        public void Remove(Car c)
        {
            cars.Remove(c);
        }

    }
}
