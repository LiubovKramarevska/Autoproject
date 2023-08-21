// See https://aka.ms/new-console-template for more information
using System;

namespace Automation

{
    class Program
    {
        static void Main()
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
            System.Console.WriteLine(num);


            }
            catch (FormatException)
            {
                Console.WriteLine("You wrote invalid format");
            }
        }
    }
}
