namespace UnicomTicProject.Views
{
    partial class All_Student_List
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name_textBox3 = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.TextBox();
            this.gender3 = new System.Windows.Forms.TextBox();
            this.addresstextBox4 = new System.Windows.Forms.TextBox();
            this.ph_notextBox5 = new System.Windows.Forms.TextBox();
            this.gmailtextBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NICno = new System.Windows.Forms.TextBox();
            this.viewstudent = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.updatestu_button = new System.Windows.Forms.Button();
            this.removestu_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.courseIDtext = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 69);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Student List ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gmail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Birth Of Date";
            // 
            // name_textBox3
            // 
            this.name_textBox3.Location = new System.Drawing.Point(157, 100);
            this.name_textBox3.Name = "name_textBox3";
            this.name_textBox3.Size = new System.Drawing.Size(196, 20);
            this.name_textBox3.TabIndex = 8;
            this.name_textBox3.TextChanged += new System.EventHandler(this.name_textBox3_TextChanged);
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(157, 142);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(196, 20);
            this.birth.TabIndex = 9;
            // 
            // gender3
            // 
            this.gender3.Location = new System.Drawing.Point(157, 178);
            this.gender3.Name = "gender3";
            this.gender3.Size = new System.Drawing.Size(196, 20);
            this.gender3.TabIndex = 10;
            // 
            // addresstextBox4
            // 
            this.addresstextBox4.Location = new System.Drawing.Point(157, 212);
            this.addresstextBox4.Name = "addresstextBox4";
            this.addresstextBox4.Size = new System.Drawing.Size(196, 20);
            this.addresstextBox4.TabIndex = 11;
            // 
            // ph_notextBox5
            // 
            this.ph_notextBox5.Location = new System.Drawing.Point(157, 240);
            this.ph_notextBox5.Name = "ph_notextBox5";
            this.ph_notextBox5.Size = new System.Drawing.Size(196, 20);
            this.ph_notextBox5.TabIndex = 12;
            // 
            // gmailtextBox6
            // 
            this.gmailtextBox6.Location = new System.Drawing.Point(157, 271);
            this.gmailtextBox6.Name = "gmailtextBox6";
            this.gmailtextBox6.Size = new System.Drawing.Size(196, 20);
            this.gmailtextBox6.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "NIC NO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Gender";
            // 
            // NICno
            // 
            this.NICno.Location = new System.Drawing.Point(157, 304);
            this.NICno.Name = "NICno";
            this.NICno.Size = new System.Drawing.Size(196, 20);
            this.NICno.TabIndex = 18;
            // 
            // viewstudent
            // 
            this.viewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewstudent.Location = new System.Drawing.Point(387, 75);
            this.viewstudent.Name = "viewstudent";
            this.viewstudent.Size = new System.Drawing.Size(649, 425);
            this.viewstudent.TabIndex = 19;
            this.viewstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewstudent_CellContentClick);
            this.viewstudent.SelectionChanged += new System.EventHandler(this.viewstudent_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addstu_button);
            // 
            // updatestu_button
            // 
            this.updatestu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatestu_button.Location = new System.Drawing.Point(304, 557);
            this.updatestu_button.Name = "updatestu_button";
            this.updatestu_button.Size = new System.Drawing.Size(132, 33);
            this.updatestu_button.TabIndex = 21;
            this.updatestu_button.Text = "UpDate ";
            this.updatestu_button.UseVisualStyleBackColor = true;
            this.updatestu_button.Click += new System.EventHandler(this.updatestu_button_Click);
            // 
            // removestu_button
            // 
            this.removestu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removestu_button.Location = new System.Drawing.Point(573, 557);
            this.removestu_button.Name = "removestu_button";
            this.removestu_button.Size = new System.Drawing.Size(132, 33);
            this.removestu_button.TabIndex = 22;
            this.removestu_button.Text = "Remove";
            this.removestu_button.UseVisualStyleBackColor = true;
            this.removestu_button.Click += new System.EventHandler(this.removestu_button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(789, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 33);
            this.button2.TabIndex = 28;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // courseIDtext
            // 
            this.courseIDtext.Location = new System.Drawing.Point(157, 378);
            this.courseIDtext.Name = "courseIDtext";
            this.courseIDtext.Size = new System.Drawing.Size(196, 20);
            this.courseIDtext.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Course Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "UserName";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(157, 342);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(196, 20);
            this.userNameText.TabIndex = 30;
            // 
            // All_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1048, 658);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.courseIDtext);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.removestu_button);
            this.Controls.Add(this.updatestu_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewstudent);
            this.Controls.Add(this.NICno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gmailtextBox6);
            this.Controls.Add(this.ph_notextBox5);
            this.Controls.Add(this.addresstextBox4);
            this.Controls.Add(this.gender3);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.name_textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "All_Student_List";
            this.Text = "Manage Student List ";
            this.Load += new System.EventHandler(this.All_Student_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name_textBox3;
        private System.Windows.Forms.TextBox birth;
        private System.Windows.Forms.TextBox gender3;
        private System.Windows.Forms.TextBox addresstextBox4;
        private System.Windows.Forms.TextBox ph_notextBox5;
        private System.Windows.Forms.TextBox gmailtextBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NICno;
        private System.Windows.Forms.DataGridView viewstudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updatestu_button;
        private System.Windows.Forms.Button removestu_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox courseIDtext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userNameText;
    }
}