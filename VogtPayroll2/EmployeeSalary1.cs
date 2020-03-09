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

        public decimal FindOverTimePaySalary()
        {
            decimal overTimePay = default;

            payRate = Convert.ToDecimal(FindGrossPay() / 40);
            overTimePay = Pay(payRate);

            return overTimePay;
        }



    }
}
