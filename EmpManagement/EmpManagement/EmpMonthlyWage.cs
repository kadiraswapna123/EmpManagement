using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement
{
    public class EmpMonthlyWage
    {
        int IsPartTime = 1;
        int IsFullTime = 2;
        int EmpRatePerHour = 20;
        int empHrs = 0;
        int EmpWage = 0;
        Random random = new Random();
        int empCheck = Random.Next(0, 2);
        if (empCheck == IsPartTime)
        {
            empHrs = 4;
        }
        else if (empCheck == IsFullTime)
        {
            empHrs = 8;
        }
        else
        {
            empHrs = 0;      
        }
        empWage = empHrs * EmpRatePerHour;
        Console.WriteLine("EmpWage : " + empWage);
    }
}
