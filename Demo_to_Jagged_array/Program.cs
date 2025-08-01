using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_to_Jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple jagged array example
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

            // Print the jagged array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row {0}: ", i);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
