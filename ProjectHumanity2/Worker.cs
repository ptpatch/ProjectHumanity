using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHumanity2
{
    class Worker
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private double WeekSalary { get; set; }
        private int HoursPerDay { get; set; }
        private string Gender { get; set; }
        private double SalaryPerHour { get; set; }

        public Worker(string firstName, string lastName, string gender, double weekSalary, int hours, double salaryPerHour)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.WeekSalary = weekSalary;
            this.HoursPerDay = hours;
            this.SalaryPerHour = salaryPerHour;
        }

        public override string ToString()
        {
            return "|FirstName: " + FirstName + " |LastName: " + LastName + " |Gender: " + Gender + " |WeekSalary: " + WeekSalary +  " |Hourse per day: " + HoursPerDay + " |SalaryPerHour: " + SalaryPerHour  ;
        }
    }
}
