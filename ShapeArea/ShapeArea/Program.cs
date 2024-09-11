using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In this program we will calculate the area of shapes
            string answer;
            float height, width, radius, baseLength;
            float result;

            Console.WriteLine("What shape would you like to find the area of?");
            Console.WriteLine("Please enter 'r' for rectangle, 't' for triangle, or any other key for circle.");

            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Please enter the height of the rectangle.");
                height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the rectangle.");
                width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else if (answer == "t")
            {
                Console.WriteLine("Please enter the base of the triangle.");
                baseLength = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of the triangle.");
                height = float.Parse(Console.ReadLine());

                result = 0.5f * baseLength * height;
            }
            else
            {
                Console.WriteLine("Please enter the radius of the circle.");
                radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);
            }

            Console.WriteLine("The result is " + result);
            Console.ReadLine();
        }
    }
}
