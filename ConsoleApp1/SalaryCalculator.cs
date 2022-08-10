using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SalaryCalculator
    {

        public static void calculateSalary()
        {
            Console.WriteLine("Enter a salary: ");
            double grossSalary = Convert.ToDouble(Console.ReadLine());
            double netSalary;
            double taxes;

            if (grossSalary <= 1000)
            {
                Console.WriteLine("The net salary is: " + grossSalary);
            }
            else
            {
                grossSalary = grossSalary - 1000;
                taxes = grossSalary * 0.1;

                if (grossSalary <= 3000)
                {
                    taxes += grossSalary * 0.15;
                }
                netSalary = grossSalary - taxes + 1000;
                Console.WriteLine("The net salary is: " + netSalary);
            }
        }
    }
}