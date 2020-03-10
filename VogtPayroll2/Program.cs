using System;
using System.Collections.Generic;

namespace VogtPayroll2
{
    class Program
    {
        private static int employeeCounter;

        static void Main(string[] args)
        {
            PayrollManager payrollManager = new PayrollManager();


            
        }

        public static Employee[] EmployeeArray(int result)
        {
            Employee[] employeeArray = new Employee[result];

            return employeeArray;
        }

        public static int HowManyEmployees()
        {
            bool run;


            Console.WriteLine("How many employees would you like to add? Please select 1-10");
            run = int.TryParse(Console.ReadLine(), out int result) && result > 1 && result < 10;

            Console.WriteLine($"Adding {result} employees!");

            return result;

        }

        public static void PrintMenu()
        {
            PayrollManager payrollManager = new PayrollManager();
            char option = Convert.ToChar(Console.ReadKey());
            string name;
            int hoursWorked;
            decimal salary;

            Console.WriteLine("Press 'q' to quit, 's' to create a salary employee and 'h' for an hourly employee");
            while (option != 'q')
            {
                switch (option)
                {
                    case 's':
                        Console.WriteLine("What is the name of the employee?");
                        name = Console.ReadLine();
                        Console.WriteLine("How many hours were worked?");
                        hoursWorked = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the salary of the employee?");
                        salary = Convert.ToDecimal(Console.ReadLine());
                        payrollManager.AddEmployee(PayrollConsoleReader.ReadSalaryEmployeeFromConsole(name, hoursWorked, salary));
                        employeeCounter++;
                        break;
                    case 'h':
                        Console.WriteLine("What is the name of the employee?");
                        name = Console.ReadLine();
                        Console.WriteLine("How many hours were worked?");
                        hoursWorked = Convert.ToInt32(Console.ReadLine());
                        payrollManager.AddEmployee(PayrollConsoleReader.ReadHourlyEmployeeFromConsole(name, hoursWorked));
                        employeeCounter++;
                        break;
                    default:
                        Console.WriteLine("Please press q, s or h");
                        break;

                }

            }
        }
    }
}
