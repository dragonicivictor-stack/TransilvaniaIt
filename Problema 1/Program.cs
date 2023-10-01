namespace Problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Va rog sa introduceti numele: ");
            string name = Console.ReadLine();

            int age = ReadNumberFromKeyboard("Va rog sa introduceti varsta: ");
            if (age>18)
                { Console.WriteLine("Buna ziua  " + name + ", avand varsta de " + age + ", aveti drept de vot!" ); 
            }
            else
            {
                Console.WriteLine("Buna ziua  " + name + ", avand varsta de " + age + ", nu aveti drept de vot!");
            }
                
            



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
                    Console.WriteLine("Textul " + textRead + " nu reprezinta un numar.");
                }

            }

            return 0;
           
        }
    }
}