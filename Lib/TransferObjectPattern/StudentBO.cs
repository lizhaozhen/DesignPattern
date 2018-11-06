using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib.TransferObjectPattern
{
    public class StudentBO
    {
        private List<StudentVO> students = new List<StudentVO>();

        public void DeleteSutdent(int id)
        {

        }

        public List<StudentVO> GetStudents()
        {
            return students;
        }

        public StudentVO GetStudent(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);
        }
    }
}
