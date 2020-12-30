using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise19
    {
        private readonly Random _random = new Random();
        int[] example;
        int min = 0;
        int max = 0;

        int maxNumOfArray = 0;

        public Exercise19()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Introduce the length of the array");

            int length = Convert.ToInt32(Console.ReadLine());

            example = new int[length];

            Console.WriteLine("Introduce the lower part of the interval: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce the Higher part of the interval: ");
            max = Convert.ToInt32(Console.ReadLine());

            FillArray(min, max);

            ShowContent();
         
        }

        public void FillArray(int min, int max)
        {

            int result = 0;
            bool primary = false;

            for (int count = 0; count < example.Length; count++)
            {
                primary = false;

                while (!primary)
                {
                    result = GenerateRandomPrimary(min, max);

                    if (isPrimary(result))
                    {
                        CheckIfMax(result);
                        example[count] = result;
                        primary = true;
                    }
                    else
                    {
                        primary = false;
                    }
                }
            }

        }

        private void CheckIfMax(int result)
        {
            if (result > maxNumOfArray)
            {
                maxNumOfArray = result;
            }
        }

        private int GenerateRandomPrimary(int min, int max)
        {
            int result = 0;

            result = _random.Next(min, max);

            return result;
        }

        public void ShowContent()
        {

            for (int count = 0; count < example.Length; count++)
            {
                Console.WriteLine("The value of the position | {0} | is | {1} | ", count, example[count]);
            }

            Console.WriteLine("The higher value is: {0}", maxNumOfArray);
        }

        public bool isPrimary(int number)
        {
            bool result = true;

            int divisor = 2;
            int rest = 0;

            while (divisor < number)
            {
                rest = number % divisor;
                if (rest == 0)
                {
                    result = false;
                }
                divisor = divisor + 1;
            }

            return result;
        }

    }
}
