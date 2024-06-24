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
            CalculateFees();
        }

        public void CalculateFees() 
        { 
            if(StudentPoints > 45 && IsFullTime.Checked == true)
            {
                FeesLabel.Text = (0.90 * 25000).ToString();
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
                MessageBox.Show("You have registered successfully!");
            }
            else
            {
                MessageBox.Show("Please enter the correct details!");
            }

        }

        private void IsFullTime_CheckedChanged(object sender, EventArgs e)
        {
            if (FeesLabel.Text == "25000" || FeesLabel.Text == "22500")
            {
                FeesLabel.Text = "30000";
            }
            else 
            {
                FeesLabel.Text = "25000";
            }
            CalculateFees();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 availableCoursesForm = new Form1();
            availableCoursesForm.Show();
            this.Hide();
        }
    }
}
