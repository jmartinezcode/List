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
            //CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList = new CustomList<int>() { 17, 3, 37, 29, 47, 71, 23 };
            testList.Sort();
        }
    }
}
