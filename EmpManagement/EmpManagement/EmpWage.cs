﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement
{
    public class EmpWage
    {

        const int IS_FULL_TIME = 1, FULL_TIME_HOURS = 8, RATE_PER_HOUR = 20;
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
        public void DailyWage()
        {
            dailyEmpWage = empHrs * RATE_PER_HOUR;
            Console.WriteLine(dailyEmpWage);
        }
    }
}
