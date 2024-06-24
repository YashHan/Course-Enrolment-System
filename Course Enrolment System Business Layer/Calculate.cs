using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnrolmentSystem
{
    internal class Calculate
    {
        public static int CalculatePoints(StudentBL student) 
        {
            int points = 0;
            foreach (string point in student.studentResults.Values) 
            {
                switch (point)
                {
                    case "A":
                        points = points + 10;
                        break;
                    case "B":
                        points = points + 8; 
                        break;
                    case "C":
                        points = points + 6;
                        break;
                    case "D":
                        points = points + 4;
                        break;
                    case "E":
                        points = points + 2;
                        break;
                    case "F":
                        points = points + 0;
                        break;

                }
            }
            return points;
        }
    }
}
