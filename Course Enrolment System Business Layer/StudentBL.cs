using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnrolmentSystem
{
    internal class StudentBL
    {
        public Dictionary<string, string> studentResults = new Dictionary<string, string>();
        public bool CheckPrerequisites(List<string> subjectRequired)
        {
            bool isEligible = true;
            foreach (string subject in subjectRequired)
            {
                if (studentResults.ContainsKey(subject))
                {

                    if (string.Compare(studentResults[subject], "D") > 0)
                    {
                        isEligible = false;
                        break;
                    }
                }
                else {
                    isEligible = false;
                    break;
                }
            }
            return isEligible;
        }
    }
}
