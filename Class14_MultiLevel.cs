using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    //Multilevel inheritance
    class BaseClass
    {
        int a;
        public BaseClass(int x)
        {
            a = x;
        }
        public void Show()
        {
            Console.WriteLine(a);

        }

    }
    //if crete object of derived class implicitly the object is created for
    //base class also
    class DerivedClass: BaseClass
    {
        int b;
        public DerivedClass(int y) : base(10)//base is similar to super keyword in java
        {
            b = y;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine(b);
        }
   }

    class SubDerivedClass :DerivedClass
    {
        int c;
        public SubDerivedClass(int z) : base(20)
        {
            c=z;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine(c);
        }

    }
    internal class Class14_MultiLevel
    {
        static void Main(string[] args)
        {
            SubDerivedClass obj = new SubDerivedClass(30);
            obj.Show();

        }
    }
}
