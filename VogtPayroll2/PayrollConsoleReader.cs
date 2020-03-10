﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class PayrollConsoleReader
    {
        public static SalaryEmployee ReadSalaryEmployeeFromConsole(string name, int hoursWorked, decimal salary)
        {
            SalaryEmployee salaryEmp = new SalaryEmployee(name, hoursWorked, salary);

            return salaryEmp;
        }

        public static HourlyEmployee ReadHourlyEmployeeFromConsole(string name, int hoursWorked)
        {
            HourlyEmployee hourlyEmp = new HourlyEmployee(name, hoursWorked);

            return hourlyEmp;
        }
    }
}