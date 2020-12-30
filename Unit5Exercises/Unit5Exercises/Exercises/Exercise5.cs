using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise5
    {
        public Exercise5()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Introduce a number on base decimal to turn into binary base: ");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("The number {0} in binary base is: {1}", decimalNumber ,DecimalToBinary(decimalNumber));
        }

        public string DecimalToBinary(int decimalNum)
        {
            string result = "";

                while (decimalNum > 0)
                {
                    if (decimalNum % 2 == 0)
                    {
                        result = "0" + result;
                    }
                    else
                    {
                        result = "1" + result;
                    }

                    decimalNum = (int)(decimalNum / 2);
                }

            return result;
        }

    }
}
