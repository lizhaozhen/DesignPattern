using System;

namespace Lib.MVC
{
    public class StudentController
    {
        private readonly Student student;
        private readonly StudentView studentView;

        public StudentController(Student student, StudentView studentView)
        {
            this.student = student;
            this.studentView = studentView;
        }

        public void SetStudentName(string name)
        {
            student.Name = name;
        }

        public void UpdateView()
        {
            studentView.PrintStudentDetails(student.Name);
        }
    }
}
