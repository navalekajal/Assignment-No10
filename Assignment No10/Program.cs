using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No10
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Calculation c1 = new Calculation();
            //Console.WriteLine(c1.Add(1, 2));
            //Console.WriteLine(c1.Add(1, 2, 3));
            //Console.WriteLine(c1.Add(75.50, 3));
            //Console.WriteLine(c1.Add(75, 25.56f));

            //Circle c1 = new Circle(5);
            //c1.CalculateArea();
            //Console.WriteLine(c1);

            Rectangle r1 = new Rectangle(5,4);
            r1.CalculateArea();
            Console.WriteLine(r1);
        }
    }
}
