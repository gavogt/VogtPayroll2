using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class EmployeeHourly : Employee
    {
        public EmployeeHourly(string aName, decimal aPayRate)
            : base(aName, aPayRate)
        {
            this.name = aName;
            this.payRate = aPayRate;
        }

        public override decimal GetGrossPay()
        {
            decimal overTime;
            overTime = OverTime();

            return overTime;
        }

        public decimal GetHourlyPayRate()
        {

            payRate = 1.5m * hoursWorked;

            return payRate;
        }
    }
}
