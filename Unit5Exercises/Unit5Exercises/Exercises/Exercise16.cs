using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{

    class Exercise16
    {
        int[] example = { 1,2,3,2,1};
        int[] example2 = { 1, 5, 3, 2, 1 };
        public Exercise16()
        {
          
        }

        public void showStatement()
        {
            Console.WriteLine("The first array is: ");

            for (int i = 0; i < example.Length;i++)
            {
                Console.WriteLine("On the position {0} the value is: {1}", i, example[i]); 
            }

            Console.WriteLine("The second array is: ");

            for (int j = 0; j < example2.Length; j++)
            {
                Console.WriteLine("On the position {0} the value is: {1}", j, example2[j]);
            }

           if( CheckIfCapicua(example))
            {
                Console.WriteLine("The first array is CapICua");
            }
           else
            {
                Console.WriteLine("The first array is not CapICua");
            }
            if (CheckIfCapicua(example2))
            {
                Console.WriteLine("The second array is CapICua");
            }
            else
            {
                Console.WriteLine("The second array is not CapICua");
            }

        }

        public bool CheckIfCapicua(int [] array)
        {
            bool result = true;
            bool finished = false;
            int i = 0;
            int j = array.Length - 1;


            while (!finished && i <= j)
            {
                if (array[i] != array[j])
                {
                    finished = true;
                    result = false;
                }

                i++;
                j--;

            }

            return result;
        }
    }
}
