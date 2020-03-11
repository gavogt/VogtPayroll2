using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace VogtPayroll2
{
    class PayrollManager
    {
        private List<Employee> _employees = new List<Employee>();

        public List<Employee> GetNetPayOfAllEmployees(List<Employee> employees)
        {
            List<Employee> sortedList = new List<Employee>();
            
            sortedList = employees.OrderBy(employees => employees.NetPay).ToList();

            return sortedList;

        }

        public void GetMinimumAndMaximumNetPay(List<Employee> sortedList)
        {
            // In addition, the program should find the minimum and maximum net pay of all employees as well as sort the employees based on their net pay (ascending order)
            // The program must combine two sorting techniques; the Selection and Exchange sorts. It will efficiently sort the employees' net pay.
            // Preferrably without using a data file.

            //return netPay;
            foreach (var employee in sortedList)
            {
                Console.WriteLine("Highest net pay");
                Console.WriteLine(employee.NetPay);
                Console.Write("highest netpay: ");

            }

            Console.WriteLine(sortedList.FirstOrDefault().ToString());
            Console.Write("lowest netpay: ");
            Console.WriteLine(sortedList.LastOrDefault().ToString());


        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);

        }
    }
}
