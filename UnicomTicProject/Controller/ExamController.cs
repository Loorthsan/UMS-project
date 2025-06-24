using System;
using System.Collections.Generic;
using System.Data.SQLite;
using UnicomTicProject.Models;
using UnicomTicProject.Repositeries;

namespace UnicomTicProject.Controller
{
    internal class ExamController
    {
       
        public void ExamForm(Exsam exsam)
        {
           
                using (var conn = DBConfig.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"
                        INSERT INTO EXAM 
                        (ExamId, StudentName, subjectname, couresename, marks, examname) 
                        VALUES 
                        (@exsamid, @StudentName, @subjectname, @couresename, @marks, @examname)";

                    cmd.Parameters.AddWithValue("@exsamid", exsam.ExamId);
                    cmd.Parameters.AddWithValue("@StudentName", exsam.StudentName);
                    cmd.Parameters.AddWithValue("@subjectname", exsam.subjectname);
                    cmd.Parameters.AddWithValue("@couresename", exsam.couresename);
                    cmd.Parameters.AddWithValue("@marks", exsam.marks);
                    cmd.Parameters.AddWithValue("@examname", exsam.examname);
                    cmd.ExecuteNonQuery();
                }
            
            
        }

       
        public List<Exsam> ViewAllExsam()
        {
            List<Exsam> exams = new List<Exsam>();

            using (var conn = DBConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM EXAM", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Exsam exam = new Exsam
                    {
                        Studentid = reader.GetInt32(0),
                        ExamId = reader.GetInt32(1),
                        StudentName = reader.GetString(2),
                        subjectname = reader.GetString(3),
                        couresename = reader.GetString(4),
                        marks = reader.GetString(5),
                        examname = reader.GetString(6)
                    };

                    exams.Add(exam);
                }
            }

            return exams;
        }

        // Update exam
        public void UpdateExsam(Exsam exsam)
        {
            
                using (var conn = DBConfig.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"
                        UPDATE EXAM SET 
                        StudentName = @name, 
                        subjectname = @subject, 
                        couresename = @course, 
                        marks = @marks, 
                        examname = @exam 
                        WHERE studentid = @id";

                    cmd.Parameters.AddWithValue("@name", exsam.StudentName);
                    cmd.Parameters.AddWithValue("@subject", exsam.subjectname);
                    cmd.Parameters.AddWithValue("@course", exsam.couresename);
                    cmd.Parameters.AddWithValue("@marks", exsam.marks);
                    cmd.Parameters.AddWithValue("@exam", exsam.examname);
                    cmd.Parameters.AddWithValue("@id", exsam.Studentid);

                    cmd.ExecuteNonQuery();
                }
            
        }

        // Delete exam
        public void DeleteExsam(int studentid)
        {
            try
            {
                using (var conn = DBConfig.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM EXAM WHERE studentid = @id";
                    cmd.Parameters.AddWithValue("@id", studentid);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting exam: " + ex.Message);
            }
        }
    }
}
