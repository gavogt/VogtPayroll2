using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll2
{
    class PayrollManager
    {
        private List<Employee> _employees = new List<Employee>();

        public void GetNetPayOfAllEmployees(Employee[] employee)
        {
            // The average net pay of all employees should also be displayed
        }

        public decimal GetMinimumAndMaximumNetPay()
        {
            // In addition, the program should find the minimum and maximum net pay of all employees as well as sort the employees based on their net pay (ascending order)
            // The program must combine two sorting techniques; the Selection and Exchange sorts. It will efficiently sort the employees' net pay.
            // Preferrably without using a data file.
            decimal netPay = default;

            return netPay;

        }

        public List<Employee> AddEmployee(Employee employee)
        {
            _employees.Add(employee);

            return _employees;

        }
    }
}
