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
            CustomList<int> testList = new CustomList<int>();

            Console.WriteLine("The Capacity is: {0}", testList.Capacity);
            Console.WriteLine("The Count is: {0}\n", testList.Count);
            testList.Add(5);
            testList.Add(3);
            testList.Add(4);
            testList.Add(6);
            testList.Add(1);
            Console.WriteLine("The Capacity is: {0}", testList.Capacity);
            Console.WriteLine("The Count is: {0}\n", testList.Count);
            for (int i = 0; i < testList.Count; i++)
            {
                Console.WriteLine(testList[i]);
            }
            // Console.WriteLine(testList[5]); //should throw IndexOutOfRangeException 
            Console.Read();

        }
    }
}
