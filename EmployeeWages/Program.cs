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
            EmpWageBuilderObject DMart = new EmpWageBuilderObject("DMart", 20, 10, 28);
            EmpWageBuilderObject BigBazar = new EmpWageBuilderObject("Big Bazar", 15, 5, 20 );
            DMart.ComputeEmpWage();
            Console.WriteLine(DMart.toString());
            BigBazar.ComputeEmpWage();
            Console.WriteLine(BigBazar.toString());
            Console.ReadLine();
        }
    }
}
