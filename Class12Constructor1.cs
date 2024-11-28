using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{

    class Box
    {
        int length, breadth, height;
        public Box()
        {
            length = 10;
            breadth = 20;
            height = 30;
        }

        public Box(int length)
        {
            this.length = length;
            breadth = 1;
            height = 3;
        }

        public int Volume(int length) { 
            return length;
        }
        public int Volume()
        {
            return length*breadth*height;
        }
    }
    internal class Class12Constructor1
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            Console.WriteLine(box.Volume());
            Box box2 = new Box(10);
            Console.WriteLine(box2.Volume());

        }
    }
}
