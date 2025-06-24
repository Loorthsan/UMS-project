namespace UnicomTicProject.Views
{
    partial class StaffMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.timeTable = new System.Windows.Forms.Button();
            this.exsamListButton = new System.Windows.Forms.Button();
            this.studentListButton = new System.Windows.Forms.Button();
            this.markList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Option";
            // 
            // timeTable
            // 
            this.timeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTable.Location = new System.Drawing.Point(568, 421);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(141, 65);
            this.timeTable.TabIndex = 22;
            this.timeTable.Text = "Time Table ";
            this.timeTable.UseVisualStyleBackColor = true;
            this.timeTable.Click += new System.EventHandler(this.timeTable_Click);
            // 
            // exsamListButton
            // 
            this.exsamListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exsamListButton.Location = new System.Drawing.Point(211, 421);
            this.exsamListButton.Name = "exsamListButton";
            this.exsamListButton.Size = new System.Drawing.Size(141, 65);
            this.exsamListButton.TabIndex = 21;
            this.exsamListButton.Text = "Exsam list ";
            this.exsamListButton.UseVisualStyleBackColor = true;
            this.exsamListButton.Click += new System.EventHandler(this.exsamListButton_Click);
            // 
            // studentListButton
            // 
            this.studentListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListButton.Location = new System.Drawing.Point(211, 252);
            this.studentListButton.Name = "studentListButton";
            this.studentListButton.Size = new System.Drawing.Size(141, 65);
            this.studentListButton.TabIndex = 18;
            this.studentListButton.Text = "All Student List ";
            this.studentListButton.UseVisualStyleBackColor = true;
            this.studentListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // markList
            // 
            this.markList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markList.Location = new System.Drawing.Point(551, 252);
            this.markList.Name = "markList";
            this.markList.Size = new System.Drawing.Size(141, 65);
            this.markList.TabIndex = 23;
            this.markList.Text = " Mark List ";
            this.markList.UseVisualStyleBackColor = true;
            this.markList.Click += new System.EventHandler(this.markList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff Form ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(743, 601);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 37);
            this.button4.TabIndex = 28;
            this.button4.Text = "Close ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // StaffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.markList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeTable);
            this.Controls.Add(this.exsamListButton);
            this.Controls.Add(this.studentListButton);
            this.Name = "StaffMainForm";
            this.Text = "StaffMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button timeTable;
        private System.Windows.Forms.Button exsamListButton;
        private System.Windows.Forms.Button studentListButton;
        private System.Windows.Forms.Button markList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}