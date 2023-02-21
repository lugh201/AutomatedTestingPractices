using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class Rectangle
    {
        public int length;
        public int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int Area()
        {
            return length * width;
        }

        public int Perimeter()
        {
            return (2*length) + (2 * width);
        }


        //static void Main(string[] args)
        //{ 
        //     Rectangle rectangle = new Rectangle(0, 0);
        //     Console.WriteLine("Calculate Area and Perimeter of a Rectangle");

        //     Console.Write("Enter Length:");
        //     rectangle.length = Convert.ToInt32(Console.ReadLine());
        //     Console.Write("Enter Width:");
        //     rectangle.width = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine($"The area of the rectangle is : {rectangle.Area()}");
        //    Console.WriteLine($"The perimeter of the rectangle is : {rectangle.Perimeter()}");

        //    Console.ReadLine();
        //}

    }


}
