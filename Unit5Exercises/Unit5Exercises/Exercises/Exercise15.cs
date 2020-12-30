using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise15
    {
        private readonly Random _random = new Random();
        int[] example;
        int[] example2;
        public Exercise15()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Introduce the length of the array");

            int length = Convert.ToInt32(Console.ReadLine());

            example = new int[length];
            example2 = new int[length];

            FillArray();

            TurnArray();
        }

        public void FillArray()
        {

            for (int count = 0; count < example.Length; count++)
            {
                example[count] = _random.Next(1, 10);

                Console.WriteLine("The position {0} is equal to {1}", count, example[count]);

            }

        }

        public void TurnArray()
        {
            int count = example.Length - 1;

            for (int i = 0; i < example.Length; i++)
            {
                example2[i] = example[count];

                Console.WriteLine("The position {0} ** on the new array** is equal to {1}", i, example2[i]);

                count--;
            }

        }
    }
}
