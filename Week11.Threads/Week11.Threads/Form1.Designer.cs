namespace Week11.Threads
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InputTextBox = new TextBox();
            GenerateButton = new Button();
            FibonacciListBox = new ListBox();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(12, 47);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(207, 27);
            InputTextBox.TabIndex = 0;
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(235, 47);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(94, 29);
            GenerateButton.TabIndex = 1;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // FibonacciListBox
            // 
            FibonacciListBox.FormattingEnabled = true;
            FibonacciListBox.HorizontalScrollbar = true;
            FibonacciListBox.Location = new Point(12, 100);
            FibonacciListBox.Name = "FibonacciListBox";
            FibonacciListBox.Size = new Size(245, 324);
            FibonacciListBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FibonacciListBox);
            Controls.Add(GenerateButton);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button GenerateButton;
        private ListBox FibonacciListBox;
    }
}
