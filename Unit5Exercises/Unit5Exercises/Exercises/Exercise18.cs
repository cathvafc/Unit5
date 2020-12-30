using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise18
    {
        private readonly Random _random = new Random();
        int[] example;
        public Exercise18()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Introduce the length of the array");

            int length = Convert.ToInt32(Console.ReadLine());

            example = new int[length];

            FillArray(0, 9);

            ShowContent();

            SumPosition();
        }

        public void FillArray(int min, int max)
        {

            for (int count = 0; count < example.Length; count++)
            {
                example[count] = GenerateRandom(min, max);

            }

        }

        private int GenerateRandom(int min, int max)
        {
            return _random.Next(min, max);
        }

        public void ShowContent()
        {

            for (int count = 0; count < example.Length; count++)
            {
                Console.WriteLine("The value of the position | {0} | is | {1} | ", count, example[count]);
            }
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
