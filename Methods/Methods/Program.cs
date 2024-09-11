using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion Failed.");
            }
            //var number = int.Parse("abc");
            int number;
            var result=int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion Failed.");
        }
        static void UseParams()
        {
            var claculator = new Calculator();
            Console.WriteLine(claculator.Add(1, 2));
            Console.WriteLine(claculator.Add(1, 2, 3));
            Console.WriteLine(claculator.Add(1, 2, 3, 4));
            Console.WriteLine(claculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0} , {1})", point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine("Point is at ({0} , {1})", point.X, point.Y);
                //but there is a problem lets go to point.cs part
            }
            catch (Exception)
            {
                Console.WriteLine("An Unexpected error occurred");
            }
        }
    }
}
