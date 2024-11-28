using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    //abstract method and abstract class

    
    abstract class Employee
    {
        public int Bonus(int basic)
        {
            if (basic == 5000)
                return 400;
            else if (basic <= 10000)

                return 800;
            else
                return 1200;

        }
        abstract public int cal_bonus();
        
    }

   class Designer : Employee
    {
        int basic = 8500;
        public override int cal_bonus()
        {
            return Bonus(basic);
        }
    }

    class Analyst : Employee
    {
        int basic = 12500;
        public override int cal_bonus()
        {
            return Bonus(basic);
        }
    }
    internal class Class15_Abstract
    {
        static void Main(string[] args)
        {
            Employee em;
            em=new Designer();
            Console.WriteLine(em.cal_bonus());

            em=new Analyst();
            Console.WriteLine(em.cal_bonus());
        }
    }
}
