using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    class Sample6
    {
        //default arguments
        public int Sum(int a,int b = 100)
        {
            return a + b;
        }

        //Nullable argument
        public int Mul(int a, int? b=null)
        {
            if(b == null)
            
                return 0;
            
            return a * (int)b;
        }
    }
    internal class Class21_DefaultAndNullable
    {
        static void Main(string[] args)
        {
            Sample6 sample6 = new Sample6();
            Console.WriteLine(sample6.Sum(10, 20));
            Console.WriteLine(sample6.Mul(12));
        }
    }
}
