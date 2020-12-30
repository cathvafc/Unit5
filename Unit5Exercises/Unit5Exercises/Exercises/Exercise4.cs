using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise4
    {
        public Exercise4()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Introduce the number which you want to calculate the factorial: ");
            int numFactorial = Convert.ToInt32(Console.ReadLine());

            int result = factorial(numFactorial);

            Console.WriteLine("The factorial number of {0} is {1}", numFactorial, result);
        }


        public int factorial(int num)
        {
            int result = 1;
            int auxiliar = num;

            while (auxiliar > 0)
            {
                result *= auxiliar--;
            }

            return result;
        }
    }
}
