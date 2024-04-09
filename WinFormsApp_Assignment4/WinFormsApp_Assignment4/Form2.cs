using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_Assignment4.Models.Entities;

namespace WinFormsApp_Assignment4
{
    public partial class Form2 : Form
    {
        private ASSN4DBContext _context;

        public Form2()
        {
            InitializeComponent();
            _context = new ASSN4DBContext();
        }

        private void button_AddUsers_Click(object sender, EventArgs e)
        {

            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBox_fname.Text) ||
                string.IsNullOrWhiteSpace(textBox_id.Text) ||
                string.IsNullOrWhiteSpace(textBox_lname.Text) ||
                string.IsNullOrWhiteSpace(textBox_Email.Text) ||
                string.IsNullOrWhiteSpace(textBox_pass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }




            if (_context.Users.Any(u => u.Id == int.Parse(textBox_id.Text)))
            {
                MessageBox.Show("A user with this ID already exists. Please enter a unique ID.");
                return;
            }

            DateTime dateCreated;
            if (!string.IsNullOrWhiteSpace(textBox_Date.Text))
            {
                if (!DateTime.TryParseExact(textBox_Date.Text, "MM/dd/yyyy",
                                            null, System.Globalization.DateTimeStyles.None, out dateCreated))
                {
                    MessageBox.Show("Please enter the Date Created in the format MM/dd/yyyy.");
                    return;
                }
            }
            else
            {
                dateCreated = DateTime.Now;
            }

            // Create new user object
            var newUser = new User
            {
                Id = int.Parse(textBox_id.Text),
                Firstname = textBox_fname.Text,
                Lastname = textBox_lname.Text,
                Email = textBox_Email.Text,
                Password = textBox_pass.Text,
                DateCreated = dateCreated
            };

            // Add new user to the DbContext
            _context.Users.Add(newUser);

            // Save changes to the database
            try
            {
                _context.SaveChanges();
                MessageBox.Show("User added successfully.");

                // Clear the fields after successful save
                textBox_id.Text = string.Empty;
                textBox_fname.Text = string.Empty;
                textBox_lname.Text = string.Empty;
                textBox_Email.Text = string.Empty;
                textBox_pass.Text = string.Empty;
                textBox_Date.Text = string.Empty;
            }
            catch (Exception ex)
            {
                // Collect the detailed exception messages
                string exceptionMessage = GetFullExceptionMessage(ex);

                // Display the exception message in a MessageBox
                MessageBox.Show($"An error occurred: {exceptionMessage}");
            }

        }


        private static string GetFullExceptionMessage(Exception e)
        {
            return e.InnerException == null
                   ? e.Message
                   : e.Message + " --> " + GetFullExceptionMessage(e.InnerException);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_signin_email.Visible = false;
            label_signin_email.Visible = false;
            textBox_signinemail.Visible = false;
            label_signin_password.Visible = false;
            textBox_signin_password.Visible = false;
            Login.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            // Validate input fields for login
            if (string.IsNullOrWhiteSpace(textBox_signinemail.Text) ||
                string.IsNullOrWhiteSpace(textBox_signin_password.Text))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            // Query the database to find a user with the entered email and password
            var user = _context.Users
                               .FirstOrDefault(u => u.Email == textBox_signinemail.Text &&
                                                    u.Password == textBox_signin_password.Text); // In plain text for example purposes

            if (user != null)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User is not authenticated to login.");
            }
        }


        private void label_signin_Click(object sender, EventArgs e)
        {
            label_signin_email.Visible = true;
            textBox_signinemail.Visible = true;
            label_signin_password.Visible = true;
            textBox_signin_password.Visible = true;
            Login.Visible = true;



            textBox_id.Visible = false;
            textBox_fname.Visible = false;
            textBox_lname.Visible = false;
            textBox_Email.Visible = false;
            textBox_pass.Visible = false;
            textBox_Date.Visible = false;


            label_ID.Visible = false;
            label_fname.Visible = false;
            label_Email.Visible = false;
            label_password.Visible = false;
            label_lname.Visible = false;
            label_date.Visible = false;
        }

        private void textBox_signin_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
