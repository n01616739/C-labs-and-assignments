namespace WinFormsApp_Assignment4
{
    partial class Form4
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
            textBox_dateCreated = new TextBox();
            textBox_accounttype = new TextBox();
            textBox_currentbalance = new TextBox();
            textBox_useraccountid = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_save = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox_dateCreated
            // 
            textBox_dateCreated.Location = new Point(104, 221);
            textBox_dateCreated.Name = "textBox_dateCreated";
            textBox_dateCreated.Size = new Size(125, 27);
            textBox_dateCreated.TabIndex = 1;
            // 
            // textBox_accounttype
            // 
            textBox_accounttype.Location = new Point(438, 65);
            textBox_accounttype.Name = "textBox_accounttype";
            textBox_accounttype.Size = new Size(125, 27);
            textBox_accounttype.TabIndex = 2;
            // 
            // textBox_currentbalance
            // 
            textBox_currentbalance.Location = new Point(438, 159);
            textBox_currentbalance.Name = "textBox_currentbalance";
            textBox_currentbalance.Size = new Size(125, 27);
            textBox_currentbalance.TabIndex = 3;
            // 
            // textBox_useraccountid
            // 
            textBox_useraccountid.Location = new Point(104, 140);
            textBox_useraccountid.Name = "textBox_useraccountid";
            textBox_useraccountid.ReadOnly = true;
            textBox_useraccountid.Size = new Size(125, 27);
            textBox_useraccountid.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 68);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 6;
            label2.Text = "Account Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "UserID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 159);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 8;
            label4.Text = "Current Balance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 228);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 9;
            label5.Text = "DateCreated";
            // 
            // button_save
            // 
            button_save.Location = new Point(200, 289);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 29);
            button_save.TabIndex = 10;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 18);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 11;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button_save);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_useraccountid);
            Controls.Add(textBox_currentbalance);
            Controls.Add(textBox_accounttype);
            Controls.Add(textBox_dateCreated);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_dateCreated;
        private TextBox textBox_accounttype;
        private TextBox textBox_currentbalance;
        private TextBox textBox_useraccountid;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_save;
        private Label label6;
    }
}