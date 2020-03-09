using System;

namespace VogtPayroll2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeArray(HowManyEmployees());
        }

        public static Employee[] EmployeeArray(int result)
        {
            Employee[] employeeArray = new Employee[result];

            return employeeArray;
        }

        public static int HowManyEmployees()
        {
            bool run;


            Console.WriteLine("How many employees would you like to add? Please select 1-10");
            run = int.TryParse(Console.ReadLine(), out int result) && result > 1 && result < 10;

            Console.WriteLine($"Adding {result} employees!");

            return result;

        }
    }
}
