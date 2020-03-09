using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class EmployeeSalary : Employee
    {
        private decimal _salary;

        public EmployeeSalary(string aName)
            : base(aName)
        {

        }

        public decimal FindGrossPay()
        {
            // For salary based employees, to find the regular (gross) pay for a week, divide the salary by 52.
            return _salary / 52;
        }

        public decimal FindOverTimePay()
        {
            // To compute the overtime pay for a salary based employee, first find the hourly rate by dividing the gross pay by 40, and then compute overtime pay
            decimal overTimePay = default;
            decimal regularPay = default;

            payRate = Convert.ToDecimal(FindGrossPay() / 40);

            regularPay = payRate * hoursWorked;

            if (hoursWorked > 40)
            {
                //hoursWorked - 40.00;

                overTimePay = hoursWorked * (payRate * 1.5m);
            }

            return overTimePay + regularPay;
        }

    }
}
