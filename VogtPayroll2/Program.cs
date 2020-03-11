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

            employeeList= payrollManager.GetNetPayOfAllEmployees(employeeList);
            payrollManager.GetMinimumAndMaximumNetPay(employeeList);

        }

        public static List<Employee> PrintMenu()
        {
            PayrollManager payrollManager = new PayrollManager();
            List<Employee> employeeList = new List<Employee>();
            char option;
            string name;
            int hoursWorked;
            decimal salary;
            decimal payrate;


            Console.WriteLine("Press 'q' to quit, 's' to create a salary employee and 'h' for an hourly employee");
            option = Console.ReadKey().KeyChar;
            Console.WriteLine("");

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
                        employeeList.Add(PayrollConsoleReader.ReadSalaryEmployeeFromConsole(name, hoursWorked, salary));
                        employeeCounter++;
                        break;
                    case 'h':
                        Console.WriteLine("What is the name of the employee?");
                        name = Console.ReadLine();
                        Console.WriteLine("How many hours were worked?");
                        hoursWorked = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the payrate of the employee?");
                        payrate = Convert.ToDecimal(Console.ReadLine());
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
