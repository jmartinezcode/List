using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing methods and properties
            CustomList<int> testList = new CustomList<int>() { 1, 3, 2, 3, 5 };

            //Console.WriteLine("The Capacity is: {0}", testList.Capacity);
            //Console.WriteLine("The Count is: {0}\n", testList.Count);

            //testList.Remove(7);

            //Console.WriteLine("The Capacity is: {0}", testList.Capacity);
            //Console.WriteLine("The Count is: {0}\n", testList.Count);
            //foreach (var item in testList)
            //{
            //    Console.Write("{0} ", item);
            //}

            Console.ReadLine();
        }
    }
}
