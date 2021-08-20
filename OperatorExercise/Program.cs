using System;

namespace OperatorExercise
{
    class Program
    {

        class AreaOfCircle
        {
            public double Area(double radius)
            {
                
                double area = (Math.PI * radius * radius);
                return area;
            }
        }



        static void Main(string[] args)
        {
            
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {b} remainder {remainder}");
            }

            AreaOfCircle n = new AreaOfCircle();
            Console.WriteLine("what is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine());
            double area = n.Area(radius);
            Console.WriteLine("Area of the circle with radius " + radius + " is " + area);

        }
    }
}
