namespace WindowsFormsApp2
{
    partial class login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1_login = new System.Windows.Forms.Button();
            this.label1_Username = new System.Windows.Forms.Label();
            this.label1_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "abc";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(340, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "password";
            // 
            // button1_login
            // 
            this.button1_login.Location = new System.Drawing.Point(351, 242);
            this.button1_login.Name = "button1_login";
            this.button1_login.Size = new System.Drawing.Size(75, 28);
            this.button1_login.TabIndex = 2;
            this.button1_login.Text = "login";
            this.button1_login.UseVisualStyleBackColor = true;
            this.button1_login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1_Username
            // 
            this.label1_Username.AutoSize = true;
            this.label1_Username.Location = new System.Drawing.Point(356, 52);
            this.label1_Username.Name = "label1_Username";
            this.label1_Username.Size = new System.Drawing.Size(73, 16);
            this.label1_Username.TabIndex = 3;
            this.label1_Username.Text = "Username:";
            // 
            // label1_Password
            // 
            this.label1_Password.AutoSize = true;
            this.label1_Password.Location = new System.Drawing.Point(356, 145);
            this.label1_Password.Name = "label1_Password";
            this.label1_Password.Size = new System.Drawing.Size(70, 16);
            this.label1_Password.TabIndex = 4;
            this.label1_Password.Text = "Password:";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1_Password);
            this.Controls.Add(this.label1_Username);
            this.Controls.Add(this.button1_login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1_login;
        private System.Windows.Forms.Label label1_Username;
        private System.Windows.Forms.Label label1_Password;
    }
}