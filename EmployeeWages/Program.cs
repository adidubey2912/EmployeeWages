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
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.AddCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilderArray.AddCompanyEmpWage("Relince", 10, 4, 20);
            empWageBuilderArray.ComputeEmpWage();
            Console.ReadLine();
        }
    }
}
