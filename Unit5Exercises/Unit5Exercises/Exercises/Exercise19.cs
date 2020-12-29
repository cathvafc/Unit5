using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise19
    {
        private readonly Random _random = new Random();
        int[] example;
        public Exercise19()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Introduce the length of the array");

            int length = Convert.ToInt32(Console.ReadLine());

            example = new int[length];

            FillArray(0, 9);

            ShowContent();

           
        }

        public void FillArray(int min, int max)
        {

            for (int count = 0; count < example.Length; count++)
            {
                example[count] = GenerateRandomPrimary(min, max);

            }

        }

        private int GenerateRandomPrimary(int min, int max)
        {
            int result = 0;
            bool notPrimary = true;

            while (notPrimary)
            _random.Next(min, max);

            return result;
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
