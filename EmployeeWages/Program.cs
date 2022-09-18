using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class Program
    {
        public const int FullTime = 1;
        public const int PartTime = 2;
        public const int EmpRatePerHour = 100;
        public const int NumOfWorkingDays = 20;
        static void Main(string[] args)
        {
            int EmpHrs = 0;
            int EmpWages = 0;
            int TotalEmpWage = 0;

            for (int day = 1; day < NumOfWorkingDays; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FullTime:
                        EmpHrs = 8;
                        Console.WriteLine("Employee type is Full time.");
                        break;
                    case PartTime:
                        EmpHrs = 4;
                        Console.WriteLine("Employee type is Part time.");
                        break;
                    default:
                        EmpHrs = 0;
                        Console.WriteLine("Employee is absent.");
                        break;
                }

                EmpWages = EmpHrs * EmpRatePerHour;
                TotalEmpWage += EmpWages;
                Console.WriteLine("Employee wage is {0}.", EmpWages);
            }
            Console.WriteLine("Total Employee Wage is {0}.",TotalEmpWage);
            Console.ReadLine();
        }
    }
}
