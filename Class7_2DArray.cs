﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    internal class Class7_2DArray
    {
        static void Main(string[] args)
        {
            int[,] a= new int[3, 3];
            Console.WriteLine("Enter the Elements");
            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("a[" + i + "," + j + "]=");
                    a[i,j]=int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("The Matrix is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i,j]+" ");
               
                }
                Console.WriteLine();
            }
        }
    }
}
