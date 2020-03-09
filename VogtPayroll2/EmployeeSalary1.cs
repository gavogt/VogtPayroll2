using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class EmployeeSalary : Employee
    {
        private decimal _salary;

        public decimal FindGrossPay()
        {
            // For salary based employees, to find the regular (gross) pay for a week, divide the salary by 52.
            return _salary / 52;
        }

        public decimal FindOverTimePay()
        {
            // To compute the overtime pay for a salary based employee, first find the hourly rate by dividing the gross pay by 40, and then compute overtime pay
            return hoursWorked * FindGrossPay() / 40;
        }

    }
}
