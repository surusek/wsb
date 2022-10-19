using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {

        static void
        PrintAllOf(UnorderedIntDynamicArray arr, int i) {
            List<int> li = arr.AllIndexesOf(i);
            Console.Write('{');
            foreach (int n in li) {
                Console.Write(n);
                Console.Write(", ");
            }

            Console.WriteLine('}');
        }

        /// <summary>
        /// Tests LastIndexOf and AllIndexesOf methods
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // build test dynamic array
            UnorderedIntDynamicArray uida = new UnorderedIntDynamicArray();
            uida.Add(1);
            uida.Add(2);
            uida.Add(3);
            uida.Add(1);
            uida.Add(10);
            // Console.WriteLine(uida);

            // test LastIndexOf with one item in dynamic array
            Console.WriteLine(uida.LastIndefOf(3));

            // test LastIndexOf with multiple items in the dynamic array
            Console.WriteLine(uida.LastIndefOf(1));
            // test LastIndexOf with item not in dynamic array
            Console.WriteLine(uida.LastIndefOf(100));
            // test AllIndexesOf with one item in dynamic array
            PrintAllOf(uida, 2);
            // test AllIndexesOf with multiple items in dynamic array
            PrintAllOf(uida, 1);
            // test AllIndexesOf with item not in dynamic array
            PrintAllOf(uida, 420);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
