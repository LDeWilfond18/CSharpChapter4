using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hurricranes
{
    class Program
    {
        static void Main(string[] args)
        {
            int windspeed;
            string result = null;
            WriteLine("What is the windspeed?");
            windspeed = Convert.ToInt32(ReadLine());

            if (windspeed >= 74 && windspeed < 96)
            {
                result = "Category 1 hurricrane";
            }
            else if (windspeed >= 96 && windspeed < 111)
            {
                result = "Category 2 hurricrane";
            }
            else if (windspeed >= 111 && windspeed < 130)
            {
                result = "Category 3 hurricrane";
            }
            else if (windspeed >= 130 && windspeed < 157)
            {
                result = "Category 4 hurricrane";
            }
            else if (windspeed >= 157)
            {
                result = "Category 5 hurricrane";
            }

            WriteLine(result);
        }
    }
}
