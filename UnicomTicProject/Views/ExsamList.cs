using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicProject.Controller;
using UnicomTicProject.Models;

namespace UnicomTicProject.Views
{
    public partial class ExamForm : Form
    {
        private ExamController _examController;

        public ExamForm()
        {
            _examController = new ExamController();
            InitializeComponent();
            LoadExsamToGrid();
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //save button
        private void savebutton1_Click(object sender, EventArgs e)
        {

            Exsam exsam = new Exsam
            {
                StudentName = studentnameTextBox1.Text.Trim(),
                studentid = int.Parse(e_studentidTextbox.Text.Trim()),
                subjectname = subjectnametextbox.Text.Trim(),
                couresename = coursenametextbox.Text.Trim(),
                marks = markstextbox.Text.Trim(),
                examname = exsamtextBox1.Text.Trim()
            };

            _examController.ExamForm(exsam);
            MessageBox.Show("Added Success");
            LoadExsamToGrid();


            studentnameTextBox1.Text = "";
            e_studentidTextbox.Text = "";
            subjectnametextbox.Text = "";
            coursenametextbox.Text = "";
            markstextbox.Text = "";
            exsamtextBox1.Text = "";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadExsamToGrid();
        }

        private void LoadExsamToGrid()
        {
            Examview.DataSource = null;
            Examview.DataSource = _examController.ViewAllExsam();
            Examview.ClearSelection();

              
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (Examview.SelectedRows.Count > 0)
            {
                int selectedStudentId = Convert.ToInt32(Examview.SelectedRows[0].Cells["ExamId"].Value);

                Exsam updatedExsam = new Exsam
                {
                    studentid = selectedStudentId,
                    StudentName = studentnameTextBox1.Text,
                    subjectname = subjectnametextbox.Text,
                    couresename = coursenametextbox.Text,
                    marks = markstextbox.Text,
                    examname = exsamtextBox1.Text
                };

                _examController.UpdateExsam(updatedExsam);

                LoadExsamToGrid(); 

                MessageBox.Show("Exsam updated successfully!");
            }
         }

        private void Examview_SelectionChanged(object sender, EventArgs e)
        {
            if (Examview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Examview.SelectedRows[0];

                studentnameTextBox1.Text = selectedRow.Cells["StudentName"].Value.ToString();
                e_studentidTextbox.Text = selectedRow.Cells["studentid"].Value.ToString();
                subjectnametextbox.Text = selectedRow.Cells["subjectname"].Value.ToString();
                coursenametextbox.Text = selectedRow.Cells["couresename"].Value.ToString();
                markstextbox.Text = selectedRow.Cells["marks"].Value.ToString();
                exsamtextBox1.Text = selectedRow.Cells["exsamname"].Value.ToString();
            }
        }

        private void deletebuton_Click(object sender, EventArgs e)
        {

        }
    }
}
