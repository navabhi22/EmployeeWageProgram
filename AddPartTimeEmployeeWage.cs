using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class AddPartTimeEmployeeWage
    {
        /// <summary>
        /// Adding Part Time Wage
        /// </summary>
        public static void DailyWage()
        {
            Random random = new Random();
            int AttendanceVariable = random.Next(3);
            int IsPresent = 1;
            int IsPartTime = 2;
            int WagePerHour = 20;
            int FullDayHour = 8;
            int PartTimeHour = 4;
            int WorkingHour;
            int DailyWage;
            if (AttendanceVariable == IsPresent)

            {
                WorkingHour = FullDayHour;
                Console.WriteLine("Employee is Present");
            }
            else if (AttendanceVariable == IsPartTime)
            {
                WorkingHour = PartTimeHour;
                Console.WriteLine("PartTime");
            }
            else
            {
                WorkingHour = 0;
                Console.WriteLine("Employee is Absent");
            }

            DailyWage = WagePerHour * WorkingHour;
            Console.WriteLine("Daily wage of employee is " + DailyWage);
        }

    }
}
