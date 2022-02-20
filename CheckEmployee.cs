using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class CheckEmployee
    {
        public static void CheckEmployeePresentOrNot()
        {
            Random random = new Random();
            int AttendanceVariable = random.Next(2);
            int IsPresent = 1;

            if (AttendanceVariable == IsPresent)

            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

    }
}