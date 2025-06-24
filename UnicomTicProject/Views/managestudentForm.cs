using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnicomTicProject.Controller;
using UnicomTicProject.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void All_Student_List_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void LoadStudent()
        {
            viewstudent.AutoGenerateColumns = true;
            List<Student> students = _Studentcontroller.ViewAllStudents();
            viewstudent.DataSource = students;
        }

        //public void LoadStudentByUsername(string username)
        //{
        //    viewstudent.AutoGenerateColumns = true;
        //    var studentList = _Studentcontroller.GetStudentByUsernameList(username);
        //    viewstudent.DataSource = studentList;
        //}
        //Add student Buttin Code
        private void addstu_button(object sender, EventArgs e)
        {
            if (!int.TryParse(courseIDtext.Text.Trim(), out int courseId))
            {
                MessageBox.Show("Enter a valid Course ID.");
                return;
            }

            Student student = new Student
            {
                Fullname = name_textBox3.Text.Trim(),
                Birthofdate = birth.Text.Trim(),
                Gender = gender3.Text.Trim(),
                Address = addresstextBox4.Text.Trim(),
                Phonenumber = ph_notextBox5.Text.Trim(),
                Gmail = gmailtextBox6.Text.Trim(),
                Nicno = NICno.Text.Trim(),
                UserName = userNameText.Text.Trim(),
                CourseId = courseId
            };

            try
            {
                _Studentcontroller.AddStudent(student);
                MessageBox.Show("Student added successfully!");
                ClearForm();
                LoadStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);
            }
        }
        //Update Button Code
        private void updatestu_button_Click(object sender, EventArgs e)
        {
            if (viewstudent.SelectedRows.Count > 0)
            {
                int selectedStudentId = Convert.ToInt32(viewstudent.SelectedRows[0].Cells["StudentId"].Value);

                Student updatedStudent = new Student
                {
                    StudentId = selectedStudentId,
                    Fullname = name_textBox3.Text.Trim(),
                    Birthofdate = birth.Text.Trim(),
                    Gender = gender3.Text.Trim(),
                    Address = addresstextBox4.Text.Trim(),
                    Phonenumber = ph_notextBox5.Text.Trim(),
                    Gmail = gmailtextBox6.Text.Trim(),
                    Nicno = NICno.Text.Trim(),
                    UserName = userNameText.Text.Trim(),
                    CourseId = int.Parse(courseIDtext.Text.Trim())
                };


                {
                    _Studentcontroller.UpdateStudent(updatedStudent);
                    LoadStudent();
                    MessageBox.Show("Student updated successfully!");
                };

            }
        }
        //Remove Studen button 
        private void removestu_button_Click(object sender, EventArgs e)
        {
            if (viewstudent.SelectedRows.Count > 0)
            {
                int selectedStudentId = Convert.ToInt32(viewstudent.SelectedRows[0].Cells["StudentId"].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    _Studentcontroller.DeleteStudent(selectedStudentId);
                    LoadStudent();
                    MessageBox.Show("Student deleted successfully!");
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }
        //DataGridView Code 
        private void viewstudent_SelectionChanged(object sender, EventArgs e)
{
            if (viewstudent.SelectedRows.Count > 0)
            {
                DataGridViewRow row = viewstudent.SelectedRows[0];

                name_textBox3.Text = row.Cells["Fullname"].Value.ToString();
                birth.Text = row.Cells["Birthofdate"].Value.ToString();
                gender3.Text = row.Cells["Gender"].Value.ToString();
                addresstextBox4.Text = row.Cells["Address"].Value.ToString();
                ph_notextBox5.Text = row.Cells["Phonenumber"].Value.ToString();
                gmailtextBox6.Text = row.Cells["Gmail"].Value.ToString();
                NICno.Text = row.Cells["Nicno"].Value.ToString();
                userNameText.Text = row.Cells["UserName"].Value?.ToString();Text = row.Cells["UserName"].Value?.ToString();
                courseIDtext.Text = row.Cells["CourseId"].Value.ToString();
            }
}

        private void ClearForm()
        {
            name_textBox3.Text = "";
            birth.Text = "";
            gender3.Text = "";
            addresstextBox4.Text = "";
            ph_notextBox5.Text = "";
            gmailtextBox6.Text = "";
            NICno.Text = "";
            userNameText.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void viewstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void name_textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
