using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class PayrollConsoleReader
    {
        #region ReadSalaryEmployeeFromConsole
        /// <summary>
        /// Create a salary employee
        /// </summary>
        /// <returns>A salary employee</returns>
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
        #endregion

        #region ReadHourlyEmployeeFromConsole
        /// <summary>
        /// Create an hourly employee
        /// </summary>
        /// <returns>An hourly employee</returns>
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
        #endregion

        #region GetPayrateConsole
        /// <summary>
        /// Gets the payrate from user
        /// </summary>
        /// <returns>The payrate</returns>
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
        #endregion

        #region GetHoursWorkedConsole
        /// <summary>
        /// Gets the hours worked from user
        /// </summary>
        /// <returns>The number of hours worked</returns>
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
        #endregion

        #region GetNameConsole
        /// <summary>
        /// Gets the name from user
        /// </summary>
        /// <returns>The name</returns>
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
        #endregion

        #region GetSalaryConsole
        /// <summary>
        /// Gets the salary from user
        /// </summary>
        /// <returns>The salary</returns>
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
        #endregion
    }
}
