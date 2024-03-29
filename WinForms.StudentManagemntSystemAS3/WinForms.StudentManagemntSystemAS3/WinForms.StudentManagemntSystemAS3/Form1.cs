using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StudentManagemntSystemAS3
{
    public partial class Form1 : Form
    {
        private static readonly string Path = @"C:\Users\siddh\OneDrive - Humber College\Documents\windowsAppDev\user.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            else if (ValidateUser(username, password))
            {
                MessageBox.Show("Login Successful");
                StudentForm studentForm = new StudentForm();
                studentForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credentials are not valid");
            }

        }

        

    private bool ValidateUser(string username, string password)
    {
        // Read the file and store user credentials into a collection (e.g., list or dictionary).
        var userCredentials = File.ReadAllLines(Path)
                                  .Select(line => line.Split(':'))
                                  .ToDictionary(split => split[0], split => split[1]); // Assuming first element is username and second is password

        // Check if the provided username exists and if the password matches.
        if (userCredentials.ContainsKey(username) && userCredentials[username] == password)
        {
            return true; // Credentials match, authentication successful
        }
        else
        {
            return false; // No matching credentials found
        }
    }


}
}
