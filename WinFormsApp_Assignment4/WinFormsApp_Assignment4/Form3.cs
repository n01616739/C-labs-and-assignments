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
    public partial class Form3 : Form
    {
        private ASSN4DBContext _context;
        private string _firstName;
        private string _lastName;
        private int userId = 0;
        private int selectedUserId = 0;


        public Form3()
        {
            InitializeComponent();
            _context = new ASSN4DBContext();

        }

        private void button_findUser_Click(object sender, EventArgs e)
        {
            // Variable to store user ID

            _firstName = textBox_findfname.Text.Trim();
            _lastName = textBox_findlastname.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(_firstName) || string.IsNullOrEmpty(_lastName))
            {
                MessageBox.Show("Please enter both first name and last name.");
                return;
            }
            var user = _context.Users.FirstOrDefault(u => u.Firstname.Equals(_firstName) && u.Lastname.Equals(_lastName));

            if (user != null)
            {
                userId = user.Id; // Retrieve user ID
                var accountDetails = _context.Accounts
                   .Where(account => account.UserId == userId)
                   .Select(account => new
                   {
                       account.UserId,
                       account.AccountId,
                       account.AccountType,
                       account.CurrentBalance,
                       account.DateCreated
                   }).ToList();

                if (accountDetails.Any())
                {
                    dataGridView1.DataSource = accountDetails;
                    dataGridView1.Visible = true;
                }
                else
                {
                    CreateNewAccount(user.Id);

                }
            }
            else
            {

                MessageBox.Show("No matching user found.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button_createaccount.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            textBox_transcid.Visible = false;
            textBox_accid.Visible = false;
            textBox_transdate.Visible = false;
            textBox_amt.Visible = false;
            textBox_desc.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                button_createaccount.Visible = true;
                dataGridView2.Visible = true;
                textBox_transcid.Visible = true;
                textBox_accid.Visible = true;
                textBox_transdate.Visible = true;
                textBox_amt.Visible = true;
                textBox_desc.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;

                var selectedRow = dataGridView1.SelectedRows[0];
                DisplayTransactionHistoryForSelectedAccount();

                if (selectedRow.DataBoundItem is not null)
                {
                    // Assuming that the DataBoundItem is of a type that has an AccountId property.
                    var account = (dynamic)selectedRow.DataBoundItem;
                    selectedUserId = account.UserId; // Updated to store UserId

                    int accountId = account.AccountId;
                    textBox_accid.Text = accountId.ToString();

                    // Now query for transactions related to this account.
                    var transactionList = _context.TransactionHistories
                        .Where(th => th.AccountId == accountId)
                        .Select(th => new
                        {
                            th.TransactionId,
                            th.AccountId,
                            th.TransactionDate,
                            th.Amount,
                            th.Description
                        }).ToList();

                    // If there is no transaction history, show a message; otherwise, bind the list to dataGridView2.
                    if (transactionList.Any())
                    {
                        dataGridView2.DataSource = transactionList;
                    }
                    else
                    {
                        dataGridView2.DataSource = null; // Clear the previous data
                        MessageBox.Show("There is no transaction history for the selected account.", "No Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button_createaccount_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(selectedUserId);
            form4.Show();
            this.Close();
        }

        private void CreateNewAccount(int userId)
        {
            if (userId != 0)
            {
                Form4 form4 = new Form4(userId);
                form4.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No user selected. Please find a user first.", "User Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_accid.Text, out int accountId) &&
                decimal.TryParse(textBox_amt.Text, out decimal amount))
            {
                string description = textBox_desc.Text;
                if (!DateTime.TryParse(textBox_transdate.Text, out DateTime transactionDate))
                {
                    MessageBox.Show("Invalid date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var transaction = new TransactionHistory
                {
                    // TransactionId is auto-generated by the database, so it's not set here
                    AccountId = accountId,
                    Amount = amount,
                    Description = description,
                    TransactionDate = transactionDate
                };

                // Add the transaction to the context
                _context.TransactionHistories.Add(transaction);

                // Update the account balance
                UpdateAccountBalance(accountId, -amount);
                _context.SaveChanges(); // Save changes to the database
                RefreshAccountGrid();
                RefreshTransactionGrid(accountId);
            }
            else
            {
                MessageBox.Show("Invalid Account ID or Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox_transcid.Text, out int transactionId) && decimal.TryParse(textBox_amt.Text, out decimal newAmount))
            {
                var transaction = _context.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId);
                if (transaction != null && DateTime.TryParse(textBox_transdate.Text, out DateTime transactionDate))
                {
                    var account = _context.Accounts.FirstOrDefault(a => a.AccountId == transaction.AccountId);
                    if (account != null)
                    {
                        double originalAmountAsDouble = Convert.ToDouble(transaction.Amount ?? 0m);
                        double newAmountAsDouble = Convert.ToDouble(newAmount);

                        account.CurrentBalance = (account.CurrentBalance ?? 0.0) + originalAmountAsDouble - newAmountAsDouble;

                        // Update transaction details
                        transaction.Amount = newAmount;
                        transaction.Description = textBox_desc.Text;
                        transaction.TransactionDate = transactionDate;

                        _context.SaveChanges();
                        RefreshAccountGrid(); 
                        RefreshTransactionGrid(transaction.AccountId);
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int transactionId;
            if (int.TryParse(textBox_transcid.Text, out transactionId))
            {
                var transaction = _context.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId);
                if (transaction != null)
                {
                    var account = _context.Accounts.FirstOrDefault(a => a.AccountId == transaction.AccountId);
                    if (account != null)
                    {
                        double transactionAmountAsDouble = Convert.ToDouble(transaction.Amount ?? 0m);

                        // Increase account balance
                        account.CurrentBalance = (account.CurrentBalance ?? 0.0) + transactionAmountAsDouble;

                        _context.TransactionHistories.Remove(transaction);
                        _context.SaveChanges();
                        RefreshAccountGrid(); 
                        RefreshTransactionGrid(transaction.AccountId);
                    }
                }
            }
        }



        private void UpdateAccountBalance(int accountId, decimal amountChange)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.AccountId == accountId);
            if (account != null)
            {
                // Convert decimal to double before the operation
                double amountChangeAsDouble = (double)amountChange;
                account.CurrentBalance = (account.CurrentBalance ?? 0.0) + amountChangeAsDouble;
                _context.SaveChanges();
                RefreshAccountGrid(); // Refresh dataGridView1 to show updated balance
            }
        }


        private void UpdateTransactionGrid(int accountId)
        {
            var transactions = _context.TransactionHistories
               .Where(t => t.AccountId == accountId)
               .Select(t => new { t.TransactionId, t.AccountId, t.TransactionDate, t.Amount, t.Description })
               .ToList();

            dataGridView2.DataSource = transactions;
            dataGridView2.Refresh();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }


        private void DisplayTransactionHistoryForSelectedAccount()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var account = (dynamic)selectedRow.DataBoundItem;
                int accountId = account.AccountId;
                textBox_accid.Text = accountId.ToString();
                RefreshTransactionGrid(accountId);
            }
        }


        private void RefreshAccountGrid()
        {
            var accountDetails = _context.Accounts
                .Where(account => account.UserId == userId)
                .Select(account => new
                {
                    account.UserId,
                    account.AccountId,
                    account.AccountType,
                    account.CurrentBalance,
                    account.DateCreated
                }).ToList();

            dataGridView1.DataSource = accountDetails;
            dataGridView1.Refresh();
        }

        private void RefreshTransactionGrid(int accountId)
        {
            var transactions = _context.TransactionHistories
                .Where(t => t.AccountId == accountId)
                .Select(t => new
                {
                    t.TransactionId,
                    t.AccountId,
                    t.TransactionDate,
                    t.Amount,
                    t.Description
                }).ToList();

            dataGridView2.DataSource = transactions;
            dataGridView2.Refresh();
        }


        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView2.SelectedRows[0];
                textBox_transcid.Text = selectedRow.Cells["TransactionId"].Value.ToString();
                textBox_accid.Text = selectedRow.Cells["AccountId"].Value.ToString();
                textBox_amt.Text = selectedRow.Cells["Amount"].Value.ToString();
                textBox_desc.Text = selectedRow.Cells["Description"].Value?.ToString() ?? string.Empty; // Handle potential nulls
                textBox_transdate.Text = ((DateTime)selectedRow.Cells["TransactionDate"].Value).ToString("yyyy-MM-dd");
            }
        }
    }
}
