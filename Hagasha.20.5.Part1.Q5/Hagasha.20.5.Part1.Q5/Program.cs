using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagasha._20._5.Part1.Q5
{
    class Program
    {
        static void Main(string[] args)
        {

            int total3 = TotalMarks(8, 9, 8);
            Console.WriteLine(total3);
        }

            // We will use params when we need to run a function for an array 
            // with undefined length (number of values)

            public static int TotalMarks(params int[] list)
            {
                int total = 0;
                for (int i = 0; i < list.Length; i++)
                    total += list[i];
                return total;
            }

        
    }
}
