using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise21
    {
        private readonly Random _random = new Random();
        int min = 1;
        int max = 300;
        int[] firstArray;
        int[] secondArray;
        int lengthArray = 0;
        public Exercise21()
        {

        }

        public void showStatement()
        {
            do
            {
                Console.WriteLine("Introduce the length of the Arrays: ");

                lengthArray = Convert.ToInt32(Console.ReadLine());

                if (0 > lengthArray)
                {

                    Console.WriteLine("The value of the arrays length is incorrect. Introduce it again.");

                }
            } while (0 > lengthArray);

           firstArray = new int[lengthArray];
            secondArray = new int[lengthArray];

            FillArray(firstArray);

            ShowArraysContent("The array result is: ",secondArray);
        }

        public void FillArray(int[] array)
        {

            int result = 0;
            int j = 0;

            for (int count = 0; count < array.Length; count++)
            {
                   
                result =  _random.Next(min, max);

                array[count] = result;

                if (result % 10 == 5)
                {
                    secondArray[j] = result;
                    j++;
                }

            }
        }

        public void ShowArraysContent(string message, int[] array)
        {

            Console.WriteLine("{0} ", message);

            for (int count = 0; count < array.Length; count++)
            {
                if (array[count] != 0)
                { 
                Console.WriteLine("The position {0} is equal to: {1}", count, array[count]);
                }
            }
        }
    }
}
