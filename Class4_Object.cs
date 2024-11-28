using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    internal class Class4_Object
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            Class4_Object obj = new Class4_Object();
            Console.WriteLine(obj.Sum(20, 24));
            Console.WriteLine(obj.Mul(15,20));

        }
    }
}
