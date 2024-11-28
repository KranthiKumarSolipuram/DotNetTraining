using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    class GenericClass<T>
    {
        T a;
        public void GetData(T x)
        {
            a = x;
        }

        public void PutData()
        {
            Console.WriteLine("a value is: "+a);
        }
    }
    internal class Class24_CustomGenericClass
    {
        static void Main(string[] args)
        {
            GenericClass<int> a = new GenericClass<int>();
            GenericClass<String> b = new GenericClass<String>();

            a.GetData(10);
            b.GetData("Kranthi");

            a.PutData();
            b.PutData();
        }
    }
}
