using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    //creating a object and initializing values
    class Employee1
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float EmpSalary {  get; set; }
    }
    internal class Class19_ObjectIntialization
    {
        static void Main(string[] args)
        {
            Employee1 emp = new Employee1();
            emp.EmpId = 11;
            emp.EmpName = "Kranthi";
            emp.EmpSalary = 123.54f;

            Console.WriteLine(emp.EmpId);
            Console.WriteLine(emp.EmpSalary);
            Console.WriteLine(emp.EmpName);
        }
    }
}
