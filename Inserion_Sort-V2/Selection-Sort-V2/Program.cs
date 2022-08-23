using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 22, 8, 12, 53, 84, 73, 81 };
            Sorting a = new Sorting();
            a.Sort(array);
            Console.ReadKey();
        }
    }
}
