using System;
using System.Collections.Generic;
using System.Linq;

namespace VogtPayroll2
{
    class Program
    {
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

            PayrollConsoleReader payrollConsoleReader = new PayrollConsoleReader();

            Console.WriteLine("Press 'q' to quit, 's' to create a salary employee and 'h' for an hourly employee");

            option = Console.ReadKey().KeyChar;

            Console.WriteLine("");

            while (option != 'q')
            {

                switch (option)
                {
                    case 's':
                        employeeList.Add(payrollConsoleReader.ReadSalaryEmployeeFromConsole());
                        break;
                    case 'h':
                        employeeList.Add(payrollConsoleReader.ReadHourlyEmployeeFromConsole());
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
