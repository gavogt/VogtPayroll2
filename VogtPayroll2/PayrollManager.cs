﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace VogtPayroll2
{
    class PayrollManager
    {

        #region GetNetPayOfAllEmployees
        /// <summary>
        /// Sorts the netpay of all employees
        /// </summary>
        /// <param name="employees">Employees passed in by a list</param>
        /// <returns>A sorted list</returns>
        public List<Employee> GetNetPayOfAllEmployees(List<Employee> employees)
        {
            List<Employee> sortedList = new List<Employee>();
            
            sortedList = employees.OrderBy(employees => employees.NetPay).ToList();

            return sortedList;

        }
        #endregion

        #region GetMinimumAndMaximumNetPay
        /// <summary>
        /// Gets the max and min value of the netpay for an employee list
        /// </summary>
        /// <param name="sortedList">The sorted list passed in</param>
        public void GetMinimumAndMaximumNetPay(List<Employee> sortedList)
        {
            // In addition, the program should find the minimum and maximum net pay of all employees as well as sort the employees based on their net pay (ascending order)
            // The program must combine two sorting techniques; the Selection and Exchange sorts. It will efficiently sort the employees' net pay.
            // Preferrably without using a data file.

            Console.WriteLine("----------------------------");

            Console.WriteLine($"highest netpay: {sortedList.LastOrDefault().NetPay:C2}");

            Console.WriteLine($"lowest netpay: {sortedList.FirstOrDefault().NetPay:C2}");

        }
        #endregion

    }
}
