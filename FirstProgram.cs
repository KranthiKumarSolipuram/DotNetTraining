using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    internal class FirstProgram

    {
        public void show()//Instance Method
        {
            Console.WriteLine("This is show method");
        }
        public static void display() //static method
        {
            Console.WriteLine("This is from display");
        }
    
        static void Main(string[] args)
        {
            FirstProgram obj = new FirstProgram();
            obj.show();
            display();
            Console.WriteLine("This ia my first .Net Application");
            Console.WriteLine("This is first class");
        }
    }

}
