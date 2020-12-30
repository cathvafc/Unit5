using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseUnit5
{
    class Exercise7
    {

        public Exercise7()
        {

        }

        public void showStatement()
        {
            Console.WriteLine("Please, insert how many euros do you want to convert: ");
            int euros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, insert the destiny currency: Dolares, Yenes or Libras");
            string currency = Console.ReadLine();


            ConvertTo(euros, currency);
        }

        public void ConvertTo(int euros, string currency)
        {

            double result = 0;

            if (currency == "Yenes")
            {
                result = euros * 129.852;
                Console.WriteLine("{0} euros are equal to {1} Yenes.", euros, result);
            }
            else if (currency == "Dolares")
            {
                result = euros * 1.28611;
                Console.WriteLine("{0} euros are equal to {1} Dolares.", euros, result);
            }
            else if(currency == "Libras")
            {
                result = euros * 0.86;
                Console.WriteLine("{0} euros are equal to {1} Libras.", euros, result);
            }
            else
            {
                Console.WriteLine("You entered a wrong currency.", euros, result);
            }

        }
    }
}
