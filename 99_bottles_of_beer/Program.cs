using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_bottles_of_beer
{
    class Program
    {
        static void Main(string[] args)
        {

           

            for (int i = 99; i>=1; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");

                if (i > 1)
                {
                    Console.WriteLine($"Take one down and pass it around, {i - 1} bottles of beer on the wall.");
                }
                else
                {
                    Console.WriteLine($"Take one down and pass it around, no more bottles of beer on the wall.");
                }
              
                Console.WriteLine("\n");
            }

            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. ");
            Console.WriteLine($"Go to the store and buy some more, 99 bottles of beer on the wall.");

            Console.ReadLine();
        }
    }
}
