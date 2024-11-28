using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    enum clrs //enum is collection of distinct type of constants
    {
        Red,
        Yellow,
        Green,
        Blue
    }
    class Car1
    {
        private string[] colors = new string[4];

        public string this[int x]
        {
            get { return colors[x]; }
            set { colors[x] = value; }
        }
     }

    internal class Class20_Enum
    {
        static void Main(string[] args)
        {
            Car1 car1 = new Car1();
            car1[0] = clrs.Yellow.ToString();
            car1[1] = clrs.Blue.ToString();
            car1[2] = clrs.Green.ToString();
            Console.WriteLine("cars.....");
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine(car1[x]);
            }
        }
    }
}
