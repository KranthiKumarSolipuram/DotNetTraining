using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    //Boxing and UnBoxing
    // Converting Value types to reference type is called boxing
    //Reference type to value type is called Unboxing
    internal class Class17_Boxing_UnBoxing
    {
        static void Main(string[] args)
        {
            int a = 100;
            Console.WriteLine(a);
            object obj = a; // Boxing
            Console.WriteLine(obj);
            int b =(int) obj; //UnBoxing
        }
    }
}
