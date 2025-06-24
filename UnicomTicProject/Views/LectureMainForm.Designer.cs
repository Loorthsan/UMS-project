namespace UnicomTicProject.Views
{
    partial class LectureMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LectureMainForm));
            this.subjectButton = new System.Windows.Forms.Button();
            this.timeTable = new System.Windows.Forms.Button();
            this.exsamListButton = new System.Windows.Forms.Button();
            this.manageStudentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.markListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectButton
            // 
            this.subjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectButton.Location = new System.Drawing.Point(461, 180);
            this.subjectButton.Name = "subjectButton";
            this.subjectButton.Size = new System.Drawing.Size(141, 65);
            this.subjectButton.TabIndex = 16;
            this.subjectButton.Text = "Subject ";
            this.subjectButton.UseVisualStyleBackColor = true;
            this.subjectButton.Click += new System.EventHandler(this.subjectButton_Click);
            // 
            // timeTable
            // 
            this.timeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTable.Location = new System.Drawing.Point(461, 310);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(141, 65);
            this.timeTable.TabIndex = 15;
            this.timeTable.Text = "Time Table ";
            this.timeTable.UseVisualStyleBackColor = true;
            this.timeTable.Click += new System.EventHandler(this.timeTable_Click);
            // 
            // exsamListButton
            // 
            this.exsamListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exsamListButton.Location = new System.Drawing.Point(77, 310);
            this.exsamListButton.Name = "exsamListButton";
            this.exsamListButton.Size = new System.Drawing.Size(141, 65);
            this.exsamListButton.TabIndex = 14;
            this.exsamListButton.Text = "Exsam list ";
            this.exsamListButton.UseVisualStyleBackColor = true;
            this.exsamListButton.Click += new System.EventHandler(this.exsamListButton_Click);
            // 
            // manageStudentButton
            // 
            this.manageStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStudentButton.Location = new System.Drawing.Point(77, 180);
            this.manageStudentButton.Name = "manageStudentButton";
            this.manageStudentButton.Size = new System.Drawing.Size(141, 65);
            this.manageStudentButton.TabIndex = 10;
            this.manageStudentButton.Text = "Manage Student list";
            this.manageStudentButton.UseVisualStyleBackColor = true;
            this.manageStudentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lecture  Form ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Option";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(557, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 42);
            this.button2.TabIndex = 25;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // markListButton
            // 
            this.markListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markListButton.Location = new System.Drawing.Point(265, 243);
            this.markListButton.Name = "markListButton";
            this.markListButton.Size = new System.Drawing.Size(141, 65);
            this.markListButton.TabIndex = 26;
            this.markListButton.Text = " Mark List ";
            this.markListButton.UseVisualStyleBackColor = true;
            this.markListButton.Click += new System.EventHandler(this.markListButton_Click);
            // 
            // LectureMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.markListButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectButton);
            this.Controls.Add(this.timeTable);
            this.Controls.Add(this.exsamListButton);
            this.Controls.Add(this.manageStudentButton);
            this.Name = "LectureMainForm";
            this.Text = "LectureMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subjectButton;
        private System.Windows.Forms.Button timeTable;
        private System.Windows.Forms.Button exsamListButton;
        private System.Windows.Forms.Button manageStudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button markListButton;
    }
}