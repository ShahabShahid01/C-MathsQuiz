using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Repeat_check = 1;

            while (Repeat_check == 1)
            {
                Random numberGenerator = new Random();

                double num_01 = numberGenerator.Next(1, 10);
                double num_02 = numberGenerator.Next(1, 10);
                double Answer;

                Console.WriteLine("What is " + num_01 + " Multiplied by " + num_02 + "?");
                Answer = Convert.ToDouble(Console.ReadLine());

                if (Answer == num_01 * num_02)
                {
                    Console.WriteLine("Correct");
                    Console.WriteLine("Again? 1 for Yes. 2 for No.");
                    Repeat_check = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Incorrect!U dumb twat.");
                    Console.WriteLine("Try Again? 1 for Yes. 2 for No.");
                    Repeat_check = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
