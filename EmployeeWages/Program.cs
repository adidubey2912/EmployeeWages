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
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.AddCompanyEmpWage("Relince", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total Wage for DMart Company : " + empWageBuilder.GetTotalWage("DMart"));
            Console.ReadLine();
        }
    }
}
