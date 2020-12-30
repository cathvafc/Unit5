using System;

namespace ExerciseUnit5
{
    class Program
    {
        static void Main(string[] args)
        {
            showStatement();       
        }

        //Method that shows the Menu to choose the exercise to execute
       static void showStatement()
        {
            Console.WriteLine("Which exercise do you want to execute? Write from 1 to 21.");
            int option = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (option)
                {

                    case 1:
                        ///Exercise 1
                        Exercise1 exercise1Object = new Exercise1();
                        exercise1Object.showStatement();
                        break;

                    case 2:
                        ///Exercise 2
                        Exercise2 exercise2Object = new Exercise2();
                        exercise2Object.showStatement();
                        break;

                    case 3:
                        ///Exercise 3
                        Exercise3 exercise3Object = new Exercise3();
                        exercise3Object.showStatement();
                        break;

                    case 4:
                        ///Exercise 4
                        Exercise4 exercise4Object = new Exercise4();
                        exercise4Object.showStatement();
                        break;

                    case 5:
                        ///Exercise 5
                        Exercise5 exercise5Object = new Exercise5();
                        exercise5Object.showStatement();
                        break;

                    case 6:
                        ///Exercise 6
                        Exercise6 exercise6Object = new Exercise6();
                        exercise6Object.showStatement();
                        break;

                    case 7:
                        ///Exercise 7
                        Exercise7 exercise7Object = new Exercise7();
                        exercise7Object.showStatement();
                        break;

                    case 8:
                        ///Exercise 8
                        Exercise8 exercise8Object = new Exercise8();
                        exercise8Object.showStatement();
                        break;

                    case 9:
                        ///Exercise 9
                        Exercise9 exercise9Object = new Exercise9();
                        exercise9Object.showStatement();
                        break;

                    case 10:
                        ///Exercise 10
                        Exercise10 exercise10Object = new Exercise10();
                        exercise10Object.showStatement();
                        break;

                    case 11:
                        ///Exercise 11
                        Exercise11 exercise11Object = new Exercise11();
                        exercise11Object.showStatement();
                        break;

                    case 12:
                        ///Exercise 12
                        Exercise12 exercise12Object = new Exercise12();
                        exercise12Object.showStatement();
                        break;

                    case 13:
                        ///Exercise 13
                        Exercise13 exercise13Object = new Exercise13();
                        exercise13Object.showStatement();
                        break;

                    case 14:
                        ///Exercise 14
                        Exercise14 exercise14Object = new Exercise14();
                        exercise14Object.showStatement();
                        break;

                    case 15:
                        ///Exercise 15
                        Exercise15 exercise15Object = new Exercise15();
                        exercise15Object.showStatement();
                        break;

                    case 16:
                        ///Exercise 16
                        Exercise16 exercise16Object = new Exercise16();
                        exercise16Object.showStatement();
                        break;

                    case 17:
                        ///Exercise 17
                        Exercise17 exercise17Object = new Exercise17();
                        exercise17Object.showStatement();
                        break;

                    case 18:
                        ///Exercise 18
                        Exercise18 exercise18Object = new Exercise18();
                        exercise18Object.showStatement();
                        break;

                    case 19:
                        ///Exercise 19
                        Exercise19 exercise19Object = new Exercise19();
                        exercise19Object.showStatement();
                        break;

                    case 20:
                        ///Exercise 20
                        Exercise20 exercise20Object = new Exercise20();
                        exercise20Object.showStatement();
                        break;

                    case 21:
                        ///Exercise 21
                        Exercise21 exercise21Object = new Exercise21();
                        exercise21Object.showStatement();
                        break;
                    default:
                        Console.WriteLine("The option is incorrect. Try it again");
                        break;
                }
            } while (1 < option && option > 21);
        }
    }
}
