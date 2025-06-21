namespace UnicomTicProject.Views
{
    partial class CourseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.corsenameTextBox = new System.Windows.Forms.TextBox();
            this.corsedurationTextBox2 = new System.Windows.Forms.TextBox();
            this.corsedescriptiontextBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.add_buttion = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.coursedataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursedataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // corsenameTextBox
            // 
            this.corsenameTextBox.Location = new System.Drawing.Point(237, 93);
            this.corsenameTextBox.Name = "corsenameTextBox";
            this.corsenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.corsenameTextBox.TabIndex = 4;
            // 
            // corsedurationTextBox2
            // 
            this.corsedurationTextBox2.Location = new System.Drawing.Point(237, 123);
            this.corsedurationTextBox2.Name = "corsedurationTextBox2";
            this.corsedurationTextBox2.Size = new System.Drawing.Size(100, 20);
            this.corsedurationTextBox2.TabIndex = 5;
            // 
            // corsedescriptiontextBox3
            // 
            this.corsedescriptiontextBox3.Location = new System.Drawing.Point(237, 158);
            this.corsedescriptiontextBox3.Name = "corsedescriptiontextBox3";
            this.corsedescriptiontextBox3.Size = new System.Drawing.Size(100, 20);
            this.corsedescriptiontextBox3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "CourseForm";
            // 
            // add_buttion
            // 
            this.add_buttion.Location = new System.Drawing.Point(12, 242);
            this.add_buttion.Name = "add_buttion";
            this.add_buttion.Size = new System.Drawing.Size(78, 35);
            this.add_buttion.TabIndex = 2;
            this.add_buttion.Text = "Add";
            this.add_buttion.UseVisualStyleBackColor = true;
            this.add_buttion.Click += new System.EventHandler(this.add_but_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(137, 242);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 35);
            this.updatebutton.TabIndex = 8;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(656, 395);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(105, 43);
            this.closebutton.TabIndex = 9;
            this.closebutton.Text = "close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // coursedataGridView1
            // 
            this.coursedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursedataGridView1.Location = new System.Drawing.Point(399, 84);
            this.coursedataGridView1.Name = "coursedataGridView1";
            this.coursedataGridView1.Size = new System.Drawing.Size(347, 270);
            this.coursedataGridView1.TabIndex = 10;
            this.coursedataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursedataGridView1_CellContentClick);
            this.coursedataGridView1.SelectionChanged += new System.EventHandler(this.coursedataGridView1_SelectionChanged);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(280, 242);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 35);
            this.deletebutton.TabIndex = 11;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.coursedataGridView1);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.add_buttion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.corsedescriptiontextBox3);
            this.Controls.Add(this.corsedurationTextBox2);
            this.Controls.Add(this.corsenameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursedataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox corsenameTextBox;
        private System.Windows.Forms.TextBox corsedurationTextBox2;
        private System.Windows.Forms.TextBox corsedescriptiontextBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_buttion;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.DataGridView coursedataGridView1;
        private System.Windows.Forms.Button deletebutton;
    }
}