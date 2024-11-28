using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    internal class Class1_Parse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee Number: ");
            //int EmpNumber = int.Parse(Console.ReadLine()) ;
            int EmpNumber=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            String EmpName = Console.ReadLine();
            Console.Write("Enter the Salary: ");
            decimal EmpSalary=decimal.Parse(Console.ReadLine());

            Console.WriteLine("Employee Number is: "+EmpNumber);
            Console.WriteLine("Employee Name is: "+EmpName); 
            Console.WriteLine("Employee Salary is: "+EmpSalary);
        }
    }
}
