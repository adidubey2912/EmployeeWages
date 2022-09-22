using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class EmpWageBuilderObject
    {
        public const int FullTime = 1;
        public const int PartTime = 2;

        private string Company;
        public int EmpRatePerHour;
        public int NumOfWorkingDays;
        private int MaxHrsInMonth;
        private int TotalEmpWage;

        public EmpWageBuilderObject(string Company, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            this.Company = Company;
            this.EmpRatePerHour = empRatePerHour;
            this.NumOfWorkingDays = numOfWorkingDays;
            this.MaxHrsInMonth = maxHrsInMonth;
        }

        public void ComputeEmpWage()
        {
            //Variables
            int EmpHrs = 0;
            int TotalEmpHrs = 0;
            int TotalWorkingDays = 0;
            //Computation
            while (TotalEmpHrs < MaxHrsInMonth && TotalWorkingDays < NumOfWorkingDays)
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
            TotalEmpWage = TotalEmpHrs * this.EmpRatePerHour;
            Console.WriteLine("Total Employee Wage for company {0} is {1}.", Company, TotalEmpWage);
        }
        public string toString()
        {
            return "Total Employee Wage for Company: " + this.Company + " is: " + this.TotalEmpWage;
        }
    }
}
