using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise20
    {
        private readonly Random _random = new Random();
        int min = 1;
        int max = 20;

        int[] resultArray;
        int[] secondArray;
        int[] firstArray;
        public Exercise20()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Introduce the length of the Arrays: ");
            int lengthArray = Convert.ToInt32(Console.ReadLine());

             firstArray = new int[lengthArray];
             secondArray = new int[lengthArray];
            resultArray = new int[lengthArray];

            secondArray = firstArray;

            FillArray(firstArray);

            firstArray = new int[lengthArray];

            FillArray(firstArray);

           resultArray =  MultiplyArrays(firstArray, secondArray);

            showArraysContent("The first array is:",firstArray);
            showArraysContent("The second array is:",secondArray);
            showArraysContent("The result array is:",resultArray);

        }

        public void FillArray(int[] array)
        {
          
            for (int count = 0; count < array.Length; count++)
            {          
                
                    array[count] = _random.Next(min, max);
                
            }
        }

        public int[] MultiplyArrays (int[] array1, int[] array2)
        {

           int[] result = new int[array1.Length];

            for (int count = 0; count < array1.Length; count++)
            {

                result[count] = array1[count] * array2[count];

            }

            return result;
        }

        public void showArraysContent(string message, int[] array)
        {

            Console.WriteLine("{0} ", message);

            for (int count = 0; count < array.Length; count++)
            {
                
                Console.WriteLine("The position {0} is equal to: {1}",count, array[count]);

            }
        }
    }
}
