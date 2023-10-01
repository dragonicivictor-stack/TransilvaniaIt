using System;
using System.Xml.Linq;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            int age = ReadNumberFromKeyboard("Please enter your age: ");
            Console.WriteLine("Hello,  " + name + " , your age is " + age);

            int currentYear = ReadNumberFromKeyboard("Please ennter current year: ");
            Console.WriteLine("Current year is: " + currentYear);




        }

        static int ReadNumberFromKeyboard(string label)
        {
            bool canConvert = false;
            while (!canConvert)
            {
                Console.Write(label);
                string textRead = Console.ReadLine();

                canConvert = int.TryParse(textRead, out int result);
                if (canConvert)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("The text " + textRead + " doesn't represent a number.");
                }

            }

            return 0;


        }
    }
}
