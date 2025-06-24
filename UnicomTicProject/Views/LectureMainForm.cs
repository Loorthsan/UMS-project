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
    public partial class LectureMainForm : Form
    {
        public LectureMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            All_Student_List managestudentForm = new All_Student_List();
            managestudentForm.Show();

        }

        private void exsamListButton_Click(object sender, EventArgs e)
        {
            ExamForm exsam = new ExamForm();
            exsam.Show();
        }

        private void markListButton_Click(object sender, EventArgs e)
        {
            MarkList markList = new MarkList();
            markList.Show();
        }

        private void subjectButton_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.Show();
        }

        private void timeTable_Click(object sender, EventArgs e)
        {
            TimeTableForm timeTableForm = new TimeTableForm();
            timeTableForm.Show();
        }
    }
    
}
