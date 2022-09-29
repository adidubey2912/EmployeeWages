using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class EmpWageBuilder: IComputeEmpWage
    {
        public const int FullTime = 1;
        public const int PartTime = 2;

        private LinkedList<CompanyEmpWage> CompanyEmpWageList;
        private Dictionary<string, CompanyEmpWage> CompanyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.CompanyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.CompanyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void AddCompanyEmpWage(string Company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHrsPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(Company, EmpRatePerHour, NumOfWorkingDays, MaxHrsPerMonth);
            this.CompanyEmpWageList.AddLast(companyEmpWage);
            this.CompanyToEmpWageMap.Add(Company, companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.CompanyEmpWageList)
            {
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.ToString());
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

        public int GetTotalWage(string Company)
        {
            return this.CompanyToEmpWageMap[Company].TotalEmpWage;
        }
    }
}
