namespace WinFormsApp_Assignment4
{
    partial class Form3
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
            textBox_findfname = new TextBox();
            button_findUser = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_findlastname = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            textBox_transcid = new TextBox();
            textBox_accid = new TextBox();
            textBox_transdate = new TextBox();
            textBox_amt = new TextBox();
            textBox_desc = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button_createaccount = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox_findfname
            // 
            textBox_findfname.Location = new Point(153, 53);
            textBox_findfname.Name = "textBox_findfname";
            textBox_findfname.Size = new Size(125, 27);
            textBox_findfname.TabIndex = 0;
            // 
            // button_findUser
            // 
            button_findUser.Location = new Point(63, 159);
            button_findUser.Name = "button_findUser";
            button_findUser.Size = new Size(94, 29);
            button_findUser.TabIndex = 1;
            button_findUser.Text = "Find User";
            button_findUser.UseVisualStyleBackColor = true;
            button_findUser.Click += button_findUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 56);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = " Fname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 111);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = " Lname";
            // 
            // textBox_findlastname
            // 
            textBox_findlastname.Location = new Point(153, 104);
            textBox_findlastname.Name = "textBox_findlastname";
            textBox_findlastname.Size = new Size(125, 27);
            textBox_findlastname.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(626, 188);
            dataGridView1.TabIndex = 5;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(41, 443);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(448, 239);
            dataGridView2.TabIndex = 7;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // textBox_transcid
            // 
            textBox_transcid.Location = new Point(651, 455);
            textBox_transcid.Name = "textBox_transcid";
            textBox_transcid.ReadOnly = true;
            textBox_transcid.Size = new Size(125, 27);
            textBox_transcid.TabIndex = 8;
            // 
            // textBox_accid
            // 
            textBox_accid.Location = new Point(651, 512);
            textBox_accid.Name = "textBox_accid";
            textBox_accid.Size = new Size(125, 27);
            textBox_accid.TabIndex = 9;
            // 
            // textBox_transdate
            // 
            textBox_transdate.Location = new Point(651, 576);
            textBox_transdate.Name = "textBox_transdate";
            textBox_transdate.Size = new Size(125, 27);
            textBox_transdate.TabIndex = 10;
            // 
            // textBox_amt
            // 
            textBox_amt.Location = new Point(651, 643);
            textBox_amt.Name = "textBox_amt";
            textBox_amt.Size = new Size(125, 27);
            textBox_amt.TabIndex = 11;
            // 
            // textBox_desc
            // 
            textBox_desc.Location = new Point(651, 703);
            textBox_desc.Name = "textBox_desc";
            textBox_desc.Size = new Size(125, 27);
            textBox_desc.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(63, 721);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(217, 721);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(380, 721);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 462);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 16;
            label3.Text = "Transcation_Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(526, 519);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 17;
            label4.Text = "AccountID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(526, 583);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 18;
            label5.Text = "TranscationDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 650);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 19;
            label6.Text = "Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(526, 710);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 20;
            label7.Text = "Description";
            // 
            // button_createaccount
            // 
            button_createaccount.Location = new Point(205, 156);
            button_createaccount.Name = "button_createaccount";
            button_createaccount.Size = new Size(94, 29);
            button_createaccount.TabIndex = 21;
            button_createaccount.Text = "Create Account";
            button_createaccount.UseVisualStyleBackColor = true;
            button_createaccount.Click += button_createaccount_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(617, 21);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 22;
            label8.Text = "Home";
            label8.Click += label8_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 762);
            Controls.Add(label8);
            Controls.Add(button_createaccount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_desc);
            Controls.Add(textBox_amt);
            Controls.Add(textBox_transdate);
            Controls.Add(textBox_accid);
            Controls.Add(textBox_transcid);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox_findlastname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_findUser);
            Controls.Add(textBox_findfname);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_findfname;
        private Button button_findUser;
        private Label label1;
        private Label label2;
        private TextBox textBox_findlastname;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox_transcid;
        private TextBox textBox_accid;
        private TextBox textBox_transdate;
        private TextBox textBox_amt;
        private TextBox textBox_desc;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button_createaccount;
        private Label label8;
    }
}