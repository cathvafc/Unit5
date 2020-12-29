using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise6
    {
        public Exercise6()
        {

        }

        public void showStatement()
        {
            int result = 0;

            Console.WriteLine("Introduce an integer number in order to calculate how many digits it has.");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                result = HowManyDigits(number);
                Console.WriteLine("The number {0} has {1} digits.", number, result);
            }
            else
            {
                Console.WriteLine("Please, introduce a positive number.");
            }


        }

        public int HowManyDigits (int num)
        {
            int result = 0;

            result = (int)Math.Floor(Math.Log10(num) + 1);

            return result;
        }

    }
}
