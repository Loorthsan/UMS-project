using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
using UnicomTicProject.Controller;
using UnicomTicProject.Models;

namespace UnicomTicProject.Views
{
    public partial class StudentMainForm : Form
    {
        private readonly string _username;
        private readonly StudentController _studentController;
       

        public StudentMainForm(string username)
        {
            InitializeComponent();
            _username = username;
            _studentController = new StudentController();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
           // LoadStudentDetails();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void studentProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    var grid = sender as DataGridView;
            //    var clickedValue = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            //    MessageBox.Show($"You clicked on: {clickedValue}");
            //}
        }

        private void studentProfilebutton(object sender, EventArgs e)
        {
            
        }

        private void StudentMainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
