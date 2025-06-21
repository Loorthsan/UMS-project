using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace UnicomTicProject.Repositeries
{
    internal class DataBaseManager
    {
        public static void createTables()
        {
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS USER (
                    UserName TEXT PRIMARY KEY,
                    Role TEXT NOT NULL,
                    Password TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS STUDENTS (
                    UTnumber INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fullname TEXT NOT NULL,
                    Birthofdate TEXT NOT NULL,
                    Gender TEXT NOT NULL,
                    Address TEXT NOT NULL,
                    Phonenumber TEXT NOT NULL,
                    Gmail TEXT NOT NULL, 
                    Nicno TEXT NOT NULL,                  
                    UserName TEXT NOT NULL,
                    courseid INTEGER,
                    FOREIGN KEY (courseid) REFERENCES COURSE(courseid)
                );

                CREATE TABLE IF NOT EXISTS SUBJECT (
                    subjectid INTEGER PRIMARY KEY AUTOINCREMENT,
                    subjectname TEXT NOT NULL,
                    roomname TEXT NOT NULL,
                    lecturename TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS COURSE (
                    courseid INTEGER PRIMARY KEY AUTOINCREMENT,
                    coursename TEXT NOT NULL,
                    courseduration TEXT NOT NULL,
                    coursedescription TEXT NOT NULL
                    -- Removed FOREIGN KEY here, since subjectid does not exist in COURSE
                );

                CREATE TABLE IF NOT EXISTS EXAM (
                    examid INTEGER PRIMARY KEY AUTOINCREMENT, 
                    studentid INTEGER NOT NULL,
                    StudentName TEXT NOT NULL,
                    subjectname TEXT NOT NULL,
                    couresename TEXT NOT NULL,
                    marks TEXT NOT NULL,
                    examname TEXT NOT NULL
                    
                );

                CREATE TABLE IF NOT EXISTS MARK (
                    markid INTEGER PRIMARY KEY AUTOINCREMENT,
                    utnumber TEXT NOT NULL,
                    subjectname TEXT NOT NULL,
                    subjectid INTEGER NOT NULL,
                    exsamname TEXT NOT NULL,
                    examid INTEGER NOT NULL,
                    FOREIGN KEY (subjectid) REFERENCES SUBJECT(subjectid),
                    FOREIGN KEY (examid) REFERENCES EXAM(examid)
                );

                CREATE TABLE IF NOT EXISTS TIMETABLE (     
                    timetableId INTEGER PRIMARY KEY AUTOINCREMENT,
                    date TEXT NOT NULL,
                    subjectid INTEGER NOT NULL,
                    roomtype TEXT NOT NULL,
                    starttime TEXT NOT NULL,
                    endtime TEXT NOT NULL, 
                    timeslot TEXT NOT NULL,
                    FOREIGN KEY (subjectid) REFERENCES SUBJECT(subjectid)
                );
                ";

                cmd.ExecuteNonQuery();
            }
        }
    }
}
