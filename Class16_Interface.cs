using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    //interface
    //by default interfaces are public and abstract
    //we cannot write concreat methods only abstract and cannot have implementation
    interface IInter
    {
        void GetDate();
        void PutData();
    }

    class Inter : IInter    

    {
        int id;
        string name="";

        public void GetDate()
        {
            id = 11;
            name = "Kranthi";
        }

        public void PutData()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
        }
    }
    internal class Class16_Interface
    {
       
        static void Main(string[] args)
        {
            IInter inter = new Inter();
            inter.GetDate();
            inter.PutData();
        }
    }
}
