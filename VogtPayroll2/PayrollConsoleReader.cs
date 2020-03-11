using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class PayrollConsoleReader
    {
        public static SalaryEmployee ReadSalaryEmployeeFromConsole(string name, int hoursWorked, decimal salary)
        {
            return new SalaryEmployee(name, hoursWorked, salary);

        }

        public static HourlyEmployee ReadHourlyEmployeeFromConsole(string name, decimal payrate, int hoursWorked)
        {
            return new HourlyEmployee(name, payrate, hoursWorked);

        }
    }
}
