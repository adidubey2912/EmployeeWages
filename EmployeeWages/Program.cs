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
            int FullTime = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == FullTime)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }
            Console.Read();
        }
    }
}
