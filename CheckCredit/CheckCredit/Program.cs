using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int Credit;
            const int MAX = 5000;

            WriteLine("Please enter the price");
            Credit = Convert.ToInt32(ReadLine());
            if (Credit > MAX)
            {
                WriteLine("error");
            }
            else
                WriteLine("approved");
            ReadLine();
        }
        
    }
}
