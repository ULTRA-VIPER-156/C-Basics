using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 32, 356, 1, 3768, 2342, 86435, 1257 ,21,42,1,51,51,62,61,552,151,131,};


            //Selection Sort 


            //Outer loop to parse through the whole array 
            for (int pass = 0; pass < ints.Length; pass++) {
                //Decleration of the min value And setting it to be the fist postion of the array 
                //In this case we are going to set it to be equal to pass so that it updates with each pass
                int min = pass;

                //inner for loop for comparing elements 

                for (int i = pass; i < ints.Length; i++)
                {
                    int compare = ints[pass];//making compare equal to some element in the array 

                    if (ints[i] < compare)//testing to find the smaller element 
                    {
                        min = i;
                    }

                }
                Swap(min, pass,ref ints);
        } 
        
//This will display the sorted array after the Algorithm 
            foreach(int j in ints)
            {
                Console.WriteLine(j);
            }
        }
        //This is the swap method 
        static void Swap(int a, int b, ref int[] ints) 
        {

            int temp = ints[a];
            ints[a]=ints[b];
            ints[b]=temp;

        
        
        
        
        }
    }
}
