using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using UnicomTicProject.Controller;

namespace UnicomTicProject.Views
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            LoginController controller = new LoginController();
            LoadRoles(); 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadRoles()
        {
            roleComboBox.Items.Clear();
            roleComboBox.Items.AddRange(new string[] { "Admin", "Student", "Staff", "Lecture" });
            roleComboBox.SelectedIndex = 0;
        }  
           

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        private void Log_but1_Click(object sender, EventArgs e)
        {

            string userrole = roleComboBox.SelectedItem?.ToString();
            string username = userNametextbox.Text.Trim();
            string password = passwordtextbox.Text.Trim();

            LoginController controller = new LoginController();  
            string userRole = controller.ValidateUser(userrole, username, password);

            if (userRole == "Admin")
            {
                MessageBox.Show("Admin Login Successful");
                new AdminMainForm().Show();
                this.Hide();
            }
            else if (userRole == "Student")
            {
                MessageBox.Show("Student Login Successful");
                new StudentMainForm().Show();
                this.Hide();
            }
            else if (userRole == "Staff")
            {
                MessageBox.Show("Staff Login Successful");
                new StaffMainForm().Show();
                this.Hide();
            }
            else if (userRole == "Lecture")
            {
                MessageBox.Show("Lecture Login Successful");
                new LectureMainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = roleComboBox.SelectedItem?.ToString();
            //MessageBox.Show("You selected: " + selectedRole);
        }
    }
}
