namespace AttendanceSystem
{
    partial class Form1
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Rpassword_txt = new System.Windows.Forms.TextBox();
            this.Remail_txt = new System.Windows.Forms.TextBox();
            this.Rname_txt = new System.Windows.Forms.TextBox();
            this.Register_btn = new System.Windows.Forms.Button();
            this.class_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(394, 206);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(333, 24);
            this.name_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(394, 272);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(333, 24);
            this.password_txt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rpassword_txt
            // 
            this.Rpassword_txt.Location = new System.Drawing.Point(800, 206);
            this.Rpassword_txt.Name = "Rpassword_txt";
            this.Rpassword_txt.Size = new System.Drawing.Size(333, 24);
            this.Rpassword_txt.TabIndex = 4;
            this.Rpassword_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Remail_txt
            // 
            this.Remail_txt.Location = new System.Drawing.Point(800, 136);
            this.Remail_txt.Name = "Remail_txt";
            this.Remail_txt.Size = new System.Drawing.Size(333, 24);
            this.Remail_txt.TabIndex = 5;
            // 
            // Rname_txt
            // 
            this.Rname_txt.Location = new System.Drawing.Point(800, 88);
            this.Rname_txt.Name = "Rname_txt";
            this.Rname_txt.Size = new System.Drawing.Size(333, 24);
            this.Rname_txt.TabIndex = 6;
            // 
            // Register_btn
            // 
            this.Register_btn.Location = new System.Drawing.Point(877, 272);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(183, 42);
            this.Register_btn.TabIndex = 7;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // class_txt
            // 
            this.class_txt.Location = new System.Drawing.Point(800, 242);
            this.class_txt.Name = "class_txt";
            this.class_txt.Size = new System.Drawing.Size(333, 24);
            this.class_txt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 484);
            this.Controls.Add(this.class_txt);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Rname_txt);
            this.Controls.Add(this.Remail_txt);
            this.Controls.Add(this.Rpassword_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.name_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Rpassword_txt;
        private System.Windows.Forms.TextBox Remail_txt;
        private System.Windows.Forms.TextBox Rname_txt;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.TextBox class_txt;
    }
}

