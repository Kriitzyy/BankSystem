using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Welcome to the Bank System!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Make a Deposit");
                Console.WriteLine("2. Make a Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        // Call the method to make a deposit
                        break;
                    case "2":
                        // Call the method to make a withdraw
                        break;
                    case "3":
                        // Call the method to show balance
                        break;
                    case "4":
                        isRunning = false;
                        Console.WriteLine("Thank you for using the Bank System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
