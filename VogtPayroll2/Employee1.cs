using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    abstract class Employee
    {
        //For simplicity, use a constant tax rate of 30% to compute the tax amount
        protected string name;
        protected int hoursWorked;
        protected decimal payRate;
        protected const decimal taxAmount = .30m;

        public Employee(string aName, decimal aPayRate)
        {
            name = aName;
            payRate = aPayRate;
        }
        public void DisplayEmployeeInfo(Employee employee)
        {
            // The output should display the aName of each Employee, hours worked, hourly rate, overtime pay, regular (gross) pay, tax amount, and net pay.
            Console.WriteLine($"Employee Name: {employee.name}");
            Console.WriteLine($"Hours worked: {employee.hoursWorked}");
            Console.WriteLine($"Hourly rate: {GetPayRate()}");
            Console.WriteLine($"Overtime pay: {OverTime()}");
            Console.WriteLine($"Regular (gross) pay: {GetGrossPay()}");
            Console.WriteLine($"Tax amount: {GetTaxAmount()}");
            Console.WriteLine($"Net Pay: {GetNetPay()}");
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

        public decimal OverTime()
        {
            //Employees that work over 40 hours will receive overtime pay of one and a half of their hourly rate for overtime hours worked.
            decimal overTimePay = default;

            overTimePay = Pay(payRate);

            return overTimePay;
        }

        public decimal Pay(decimal payRate)
        {
            decimal overTimePay = default;
            decimal hoursW = default;

            if (hoursWorked > 40)
            {
                hoursW = Convert.ToDecimal(hoursWorked - 40.00);

                overTimePay = hoursW * (payRate * 1.5m);
            }

            return overTimePay;
        }

        public abstract decimal GetGrossPay();
        public abstract decimal GetPayRate();


        public decimal GetTaxAmount()
        {
            decimal grossPay = GetGrossPay();
            decimal taxedAmount;
            taxedAmount = taxAmount * grossPay;

            return taxedAmount;
        }

        public decimal GetNetPay()
        {
            return GetGrossPay() - GetTaxAmount();

        }
        
    }
}
