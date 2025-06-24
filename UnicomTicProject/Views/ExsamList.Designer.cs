namespace UnicomTicProject.Views
{
    partial class ExamForm
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
            this.exsam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentnameTextBox1 = new System.Windows.Forms.TextBox();
            this.subjectnametextbox = new System.Windows.Forms.TextBox();
            this.coursenametextbox = new System.Windows.Forms.TextBox();
            this.markstextbox = new System.Windows.Forms.TextBox();
            this.Examview = new System.Windows.Forms.DataGridView();
            this.savebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.exsamtextBox1 = new System.Windows.Forms.TextBox();
            this.deletebuton = new System.Windows.Forms.Button();
            this.exsamidTextbox = new System.Windows.Forms.TextBox();
            this.exsamtextBOX = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Examview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exsam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 91);
            this.panel1.TabIndex = 0;
            // 
            // exsam
            // 
            this.exsam.AutoSize = true;
            this.exsam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exsam.Location = new System.Drawing.Point(252, 41);
            this.exsam.Name = "exsam";
            this.exsam.Size = new System.Drawing.Size(112, 24);
            this.exsam.TabIndex = 0;
            this.exsam.Text = "ExamForm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "marks ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Courese name ";
            // 
            // studentnameTextBox1
            // 
            this.studentnameTextBox1.Location = new System.Drawing.Point(153, 131);
            this.studentnameTextBox1.Name = "studentnameTextBox1";
            this.studentnameTextBox1.Size = new System.Drawing.Size(130, 20);
            this.studentnameTextBox1.TabIndex = 6;
            // 
            // subjectnametextbox
            // 
            this.subjectnametextbox.Location = new System.Drawing.Point(153, 192);
            this.subjectnametextbox.Name = "subjectnametextbox";
            this.subjectnametextbox.Size = new System.Drawing.Size(130, 20);
            this.subjectnametextbox.TabIndex = 8;
            // 
            // coursenametextbox
            // 
            this.coursenametextbox.Location = new System.Drawing.Point(153, 225);
            this.coursenametextbox.Name = "coursenametextbox";
            this.coursenametextbox.Size = new System.Drawing.Size(130, 20);
            this.coursenametextbox.TabIndex = 9;
            // 
            // markstextbox
            // 
            this.markstextbox.Location = new System.Drawing.Point(153, 261);
            this.markstextbox.Name = "markstextbox";
            this.markstextbox.Size = new System.Drawing.Size(130, 20);
            this.markstextbox.TabIndex = 10;
            // 
            // Examview
            // 
            this.Examview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Examview.Location = new System.Drawing.Point(20, 350);
            this.Examview.Name = "Examview";
            this.Examview.Size = new System.Drawing.Size(823, 177);
            this.Examview.TabIndex = 11;
            this.Examview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Examview.SelectionChanged += new System.EventHandler(this.Examview_SelectionChanged);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(26, 549);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(90, 30);
            this.savebutton.TabIndex = 12;
            this.savebutton.Text = "Add";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton1_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(180, 549);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(90, 30);
            this.updatebutton.TabIndex = 13;
            this.updatebutton.Text = "Update ";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.Location = new System.Drawing.Point(494, 549);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(90, 30);
            this.closebutton.TabIndex = 14;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "ExsamName";
            // 
            // exsamtextBox1
            // 
            this.exsamtextBox1.Location = new System.Drawing.Point(153, 295);
            this.exsamtextBox1.Name = "exsamtextBox1";
            this.exsamtextBox1.Size = new System.Drawing.Size(130, 20);
            this.exsamtextBox1.TabIndex = 16;
            // 
            // deletebuton
            // 
            this.deletebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebuton.Location = new System.Drawing.Point(333, 549);
            this.deletebuton.Name = "deletebuton";
            this.deletebuton.Size = new System.Drawing.Size(90, 30);
            this.deletebuton.TabIndex = 17;
            this.deletebuton.Text = "Delete";
            this.deletebuton.UseVisualStyleBackColor = true;
            this.deletebuton.Click += new System.EventHandler(this.deletebuton_Click);
            // 
            // exsamidTextbox
            // 
            this.exsamidTextbox.Location = new System.Drawing.Point(153, 162);
            this.exsamidTextbox.Name = "exsamidTextbox";
            this.exsamidTextbox.Size = new System.Drawing.Size(130, 20);
            this.exsamidTextbox.TabIndex = 7;
            this.exsamidTextbox.TextChanged += new System.EventHandler(this.ExamForm_Load);
            // 
            // exsamtextBOX
            // 
            this.exsamtextBOX.AutoSize = true;
            this.exsamtextBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exsamtextBOX.Location = new System.Drawing.Point(12, 162);
            this.exsamtextBOX.Name = "exsamtextBOX";
            this.exsamtextBOX.Size = new System.Drawing.Size(70, 16);
            this.exsamtextBOX.TabIndex = 1;
            this.exsamtextBOX.Text = "Exsam Id";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 636);
            this.Controls.Add(this.deletebuton);
            this.Controls.Add(this.exsamtextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.Examview);
            this.Controls.Add(this.markstextbox);
            this.Controls.Add(this.coursenametextbox);
            this.Controls.Add(this.subjectnametextbox);
            this.Controls.Add(this.exsamidTextbox);
            this.Controls.Add(this.studentnameTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exsamtextBOX);
            this.Controls.Add(this.panel1);
            this.Name = "ExamForm";
            this.Text = "ExsamList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Examview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentnameTextBox1;
        private System.Windows.Forms.TextBox subjectnametextbox;
        private System.Windows.Forms.TextBox coursenametextbox;
        private System.Windows.Forms.TextBox markstextbox;
        private System.Windows.Forms.DataGridView Examview;
        private System.Windows.Forms.Label exsam;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox exsamtextBox1;
        private System.Windows.Forms.Button deletebuton;
        private System.Windows.Forms.TextBox exsamidTextbox;
        private System.Windows.Forms.Label exsamtextBOX;
    }
}