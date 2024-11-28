using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    internal class Class9_ForEach
    {
        static void Main(string[] args)
        {
            //looping in while,for,do-while,foreach
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int i = 0;
            Console.WriteLine("The Array Elements are......");
            while (i < a.Length) { 
                Console.Write(a[i++]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("The Array Elements are......");
            foreach (var item in a)
            {
                Console.Write(item+" ");
            }

        }
    }
}
