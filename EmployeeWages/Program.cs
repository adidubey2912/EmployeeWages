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
        public static int ComputeEmpWage(string Company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHrsInMonth)
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
                        break;
                    case PartTime:
                        EmpHrs = 4;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }

                TotalEmpHrs += EmpHrs;
                Console.WriteLine("Working days {0} and hours {1}.", TotalWorkingDays, EmpHrs);
            }
            int TotalEmpWages = TotalEmpHrs * EmpRatePerHour;
            Console.WriteLine("Total Employee Wage for company {0} is {1}.", Company, TotalEmpWages);
            return TotalEmpWages;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("DMart", 20, 30, 208);
            ComputeEmpWage("Big Bazar", 15, 26, 200 );
            Console.ReadLine();
        }
    }
}
