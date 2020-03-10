﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class EmployeeHourly : Employee
    {
        public EmployeeHourly(string name, int hoursWorked)
            : base(name, hoursWorked)
        {
            this._name = name;
            this._hoursWorked = hoursWorked;

        }

        public override decimal GetGrossPay()
        {
            return _hoursWorked + GetPayRate();

        }

        public override decimal GetPayRate()
        {
            return _payRate;

        }
    }
}
