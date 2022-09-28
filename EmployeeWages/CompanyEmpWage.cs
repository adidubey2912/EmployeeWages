using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class CompanyEmpWage
    {
        public string Company;
        public int EmpratePerHour;
        public int NumOfWorkingDays;
        public int MaxHrsPerMonth;
        public int TotalEmpWage;

        public CompanyEmpWage(string Company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHrsPerMonth)
        {
            this.Company = Company;
            this.EmpratePerHour = EmpRatePerHour;
            this.NumOfWorkingDays = NumOfWorkingDays;
            this.MaxHrsPerMonth = MaxHrsPerMonth;
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
