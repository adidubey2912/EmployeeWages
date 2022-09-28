using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmpWageBuilderArray
    {
        public const int FullTime = 1;
        public const int PartTime = 2;

        private int NumOfCompany = 0;
        private CompanyEmpWage[] companyEmpWagesArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];
        }

        public void AddCompanyEmpWage(string Company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHrsPerMonth)
        {
            companyEmpWagesArray[this.NumOfCompany] = new CompanyEmpWage(Company, EmpRatePerHour, NumOfWorkingDays, MaxHrsPerMonth);
            NumOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < NumOfCompany; i++)
            {
                companyEmpWagesArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWagesArray[i]));
                Console.WriteLine(this.companyEmpWagesArray[i].ToString());
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //Variables
            int EmpHrs = 0;
            int TotalEmpHrs = 0;
            int TotalWorkingDays = 0;
            //Computation
            while (TotalEmpHrs < companyEmpWage.MaxHrsPerMonth && TotalWorkingDays < companyEmpWage.NumOfWorkingDays)
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
            return TotalEmpHrs * companyEmpWage.EmpRatePerHour;
        }
    }
}
