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
        public const int EmpRatePerHour = 20;
        public const int NumOfWorkingDays = 20;
        public const int MaxHrsInMonth = 100;
        public static int ComputeEmpWage()
        {
            int EmpHrs = 0;
            int TotalEmpHrs = 0;
            int TotalWorkingDays = 0;

            while(TotalEmpHrs < MaxHrsInMonth && TotalWorkingDays < NumOfWorkingDays)
            {
                TotalWorkingDays++;
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

                TotalEmpHrs += EmpHrs;
                Console.WriteLine("Working days {0} and hours {1}", TotalWorkingDays, EmpHrs);
            }
            int TotalEmpWages = TotalEmpHrs * EmpRatePerHour;
            Console.WriteLine("Monthly Employee Wage is {0}", TotalEmpWages);
            return TotalEmpWages;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
            Console.ReadLine();
        }
    }
}
