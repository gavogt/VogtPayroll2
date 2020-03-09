using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class EmployeeSalary : Employee
    {
        private decimal _salary;

        public EmployeeSalary(string aName, int aHoursworked, decimal aPayRate)
            : base(aName, aHoursworked, aPayRate)
        {
            this.name = aName;
            this.hoursWorked = aHoursworked;
            this.payRate = aPayRate;
        }

        public override decimal GetGrossPay()
        {
            // For salary based employees, to find the regular (gross) pay for a week, divide the salary by 52.
            return _salary / 52;
        }

        public override decimal GetPayRate()
        {
            // To compute the overtime pay for a salary based employee, first find the hourly rate by dividing the gross pay by 40, and then compute overtime pay
            payRate = Convert.ToDecimal(GetGrossPay() / 40);

            return payRate;
        }



    }
}
