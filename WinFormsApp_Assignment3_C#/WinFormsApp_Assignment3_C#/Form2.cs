using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Assignment3_C_
{
    public partial class Form2 : Form
    {
        private BusinessLogic businessLogic;
        private DataTable dataTable;

        public Form2()
        {
            InitializeComponent();
            dataTable = new DataTable();
            businessLogic = new BusinessLogic(@"C:\Users\siddh\OneDrive - Humber College\Documents\windowsAppDev\grocery_inventory_items.txt");
            this.Load += new EventHandler(Form2_Load);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SetupDataTableColumns();
            LoadDataIntoDataTable();
        }

        private void SetupDataTableColumns()
        {
            if (dataTable.Columns.Count == 0)
            {
                dataTable.Columns.Add("Student ID", typeof(string));
                dataTable.Columns.Add("Firstname", typeof(string));
                dataTable.Columns.Add("Lastname", typeof(string));
                dataTable.Columns.Add("Age", typeof(int));
                dataTable.Columns.Add("Gender", typeof(string));
                dataTable.Columns.Add("Classname", typeof(string));
                dataTable.Columns.Add("Grade", typeof(string));
            }
        }

        private void LoadDataIntoDataTable()
        {
            dataTable.Clear();
            var records = businessLogic.GetAllRecords();
            foreach (var record in records)
            {
                DataRow row = dataTable.NewRow();
                for (int i = 0; i < record.Length; i++)
                {
                    row[i] = record[i];
                }
                dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Ensure no duplicate Student ID
            if (dataTable.AsEnumerable().Any(row => row["Student ID"].ToString() == textBox1.Text))
            {
                MessageBox.Show("A record with this Student ID already exists.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new record
            string[] newRecord = new string[]
            {
        textBox1.Text, // Student ID
        textBox2.Text, // Firstname
        textBox3.Text, // Lastname
        textBox4.Text, // Age
        textBox5.Text, // Gender
        textBox6.Text, // Classname
        textBox7.Text  // Grade
            };
            businessLogic.AddRecord(newRecord);
            LoadDataIntoDataTable(); // Refresh data grid
            MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string studentId = selectedRow.Cells["Student ID"].Value.ToString();

                string[] updatedRecord = new string[]
                {
            textBox1.Text, // Student ID
            textBox2.Text, // Firstname
            textBox3.Text, // Lastname
            textBox4.Text, // Age
            textBox5.Text, // Gender
            textBox6.Text, // Classname
            textBox7.Text  // Grade
                };

                businessLogic.UpdateRecord(studentId, updatedRecord);
                LoadDataIntoDataTable(); // Refresh the data grid
                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string studentId = selectedRow.Cells["Student ID"].Value.ToString();
                businessLogic.DeleteRecord(studentId);
                LoadDataIntoDataTable(); // Refresh data grid
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                textBox1.Text = row.Cells["Student ID"].Value?.ToString() ?? "";
                textBox2.Text = row.Cells["Firstname"].Value?.ToString() ?? "";
                textBox3.Text = row.Cells["Lastname"].Value?.ToString() ?? "";
                textBox4.Text = row.Cells["Age"].Value?.ToString() ?? "";
                textBox5.Text = row.Cells["Gender"].Value?.ToString() ?? "";
                textBox6.Text = row.Cells["Classname"].Value?.ToString() ?? "";
                textBox7.Text = row.Cells["Grade"].Value?.ToString() ?? "";
            }
        }


    }
}
