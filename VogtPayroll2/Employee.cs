using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    abstract class Employee
    {
        //For simplicity, use a constant tax rate of 30% to compute the tax amount
        protected string _name;
        protected int _hoursWorked;
        private decimal _netPay;

        protected const decimal _taxAmount = .30m;

        public decimal NetPay { get => _netPay; set => _netPay = value; }

        public Employee(string name, int hoursWorked)
        {
            _name = name;
            _hoursWorked = hoursWorked;

        }

        public abstract decimal GetGrossPay();
        public abstract decimal GetPayRate();

        public void DisplayEmployeeInfo(Employee employee)
        {
            // The output should display the name of each Employee, hours worked, hourly rate, overtime pay, regular (gross) pay, tax amount, and net pay.
            Console.WriteLine(" ");
            Console.WriteLine($"Employee Name: {employee._name}");
            Console.WriteLine($"Hours worked: {employee._hoursWorked}");
            Console.WriteLine($"Hourly rate: {GetPayRate():C2}");
            Console.WriteLine($"Overtime pay: {GetOverTimePay():C2}");
            Console.WriteLine($"Regular (gross) pay: {GetGrossPay():C2}");
            Console.WriteLine($"Tax amount: {GetTaxAmount():C2}");
            Console.WriteLine($"Net GetOverTimePay: {GetNetPay():C2}");

        }


        public decimal GetOverTimePay()
        {
            if (_hoursWorked <= 40)
                return 0;

            return GetPayRate() * (_hoursWorked - 40);

        }

        public decimal GetTaxAmount()
        {
            return _taxAmount * GetGrossPay();

        }

        public decimal GetNetPay()
        {

            return GetGrossPay() - GetTaxAmount();

        }

    }
}
