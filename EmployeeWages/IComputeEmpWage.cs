using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public interface IComputeEmpWage
    {
        public void AddCompanyEmpWage(string Company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHrsPerMonth);
        public void ComputeEmpWage();
        public int GetTotalWage(string Company);
    }
    public class CompanyEmpWage
    {
        public string Company;
        public int EmpRatePerHour;
        public int NumOfWorkingDays;
        public int MaxHrsPerMonth;
        public int TotalEmpWage;

        public CompanyEmpWage(string Company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHrsPerMonth)
        {
            this.Company = Company;
            this.EmpRatePerHour = EmpRatePerHour;
            this.NumOfWorkingDays = NumOfWorkingDays;
            this.MaxHrsPerMonth = MaxHrsPerMonth;
            this.TotalEmpWage = 0;
        }

        public void SetTotalEmpWage(int TotalEmpWage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }

        public string toString()
        {
            return "Total Employee Wage for Company: " + this.Company + " is: " + this.TotalEmpWage;
        }
    }
}
