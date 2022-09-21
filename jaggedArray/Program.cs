using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggeArray = new int[3][];

            jaggeArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggeArray[1] = new int[] { 1, 2, 3 };
            jaggeArray[2] = new int[] { 1, 2 };

            for(int i=0; i<jaggeArray.Length; i++)
            {
                for(int j=0; j<jaggeArray[i].Length; j++)
                {
                    Console.Write(jaggeArray[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
