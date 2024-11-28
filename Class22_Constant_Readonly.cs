using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    class Sample7
    {
        const int a = 100; //constant cannot be modifies
        private readonly int b;  //readonly variable
        public Sample7()
        {
            b = 200;
        }
        public void ChangeData()
        {
            //a = 100;
        }
    }
    internal class Class22_Constant_Readonly
    {
        static void Main(string[] args)
        {

        }
    }
}
