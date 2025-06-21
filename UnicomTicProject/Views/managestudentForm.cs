using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicProject.Controller;
using UnicomTicProject.Models;

namespace UnicomTicProject.Views
{
    public partial class All_Student_List : Form
    {
        StudentController _Studentcontroller;

        public All_Student_List()
        {
            _Studentcontroller = new StudentController();
            InitializeComponent();
           


        }

        private void LoadStudent()
        {
            StudentController studentController = new StudentController();
            List<Student> student = _Studentcontroller.ViewAllStudents();
            viewstudent.DataSource = null;
            viewstudent.DataSource = student;

        }

        //add button

        private void addstu_button(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Fullname = name_textBox3.Text,
                Birthofdate = birth.Text,
                Gender = gender3.Text,
                Address = addresstextBox4.Text,
                Phonenumber = ph_notextBox5.Text,
                Gmail = gmailtextBox6.Text,
                Nicno = NICno.Text,

            };


            _Studentcontroller.AddStudent(student);
            MessageBox.Show("student added successfull!");
            name_textBox3.Text = "";
            birth.Text = "";
            gender3.Text = "";
            addresstextBox4.Text = "";
            ph_notextBox5.Text = "";
            gmailtextBox6.Text = "";
            NICno.Text = "";
            
            LoadStudent();

        }

        //update button

        private void updatestu_button_Click(object sender, EventArgs e)
        {
            if (viewstudent.SelectedRows.Count > 0)
            {
                int selectedUtnumber = Convert.ToInt32(viewstudent.SelectedRows[0].Cells["StudentId"].Value);


                Student updatedStudent = new Student
                {

                    UTnumber = selectedUtnumber,
                    Fullname = name_textBox3.Text,
                    Birthofdate = birth.Text,
                    Gender = gender3.Text,
                    Address = addresstextBox4.Text,
                    Phonenumber = ph_notextBox5.Text,
                    Gmail = gmailtextBox6.Text,
                    Nicno = NICno.Text


                };

                _Studentcontroller.UpdateStudent(updatedStudent);
                LoadStudent();

                MessageBox.Show("Student updated successfully!");
            }
           
        }



        private void removestu_button_Click(object sender, EventArgs e)
        {
            if (viewstudent.SelectedRows.Count > 0)
            {
                int selectedUtnumber = Convert.ToInt32(viewstudent.SelectedRows[0].Cells["StudentId"].Value);

                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                   
                {
                    _Studentcontroller.DeleteStudent(selectedUtnumber);
                    LoadStudent();
                    MessageBox.Show("Student deleted successfully!");

                    name_textBox3.Text = "";
                    birth.Text = "";
                    gender3.Text = "";
                    addresstextBox4.Text = "";
                    ph_notextBox5.Text = "";
                    gmailtextBox6.Text = "";
                    NICno.Text = "";


                }

            }
            else
            {
                MessageBox.Show("Please select a student to remove.");
            }
        }

        private void LoadStudentData()
        {
            
        }

        private void All_Student_List_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void viewstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void viewstudent_SelectionChanged(object sender, EventArgs e)
        {
            if (viewstudent.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = viewstudent.SelectedRows[0];

                name_textBox3.Text = selectedRow.Cells["Fullname"].Value.ToString();
                birth.Text = selectedRow.Cells["Birthofdate"].Value.ToString();
                gender3.Text = selectedRow.Cells["Gender"].Value.ToString();
                ph_notextBox5.Text = selectedRow.Cells["Phonenumber"].Value.ToString();
                gmailtextBox6.Text = selectedRow.Cells["mail"].Value.ToString();
                NICno.Text = selectedRow.Cells["Nicno"].Value.ToString() ;

            }
        }
    }
}
