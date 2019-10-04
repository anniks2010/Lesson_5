using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            //int i = 0  - start of the loop, i<10 - stop tingimus; i++ - step, mitu sammu ta teeb
            for (int i = 1; i < 11; i+=2 )
            {
                Console.WriteLine($" i equals {i}");
            }
            Console.WriteLine("\n"); //n on käsk 'new line'

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($" i equals {i}");
            }

            
            Console.ReadLine();


        }
    }
}
