namespace Calculator
{
    public partial class Calculator : Form
    {

        private decimal num1;
        private decimal num2;
        private string option;
        private decimal result;


        public Calculator()
        {
            InitializeComponent();
            textTotal.Text = "0";
            KeyDown += Calculator_KeyDown;
            textTotal.KeyDown += TextTotal_KeyDown;
        }

        private void TextBox(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textTotal.Text) && textTotal.Focused)
            {
                textTotal.Text = "0";
            }
        }

        // BUTTONS 
        private void Btn0(object sender, EventArgs e)
        {
            if (textTotal.Text == "0")

                textTotal.Clear();
            textTotal.Text += btn0.Text;
        }

        private void Btn1(object sender, EventArgs e)
        {
            if (textTotal.Text == "0" || textTotal.Text.EndsWith("0"))

                textTotal.Clear();
            textTotal.Text += btn1.Text;
        }

        private void Btn2(object sender, EventArgs e)
        {
            if (textTotal.Text == "0")

                textTotal.Clear();
            textTotal.Text += btn2.Text;
        }

        private void Btn3(object sender, EventArgs e)
        {
            if (textTotal.Text == "0")

                textTotal.Clear();
            textTotal.Text += btn3.Text;
        }

        private void Btn4(object sender, EventArgs e)
        {
            if (textTotal.Text == "0")

                textTotal.Clear();
            textTotal.Text += btn4.Text;
        }

        private void Btn5(object sender, EventArgs e)
        {
            if (textTotal.Text == "0")

                textTotal.Clear();
            textTotal.Text += btn5.Text;
        }

        private void Btn6(object sender, EventArgs e)
        {
            if (textTotal.Text == "0")

                textTotal.Clear();
            textTotal.Text += btn6.Text;
        }

        private void Btn7(object sender, EventArgs e)
        {
            if (textTotal.Text == "0")

                textTotal.Clear();
            textTotal.Text += btn7.Text;
        }

        private void Btn8(object sender, EventArgs e)
        {
            if (textTotal.Text == "0")

                textTotal.Clear();
            textTotal.Text += btn8.Text;
        }

        private void Btn9(object sender, EventArgs e)
        {
            if (textTotal.Text == "0")

                textTotal.Clear();
            textTotal.Text += btn9.Text;
        }

        //OPERATIONS

        private void Btn_divide(object sender, EventArgs e)
        {
            option = "÷";
            ParseToDecimal(textTotal.Text);
        }
        private void Btn_multiply(object sender, EventArgs e)
        {
            option = "*";
            ParseToDecimal(textTotal.Text);
        }
        private void Btn_subtraction(object sender, EventArgs e)
        {
            option = "-";
            ParseToDecimal(textTotal.Text);
        }
        private void Btn_addition(object sender, EventArgs e)
        {
            option = "+";
            ParseToDecimal(textTotal.Text);
        }
        private void Btn_equals(object sender, EventArgs e)
        {
            num2 = decimal.Parse(textTotal.Text);

            switch (option)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "÷":
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 * (num2 / 100);
                    break;
                default:
                    break;
            }
            textTotal.Text = result.ToString();
        }

        private void ParseToDecimal(string str)
        {
            num1 = decimal.Parse(textTotal.Text);
            textTotal.Clear();
        }

        // PRESS KEYS
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                textTotal.Text = "0";
                option = "";
                num1 = 0;
                num2 = 0;
            }
        }

        private void TextTotal_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the key that was pressed is a number key (0 to 9) or NumPad key
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                // Add the character corresponding to the key that was pressed to the text in the textTotal text box
                // But only if the current text box content is "0"
                if (textTotal.Text == "0" || option != "")
                {
                    textTotal.Text = ((char)e.KeyCode).ToString();
                }

                // Prevent the key event from being processed by other controls
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Add)
            {
                option = e.KeyCode.ToString();
                textTotal.Clear(); // Clear the textTotal field when the "+" key is pressed
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Divide || e.KeyCode == Keys.Oem5)
            {
                option = e.KeyCode.ToString();
                e.Handled = true;
            }

            else if (e.KeyCode == Keys.Enter)
            {
                // Calculate the expression and update the text in the textTotal text box
                string input = textTotal.Text.Trim();
                int operatorIndex = input.LastIndexOfAny(new char[] { '+', '-', '*', '/', '%' });
                string operatorSymbol = input[operatorIndex].ToString();
                result = PerformOperation(num1, num2, operatorSymbol);
                textTotal.Text = result.ToString();

                //if (!IsValidInputFormat(input))
                //{
                //    //MessageBox.Show("Invalid input format. Enter a valid expression with two numbers and an operator (+, -, *, /, %).");
                //    return;
                //}

                // Find the last index of the operator within the input string
                //int operatorIndex = input.LastIndexOfAny(new char[] { '+', '-', '*', '/', '%' });

                // Ensure the operator exists and is not the first or last character
                //if (operatorIndex < 1 || operatorIndex >= input.Length - 1)
                //{
                //    MessageBox.Show("Invalid input format. Enter a valid expression with two numbers and an operator (+, -, *, /, %).");
                //    return;
                //}

                // Extract the numbers and operator from the input
                //string num1String = input.Substring(0, operatorIndex).Trim();
                //string num2String = input.Substring(operatorIndex + 1).Trim();
                //string operatorSymbol = input[operatorIndex].ToString();

                //if (!decimal.TryParse(num1String, out decimal num1) || !decimal.TryParse(num2String.Trim(), out decimal num2))
                //{
                //    MessageBox.Show("Invalid input format. Enter valid decimal numbers.");
                //    return;
                //}

                //if (operatorSymbol == "%")
                //{
                //    // Handle the percentage calculation
                //    //num2 = num1 * (num2 / 100);
                //    //textTotal.Text = num2.ToString();
                //    num2 = decimal.Parse(textTotal.Text);
                //    result = num1 * (num2 / 100);
                //    textTotal.Text = result.ToString();
                //}
                //else
                //{
                //    result = PerformOperation(num1, num2, operatorSymbol);
                //    textTotal.Text = result.ToString();
                //}
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // Reset the textTotal text box to 0
                textTotal.Text = "0";
            }
            else if (e.KeyCode == Keys.Oem5) // The percent sign '%'
            {
                // Handle the percent key
                // If the key that was pressed is the percentage sign (%), then update the textTotal text box with the percentage calculation
                num2 = num1 * (decimal.Parse(textTotal.Text.Trim()) / 100);
                textTotal.Text = num2.ToString();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textTotal.Clear();
            textTotal.Text = "0";
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void decimal_Click(object sender, EventArgs e)
        {
            if (!textTotal.Text.Contains("."))
            {
                textTotal.Text += ".";
            }
        }

        //private void TextDisplay_KeyDown(object sender, KeyEventArgs e)


        private bool IsValidInputFormat(string input)
        {
            // Check if the input string contains a valid operator
            char oper = input.FirstOrDefault(c => c == '+' || c == '-' || c == '*' || c == '/' || c == '%');
            if (oper == '\0')
            {
                return false;
            }

            // Split the input string on the operator
            string[] parts = input.Split(oper);

            // Check if there are two parts in the input string
            if (parts.Length != 2)
            {
                return false;
            }

            // Check if the two parts are valid decimal numbers
            if (!decimal.TryParse(parts[0], out decimal num1) || !decimal.TryParse(parts[1], out decimal num2))
            {
                return false;
            }

            return true;
        }


        private decimal PerformOperation(decimal num1, decimal num2, string input)
        {
            char oper = input.FirstOrDefault(c => c == '+' || c == '-' || c == '*' || c == '/' || c == '%');

            switch (oper)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    throw new InvalidOperationException("Invalid operator.");
            }
        }

        private void Btn_percent(object sender, EventArgs e)
        {
            num2 = decimal.Parse(textTotal.Text);
            result = num1 * (num2 / 100);
            textTotal.Text = result.ToString();
        }

        private void textTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            var keychar = e.KeyChar;
        }
    }
}

