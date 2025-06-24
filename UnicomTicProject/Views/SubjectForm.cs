using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnicomTicProject.Controller;
using UnicomTicProject.Models;

namespace UnicomTicProject.Views
{
    public partial class SubjectForm : Form
    {
        private SubjectController _subjectController;

        public SubjectForm()
        {
            InitializeComponent();
            _subjectController = new SubjectController();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            LoadSubjectsToGrid();
        }

        private void LoadSubjectsToGrid()
        {
            subjectList.AutoGenerateColumns = true;
            subjectList.DataSource = _subjectController.GetAllSubjects();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Subject subject = new Subject
                {
                    subjectname = subjectName.Text,
                    roomname = roomnametextbox.Text,
                    lecturename = lecturenametextbox.Text,
                    courseid = int.Parse(coursetextbox.Text)
                };

                _subjectController.AddSubject(subject);
                MessageBox.Show("Subject added successfully!");

                ClearInputs();
                LoadSubjectsToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            if (subjectList.SelectedRows.Count > 0)
            {
                int subjectId = Convert.ToInt32(subjectList.SelectedRows[0].Cells["subjectid"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _subjectController.clearSubject(subjectId);
                    MessageBox.Show("Subject deleted successfully!");

                    LoadSubjectsToGrid();
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to delete.");
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            subjectName.Text = "";
            roomnametextbox.Text = "";
            lecturenametextbox.Text = "";
            coursetextbox.Text = "";
        }

       
        private void subjectList_SelectionChanged(object sender, EventArgs e)
        {
            if (subjectList.SelectedRows.Count > 0)
            {
                var row = subjectList.SelectedRows[0];
                subjectName.Text = row.Cells["subjectname"].Value.ToString();
                roomnametextbox.Text = row.Cells["roomname"].Value.ToString();
                lecturenametextbox.Text = row.Cells["lecturename"].Value.ToString();
                coursetextbox.Text = row.Cells["courseid"].Value.ToString();
            }
        }

        private void coursetextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
