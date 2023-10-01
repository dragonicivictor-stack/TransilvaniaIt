namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter yout age: ");
            string textRead = Console.ReadLine();
            bool canConvert = int.TryParse(textRead, out int result);
            if (canConvert)
            {
                Console.WriteLine("Hello,  " + name + " , your age is " + result);
            } 
            else
            {
                Console.WriteLine("The text " + textRead + "doesn't represent a number.");
            }
            }
                

            

           
        }
    }
