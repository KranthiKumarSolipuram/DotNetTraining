using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    //single inheriatnce
    class Sample //Base class
    {
        //private int a;//not accessible outside this class
        protected int a;
        protected int b;

        public void GetData()
        {
            Console.Write("Enter a value: ");
             a=int.Parse(Console.ReadLine());

            Console.Write("Enter b value: ");
             b=int.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

    class Sample1 : Sample //Derived Class
    {
        int c;
        public void Cal()
        {
            c = a + b;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine(c);
        }
    }
    internal class Class13_Inheritance
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.GetData();
            sample.Show();
        }
    }
}
