using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003GenericSln
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create queue for int
            MyQueue<int> numbers = new MyQueue<int>();
            numbers.Enqueue(3);
            numbers.Enqueue(5);
            numbers.Enqueue(1);
            numbers.Enqueue(-2);
            numbers.Enqueue(30);

            Console.WriteLine("For each:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine($"Dequeue item returned: {numbers.Dequeue()}");
            Console.WriteLine();

            Console.WriteLine("For each:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            Console.WriteLine($"Item at index 3 : {numbers[3]}");

            // Create queue for float
            Console.WriteLine();
            Console.WriteLine("Now float queue:");
            MyQueue<float> numbersFloat = new MyQueue<float>();
            numbersFloat.Enqueue(3.7f);
            numbersFloat.Enqueue(2.4f);
            Console.WriteLine("For each:");
            foreach (float num in numbersFloat)
            {
                Console.WriteLine(num);
            }
        }
    }
}
