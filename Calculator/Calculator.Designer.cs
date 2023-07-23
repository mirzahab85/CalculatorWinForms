namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textTotal = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn_Decimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTotal
            // 
            this.textTotal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textTotal.Location = new System.Drawing.Point(30, 33);
            this.textTotal.Margin = new System.Windows.Forms.Padding(5);
            this.textTotal.Multiline = true;
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(469, 65);
            this.textTotal.TabIndex = 0;
            this.textTotal.Text = "0";
            this.textTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextTotal_KeyDown);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(31, 228);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(103, 76);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn7);
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(30, 353);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(103, 76);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(30, 478);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 76);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(30, 123);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(103, 76);
            this.button13.TabIndex = 1;
            this.button13.Text = "DEL";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(152, 123);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(103, 76);
            this.clear.TabIndex = 1;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divide.Location = new System.Drawing.Point(397, 123);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(103, 76);
            this.divide.TabIndex = 1;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Btn_divide);
            this.divide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(275, 228);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(103, 76);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9);
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(152, 228);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(103, 76);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8);
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiply.Location = new System.Drawing.Point(397, 228);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(103, 76);
            this.multiply.TabIndex = 1;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Btn_multiply);
            this.multiply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(275, 353);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(103, 76);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6);
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(152, 353);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(103, 76);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5);
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subtraction.Location = new System.Drawing.Point(397, 353);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(103, 76);
            this.subtraction.TabIndex = 1;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.Btn_subtraction);
            this.subtraction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(275, 478);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(103, 76);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(152, 478);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(103, 76);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // btn_Decimal
            // 
            this.btn_Decimal.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Decimal.Location = new System.Drawing.Point(275, 594);
            this.btn_Decimal.Name = "btn_Decimal";
            this.btn_Decimal.Size = new System.Drawing.Size(103, 76);
            this.btn_Decimal.TabIndex = 1;
            this.btn_Decimal.Text = ".";
            this.btn_Decimal.UseVisualStyleBackColor = true;
            this.btn_Decimal.Click += new System.EventHandler(this.decimal_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(30, 594);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(225, 76);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btn0);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equals.Location = new System.Drawing.Point(397, 594);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(103, 76);
            this.equals.TabIndex = 1;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.Btn_equals);
            this.equals.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(397, 478);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(103, 76);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Btn_addition);
            this.add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(31, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(275, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 713);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.add);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn_Decimal);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.textTotal);
            this.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textTotal;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button button13;
        private Button clear;
        private Button divide;
        private Button btn9;
        private Button btn8;
        private Button multiply;
        private Button btn6;
        private Button btn5;
        private Button subtraction;
        private Button btn3;
        private Button btn2;
        private Button btn_Decimal;
        private Button btn0;
        private Button equals;
        private Button add;
        private Button button2;
        private Button button1;
    }
}