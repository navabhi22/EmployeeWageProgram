using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class DailyWage
    {
        public static void CalculateDailyWage()
        {
            Random random = new Random();
            int AttendanceVariable = random.Next(2);
            int IsPresent = 1;
            int WagePerHour = 20;
            int FullDayHour = 8;
            int WorkingHour;
            int DailyWage;
            if (AttendanceVariable == IsPresent)

            {
                WorkingHour = FullDayHour;
                Console.WriteLine("Employee is Present");
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