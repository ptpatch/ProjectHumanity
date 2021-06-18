using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHumanity2
{
    class Student
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int FacultyNumber { get; set; }

        private string Gender { get; set; }

        public Student(string firstName, string lastName, int facultyNumber, string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return "|FirstName: " + FirstName + " |LastName: " + LastName + " |Gender : " + Gender + " |FacultyNumber:" + FacultyNumber;
        }
    }   
}
