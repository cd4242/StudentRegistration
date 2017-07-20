using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class AddStudentInformation
    {
        public string fNameStudent, lNameStudent, streetAddress, studentCity, email, studentState, program;
        public int sID, zipCode;
        public long phoneNumber;
        public AddStudentInformation(string firstName, string lastName, int studentID, string address, 
            string city, string state, int zip, long phoneNum, string eMail, string program)
        {
            this.fNameStudent = firstName;
            this.lNameStudent = lastName;
            this.sID = studentID;
            this.streetAddress = address;
            this.studentCity = city;
            this.email = eMail;
            this.zipCode = zip;
            this.phoneNumber = phoneNum;
            this.studentState = state;
            this.program = program;
        }
        public void SetName(string firstName, string lastName, int studentID, string address,
            string city, string state, int zip, long phoneNum, string eMail, string program)
        {
            this.fNameStudent = firstName;
            this.lNameStudent = lastName;
            this.sID = studentID;
            this.streetAddress = address;
            this.studentCity = city;
            this.email = eMail;
            this.zipCode = zip;
            this.phoneNumber = phoneNum;
            this.studentState = state;
            this.program = program;
        }

        public override string ToString()
        {
            return "First Name " + this.fNameStudent + " ";
        }

    }
}
