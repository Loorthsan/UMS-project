﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicProject.Repositeries;
using UnicomTicProject.Views;

namespace UnicomTicProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBaseManager.createTables();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new CourseForm());
            //Application.Run(new StudentMainForm("student")); // or pass the logged-in user's username

            //Application.Run(new ExamForm());
            //Application.Run(new All_Student_List());
            //Application.Run(new SubjectForm());
        }
    }
}
