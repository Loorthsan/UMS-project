using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicProject.Models;
using UnicomTicProject.Repositeries;

namespace UnicomTicProject.Controller
{
    internal class CourseController
    {
        public void CoursForm(Course course)
        {
            try
            {
                using (var conn = DBConfig.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO COURSE (coursename, courseduration, coursedescription) VALUES (@name, @duration, @description)";
                    cmd.Parameters.AddWithValue("@name", course.coursename);
                    cmd.Parameters.AddWithValue("@duration", course.courseduration);
                    cmd.Parameters.AddWithValue("@description", course.coursedescription);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting course: " + ex.Message);

            }
        }
        public List<Course> ViewAllCourses()
        {
            var courses = new List<Course>();
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM COURSE", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course course = new Course();
                    course.courseid = reader.GetInt32(0);
                    course.coursename = reader.GetString(1);
                    course.courseduration = reader.GetString(2);
                    course.coursedescription = reader.GetString(3);
                    courses.Add(course);

                }


            }
            return courses;
        }
        public void UpdateCourse(Course course)
        {
            try
            {
                using (var conn = DBConfig.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"UPDATE COURSE SET 
                    coursename = @name, 
                    courseduration = @duration, 
                    coursedescription = @description 
                    WHERE courseid = @id";

                    cmd.Parameters.AddWithValue("@name", course.coursename);
                    cmd.Parameters.AddWithValue("@duration", course.courseduration);
                    cmd.Parameters.AddWithValue("@description", course.coursedescription);
                    cmd.Parameters.AddWithValue("@id", course.courseid);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating course: " + ex.Message);
            }
        }

        public void DeleteCourse(int courseid)
        {
            try
            {
                using (var conn = DBConfig.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM COURSE WHERE courseid = @id";
                    cmd.Parameters.AddWithValue("@id", courseid);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting course: " + ex.Message);
            }
        }

    }

}
