using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicProject.Controller
{
    internal class AttendanceController
    {
        public bool AuthenticateUse(User user)
        {

            if ((user.UserName == "admin" && user.password == "123" && user.Role == "Admin") ||
                (user.UserName == "staff" && user.password == "456" && user.Role == "Staff") ||
                (user.UserName == "Priyan" && user.password == "789" && user.Role == "student") ||
                (user.UserName == "Raj" && user.password == "789" && user.Role == "student") ||
                (user.UserName == "lecture" && user.password == "012" && user.Role == "Lecture"))


            {
                return true;
            }
        }
}
