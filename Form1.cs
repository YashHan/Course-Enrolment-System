using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrolmentSystem
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

        public int StudentPoints;
        private void GetCourseButton_Click(object sender, EventArgs e)
        {
            List<int> availableCourses = new List<int>();
            // getting the input from all the combo boxes
            string studentSubject1 = subject1.SelectedItem.ToString();
            string studentSubject2 = subject2.SelectedItem.ToString();
            string studentSubject3 = subject3.SelectedItem.ToString();
            string studentSubject4 = subject4.SelectedItem.ToString();
            string studentSubject5 = subject5.SelectedItem.ToString();

            string subject1Grade = gradeSubject1.SelectedItem.ToString();
            string subject2Grade = gradeSubject2.SelectedItem.ToString();
            string subject3Grade = gradeSubject3.SelectedItem.ToString();
            string subject4Grade = gradeSubject4.SelectedItem.ToString();
            string subject5Grade = gradeSubject5.SelectedItem.ToString();

            // creating a new student object and storing the subjects with the grades in a dictionary

            // ADD TRY CATCH BLOCK TO CHECK IF ONE SUBJECT HAS BEEN SELECTED MULTIPLE TIMES 
            StudentBL student = new StudentBL();
            student.studentResults.Add(studentSubject1, subject1Grade);
            student.studentResults.Add(studentSubject2, subject2Grade);
            student.studentResults.Add(studentSubject3, subject3Grade);
            student.studentResults.Add(studentSubject4, subject4Grade);
            student.studentResults.Add(studentSubject5, subject5Grade);

            // calculate the number of points of the student and get courses greater than the number of pounts of students
            List<int> courseWithSufficientPoints = CourseEnrolmentSystemDAL.GetCourses(Calculate.CalculatePoints(student));
            StudentPoints = Calculate.CalculatePoints(student);

            if (courseWithSufficientPoints != null)
            {
                // check for prerequisites
                foreach (int courseId in courseWithSufficientPoints)
                {
                    List<string> prerequisites = CourseEnrolmentSystemDAL.GetPrerequisites(courseId);
                    // check if the student meets the prerequisites and if there are seats available
                    if (student.CheckPrerequisites(prerequisites) && CourseEnrolmentSystemDAL.CheckSeatsAvailable(courseId))
                    {
                        // if true then course is added to list of available courses for the student
                        availableCourses.Add(courseId);
                    }
                }
            }

            if (availableCourses.Count > 0) 
            {
                List<string> availableCoursesName = CourseEnrolmentSystemDAL.GetCoursesAvailable(availableCourses);
                DisplayCourses(availableCoursesName);
            }

        }

        private void DisplayCourses(List<string> availableCourses) 
        {
            tableLayoutPanel1.Controls.Clear();
            for (int i = 0; i < availableCourses.Count; i++) 
            {
                Label label = new Label();
                label.Text = availableCourses[i];

                string courseName = availableCourses[i];
                Button registerButton = new Button();
                registerButton.Text = "Register";
                registerButton.Click += delegate (object sender, EventArgs e) { RegisterButton_click(sender, e, courseName); };

                tableLayoutPanel1.Controls.Add(label, 0, i);
                tableLayoutPanel1.Controls.Add(registerButton, 1, i);
            }
        }

        private void RegisterButton_click(object sender, EventArgs e, string courseName) 
        {
            register formRegister = new register(courseName, StudentPoints);
            formRegister.Show();
            this.Hide();
        }
        private void coursesEligible_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
