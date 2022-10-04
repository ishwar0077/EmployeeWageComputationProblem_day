﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeCheck
    {
        public static void EmployeeAttendance()
        {
           const int Is_Full_time = 1;
           const int Is_Part_time = 2;
           const int Emp_Rate_per_hour = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random rand = new Random();
            int empCheck = rand.Next(3);

                //Computation
                switch (empCheck)
                {
                    case Is_Full_time:
                        empHrs = 8;
                        break;

                    case Is_Part_time:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
            empWage = Emp_Rate_per_hour * empHrs;
            Console.WriteLine("total employee wage is: " + empWage);
        }
    }
}
