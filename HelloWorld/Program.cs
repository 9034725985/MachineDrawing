using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static readonly string promptName = "What is your name?";
        static readonly string promptAge = "How old are you in years as of your last birthday?";
        static readonly string doesNotExist = "Does not exist in our records.";
        static readonly string name = "name";
        static readonly string age = "age";

        static void Main(string[] args)
        {
            PrintToConsole();
        }

        private static void PrintToConsole()
        {
            string[] client = new string[2];
            Console.WriteLine(promptName);
            string clientName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(clientName))
            {
                client[0] = clientName;
            }
            else
            {
                client[0] = doesNotExist;
            }
            Console.WriteLine(promptAge);
            string clientAge = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(clientAge))
            {
                client[1] = clientAge;
            }
            else
            {
                client[1] = doesNotExist;
            }
            Console.WriteLine(string.Format("{0}: {1}", name, client[0].ToString()));
            Console.WriteLine(string.Format("{0}: {1}", age, client[1].ToString()));
            ConsoleKeyInfo c = Console.ReadKey();
            if (c.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("The program ran successfully.");
                Console.ReadLine();
            }
        }
    }
}
