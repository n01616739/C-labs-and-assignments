namespace WinFormsApp_Assignment4
{
    partial class Form2
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
            label_date = new Label();
            label_password = new Label();
            label_Email = new Label();
            label_lname = new Label();
            label_fname = new Label();
            textBox_Date = new TextBox();
            textBox_pass = new TextBox();
            textBox_Email = new TextBox();
            textBox_lname = new TextBox();
            textBox_fname = new TextBox();
            button_AddUsers = new Button();
            textBox_id = new TextBox();
            label_ID = new Label();
            label_signin = new Label();
            label_signin_email = new Label();
            label_signin_password = new Label();
            textBox_signinemail = new TextBox();
            textBox_signin_password = new TextBox();
            Login = new Button();
            SuspendLayout();
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Location = new Point(57, 373);
            label_date.Name = "label_date";
            label_date.Size = new Size(93, 20);
            label_date.TabIndex = 23;
            label_date.Text = "DateCreated";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(57, 318);
            label_password.Name = "label_password";
            label_password.Size = new Size(70, 20);
            label_password.TabIndex = 22;
            label_password.Text = "Password";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(57, 259);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(46, 20);
            label_Email.TabIndex = 21;
            label_Email.Text = "Email";
            // 
            // label_lname
            // 
            label_lname.AutoSize = true;
            label_lname.Location = new Point(57, 199);
            label_lname.Name = "label_lname";
            label_lname.Size = new Size(53, 20);
            label_lname.TabIndex = 20;
            label_lname.Text = "Lname";
            // 
            // label_fname
            // 
            label_fname.AutoSize = true;
            label_fname.Location = new Point(57, 142);
            label_fname.Name = "label_fname";
            label_fname.Size = new Size(53, 20);
            label_fname.TabIndex = 19;
            label_fname.Text = "Fname";
            // 
            // textBox_Date
            // 
            textBox_Date.Location = new Point(255, 373);
            textBox_Date.Name = "textBox_Date";
            textBox_Date.Size = new Size(125, 27);
            textBox_Date.TabIndex = 18;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(255, 318);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.PasswordChar = '*';
            textBox_pass.Size = new Size(125, 27);
            textBox_pass.TabIndex = 17;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(255, 252);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(125, 27);
            textBox_Email.TabIndex = 16;
            // 
            // textBox_lname
            // 
            textBox_lname.Location = new Point(255, 192);
            textBox_lname.Name = "textBox_lname";
            textBox_lname.Size = new Size(125, 27);
            textBox_lname.TabIndex = 15;
            // 
            // textBox_fname
            // 
            textBox_fname.Location = new Point(255, 135);
            textBox_fname.Name = "textBox_fname";
            textBox_fname.Size = new Size(125, 27);
            textBox_fname.TabIndex = 14;
            // 
            // button_AddUsers
            // 
            button_AddUsers.Location = new Point(57, 52);
            button_AddUsers.Name = "button_AddUsers";
            button_AddUsers.Size = new Size(94, 29);
            button_AddUsers.TabIndex = 13;
            button_AddUsers.Text = "ADD Users";
            button_AddUsers.UseVisualStyleBackColor = true;
            button_AddUsers.Click += button_AddUsers_Click;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(255, 87);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(125, 27);
            textBox_id.TabIndex = 25;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(57, 87);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(24, 20);
            label_ID.TabIndex = 26;
            label_ID.Text = "ID";
            // 
            // label_signin
            // 
            label_signin.AutoSize = true;
            label_signin.Location = new Point(615, 52);
            label_signin.Name = "label_signin";
            label_signin.Size = new Size(59, 20);
            label_signin.TabIndex = 27;
            label_signin.Text = "Sign-IN";
            label_signin.Click += label_signin_Click;
            // 
            // label_signin_email
            // 
            label_signin_email.AutoSize = true;
            label_signin_email.Location = new Point(513, 110);
            label_signin_email.Name = "label_signin_email";
            label_signin_email.Size = new Size(46, 20);
            label_signin_email.TabIndex = 28;
            label_signin_email.Text = "Email";
            // 
            // label_signin_password
            // 
            label_signin_password.AutoSize = true;
            label_signin_password.Location = new Point(513, 164);
            label_signin_password.Name = "label_signin_password";
            label_signin_password.Size = new Size(70, 20);
            label_signin_password.TabIndex = 29;
            label_signin_password.Text = "Password";
            // 
            // textBox_signinemail
            // 
            textBox_signinemail.Location = new Point(615, 103);
            textBox_signinemail.Name = "textBox_signinemail";
            textBox_signinemail.Size = new Size(125, 27);
            textBox_signinemail.TabIndex = 30;
            // 
            // textBox_signin_password
            // 
            textBox_signin_password.Location = new Point(615, 161);
            textBox_signin_password.Name = "textBox_signin_password";
            textBox_signin_password.PasswordChar = '*';
            textBox_signin_password.Size = new Size(125, 27);
            textBox_signin_password.TabIndex = 31;
            textBox_signin_password.TextChanged += textBox_signin_password_TextChanged;
            // 
            // Login
            // 
            Login.Location = new Point(530, 220);
            Login.Name = "Login";
            Login.Size = new Size(210, 36);
            Login.TabIndex = 32;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(textBox_signin_password);
            Controls.Add(textBox_signinemail);
            Controls.Add(label_signin_password);
            Controls.Add(label_signin_email);
            Controls.Add(label_signin);
            Controls.Add(label_ID);
            Controls.Add(textBox_id);
            Controls.Add(label_date);
            Controls.Add(label_password);
            Controls.Add(label_Email);
            Controls.Add(label_lname);
            Controls.Add(label_fname);
            Controls.Add(textBox_Date);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_lname);
            Controls.Add(textBox_fname);
            Controls.Add(button_AddUsers);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_date;
        private Label label_password;
        private Label label_Email;
        private Label label_lname;
        private Label label_fname;
        private TextBox textBox_Date;
        private TextBox textBox_pass;
        private TextBox textBox_Email;
        private TextBox textBox_lname;
        private TextBox textBox_fname;
        private Button button_AddUsers;
        private TextBox textBox_id;
        private Label label_ID;
        private Label label_signin;
        private Label label_signin_email;
        private Label label_signin_password;
        private TextBox textBox_signinemail;
        private TextBox textBox_signin_password;
        private Button Login;
    }
}