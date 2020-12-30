using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise9
    {
        int[] example;
        public Exercise9()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Introduce the length of the array");

            int length = Convert.ToInt32(Console.ReadLine());

            example = new int[length];

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
        ;

            for (int count = 0; count < example.Length; count++)
            {
                Console.WriteLine("The value of the position {0} is {1}: |||", count, example[count]);        
            }
        }
    }
}
