using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    internal class Class6_Sort
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            Console.WriteLine("Enter Elements: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[" + i + "]= ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Before Sort");
            for (int i = 0; i < a.Length; i++) {
                Console.Write(a[i]+ "\t");
            }

            Array.Sort(a);
            Console.WriteLine("After Sort");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }
    }
}
