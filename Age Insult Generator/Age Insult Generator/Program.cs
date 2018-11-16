using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Age_Insult_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string college;
            string stringAnswer = null;

            WriteLine("What is your age? ");
            age = int.Parse(ReadLine());

            if (age <= 12)
            {
                stringAnswer = "You are a minor";
            }
            else if (age > 13 && age <= 18)
            {
                stringAnswer = "You are stupid";
            }
            else if (age > 18 && age <= 25)
            {
                WriteLine("Did you go to college? Yes or No >>");
                college = ReadLine();
                if (college == "Yes")
                {
                    stringAnswer = "Im Broke!";
                }
                else
                {
                    stringAnswer = "I wish I went to college!";
                }
            }
            else if (age > 26 && age <= 30)
            {
                stringAnswer = "You finally got a real job";
            }
            else if (age > 31 && age <= 40)
            {
                stringAnswer = "You are fat and tired of working";
            }
            else if (age > 41 && age <= 50)
            {
                stringAnswer = "Can I just retire already?";
            }
            else if (age > 51 && age <= 75)
            {
                stringAnswer = "Finally retirement";
            }
            else if (age > 76)
            {
                stringAnswer = "Old fart";
            }
            WriteLine(stringAnswer);

        }
    }
}
