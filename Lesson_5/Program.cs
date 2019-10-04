﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cpuNumber;
            int tries = 0;
            string name;
            bool gameOver = false; // bool muutujal on kaks väärtust, kas true või false

            Random rnd = new Random(); //loome Random klassi, aga ei anna sulgudesse parameetrit.
            cpuNumber = rnd.Next(1, 6); // 1 on kaasaarvatud ning 6 on väljaarvatud
            ///Console.WriteLine(cpuNumber); ///Selle reaga näitab arvuti enda numbrit.

            Console.WriteLine($"Please, enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}. The game has started.");

            while (!gameOver) // !gameOver = NOT gameOver
            {
                int userNumber;
                Console.WriteLine($"Try to guess the number: ");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber > cpuNumber)
                {
                    Console.WriteLine($"Cpu number is smaller.");
                    
                }
                else if (userNumber < cpuNumber)
                {
                    Console.WriteLine($"Cpu number is bigger.");
                }
                else
                {
                    Console.WriteLine("Got me!");
                    gameOver = true;
                }


            }
            Console.ReadLine();


        }
    }
}
