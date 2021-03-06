﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class HourlyEmployee : Employee
    {
        protected decimal _payRate;

        public HourlyEmployee(string name, decimal payrate, int hoursWorked)
            : base(name, hoursWorked)
        {
            this._name = name;
            this._payRate = payrate;
            this._hoursWorked = hoursWorked;

        }

        #region GetGrossPay
        /// <summary>
        /// Gets the gross pay
        /// </summary>
        /// <returns>Gross pay</returns>
        public override decimal GetGrossPay()
        {
            return _hoursWorked * GetPayRate();

        }
        #endregion

        #region GetPayRate
        /// <summary>
        /// Gets the payrate
        /// </summary>
        /// <returns>Payrate</returns>
        public override decimal GetPayRate()
        {
            return _payRate;

        }
        #endregion

    }
}
