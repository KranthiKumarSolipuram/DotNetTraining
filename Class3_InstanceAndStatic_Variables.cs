using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    internal class Class3_InstanceAndStatic_Variables
    {
        int EmpNumber = 101;  //instance variable

        static int StuNumber = 201; //static variable

        public void Show() //Instance Method it can access all instance and static variables anf methods
        {
            Console.WriteLine(EmpNumber);  
            Console.WriteLine(StuNumber);
            
        }

        public static void Show1() //Static Method can only access other stati variales and methods
        { 

        }

        static void Main(string[] args)
        {
            Console.WriteLine(StuNumber);
            Class3_InstanceAndStatic_Variables obj = new Class3_InstanceAndStatic_Variables(); 
            obj.Show();

        }
    }
}
