using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    //getters and setters
    class Car
    {
        private string _color="Red";
        public String Color //no () because it is property
        {
            get { return _color; }
            set { _color = value; }
        }
    }
    internal class Class18_GettersSetters
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.Color); //get
            car.Color = "Green";  //set
            Console.WriteLine(car.Color); //get
        }
    }
}
