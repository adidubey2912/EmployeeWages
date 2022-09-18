using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class Program
    {
        static void Main(string[] args)
        {
            int FullTime = 1;
            int EmpRatePerHour = 20;

            int EmpHrs = 0;
            int EmpWages = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == FullTime)
            {
                EmpHrs = 8;
                Console.WriteLine("Employee type is Full time.");
            }
            else
            {
                EmpHrs = 0;
                Console.WriteLine("Employee is absent.");
            }

            EmpWages = EmpHrs * EmpRatePerHour;
            Console.WriteLine("Employee wage is {0}.", EmpWages);
            Console.ReadLine();
        }
    }
}
