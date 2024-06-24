using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CourseEnrolmentSystem
{
    internal class Validation
    {
        public static bool ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("The name field cannot be empty");
                return false;
            }
            else if (name.Any(char.IsDigit))
            {
                MessageBox.Show("The name cannot contain any digits");
                return false;
            }
            return true;
        }

        public static bool ValidateEmail(string email)
        {
            string regPattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            Regex regex = new Regex(regPattern);
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("The email field cannot be empty");
                return false;
            }
            else if (!regex.IsMatch(email))
            {
                MessageBox.Show("Email entered is not in the correct format. It must be in the format \'Yash@gmail.com\'");
                return false;
            }
            return true;
        }

        public static bool ValidateContactNumber(string contactNumber)
        {
            if (string.IsNullOrEmpty(contactNumber))
            {
                MessageBox.Show("The contact number field cannot be empty");
                return false;
            }
            else if (!contactNumber.All(char.IsDigit))
            {
                MessageBox.Show("The contact number should contain only numbers");
                return false;
            }
            return true;
        }

        public static bool ValidateAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("The address cannot be empty");
                return false;
            }
            return true;
        }
    }


}
