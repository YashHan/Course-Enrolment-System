using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace CourseEnrolmentSystem
{
    internal class CourseEnrolmentSystemDAL
    {

        // used to get courses which have points greater than the points of the student
        public static List<int> GetCourses(int studentPoints)
        {
            // store in a list and then get prerequisites
            try 
            {
                string query = $"SELECT CourseId FROM Course WHERE MinNumberOfPoints <= {studentPoints}";
                List<int> results = new List<int>();


                using (SqlConnection conn = new SqlConnection(@"Data Source=DAYFORCEUF2UVFQ\SQLEXPRESS;Initial Catalog=CourseEnrolmentSystem;Integrated Security=True;")) 
                {
                    conn.Open();

                    // execute the command
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {

                        // retrieve data obtained from query
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {

                            // extracting the data from the results obtained
                            while (dataReader.Read())
                            {
                                results.Add(dataReader.GetInt32(0));
                            }
                        }

                    }
                    conn.Close();
                }
                return results;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }

        //used to get prerequisite of a specified course
        public static List<string> GetPrerequisites(int courseId) 
        {
            try
            {
                string query = $"SELECT Prerequisite FROM CoursePrerequisites WHERE CourseId = {courseId}";
                List<string> results = new List<string>();


                using (SqlConnection conn = new SqlConnection(@"Data Source=DAYFORCEUF2UVFQ\SQLEXPRESS;Initial Catalog=CourseEnrolmentSystem;Integrated Security=True;"))
                {
                    conn.Open();

                    // execute the command
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {

                        // retrieve data obtained from query
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {

                            // extracting the data from the results obtained
                            while (dataReader.Read())
                            {
                                results.Add(dataReader.GetString(0));
                            }
                        }

                    }
                    conn.Close();
                }
                return results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }


        public static bool CheckSeatsAvailable(int courseId)
        {
            try
            {
                string query = $"SELECT CourseId FROM Course WHERE CourseId = {courseId} AND SeatsAvailable < NumberOfSeats";
                List<string> results = new List<string>();


                using (SqlConnection conn = new SqlConnection(@"Data Source=DAYFORCEUF2UVFQ\SQLEXPRESS;Initial Catalog=CourseEnrolmentSystem;Integrated Security=True;"))
                {
                    conn.Open();

                    // execute the command
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {

                        // retrieve data obtained from query
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                conn.Close();
                                return true;
                            }
                            else 
                            {
                                conn.Close();
                                return false;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }

        public static List<string> GetCoursesAvailable(List<int> availableCourses) 
        {
            string courseId = "";
            for (int i = 0; i < availableCourses.Count; i++)
            {
                courseId = courseId + availableCourses[i].ToString() + ",";
            }
            courseId = courseId.TrimEnd(',');

            try
            {
                string query = "SELECT CourseName FROM Course WHERE CourseId IN (" + courseId + ")";
                List<string> results = new List<string>();


                using (SqlConnection conn = new SqlConnection(@"Data Source=DAYFORCEUF2UVFQ\SQLEXPRESS;Initial Catalog=CourseEnrolmentSystem;Integrated Security=True;"))
                {
                    conn.Open();

                    // execute the command
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {

                        // retrieve data obtained from query
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                results.Add(dataReader.GetString(0));
                            }
                        }

                    }
                }
                return results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }

        public static void RegisterUser(string firstName, string lastName, string email, string contactNumber, string address, string courseName, int fees) 
        {
            string query = $"INSERT INTO Student(FirstName, LastName, Email, Address, ContactNumber, CourseName, Fees) VALUES(\'{firstName}\', \'{lastName}\'," +
                $"\'{email}\', \'{address}\', \'{contactNumber}\', \'{courseName}\', {fees})";
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DAYFORCEUF2UVFQ\SQLEXPRESS;Initial Catalog=CourseEnrolmentSystem;Integrated Security=True;"))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        public static int GetFees(bool isFulTime, string courseName)
        {


            try
            {
                string query;
                if (isFulTime == true)
                {
                    query = $"SELECT FullTimeCost FROM Course WHERE CourseName = \'{courseName}\'";
                }
                else
                {
                    query = $"SELECT PartTimeCost FROM Course WHERE CourseName = \'{courseName}\'";
                }
                int results;
                using (SqlConnection conn = new SqlConnection(@"Data Source=DAYFORCEUF2UVFQ\SQLEXPRESS;Initial Catalog=CourseEnrolmentSystem;Integrated Security=True;"))
                {
                    conn.Open();

                    // execute the command
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        // retrieve data obtained from query
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            dataReader.Read();
                            results = dataReader.GetInt32(0);
                        }
                    }
                }
                return results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return 0;
            }

        }

        public static void UpdateNumberOfSeats(string courseName)
        {
            string query = $"UPDATE Course SET SeatsAvailable = SeatsAvailable + 1 WHERE CourseName = \'{courseName}\'";
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DAYFORCEUF2UVFQ\SQLEXPRESS;Initial Catalog=CourseEnrolmentSystem;Integrated Security=True;"))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
