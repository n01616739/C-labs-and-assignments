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
    public partial class Form4 : Form
    {
        private ASSN4DBContext _context;
        private int _userId;

        public Form4(int userId)
        {
            InitializeComponent();
            _context = new ASSN4DBContext();
            _userId = userId; // Store the passed userId for later use
            textBox_useraccountid.Text = userId.ToString();

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string accountType = textBox_accounttype.Text;

            if (!decimal.TryParse(textBox_currentbalance.Text, out decimal currentBalance))
            {
                MessageBox.Show("Please enter a valid current balance.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new instance of the Account entity
            var newAccount = new Account
            {
                AccountType = accountType,
                UserId = _userId, 
                CurrentBalance = (double?)decimal.Parse(textBox_currentbalance.Text), 
                DateCreated = DateTime.Parse(textBox_dateCreated.Text)
            };

            // Add the new Account entity to the context
            _context.Accounts.Add(newAccount);

            // Try to save changes to the database
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Account created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating account: {ex.Message}");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}
