using System;
using System.Collections.Generic;
using System.Linq;

namespace VogtPayroll2
{
    class Program
    {
        private static int employeeCounter;

        static void Main(string[] args)
        {
            PayrollManager payrollManager = new PayrollManager();
            List<Employee> employeeList = new List<Employee>();

            employeeList = PrintMenu();

            foreach (var employee in employeeList)
            {
                employee.NetPay = employee.GetNetPay();
                employee.DisplayEmployeeInfo(employee);
            }

            employeeList = payrollManager.GetNetPayOfAllEmployees(employeeList);
            payrollManager.GetMinimumAndMaximumNetPay(employeeList);

        }

        public static List<Employee> PrintMenu()
        {
            PayrollManager payrollManager = new PayrollManager();
            List<Employee> employeeList = new List<Employee>();
            char option;
            string name;


            Console.WriteLine("Press 'q' to quit, 's' to create a salary employee and 'h' for an hourly employee");
            option = Console.ReadKey().KeyChar;
            Console.WriteLine("");

            while (option != 'q')
            {

                bool run;
                switch (option)
                {
                    case 's':
                        Console.WriteLine("What is the name of the employee?");
                        name = Console.ReadLine();
                        while (string.IsNullOrEmpty(name))
                        {
                            Console.WriteLine("The name can't be empty! try again");
                            name = Console.ReadLine();
                        }
                        Console.WriteLine("How many hours were worked?");
                        var hoursWorked = Console.ReadLine();
                        while (!int.TryParse(hoursWorked, out int result))
                        {
                            Console.WriteLine("Not a number!");
                            hoursWorked = Console.ReadLine();
                        }
                        Console.WriteLine("What is the salary of the employee?");
                        var salary = Console.ReadLine();
                        while (!decimal.TryParse(salary, out decimal result))
                        {
                            Console.WriteLine("Not a salary amount!");
                            salary = Console.ReadLine();
                        }
                        employeeList.Add(PayrollConsoleReader.ReadSalaryEmployeeFromConsole(name, hoursWorked, salary));
                        employeeCounter++;
                        break;
                    case 'h':
                        Console.WriteLine("What is the name of the employee?");
                        name = Console.ReadLine();
                        while (string.IsNullOrEmpty(name))
                        {
                            Console.WriteLine("The name can't be empty! try again");
                            name = Console.ReadLine();
                        }
                        Console.WriteLine("How many hours were worked?");
                        hoursWorked = Console.ReadLine();
                        while (!int.TryParse(hoursWorked, out int result))
                        {
                            Console.WriteLine("Not a number!");
                            hoursWorked = Console.ReadLine();
                        }
                        Console.WriteLine("What is the payrate of the employee?");
                        var payrate = Console.ReadLine();
                        while (!decimal.TryParse(payrate, out decimal result))
                        {
                            Console.WriteLine("Not a salary amount!");
                            salary = Console.ReadLine();
                        }
                        employeeList.Add(PayrollConsoleReader.ReadHourlyEmployeeFromConsole(name, payrate, hoursWorked));
                        employeeCounter++;
                        break;
                    case 'q':
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please press q, s or h");
                        break;

                }
                option = Console.ReadKey().KeyChar;
                Console.WriteLine("");
            }
            return employeeList;

        }
    }
}
