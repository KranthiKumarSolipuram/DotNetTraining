using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    internal class Class8_JoggedArray
    {
        //Jogged Array
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0]=new int[2];
            a[1]=new int[3];
            a[2]=new int[4];

            Console.WriteLine("Enter the Jogged Array Elements");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < a[i].Length; j++)

                {
                    Console.Write("a[" + i + "][" + j + "]=");
                    a[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("The Jogged Array Elements: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < a[i].Length; j++)

                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
