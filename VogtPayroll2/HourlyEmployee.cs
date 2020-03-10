using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class HourlyEmployee : Employee
    {
        public HourlyEmployee(string name, decimal payrate, int hoursWorked)
            : base(name, hoursWorked)
        {
            this._name = name;
            this._payRate = payrate;
            this._hoursWorked = hoursWorked;


        }

        public override decimal GetGrossPay()
        {
            return _hoursWorked * GetPayRate();

        }

        public override decimal GetPayRate()
        {
            return _payRate;

        }
    }
}
