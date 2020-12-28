using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise3
    {
        public Exercise3()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Introduce a number to check if is a primary number");

            if (isPrimary(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("The number is primary.");
            }
            else
            {
                Console.WriteLine("The number is not primary.");
            }
        }

        public bool isPrimary(int number)
        {
            bool result = true;

            int divisor = 2;
            int rest = 0;

            while (divisor < number)
            {
                rest = number % divisor;
                if(rest == 0)
                {
                    result = false;
                }
                divisor = divisor + 1;
            }



            return result;
        }
    }
}
