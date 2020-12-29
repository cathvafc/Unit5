using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise8
    {
        int[] example;
        public Exercise8()
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
            int count = 0;

            foreach (int element in example)
            {
                example[count] = count;

                Console.WriteLine("The position {0} is equal to {1}", count, example[count]);

                count++;
            }

        }

       

    }
}
