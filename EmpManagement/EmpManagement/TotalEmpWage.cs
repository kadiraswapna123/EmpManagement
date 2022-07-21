using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement
{
    public class TotalEmpWage
    {
        const int IS_FULL_TIME = 1, FULL_TIME_HOURS = 8, RATE_PER_HOUR = 20, NUM_OF_WORKING_DAYS = 100;
        int empHrs = 0, dailyEmpWage;
        Random random = new Random();
        public void Attendance()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = FULL_TIME_HOURS;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public void TotalEmpWage()
        {
            dailyEmpWage = empHrs * RATE_PER_HOUR;
            totalEmpWage += EmpWage;
            Console.WriteLine(DailyWage);
        }
        Console.WriteLine("Total Emp Wage : " + totalEmpWage)
    }
}
