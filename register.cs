using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrolmentSystem
{
    public partial class register : Form
    {
        public int StudentPoints;
        public register(string courseName, int studentPoints)
        {
            InitializeComponent();
            CourseNameLabel.Text = courseName;
            StudentPoints = studentPoints;
            CalculateFees(courseName);
        }

        public void CalculateFees(string courseName) 
        {
            int fees;
            if (StudentPoints > 45 && IsFullTime.Checked == true)
            {
                fees = CourseEnrolmentSystemDAL.GetFees(true, courseName);
                FeesLabel.Text = (0.90 * fees).ToString();
            }
            else
            {
                if (IsFullTime.Checked == true)
                {
                    fees = CourseEnrolmentSystemDAL.GetFees(true, courseName);
                }
                else
                {
                    fees = CourseEnrolmentSystemDAL.GetFees(false, courseName);
                }
                FeesLabel.Text = fees.ToString();
            }

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string lastName = LastName.Text;    
            string email = Email.Text;
            string address = Address.Text;
            string contactNumber = ContactNumber.Text;
            string courseName = CourseNameLabel.Text;
            bool isValid = true;
            

            if (Validation.ValidateName(firstName) == false)
            {
                isValid = false;
            }

            if(Validation.ValidateName(lastName) == false)
            {
                isValid = false;
            }

            if (Validation.ValidateEmail(email) == false)
            {
                isValid = false;
            }

            if (Validation.ValidateContactNumber(contactNumber) == false)
            {
                isValid = false;
            }

            if (Validation.ValidateAddress(address) == false)
            {
                isValid = false;
            }


            if (isValid == true)
            {
                // save the student details in the database student
                CourseEnrolmentSystemDAL.RegisterUser(firstName, lastName, email, contactNumber, address, courseName, int.Parse(FeesLabel.Text));

                // update the number of seats for the course
                CourseEnrolmentSystemDAL.UpdateNumberOfSeats(courseName);
                MessageBox.Show("Student has been successfully registered");
            }
            else
            {
                MessageBox.Show("Please enter the correct details!");
            }
        }

        private void IsFullTime_CheckedChanged(object sender, EventArgs e)
        {
            CalculateFees(CourseNameLabel.Text);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 availableCoursesForm = new Form1();
            availableCoursesForm.Show();
            this.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstName.Clear();
            LastName.Clear();
            Email.Clear();
            Address.Clear();
            ContactNumber.Clear();
        }
    }
}
