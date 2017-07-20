using System;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    internal class CourseAdd
    {
        public string courseName;
        public int courseNumber;
        public DateTimePicker dateEndDate;
        public DateTimePicker dateStartDate;

        public CourseAdd(string nameOfCourse, int numOfCourse, DateTimePicker startDate, DateTimePicker endDate)
        {
            this.courseName = nameOfCourse;
            this.courseNumber = numOfCourse;
            this.dateStartDate = startDate;
            this.dateEndDate = endDate;
        }

        public void SetCourse(string nameOfCourse, int numOfCourse, DateTimePicker startDate, DateTimePicker endDate)
        {
            this.courseName = nameOfCourse;
            this.courseNumber = numOfCourse;
            this.dateStartDate = startDate;
            this.dateEndDate = endDate;
        }
    }
}