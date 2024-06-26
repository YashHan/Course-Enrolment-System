using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CourseEnrolmentSystem
{
    internal class AvailableCourseBL
    {
        public static List<int> GetCourses(int studentPoints) 
        {
            return CourseEnrolmentSystemDAL.GetCourses(studentPoints);
        }

        public static List<string> GetPrerequisites(int courseId) 
        {
            return CourseEnrolmentSystemDAL.GetPrerequisites(courseId);
        }

        public static bool CheckSeatsAvailable(int courseId) 
        {
            return CourseEnrolmentSystemDAL.CheckSeatsAvailable(courseId);
        }

        public static List<string> GetCoursesAvailable(List<int> availableCourses)
        {
            return CourseEnrolmentSystemDAL.GetCoursesAvailable(availableCourses);
        }

        public static int GetFees(bool isFullTime, string courseName)
        {
            return CourseEnrolmentSystemDAL.GetFees(isFullTime, courseName);
        }

        public static void UpdateNumberOfSeats(string courseName)
        {
            CourseEnrolmentSystemDAL.UpdateNumberOfSeats(courseName);
        }

        public static void RegisterUser(string firstName, string lastName, string email, string contactNumber, string address, string courseName, int fees) 
        {
            CourseEnrolmentSystemDAL.RegisterUser(firstName, lastName, email, contactNumber, address, courseName, fees);
        }
    }
}
