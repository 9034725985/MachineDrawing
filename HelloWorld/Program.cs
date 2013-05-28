using System;

namespace HelloWorld
{
    class Program
    {
        static readonly string promptName = "What is your name?";
        static readonly string promptAge = "How old are you in years as of your last birthday?";
        static readonly string doesNotExist = "Does not exist in our records.";
        static readonly string name = "name";
        static readonly string age = "age";
        static readonly string ageMustBeInteger = "Please enter a valid integer for age as of last birthday.";
        static readonly string notOfAge = "Sorry, you are too young to use this service.";
        static readonly string promptVerification = "Please verify your name and age. If there is anything wrong, call us at 555-555-5555.";

        static void Main()
        {
            PrintToConsole();
        }

        private static void PrintToConsole()
        {
            try
            {
                string[] client = new string[2];
                Console.WriteLine(promptName);
                string name = Console.ReadLine();
                AddNameToClient(client, name);
                Console.WriteLine(promptAge);
                int age = InputAge();
                AddAgeToClient(client, age);
                ConsoleKeyInfo c = VerifyClientInformation(client);
                c = IsSuccess(c);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private static int InputAge()
        {
            string clientAgeInput = Console.ReadLine();
            int age = new int();
            if (!int.TryParse(clientAgeInput, out age))
            {
                Console.WriteLine(ageMustBeInteger);
                clientAgeInput = Console.ReadLine();
                InputAge();
            }
            return age;
        }

        private static void AddNameToClient(string[] client, string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                client[0] = name;
            }
            else
            {
                client[0] = doesNotExist;
            }
        }

        private static void AddAgeToClient(string[] client, int age)
        {
            //A client must be older than 13
            if (age > 13)
            {
                client[1] = age.ToString();
            } 
            else
            {
                //Delete all client information if prospective client is not older than 13.
                client[0] = doesNotExist;
                client[1] = doesNotExist;
                Console.WriteLine(notOfAge);
                Console.ReadLine();
            }
        }

        private static ConsoleKeyInfo VerifyClientInformation(string[] client)
        {
            Console.WriteLine(promptVerification);
            Console.WriteLine(string.Format("{0}: {1}", name, client[0].ToString()));
            Console.WriteLine(string.Format("{0}: {1}", age, client[1].ToString()));
            ConsoleKeyInfo c = Console.ReadKey();
            return c;
        }

        private static ConsoleKeyInfo IsSuccess(ConsoleKeyInfo c)
        {
            if (c.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("The program ran successfully.");
                Console.ReadLine();
            }
            return c;
        }
    }
}
