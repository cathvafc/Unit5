using System;

namespace Exercise2
{
    class Program
    {
        private static readonly Random _random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce how many random numbers do you want: ");
            int randomNumbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce the interval to create the random numbers: \n The first part of the interval:  ");
            int lowerInterval = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce the second part of the interval:  ");
            int upperInterval = Convert.ToInt32(Console.ReadLine());


            int iterator = 0;
            int randomResult = 0;

            while (iterator < randomNumbers)
            {

                randomResult = generateRandomNumber(lowerInterval, upperInterval);

                Console.WriteLine("The random number is: {0}", randomResult);
                iterator++;
            }

        }

        static int generateRandomNumber (int min, int max)
        {
            int result = 0;

            result = _random.Next(min, max);

            return result;
        }
    }
}
