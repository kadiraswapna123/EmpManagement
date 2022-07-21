using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement
{
    internal class ComputeEmpWage
    {
        int IS_PART_TIME = 1;
        int IS_FULL_TIME = 2;
        int EMP_RATE_PER_HOUR = 20;
        int NUM_OF_WORKING_DAYS = 2;
        int MAX_HRS_IN_MONTH = 10;
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays<NUM_OF_WORKING_DAYS)
        {
               totalWorkingDays++;
            Random rand = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                  case IS_PART_TIME:
                       empHrs = 4;
                       break;
                  case IS_FULL_TIME:
                       empHrs = 8;
                       break;
                  default:
                       empHrs = 0;
                       break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Days;" + totalWorkingDays + "Emp Hrs : " + empHrs);
        }
        int totalEmpWage = totalWorkingDaysEmpHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Total Emp Wage . " + totalEmpWage);
        static void Main(string[] args)
        {
             computeEmpWage();
        }
    }
}
