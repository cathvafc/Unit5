using System;
using System.Collections.Generic;
using System.Text;

namespace Unit5Exercises
{
    class AreaCalculator
    {

        public AreaCalculator()
        {

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
