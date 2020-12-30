using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise17
    {
        int[] example;
        public Exercise17()
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

                Console.WriteLine("Introduce the integer value for the position {0}: ", count);

                int valueRead = Convert.ToInt32(Console.ReadLine());

                example[count] = valueRead;

            }

            ShowContent();

        }

        public void ShowContent()
        {
            
            for (int count = 0; count < example.Length; count++)
            {
                Console.WriteLine("The value of the position | {0} | is | {1} | ", count, example[count]);
            }
        }
    }
}
