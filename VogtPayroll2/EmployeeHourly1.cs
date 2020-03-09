﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class EmployeeHourly : Employee
    {
        public EmployeeHourly(string aName)
            : base(aName)
        {

        }


        public decimal ComputeHourlyPay()
        {
            // Employees that work over 40 hours will receive overtime pay of one and a half of their hourly rate for overtime hours worked.
            decimal overtimePay = default;
            decimal regularPay = default;

            regularPay = (hoursWorked * payRate);

            overtimePay = Pay(payRate);

            return regularPay + overtimePay;
        }
    }
}
