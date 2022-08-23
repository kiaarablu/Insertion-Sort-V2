using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort_V2
{
    internal class Sorting
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minindex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minindex])
                    {
                        minindex = j;
                    }

                }
                int temp = array[minindex];
                array[minindex] = array[i];
                array[i] = temp;
            }
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }


        }
    }
}
