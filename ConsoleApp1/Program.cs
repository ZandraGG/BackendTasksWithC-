using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            MainMenu();
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Task One");
            Console.WriteLine("2) Task Two");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ReadFile.readFromFile();

                    Console.WriteLine("Selected option Task One!");
                    return true;
                case "2":
                    SalaryCalculator.calculateSalary();
                    Console.WriteLine("Selected option Task Two!");
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
    }
}
