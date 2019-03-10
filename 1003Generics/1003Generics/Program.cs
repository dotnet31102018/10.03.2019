using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            PrintDataGeneric<int> pData = new PrintDataGeneric<int>(10);
            PrintDataGeneric<float> pDataF = new PrintDataGeneric<float>(10);
            PrintDataGeneric<Book> pDataBook = new PrintDataGeneric<Book>(new Book("a", "b", "c", "d"));

            Console.WriteLine(pData.GetType());
        }
    }
}
