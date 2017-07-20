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
    public partial class registerStudentToCourse : Form
    {
        private addCourses addCourses;

        public registerStudentToCourse()
        {
            InitializeComponent();
        }

        public registerStudentToCourse(addCourses addCourses)
        {
            this.addCourses = addCourses;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result;
            int courseNum;
            string fileName = "../../StudentsToCourse.txt";
            StreamWriter sw = new StreamWriter(fileName, true);
            if (File.Exists(fileName))
            {
                if (!int.TryParse(fNameBox.Text, out result) || !int.TryParse(lNameBox.Text, out result) || courseNumBox.Text != null)
                {
                    try
                    {

                        RegisterStudentCourse studentCourse = new RegisterStudentCourse(fNameBox.Text, lNameBox.Text, courseNumBox.Text);
                        studentCourse.SetName(fNameBox.Text, lNameBox.Text, courseNumBox.Text);

                        List<RegisterStudentCourse> course = new List<RegisterStudentCourse>();
                        course.Add(new RegisterStudentCourse(fNameBox.Text, lNameBox.Text, courseNumBox.Text));

                        MessageBox.Show(String.Format("{0} added succesfully", fNameBox.Text), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (RegisterStudentCourse item in course)
                        {
                            MessageBox.Show(item.fNameStudent + " " + item.lNameStudent + " " + item.courseNumber, "Course Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sw.WriteLine(item.fNameStudent + " " + item.lNameStudent + " " + item.courseNumber);
                        }
                        sw.Flush();
                        sw.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("An Unexpected error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                File.CreateText(fileName);
                if (!int.TryParse(fNameBox.Text, out result) || !int.TryParse(lNameBox.Text, out result) || courseNumBox.Text != null)
                {
                    try
                    {

                        RegisterStudentCourse studentCourse = new RegisterStudentCourse(fNameBox.Text, lNameBox.Text, courseNumBox.Text);
                        studentCourse.SetName(fNameBox.Text, lNameBox.Text, courseNumBox.Text);

                        List<RegisterStudentCourse> course = new List<RegisterStudentCourse>();
                        course.Add(new RegisterStudentCourse(fNameBox.Text, lNameBox.Text, courseNumBox.Text));

                        MessageBox.Show(String.Format("{0} added succesfully", fNameBox.Text), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (RegisterStudentCourse item in course)
                        {
                            //string arrayItem = string.Format("{0}", item);
                            //MessageBox.Show("{0}", item.ToString());
                            MessageBox.Show(item.fNameStudent + " " + item.lNameStudent + " " + item.courseNumber, "Course Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sw.WriteLine(item.fNameStudent + " " + item.lNameStudent + " " + item.courseNumber);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("An Unexpected error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerStudentToCourse_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseNumBox.Text = listBox1.SelectedItem.ToString();
        }

        private void butShowCourses_Click(object sender, EventArgs e)
        {
            /*
            //reads lines of courselist and displays them in listbox 
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader("../../courseList.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);

                }
                */
                FileStream fileContent = new FileStream(@"../../courseList.txt", FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(fileContent);
                string name;
                try
                {

                    name = reader.ReadLine();
                    while (name != null)
                    {
                        
                        listBox1.Items.Add("Courses: \n\n" + name);
                        name = reader.ReadLine();
                    }
                }
                finally
                {
                    reader.Close();
                    fileContent.Close();
                }           
        }
    }
}
