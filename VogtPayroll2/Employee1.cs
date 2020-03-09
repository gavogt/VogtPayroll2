using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class Employee
    {
        protected string name;
        protected int hoursWorked;


        public void DisplayEmployeeInfo(Employee employee)
        {
            // The output should display the name of each Employee, hours worked, hourly rate, overtime pay, regular (gross) pay, tax amount, and net pay.
            Employee hourlyEmployee = new EmployeeHourly();

            Console.WriteLine("Employee name: {Employee.name}");
            Console.WriteLine("Hours worked: {Employee}");
            Console.WriteLine("Hourly rate: {Employee}");
            Console.WriteLine("Overtime pay: {Employee}");
            Console.WriteLine("Regular (gross) pay: {Employee");
            Console.WriteLine("Tax amount: {Employee}");
            Console.WriteLine("Net Pay: {Employee}");
        }

        public void DisplayNetPayOfAllEmployees(Employee[] employee)
        {
            // The average net pay of all employees should also be displayed
        }

        public decimal FindMinimumAndMaximumNetPay()
        {
            // In addition, the program should find the minimum and maximum net pay of all employees as well as sort the employees based on their net pay (ascending order)
            // The program must combine two sorting techniques; the Selection and Exchange sorts. It will efficiently sort the employees' net pay.
            // Preferrably without using a data file.
            decimal netPay = default;

            return netPay;
        }
    }
}
