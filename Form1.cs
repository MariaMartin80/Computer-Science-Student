using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getHoursButton_Click(object sender, EventArgs e)
        {
            //variables to hold input
            string name, id, track;

            //get the student's name and ID
            name = nameTextBox.Text;
            id = idTextBox.Text;

            //get the student's academic track
            if (infoSystemsRadioButton.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "software Engineering";
            }

            //create a CompSciStudent object
            CompSciStudent csStudent = new CompSciStudent(name, id, track);

            //display the student's required hours
            requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
