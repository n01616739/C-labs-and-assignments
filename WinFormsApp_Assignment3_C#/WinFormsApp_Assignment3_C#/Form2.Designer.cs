namespace WinFormsApp_Assignment3_C_
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
            dataGridView1 = new DataGridView();
            button_add = new Button();
            button_Update = new Button();
            button_delete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(451, 286);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button_add
            // 
            button_add.Location = new Point(47, 371);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 1;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(171, 371);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(94, 29);
            button_Update.TabIndex = 2;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(290, 371);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(94, 29);
            button_delete.TabIndex = 3;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 55);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 93);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 5;
            label2.Text = "FName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 135);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 6;
            label3.Text = "LName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(526, 191);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 7;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(526, 251);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 8;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 324);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 9;
            label6.Text = "ClassName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(526, 380);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 10;
            label7.Text = "Grade";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(632, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(632, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(632, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(632, 191);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(109, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(632, 251);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(109, 27);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(632, 317);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(109, 27);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(632, 383);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(109, 27);
            textBox7.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(411, 371);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_delete);
            Controls.Add(button_Update);
            Controls.Add(button_add);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_add;
        private Button button_Update;
        private Button button_delete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
    }
}