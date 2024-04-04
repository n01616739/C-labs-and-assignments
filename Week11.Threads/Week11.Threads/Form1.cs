using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11.Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            // Validate input
            if (!int.TryParse(InputTextBox.Text, out int count) || count < 1)
            {
                MessageBox.Show("Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FibonacciListBox.Items.Clear();
            // Generate Fibonacci numbers asynchronously
            await Task.Run(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    int fibonacciNumber = CalculateFibonacci(i);
                    // Update UI asynchronously
                    Invoke((MethodInvoker)delegate {
                        FibonacciListBox.Items.Add(fibonacciNumber);
                    });
                    // Simulate some computation time
                    Thread.Sleep(100);
                }
            });
        }

        // Fibonacci calculation method
        private int CalculateFibonacci(int n)
        {
            if (n <= 1)
                return n;

            int a = 0;
            int b = 1;

            for (int i = 2; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b;
        }
    }
}
