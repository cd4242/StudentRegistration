using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class AddFacultyInformation
    {
        public string fNameFaculty, lNameFaculty, streetAddress, facultyCity, email, studentState, program;
        public int fID, zipCode;
        public long phoneNumber;

        public AddFacultyInformation(string firstName, string lastName, int facultyID, string address,
            string city, string state, int zip, long phoneNum, string eMail, string program)
        {
            this.fNameFaculty = firstName;
            this.lNameFaculty = lastName;
            this.fID = facultyID;
            this.streetAddress = address;
            this.facultyCity = city;
            this.email = eMail;
            this.zipCode = zip;
            this.phoneNumber = phoneNum;
            this.studentState = state;
            this.program = program;
        }

        public void SetName(string firstName, string lastName, int facultyID, string address,
            string city, string state, int zip, long phoneNum, string eMail, string program)
        {
            fNameFaculty = firstName;
            lNameFaculty = lastName;
            fID = facultyID;
            this.streetAddress = address;
            this.facultyCity = city;
            this.email = eMail;
            this.zipCode = zip;
            this.phoneNumber = phoneNum;
            this.studentState = state;
            this.program = program;
        }
    }
}
