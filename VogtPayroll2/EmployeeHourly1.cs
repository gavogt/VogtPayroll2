using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class EmployeeHourly : Employee
    {
        
        private decimal _payRate;

        public decimal ComputeHourlyPay()
        {
            // Employees that work over 40 hours will receive overtime pay of one and a half of their hourly rate for overtime hours worked.
            return ((hoursWorked) * _payRate);
        }
    }
}
