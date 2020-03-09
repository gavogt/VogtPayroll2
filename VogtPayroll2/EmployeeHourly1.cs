using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class EmployeeHourly : Employee
    {
        public EmployeeHourly(string aName, int aHoursWorked, decimal aPayRate)
            : base(aName, aHoursWorked, aPayRate)
        {
            this.name = aName;
            this.hoursWorked = aHoursWorked;
            this.payRate = aPayRate;
        }

        public override decimal GetGrossPay()
        {
            decimal regularPay = default;
            decimal overTime;
            overTime = OverTime();
            if (hoursWorked > 40)
            {
                hoursWorked = 40;
                regularPay = 1.5m * hoursWorked * payRate;
            }

            return overTime + regularPay;
        }

        public override decimal GetPayRate()
        {

            return payRate;
        }
    }
}
