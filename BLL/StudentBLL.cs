using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BLL
{
    public class StudentBLL
    {
        StudentDAO stdDAO = new();
        public List<Student> SelectAllStudent()
        {

            return stdDAO.SelectAllStudent();
        }
        public bool InsertStudent(Student st)
        {
            return stdDAO.InsertStudent(st);
        }
        public bool UpdateStudent(Student st)
        {
            return stdDAO.UpdateStudent(st);
        }
        public bool DeleteStudent(string studentID)
        {
            return stdDAO.DeleteStudent(studentID);
        }
    }
}