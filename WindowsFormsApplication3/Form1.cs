using System;
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
    public partial class Form1 : Form
    {
        public const string FILE_NAME = "Students.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fileContent = new FileStream(@"../../StudentsToCourse.txt", FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(fileContent);
            string name;
            try
            {

                name = reader.ReadLine();
                while (name != null)
                {
                    {
                        MessageBox.Show(name);                      
                    }
                    name = reader.ReadLine();
                }
            }
            finally
            {
                reader.Close();
                fileContent.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addStudents addS = new addStudents();
            addS.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addFacultyMembers addFM = new addFacultyMembers();
            addFM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addCourses addC = new addCourses();
            addC.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registerStudentToCourse registerSTC = new registerStudentToCourse();
            registerSTC.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Learning Team C\nJared, Nick, Manuel, Charlie (c) 2016", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
