using System;

namespace LinkedLists
{
    /// <summary>
    /// Tests the linked lists
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests the linked lists
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            UnsortedLinkedList<int> list = new UnsortedLinkedList<int>();
            Console.WriteLine("\n=========== Właściwe ===========");
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.PrintList();
            Console.WriteLine("\n========== Usuwanie 200 ========");
            list.Remove(200);
            list.PrintList();

            Console.WriteLine("\n======= Usuwanie 300 ===========");
            list.Add(200);
            list.Remove(300);
            list.PrintList();

            Console.WriteLine("\n======= Usuwanie 100 ===========");
            list.Add(300);
            list.Remove(100);

            list.PrintList();
            //TestUnsortedLinkedList.RunTestCases();
            //TestSortedLinkedList.RunTestCases();

            Console.ReadKey();
        }
    }
}
