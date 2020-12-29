using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise11
    {
        int[] example;
        public Exercise11()
        {

        }

        public void showStatement()
        {
         

            example = new int[10];

            FillArray();

        }

        public void FillArray()
        {

            for (int count = 0; count < example.Length; count++)
            {
                example[count] = count;

            }

            SumPosition();

        }

        public void SumPosition()
        {
            int result = 0;

            for (int count = 0; count < example.Length; count++)
            {
               result += example[count];

            }

            Console.WriteLine("The sum of all position of the array is: {0}", result);
        }
    }
}
