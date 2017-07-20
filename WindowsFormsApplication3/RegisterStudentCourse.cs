using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class RegisterStudentCourse
    {
        public string fNameStudent, lNameStudent;
        public string courseNumber;

        public RegisterStudentCourse(string firstName, string lastName, string courseNum)
        {
            this.fNameStudent = firstName;
            this.lNameStudent = lastName;
            this.courseNumber = courseNum;
        }

        public void SetName(string newFName, string newLName, string courseNum)
        {
            this.fNameStudent = newFName;
            this.lNameStudent = newLName;
            this.courseNumber = courseNum;
        }
    }
}
