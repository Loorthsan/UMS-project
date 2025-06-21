using System;
using System.Collections.Generic;
using UnicomTicProject.Models;

namespace UnicomTicProject.Controller
{
    public class LoginController
    {
       
        private readonly Dictionary<string, (string username, string password)> users =
        new Dictionary<string, (string username, string password)>()
        {
            { "Student", ("student", "stud123") },
            { "Admin", ("admin", "admin123") },
            { "Staff", ("staff", "staff123") },
            { "Lecture",("lecture", "lect123") }
        };

        // Main method to validate user login
        public string ValidateUser(string role, string username, string password)
        {
            if (users.ContainsKey(role) &&
                users[role].username == username &&
                users[role].password == password)
            {
                return role;
            }
            return null;
        }
    }
}
