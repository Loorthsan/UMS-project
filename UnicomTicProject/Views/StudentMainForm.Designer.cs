namespace UnicomTicProject.Views
{
    partial class StudentMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.studentProfile = new System.Windows.Forms.DataGridView();
            this.viewmarkStudent = new System.Windows.Forms.DataGridView();
            this.viewTimeTablestudent = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmarkStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTimeTablestudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 116);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student menu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 509);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(30, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "View TimeTable ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Marks";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Student Profile ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.studentProfilebutton);
            // 
            // studentProfile
            // 
            this.studentProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentProfile.Location = new System.Drawing.Point(228, 134);
            this.studentProfile.Name = "studentProfile";
            this.studentProfile.Size = new System.Drawing.Size(653, 98);
            this.studentProfile.TabIndex = 2;
            this.studentProfile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentProfile_CellContentClick);
            // 
            // viewmarkStudent
            // 
            this.viewmarkStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewmarkStudent.Location = new System.Drawing.Point(228, 256);
            this.viewmarkStudent.Name = "viewmarkStudent";
            this.viewmarkStudent.Size = new System.Drawing.Size(653, 106);
            this.viewmarkStudent.TabIndex = 4;
            // 
            // viewTimeTablestudent
            // 
            this.viewTimeTablestudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTimeTablestudent.Location = new System.Drawing.Point(228, 406);
            this.viewTimeTablestudent.Name = "viewTimeTablestudent";
            this.viewTimeTablestudent.Size = new System.Drawing.Size(653, 79);
            this.viewTimeTablestudent.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(776, 571);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 42);
            this.button6.TabIndex = 25;
            this.button6.Text = "Close";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 625);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.viewTimeTablestudent);
            this.Controls.Add(this.viewmarkStudent);
            this.Controls.Add(this.studentProfile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.Load += new System.EventHandler(this.StudentMainForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmarkStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTimeTablestudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView studentProfile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView viewmarkStudent;
        private System.Windows.Forms.DataGridView viewTimeTablestudent;
        private System.Windows.Forms.Button button6;
    }
}