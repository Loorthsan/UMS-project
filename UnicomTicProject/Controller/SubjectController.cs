using System;
using System.Collections.Generic;
using System.Data.SQLite;
using UnicomTicProject.Models;
using UnicomTicProject.Repositeries;

namespace UnicomTicProject.Controller
{
    internal class SubjectController
    {
        public void AddSubject(Subject subject)
        {
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO SUBJECT (subjectname, roomname, lecturename, courseid) VALUES (@name, @room, @lecturer, @courseid)";
                cmd.Parameters.AddWithValue("@name", subject.subjectname);
                cmd.Parameters.AddWithValue("@room", subject.roomname);
                cmd.Parameters.AddWithValue("@lecturer", subject.lecturename);
                cmd.Parameters.AddWithValue("@courseid", subject.courseid);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Subject> GetAllSubjects()
        {
            var list = new List<Subject>();
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM SUBJECT", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Subject
                    {
                        subjectid = reader.GetInt32(0),
                        subjectname = reader.GetString(1),
                        roomname = reader.GetString(2),
                        lecturename = reader.GetString(3),
                        courseid = reader.GetInt32(4)
                    });
                }
            }
            return list;
        }
        public void clearSubject(int subjectid)
        {
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM SUBJECT WHERE subjectid = @id";
                cmd.Parameters.AddWithValue("@id", subjectid);
                cmd.ExecuteNonQuery();
            }

        }
    }
}

