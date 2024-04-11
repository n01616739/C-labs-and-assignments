using Microsoft.Maui.Controls;

namespace MauiAppweek13
{
    public partial class MainPage : ContentPage
    {
        double lastNumber, currentNumber;
        string currentOperation;

      

        private void OnDigitClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if ((displayEntry.Text == "0" && pressed != ".") || currentOperation == "=" || currentOperation == "C")
            {
                displayEntry.Text = pressed;
                if (currentOperation == "=" || currentOperation == "C")
                    currentOperation = null;
            }
            else
            {
                displayEntry.Text += pressed;
            }

            if (double.TryParse(displayEntry.Text, out double number))
            {
                currentNumber = number;
            }
        }

        private void OnOperatorClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (currentOperation != null && pressed != "=")
            {
                // Perform the previous operation
                CalculateResult();
            }

            lastNumber = currentNumber;
            currentOperation = pressed;
            displayEntry.Text = "0";
        }

        private void OnEqualsClicked(object sender, EventArgs e)
        {
            if (currentOperation == null)
                return;

            CalculateResult();
            currentOperation = "=";
        }

        private void CalculateResult()
        {
            double result = 0;

            switch (currentOperation)
            {
                case "+":
                    result = lastNumber + currentNumber;
                    break;
                case "-":
                    result = lastNumber - currentNumber;
                    break;
                case "*":
                    result = lastNumber * currentNumber;
                    break;
                case "/":
                    if (currentNumber != 0)
                    {
                        result = lastNumber / currentNumber;
                    }
                    else
                    {
                        displayEntry.Text = "Cannot divide by zero";
                        currentOperation = null;
                        return;
                    }
                    break;
            }

            currentNumber = result;
            displayEntry.Text = result.ToString();
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            lastNumber = 0;
            currentNumber = 0;
            currentOperation = null;
            displayEntry.Text = "0";
        }
    }
}
