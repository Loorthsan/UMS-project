using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTicProject.Views
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_Lecture ManageLecture = new Manage_Lecture();
            ManageLecture.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MarkList markList = new MarkList();
            markList.Show();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void MSlist_button_Click(object sender, EventArgs e)
        {
            //All_Student_List studentListForm = new All_Student_List();
            //All_Student_List.Show();

            All_Student_List managestudentForm = new All_Student_List();
            managestudentForm.Show();
        }

        private void manageStaff_button_Click(object sender, EventArgs e)
        {
            Manage_Staff ManageStaff = new Manage_Staff();
            ManageStaff.Show();
        }

        private void attendance_button_Click(object sender, EventArgs e)
        {
            Attendance Attendance = new Attendance();
            Attendance.Show();
        }

        private void exsamList_button_Click(object sender, EventArgs e)
        {
            ExamForm exsam = new ExamForm();
            exsam.Show();
        }

        private void vlForm_button_Click(object sender, EventArgs e)
        {
            View_Leave_Form view_Leave_Form = new View_Leave_Form();
            view_Leave_Form.Show();
        }

        private void timtTable_button_Click(object sender, EventArgs e)
        {
            TimeTableForm timeTableForm = new TimeTableForm();
            timeTableForm.Show();
        }
    }
}
