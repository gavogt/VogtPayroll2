using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class PayrollConsoleReader
    {
        public SalaryEmployee ReadSalaryEmployeeFromConsole()
        {
            string name;
            int hoursWorked;
            decimal salary;

            name = GetNameConsole();
            hoursWorked = GetHoursWorkedConsole();
            salary = GetSalaryConsole();

            return new SalaryEmployee(name, hoursWorked, salary);

        }

        public HourlyEmployee ReadHourlyEmployeeFromConsole()
        {
            string name;
            int hoursWorked;
            decimal payrate;

            name = GetNameConsole();
            hoursWorked = GetHoursWorkedConsole();
            payrate = GetPayrateConsole();

            return new HourlyEmployee(name, payrate, hoursWorked);

        }

        public decimal GetPayrateConsole()
        {
            decimal payrateResult;
            Console.WriteLine("What is the payrate amount?");
            var payrate = Console.ReadLine();
            while (!decimal.TryParse(payrate, out payrateResult))
            {
                Console.WriteLine("Not a payrate amount!");
                payrate = Console.ReadLine();
            }

            return payrateResult;

        }

        public int GetHoursWorkedConsole()
        {

            int hoursResult;
            Console.WriteLine("How many hours were worked?");
            var hoursWorked = Console.ReadLine();
            while (!int.TryParse(hoursWorked, out hoursResult))
            {
                Console.WriteLine("Not a number!");
                hoursWorked = Console.ReadLine();
            }

            return hoursResult;

        }

        public string GetNameConsole()
        {
            Console.WriteLine("What is the name of the employee?");

            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("The name can't be empty! try again");
                name = Console.ReadLine();
            }

            return name;

        }

        public decimal GetSalaryConsole()
        {
            decimal salaryResult;

            Console.WriteLine("What is the salary of the employee?");

            var salary = Console.ReadLine();

            while (!decimal.TryParse(salary, out salaryResult))
            {
                Console.WriteLine("Not a salary amount!");
                salary = Console.ReadLine();

            }

            return salaryResult;

        }
    }
}
