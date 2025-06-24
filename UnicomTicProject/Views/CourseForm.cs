using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnicomTicProject.Controller;
using UnicomTicProject.Models;

namespace UnicomTicProject.Views
{

    public partial class CourseForm : Form
    {
        CourseController _CourseController;

        
        public CourseForm()
        {
            _CourseController = new CourseController();
            InitializeComponent();
        }

        //add button
        private void add_but_Click(object sender, EventArgs e)
        {
            Course course = new Course
            {
                coursename = corsenameTextBox.Text,
                courseduration = corsedurationTextBox2.Text,
                coursedescription = corsedescriptiontextBox3.Text
            };
            _CourseController.CoursForm(course);
            MessageBox.Show("Course added successfully!");
            corsenameTextBox.Text = "";
            corsedurationTextBox2.Text = "";
            corsedescriptiontextBox3.Text = "";

            LoadCoursesToGrid();

        }

        private void LoadCoursesToGrid()
        {
            coursedataGridView1.AutoGenerateColumns = true;
            List<Course> courses = _CourseController.ViewAllCourses();
            coursedataGridView1.DataSource = courses;
        }


        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCoursesToGrid();
        }


        //update button
        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (coursedataGridView1.SelectedRows.Count > 0)
            {
               
                int selectedCourseId = Convert.ToInt32(coursedataGridView1.SelectedRows[0].Cells["courseid"].Value);

               
                Course updatedCourse = new Course
                {
                    courseid = selectedCourseId,
                    coursename = corsenameTextBox.Text,
                    courseduration = corsedurationTextBox2.Text,
                    coursedescription = corsedescriptiontextBox3.Text
                };

              
                _CourseController.CoursForm(updatedCourse);

                
                LoadCoursesToGrid();

                MessageBox.Show("Course updated successfully!");
            }
           
            
        }
        
        private void coursedataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        //Close button
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (coursedataGridView1.SelectedRows.Count > 0)
            {
                int selectedCourseId = Convert.ToInt32(coursedataGridView1.SelectedRows[0].Cells["courseid"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _CourseController.DeleteCourse(selectedCourseId);
                    LoadCoursesToGrid(); 
                    MessageBox.Show("Course deleted successfully!");

                    
                    corsenameTextBox.Text = "";
                    corsedurationTextBox2.Text = "";
                    corsedescriptiontextBox3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");

            }
        }

        private void coursedataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (coursedataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = coursedataGridView1.SelectedRows[0];

                corsenameTextBox.Text = selectedRow.Cells["coursename"].Value.ToString();
                corsedurationTextBox2.Text = selectedRow.Cells["courseduration"].Value.ToString();
                corsedescriptiontextBox3.Text = selectedRow.Cells["coursedescription"].Value.ToString();
            }
        }
    }
}

