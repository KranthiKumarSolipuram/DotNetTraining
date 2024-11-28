using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    /*
       * types of constructor
       * 1. default construtor
       * 2. parameter constructor
       * 3. overloaded constructor
       * 4.copy constructor
       */
    //constructor will not have return datatype 
    //class name and constuctor name should be same
    class Myclass
    {
        int a, b;

        public Myclass()
        {
            a = 10;
            b = 20;
            Console.WriteLine("Default constructor called");
        }

        public Myclass(int x, int y)
        {
            a = x;
            b = y;
            Console.WriteLine("Parameter Constructor Called");
        }
        public Myclass(Myclass obj)
        {

            a = obj.a;
            b = obj.b;
            Console.WriteLine("copy constructor called");
        }

        public void Show()
        {
            Console.WriteLine("a value is : " + a);
            Console.WriteLine("b value is : " + b);

        }
    }
    internal class Class11_Constructor
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.Show();

            Myclass myclass1 = new Myclass(23,34);
            myclass1.Show();

            Myclass myclass2 = new Myclass(myclass);
            myclass2.Show();

        }
    }
}
