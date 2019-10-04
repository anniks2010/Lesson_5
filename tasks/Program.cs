using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            Console.WriteLine("Is user number positive or negative");
            Console.WriteLine($"Please enter number: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber < 0)
            {
                Console.WriteLine("User number is negative");
            }
            else if (userNumber > 0)
            {
                Console.WriteLine("User number is positive");
            }
            else
            {
                Console.WriteLine("User number is zero");
            }
            Console.WriteLine("\n");
            //TASK2
            Console.WriteLine("Is user number divisible by 5 and/or 11 or not");
            Console.WriteLine($"Please enter number: ");
            int userNumber2 = int.Parse(Console.ReadLine());

            if (userNumber2 % 5 == 0 && userNumber2 % 11 == 0) 
            {
                Console.WriteLine("Usernumber is divisible by 5 and 11");
            }
            else if (userNumber2 % 11 == 0)
            {
                Console.WriteLine("Usernumber is divisible by 11");
            }
            else if (userNumber2 % 5 == 0)
            {
                Console.WriteLine("Usernumber is divisible by 5");
            }
            else
            {
                Console.WriteLine("Usernumber is not divisible by 5 or 11");
            }
            Console.WriteLine("\n");
            //TASK3
            Console.WriteLine("Check wether a user's number is even or odd");
            Console.WriteLine($"Please enter number: ");
            int userNumber3 = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Usernumber is even");
            }
            else
            {
                Console.WriteLine("Usernumber is odd");
            }
            Console.WriteLine("\n");
            //TASK4
            Console.WriteLine("Check wether a user's letter is vowel or something else");
            Console.WriteLine($"Please enter letter: ");
            string userLetter = Console.ReadLine().ToLower();

            switch (userLetter)
            {
                case "a":
                    Console.WriteLine("Letter is vowel");
                    break;
                case "e":
                    Console.WriteLine("Letter is vowel");
                    break;
                case "i":
                    Console.WriteLine("Letter is vowel");
                    break;
                case "o":
                    Console.WriteLine("Letter is vowel");
                    break;
                case "u":
                    Console.WriteLine("Letter is vowel");
                    break;
                case "õ":
                    Console.WriteLine("Letter is vowel");
                    break;
                case "ä":
                    Console.WriteLine("Letter is vowel");
                    break;
                case "ö":
                    Console.WriteLine("Letter is vowel");
                    break;
                case "ü":
                    Console.WriteLine("Letter is vowel");
                    break;
                default:
                    Console.WriteLine("Letter is something else");
                    break;
            }
            Console.WriteLine("\n");
            //TASK5
            Console.WriteLine("insert input 1-7");
            Console.WriteLine($"Please enter number 1-7: ");
            int userNumber4 = int.Parse(Console.ReadLine());

            switch (userNumber4)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please enter new number");
                    break;
            }




            Console.ReadLine();
        }
    }
}
