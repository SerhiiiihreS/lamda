using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lamda
{
    internal class Program
    {
        static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
        static int Count(int[] arr, Predicate<int> predicate)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (predicate(i))
                {
                    count++;
                }
            }
            return count;
        }
        static int Count1(int[] arr, Predicate<int> predicate)
        {
            int count = 0;
            int t = 0;
            int n = 0;
            for (int j = 0;j< arr.Length; j++)
            {
                int r = arr[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == r)
                    {
                        t++;
                    }
                }
                if (t == 1)
                {
                    foreach (int i in arr)
                    {
                        if (predicate(i))
                        {
                            count++;
                        }
                    }
                    return count;
                }

            }
        }




        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-7, 40);
            }
            Print(arr);
            int count = Count(arr, el => el % 7 == 0);
            Console.WriteLine("Count %7 ={0} ", count);
            Console.WriteLine();
            int count2= Count(arr, el1 => el1 >=0);
            Console.WriteLine("Count >0 ={0} ", count2);
            Console.WriteLine();
            int count3= Count1(arr,el3 => el3<0 );


        }
    }
}
