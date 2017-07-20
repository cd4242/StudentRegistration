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
    public partial class addFacultyMembers : Form
    {
        public addFacultyMembers()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            int result;
            long resultOut;
            if (!int.TryParse(txtFirstName.Text, out result) &&
                        !int.TryParse(txtLastName.Text, out result) && int.TryParse(txtFacultyID.Text, out result)
                        && !int.TryParse(txtCity.Text, out result) &&
                        !int.TryParse(txtState.Text, out result) && int.TryParse(txtZipCode.Text, out result) &&
                        long.TryParse(txtPhoneNumber.Text, out resultOut) && !int.TryParse(txtEmail.Text, out result))
            {
                try
                {
                    AddFacultyInformation faculty = new AddFacultyInformation(txtFirstName.Text, txtLastName.Text, int.Parse(txtFacultyID.Text),
                        txtStreetAddress.Text, txtCity.Text, txtState.Text, int.Parse(txtZipCode.Text), long.Parse(txtPhoneNumber.Text), txtEmail.Text, comboProgram.Text);
                    faculty.SetName(txtFirstName.Text, txtLastName.Text, int.Parse(txtFacultyID.Text),
                        txtStreetAddress.Text, txtCity.Text, txtState.Text, int.Parse(txtZipCode.Text), long.Parse(txtPhoneNumber.Text), txtEmail.Text, comboProgram.Text);

                    List<AddFacultyInformation> staff = new List<AddFacultyInformation>();
                    staff.Add(new AddFacultyInformation(txtFirstName.Text, txtLastName.Text, int.Parse(txtFacultyID.Text),
                        txtStreetAddress.Text, txtCity.Text, txtState.Text, int.Parse(txtZipCode.Text), long.Parse(txtPhoneNumber.Text), txtEmail.Text, comboProgram.Text));

                    MessageBox.Show(String.Format("Faculty member {0} added succesfully", txtFirstName.Text), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //creates a file path for new file to be written
                    string path = "../../Faculty.txt";
                    if (!File.Exists(path))
                    {
                        File.CreateText(path);
                        // Create a file to write to.
                        using (StreamWriter sw = new StreamWriter(path, true))
                        //using (StreamWriter sw = File.CreateText(path))
                        {
                            //foreach (object s in people)
                            foreach (AddFacultyInformation item in staff)
                            {
                                // Show items in a message box
                                MessageBox.Show(item.fNameFaculty + " " + item.lNameFaculty + " " + item.fID
                                    + " " + item.streetAddress + "\n" + item.facultyCity + ", " + item.studentState + " " +
                                    item.zipCode + "\n" + item.phoneNumber + "\n" + item.email + " " + item.program);
                                // write items to the file
                                sw.WriteLine(item.fNameFaculty + " " + item.lNameFaculty + " " + item.fID
                                + " " + item.streetAddress + "\n" + item.facultyCity + ", " + item.studentState + " " +
                                item.zipCode + "\n" + item.phoneNumber + "\n" + item.email + " " + item.program);
                            }
                        }
                    }else
                    {
                        StreamWriter sw = new StreamWriter(path, true);
                        foreach (AddFacultyInformation item in staff)
                        {
                            MessageBox.Show(item.fNameFaculty + " " + item.lNameFaculty + " " + item.fID + "\n"
                                + item.streetAddress + "\n" + item.facultyCity + " " + item.studentState + " " +
                                item.zipCode + "\n" + item.phoneNumber + "\n" + item.email + "\n" + item.program);

                            sw.WriteLine(item.fNameFaculty + " " + item.lNameFaculty + " " + item.fID + " "
                            + item.streetAddress + "\n" + item.facultyCity + " " + item.studentState + " " +
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
            }else
            {
                MessageBox.Show("An Unexpected error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

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
    }
}
