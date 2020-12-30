using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise1
    {

        public Exercise1()
        {

        }

        public void showStatement()
        {
            int option = 0;
            double result = 0;

            Console.WriteLine("What area do you want to calculate? \n Choose one of the following options. \n Enter 1 for Circle \n Enter 2 for square \n ENter 3 for triangle.");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("The option that you have introduced is calculate the area of a Circle.");
                    Console.WriteLine("Introduce the radius of the circle: ");
                    double radiusOfCircle = Convert.ToDouble(Console.ReadLine());
                    result = CircleArea(radiusOfCircle);
                    break;
                case 2:
                    Console.WriteLine("The option that you have introduced is calculate the area of a square.");
                    Console.WriteLine("Introduce the side of the square: ");
                    double sideOfSquare = Convert.ToDouble(Console.ReadLine());
                    result = SquareArea(sideOfSquare);
                    break;
                case 3:
                    Console.WriteLine("The option that you have introduced is calculate the area of a triangle.");
                    Console.WriteLine("Introduce the height of the triangle: ");
                    double triangleHeight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduce the base of the triangle: ");
                    double baseTriangle = Convert.ToDouble(Console.ReadLine());

                    result = TriangleArea(baseTriangle, triangleHeight);

                    break;
                default:
                    Console.WriteLine("The option that you have introduced is incorrect. Try it again.");
                    break;
            }

            if (result != 0)
            {
                Console.WriteLine("The area result is: {0}", result);
            }
        }

        public double CircleArea(double radius)
        {
            double result = 0;

            result = Math.PI * Math.Pow(radius,2);

            return result;
        }

        public double SquareArea(double side)
        {
            double result = 0;

            result = Math.Pow(side, 2);

            return result;
        }

        public double TriangleArea(double triangleBase, double height)
        {
            double result = 0;

            result = (height * triangleBase) / 2;

            return result;
        }

    }
}
