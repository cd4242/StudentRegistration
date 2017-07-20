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
    public partial class addStudents : Form
    {
        public addStudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            int result;
            long resultLong;
            int studentID;

            
                if (!int.TryParse(txtFirstName.Text, out result) && !int.TryParse(txtLastName.Text, out result) && int.TryParse(txtStudentID.Text, out studentID)
                && !int.TryParse(txtCity.Text, out result) && !int.TryParse(txtState.Text, out result) && int.TryParse(txtZipCode.Text, out result) && long.TryParse(txtPhoneNumber.Text, out resultLong) && !int.TryParse(txtEmail.Text, out result))
                {
                try
                {
                    //creates array for student 
                    AddStudentInformation student = new AddStudentInformation(
                        txtFirstName.Text, txtLastName.Text, int.Parse(txtStudentID.Text),
                        txtStreetAddress.Text, txtCity.Text, txtState.Text, int.Parse(txtZipCode.Text), long.Parse(txtPhoneNumber.Text), txtEmail.Text, comboProgram.Text);
                    student.SetName(txtFirstName.Text, txtLastName.Text, int.Parse(txtStudentID.Text),
                        txtStreetAddress.Text, txtCity.Text, txtState.Text, int.Parse(txtZipCode.Text), long.Parse(txtPhoneNumber.Text), txtEmail.Text, comboProgram.Text);
                     
                    //creates list of people                  
                    List<AddStudentInformation> people = new List<AddStudentInformation>();
                    people.Add(new AddStudentInformation(txtFirstName.Text, txtLastName.Text, int.Parse(txtStudentID.Text),
                        txtStreetAddress.Text, txtCity.Text, txtState.Text, int.Parse(txtZipCode.Text), long.Parse(txtPhoneNumber.Text), txtEmail.Text, comboProgram.Text));

                    //shows message box 
                    MessageBox.Show(String.Format("{0} added succesfully", txtFirstName.Text), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //creates a file path for new file to be written
                    string path = "../../Students.txt";
                    if (!File.Exists(path))
                    {
                        File.CreateText(path);
                        // Create a file to write to.
                        using (StreamWriter sw = new StreamWriter(path, true)) 
                        //using (StreamWriter sw = File.CreateText(path))
                        {
                            //foreach (object s in people)
                            foreach (AddStudentInformation item in people)
                            {
                                // Show message box with the information just added
                                MessageBox.Show(item.fNameStudent + " " + item.lNameStudent + " " + item.sID + "\n"
                                    + item.streetAddress + "\n" + item.studentCity + " " + item.studentState + " " +
                                    item.zipCode + "\n" + item.phoneNumber + "\n" + item.email + "\n" + item.program);

                                // Use StreamWriter to write the information to the text file
                                sw.WriteLine(item.fNameStudent + " " + item.lNameStudent + " " + item.sID + " "
                                + item.streetAddress + "\n" + item.studentCity + " " + item.studentState + " " +
                                item.zipCode + "\n" + item.phoneNumber + "\n" + item.email + "\n" + item.program);
                            }
                        }
                    }else
                    {
                        StreamWriter sw = new StreamWriter(path, true);
                        foreach (AddStudentInformation item in people)
                        {
                            MessageBox.Show(item.fNameStudent + " " + item.lNameStudent + " " + item.sID + "\n"
                                + item.streetAddress + "\n" + item.studentCity + " " + item.studentState + " " +
                                item.zipCode + "\n" + item.phoneNumber + "\n" + item.email + "\n" + item.program);

                            sw.WriteLine(item.fNameStudent + " " + item.lNameStudent + " " + item.sID + " "
                            + item.streetAddress + "\n" + item.studentCity + " " + item.studentState + " " +
                            item.zipCode + "\n" + item.phoneNumber + "\n" + item.email + "\n" + item.program);
                        }
                        sw.Flush();
                        sw.Close();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears all of the textboxes 
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void addStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
