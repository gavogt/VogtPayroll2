using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class SalaryEmployee : Employee
    {
        private decimal _salary;

        public SalaryEmployee(string name, int hoursWorked, decimal salary)
            : base(name, hoursWorked)
        {
            this._name = name;
            this._hoursWorked = hoursWorked;
            this._salary = salary;

        }

        public override decimal GetGrossPay()
        {
            // For salary based employees, to find the regular (gross) pay for a week, divide the salary by 52.
            return _salary / 52;

        }

        public override decimal GetPayRate()
        {
            // To compute the overtime pay for a salary based employee, first find the hourly rate by dividing the gross pay by 40, and then compute overtime pay
            return Convert.ToDecimal(GetGrossPay() / 40);

        }



    }
}
