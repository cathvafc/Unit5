using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise10
    {
        int[] example;
        public Exercise10()
        {
            example = new int[11];
        }

        public void showStatement()
        {

            Console.WriteLine("Introduce the value to calculate its multiplication table.");

            Calculate(Convert.ToInt32(Console.ReadLine()));
        }

        public void Calculate(int value)
        {
            for (int i = 0; i < example.Length; i++)
            {
                example[i] = value * i;
            }

            ShowContent(value);
        }

        public void ShowContent(int value)
        {
            for (int i = 0; i < example.Length; i++)
            {
                Console.WriteLine("The value of {0} * {1} is: {2}", value, i, example[i]);
            }
        }
    }
}
