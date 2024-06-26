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
        public static List<string> ValidationErrors = new List<string>();
        public static bool ValidateFirstName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ValidationErrors.Add("The First name field cannot be empty");
                return false;
            }
            else if (name.Any(char.IsDigit))
            {
                ValidationErrors.Add("The First name cannot contain any digits");
                return false;
            }
            return true;
        }

        public static bool ValidateLastName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ValidationErrors.Add("The Last name field cannot be empty");
                return false;
            }
            else if (name.Any(char.IsDigit))
            {
                ValidationErrors.Add("The Last name cannot contain any digits");
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
                ValidationErrors.Add("The email field cannot be empty");
                return false;
            }
            else if (!regex.IsMatch(email))
            {
                ValidationErrors.Add("Email entered is not in the correct format. It must be in the format \'Yash@gmail.com\'");
                return false;
            }
            return true;
        }

        public static bool ValidateContactNumber(string contactNumber)
        {
            if (string.IsNullOrEmpty(contactNumber))
            {
                ValidationErrors.Add("The contact number field cannot be empty");
                return false;
            }
            else if (!contactNumber.All(char.IsDigit))
            {
                ValidationErrors.Add("The contact number should contain only numbers");
                return false;
            }
            return true;
        }

        public static bool ValidateAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                ValidationErrors.Add("The address cannot be empty");
                return false;
            }
            return true;
        }

        public static void DisplayErrors()
        {
            string errors = "";
            foreach (string err in ValidationErrors)
            {
                errors = errors + err + "\n";
            }
            errors = errors + "PLEASE ENTER THE CORRECT DETAILS!" + "\n";
            MessageBox.Show(errors);
            ValidationErrors.Clear();
        }
    }


}
