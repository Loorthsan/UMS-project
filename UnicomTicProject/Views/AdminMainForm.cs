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

        

        private void button7_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();
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
 
            All_Student_List managestudentForm = new All_Student_List();
            managestudentForm.Show();
        }

        private void exsamList_button_Click(object sender, EventArgs e)
        {
            ExamForm exsam = new ExamForm();
            exsam.Show();
        }

        private void vlForm_button_Click(object sender, EventArgs e)
        {
           
        }

        private void timtTable_button_Click(object sender, EventArgs e)
        {
            TimeTableForm timeTableForm = new TimeTableForm();
            timeTableForm.Show();
        }
    }
}
