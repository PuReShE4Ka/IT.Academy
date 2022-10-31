using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.DataModel
{
    public partial class Teacher
    {
        private const int MAX_CLASS_SIZE = 8;
        public void EnrollInClass(Student student)
        {
            int numStudents = (from s in Students
                               where s.TeacherUserId == UserId
                               select s).Count();

            if (numStudents >= MAX_CLASS_SIZE)
            {
                throw new ClassFullException("Class full: Unable to enroll student", Class);
            }
            if (student.TeacherUserId == null)
            {
                student.TeacherUserId = UserId;
            }
            else
            {
                throw new ArgumentException("Student", "Student is already assigned to a class");
            }
        }
    }
    

}
