using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Number_Picker
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            WriteLine("Pick a number 1, 2 or 3:");
            choice = Convert.ToInt32(ReadLine());

            if (choice == 2)
            {
                WriteLine("You Win!");
            }
            else if (choice == 1 || choice == 3)
            {
                WriteLine("You Lose!");
            }
            else
            {
                WriteLine("Error");
            }
            Console.ReadLine();
        }
    }
}
