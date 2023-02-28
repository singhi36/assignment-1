using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    public class Student : Person
    {
        public Student(string takeName, int takeAge) : base(takeName, takeAge)
        {

        }

        public string IsCollegeStudent()
        {
            if (IsAdult())
            {
                return "CollegeStudent";

            }
            else
            {
                return "GradeStudent";

            }

        }
    }
}
