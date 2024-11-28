using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    //Method Overloading
    internal class Class10_Polymorphism
    {
        //Polimorphism

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum (int a, int b,int c)
        {
            return a + b + c; 
        }

        public float Sum(float a, float b) 
        {
            return a + b; 
        }

        static void Main(string[] args)
        {
            Class10_Polymorphism obj = new Class10_Polymorphism();
            Console.WriteLine("sum: " + obj.Sum(10, 30));
            Console.WriteLine("Sum of two floats: "+obj.Sum(1.0f, 3.0f));

        }

    }
}
