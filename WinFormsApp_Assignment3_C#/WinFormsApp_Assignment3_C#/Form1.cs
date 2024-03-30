using System;
using System.Windows.Forms;

namespace WinFormsApp_Assignment3_C_
{
    public partial class Form1 : Form
    {
        private BusinessLogic businessLogic;
        private ErrorProvider errorProvider;

        public Form1()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            // Assuming your credentials are stored in a separate file
            businessLogic = new BusinessLogic(@"C:\Users\siddh\OneDrive - Humber College\Documents\grocery_inventory_items.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool loginSuccessful = businessLogic.ValidateLogin(username, password);

            if (loginSuccessful)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Close(); // Close Form1 after Form2 is closed
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
