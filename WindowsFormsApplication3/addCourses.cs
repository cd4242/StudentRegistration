using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class addCourses : Form
    {
        string nameOfCourse;
        int numOfCourse;
        string startDate, endDate;
        
                       

        public addCourses()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            int result;
            startDate = dateStartDate.Value.ToString();
            endDate = dateEndDate.Value.ToShortDateString();
            Console.WriteLine(startDate + " " + endDate);
            CourseAdd course = new CourseAdd(nameOfCourse, numOfCourse, dateStartDate, dateEndDate);
            List<CourseAdd> aCourse = new List<CourseAdd>();

            if (int.TryParse(txtCourseNum.Text, out result) && !int.TryParse(txtCourseName.Text, out result))
            {
                try
                {
                    nameOfCourse = txtCourseName.Text;
                    string num = txtCourseNum.Text;
                    numOfCourse = int.Parse(num);
                    
                    course.SetCourse(nameOfCourse, numOfCourse, dateStartDate, dateEndDate);
                
                    aCourse.Add(new CourseAdd(txtCourseName.Text, int.Parse(txtCourseNum.Text), dateStartDate, dateEndDate));

                    MessageBox.Show(String.Format("Course {0} added successfully", nameOfCourse), "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (CourseAdd item in aCourse)
                    {
                        MessageBox.Show(item.courseName + " " + item.courseNumber + " " + item.dateStartDate.Value.ToShortDateString() + " " + item.dateEndDate.Value.ToShortDateString(), "Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("An error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //creates path to write file
            string path = "../../courseList.txt";
            if (!File.Exists(path))
            {
                try
                {
                    File.CreateText(path);
                    // Create a file to write to.
                    using (StreamWriter sw = new StreamWriter(path, true))

                    {
                        sw.WriteLine("Math" + " " + "101" + " " + "12 / 15 / 2016 12:00:00 AM" + "04 / 31 / 2017 12:00:00 AM");
                        sw.WriteLine("English" + " " + "101" + " " + "12 / 15 / 2016 12:00:00 AM" + "04 / 31 / 2017 12:00:00 AM");
                        sw.WriteLine("Intro to C#" + " " + "101" + " " + "12 / 15 / 2016 12:00:00 AM" + "04 / 31 / 2017 12:00:00 AM");

                        foreach (CourseAdd item in aCourse)
                        {
                            sw.WriteLine(item.courseName + "\t" + item.courseNumber + "\t" + item.dateStartDate.Value.ToShortDateString() + "\t" + item.dateEndDate.Value.ToShortDateString());
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path, true))
                    {
                        foreach (CourseAdd item in aCourse)
                        {
                            sw.WriteLine(item.courseName + "\t" + item.courseNumber + "\t" + item.dateStartDate.Value.ToShortDateString() + "\t" + item.dateEndDate.Value.ToShortDateString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtCourseNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addCourses_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
