using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Data.SqlClient;

namespace DAO
{
    public class StudentDAO : DatabaseConnection
    {
        public List<Student> SelectAllStudent()
        {
            OpenConnection();
            SqlCommand command = new("SELECT * FROM Student", conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Student> result = new();
            while (reader.Read())
            {
                result.Add(new Student(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
            }

            return result;
        }

        public bool InsertStudent(Student st)
        {
            try
            {
                OpenConnection();
                string sql = $"insert into Student values ('{st.StudentID}','{st.Name}','{st.ClassID}')";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
        public bool UpdateStudent(Student st)
        {
            try
            {
                OpenConnection();
                string sql = $"update student set name='{st.Name}',classID='{st.ClassID}' " +
                    $"where studentID='{st.StudentID}'";
                SqlCommand command = new(sql, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
        public bool DeleteStudent(string studentID)
        {
            try
            {
                OpenConnection();
                string sql = $"delete from student where studentID='{studentID}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}