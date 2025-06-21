namespace UnicomTicProject.Views
{
    partial class SingupForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_Name = new System.Windows.Forms.TextBox();
            this.signupPassword = new System.Windows.Forms.TextBox();
            this.signupReentpasdsword = new System.Windows.Forms.TextBox();
            this.SignUpBitton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 100);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sign Up";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Conform Pasdsword ";
            // 
            // signup_Name
            // 
            this.signup_Name.Location = new System.Drawing.Point(239, 172);
            this.signup_Name.Name = "signup_Name";
            this.signup_Name.Size = new System.Drawing.Size(149, 20);
            this.signup_Name.TabIndex = 4;
            // 
            // signupPassword
            // 
            this.signupPassword.Location = new System.Drawing.Point(239, 230);
            this.signupPassword.Name = "signupPassword";
            this.signupPassword.Size = new System.Drawing.Size(149, 20);
            this.signupPassword.TabIndex = 5;
            // 
            // signupReentpasdsword
            // 
            this.signupReentpasdsword.Location = new System.Drawing.Point(245, 285);
            this.signupReentpasdsword.Name = "signupReentpasdsword";
            this.signupReentpasdsword.Size = new System.Drawing.Size(143, 20);
            this.signupReentpasdsword.TabIndex = 6;
            // 
            // SignUpBitton
            // 
            this.SignUpBitton.BackColor = System.Drawing.Color.Blue;
            this.SignUpBitton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBitton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignUpBitton.Location = new System.Drawing.Point(159, 375);
            this.SignUpBitton.Name = "SignUpBitton";
            this.SignUpBitton.Size = new System.Drawing.Size(194, 40);
            this.SignUpBitton.TabIndex = 7;
            this.SignUpBitton.Text = "Register";
            this.SignUpBitton.UseVisualStyleBackColor = false;
            this.SignUpBitton.Click += new System.EventHandler(this.SignUpBitton_Click);
            // 
            // SingupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.SignUpBitton);
            this.Controls.Add(this.signupReentpasdsword);
            this.Controls.Add(this.signupPassword);
            this.Controls.Add(this.signup_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "SingupForm";
            this.Text = "Singup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_Name;
        private System.Windows.Forms.TextBox signupPassword;
        private System.Windows.Forms.TextBox signupReentpasdsword;
        private System.Windows.Forms.Button SignUpBitton;
    }
}