using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise14
    {
        private readonly Random _random = new Random();
        int[] example;
        public Exercise14()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Introduce the length of the array");

            int length = Convert.ToInt32(Console.ReadLine());

            example = new int[length];

            FillArray();

            Console.WriteLine("Introduce the value to find: ");
            int value = Convert.ToInt32(Console.ReadLine());

            if (FindValue(value))
            {
                Console.WriteLine("The value {0} is on the array.", value);
            }
            else
            {
                Console.WriteLine("The value {0} is not on the array.", value);
            }
        }

        public void FillArray()
        {

            for (int count = 0; count < example.Length; count++)
            {
                example[count] = _random.Next(1, 10);

                Console.WriteLine("The position {0} is equal to {1}", count, example[count]);

            }

        }
        public bool FindValue(int value)
        {
            bool find = false;

            for (int count = 0; count < example.Length; count++)
            {
                if (example[count] == value)
                {
                    find = true;
                }
                
            }
            return find;
        }
    }
}
