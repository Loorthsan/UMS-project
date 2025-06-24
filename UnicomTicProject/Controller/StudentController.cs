using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicProject.Models;
using UnicomTicProject.Repositeries;
using UnicomTicProject.Views;

namespace UnicomTicProject.Controller
{
    internal class StudentController
    {
        public void AddStudent(Student student)
        {
            using (var conn = DBConfig.GetConnection())
            {
                using (var cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = @"
                INSERT INTO STUDENTS 
                        (Fullname, Birthofdate, Gender, Address, Phonenumber, Gmail, Nicno, UserName, courseid)
                        VALUES 
                        (@Fullname, @Birthofdate, @Gender, @Address, @Phonenumber, @Gmail, @Nicno, @UserName, @CourseId)";

                    cmd.Parameters.AddWithValue("@Fullname", student.Fullname);
                    cmd.Parameters.AddWithValue("@Birthofdate", student.Birthofdate);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@Phonenumber", student.Phonenumber);
                    cmd.Parameters.AddWithValue("@Gmail", student.Gmail);
                    cmd.Parameters.AddWithValue("@Nicno", student.Nicno);
                    cmd.Parameters.AddWithValue("@UserName", student.UserName);
                    cmd.Parameters.AddWithValue("@CourseId", student.CourseId);

                    cmd.ExecuteNonQuery();
                }
            }
        }



        public void UpdateStudent(Student student)
        {
            try
            {
                using (var conn = DBConfig.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"
                    UPDATE STUDENTS 
                    SET 
                        Fullname = @fullname,
                        Birthofdate = @birthdate,
                        Gender = @gender,
                        Address = @address,
                        Phonenumber = @phone,
                        Gmail = @gmail,
                        Nicno = @nicno,
                        UserName = @username,
                        courseid = @courseid
                    WHERE StudentId = @id";

                        cmd.Parameters.AddWithValue("@fullname", student.Fullname);
                        cmd.Parameters.AddWithValue("@birthdate", student.Birthofdate);
                        cmd.Parameters.AddWithValue("@gender", student.Gender);
                        cmd.Parameters.AddWithValue("@address", student.Address);
                        cmd.Parameters.AddWithValue("@phone", student.Phonenumber);
                        cmd.Parameters.AddWithValue("@gmail", student.Gmail);
                        cmd.Parameters.AddWithValue("@nicno", student.Nicno);
                        cmd.Parameters.AddWithValue("@username", student.UserName);
                        cmd.Parameters.AddWithValue("@courseid", student.CourseId);
                        cmd.Parameters.AddWithValue("@id", student.StudentId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating student: " + ex.Message);
                MessageBox.Show("Failed to update student. Please check the input and try again.");
            }
        }



        public List<Student> ViewAllStudents()
        {
            var students = new List<Student>();

            using (var conn = DBConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM STUDENTS", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student
                    {
                        StudentId = reader.GetInt32(reader.GetOrdinal("StudentId")),
                        Fullname = reader.GetString(reader.GetOrdinal("Fullname")),
                        Birthofdate = reader.GetString(reader.GetOrdinal("Birthofdate")),
                        Gender = reader.GetString(reader.GetOrdinal("Gender")),
                        Address = reader.GetString(reader.GetOrdinal("Address")),
                        Phonenumber = reader.GetString(reader.GetOrdinal("Phonenumber")),
                        Gmail = reader.GetString(reader.GetOrdinal("Gmail")),
                        Nicno = reader.GetString(reader.GetOrdinal("Nicno")),
                        UserName = reader.GetString(reader.GetOrdinal("UserName")),
                        CourseId = reader.GetInt32(reader.GetOrdinal("courseid"))
                    };

                    students.Add(student);
                }
            }

            return students;
        }



        public void DeleteStudent(int StudentId)
        {
            try
            {
                using (var conn = DBConfig.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = "DELETE FROM STUDENTS WHERE StudentId = @id";
                        cmd.Parameters.AddWithValue("@id", StudentId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting student: " + ex.Message);
                MessageBox.Show("Failed to delete student. Please try again.");
            }
        }

       
    }



}


