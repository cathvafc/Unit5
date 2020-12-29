using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise12
    {
        int[] example;
        public Exercise12()
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

            Average();

        }

        public void Average()
        {

            double result = 0;

            for (int count = 0; count < example.Length; count++)
            {
                result += example[count];

            }

            Console.WriteLine("The average of all position of the array is: {0}", result/example.Length);
        }

    }
}
