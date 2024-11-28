using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    internal class Class2_DataTypes
    {
        public void show()
        {
            float EmpSalary = 80000;
            Console.WriteLine(EmpSalary);
        }
        static void Main(string[] args)
        {
            int EmpNumber = 101;
            string EmpName = "Kranthi";
            Console.WriteLine(EmpName);
            Console.WriteLine(EmpNumber);

            Class2_DataTypes obj = new Class2_DataTypes();
            obj.show();
        }
    }
}
