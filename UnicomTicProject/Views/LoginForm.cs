using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using UnicomTicProject.Controller;

namespace UnicomTicProject.Views
{
    public partial class LoginForm : Form
    {
        private string Role;

        public string UserName { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            LoadRoles(); // call role load on form start
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Optional: you can call LoadRoles() here instead of constructor
        }

        private void LoadRoles()
        {
            var roles = new List<string> { "Admin", "Staff", "Student" };
            roleCombobox.DataSource = roles; // Make sure 'Role' is your ComboBox name
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Do something when user selects a role (optional)
        }



        private void Log_but1_Click(object sender, EventArgs e)
        { 

        }
    }
}
