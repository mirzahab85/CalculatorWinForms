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
            }
        }

        private void TextTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = textTotal.Text.Trim();

                if (!IsValidInputFormat(input))
                {
                    //MessageBox.Show("Invalid input format. Enter a valid expression with two numbers and an operator (+, -, *, /).");
                    return;
                }

                // Find the index of the operator within the input string
                int operatorIndex = input.IndexOfAny(new char[] { '+', '-', '*', '/' });

                // Ensure the operator exists and is not the first or last character
                if (operatorIndex < 1 || operatorIndex >= input.Length - 1)
                {
                    //MessageBox.Show("Invalid input format. Enter a valid expression with two numbers and an operator (+, -, *, /).");
                    return;
                }

                // Extract the numbers and operator from the input
                string num1String = input.Substring(0, operatorIndex).Trim();
                string num2String = input.Substring(operatorIndex + 1).Trim();
                string operatorSymbol = input[operatorIndex].ToString();

                if (!decimal.TryParse(num1String, out decimal num1) || !decimal.TryParse(num2String, out decimal num2))
                {
                    MessageBox.Show("Invalid input format. Enter valid decimal numbers.");
                    return;
                }

                decimal result = PerformOperation(num1, num2, operatorSymbol);

                textTotal.Text = result.ToString();
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
            return input.Split(new[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 2;
        }

        private decimal PerformOperation(decimal num1, decimal num2, string input)
        {
            char oper = input.FirstOrDefault(c => c == '+' || c == '-' || c == '*' || c == '/');

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
    }
}

