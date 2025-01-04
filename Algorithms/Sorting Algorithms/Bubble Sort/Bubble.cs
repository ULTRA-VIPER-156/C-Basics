using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] ints = { 21, 2, 1, 5, 8 };


            for (int pass = 0; pass < ints.Length; pass++)
            {
                for (int current = 1; current < ints.Length-pass; current++)
                {

                    int prev = current - 1;
                    if (ints[prev] > ints[current])
                    {
                        Swap(prev, current,ref ints);

                    }

                }
            }
            foreach (int i in ints) 
            {
                Console.WriteLine(i);
            }
        }
        static public void Swap(int a, int b,ref int[] ints) 
        {
            int temp = ints[a];
            ints[a] = ints[b];
            ints[b] = temp;
        
        }
    }
}
