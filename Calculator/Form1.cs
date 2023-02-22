/*
Файл: Form1.cs
Лабораторная робота № 1
Автор: Положий А. С.
Тема: Розробка та дослідження лінійних програм
Дата створення: 09.02.2023
*/

using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Calculator.Operations;

namespace Calculator
{
    public partial class Form1 : Form
    {
        #region Code for moving the control panel
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        double result = 0;
        string operation = "";
        string fstNum, secNum;
        bool enterValue = false;
        const double minValue = -300000;
        const double maxValue = 500000;

        public Form1()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.TextLength != 0 && TxtDisplay1.Text[TxtDisplay1.TextLength - 1] == '.')
                TxtDisplay1.Text = TxtDisplay1.Text.Substring(0, TxtDisplay1.TextLength - 1);

            CustomButton button = (CustomButton)sender;
            operation = button.Text;

            if (Check())
            {
                if(!(operation == "-" && TxtDisplay1.Text == ""))
                {
                    MessageBox.Show("Некорректный ввод!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (result != 0)
                BtnEquals.PerformClick();
            else if (TxtDisplay1.Text != "")
                result = Math.Round(double.Parse(TxtDisplay1.Text, NumberStyles.Any, CultureInfo.InvariantCulture), 3);

            enterValue = true;
            if (operation == "-" && TxtDisplay1.Text == "" && TxtDisplay2.Text == "")
                TxtDisplay1.Text = operation;
            else if (TxtDisplay1.Text != "Err")
            {
                TxtDisplay2.Text = fstNum = $"{result} {operation}".Replace(",", ".");
                TxtDisplay1.Text = "";
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.TextLength != 0 && TxtDisplay1.Text[TxtDisplay1.TextLength - 1] == '.')
                TxtDisplay1.Text = TxtDisplay1.Text.Substring(0, TxtDisplay1.TextLength - 1);

            if (Check())
            {
                MessageBox.Show("Некорректный ввод!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(TxtDisplay2.Text == "")
            {
                return;
            }

            secNum = TxtDisplay1.Text;

            if (TxtDisplay1.Text != "" && !TxtDisplay2.Text.Contains("="))
            {
                TxtDisplay2.Text = $"{TxtDisplay2.Text} {TxtDisplay1.Text} = ";

                switch (operation)
                {
                    case "+":
                        TxtDisplay1.Text = Add(result.ToString().Replace(",", "."), TxtDisplay1.Text);
                        RtBoxDisplayHistory.AppendText($" {fstNum.Replace(",", ".")} {secNum.Replace(",", ".")} = {TxtDisplay1.Text}\n");
                        break;
                    case "-":
                        TxtDisplay1.Text = Sub(result.ToString().Replace(",", "."), TxtDisplay1.Text);
                        RtBoxDisplayHistory.AppendText($" {fstNum.Replace(",", ".")} {secNum.Replace(",", ".")} = {TxtDisplay1.Text}\n");
                        break;
                    case "×":
                        TxtDisplay1.Text = Mul(result.ToString().Replace(",", "."), TxtDisplay1.Text);
                        RtBoxDisplayHistory.AppendText($" {fstNum.Replace(",", ".")} {secNum.Replace(",", ".")} = {TxtDisplay1.Text}\n");
                        break;
                    case "÷":
                        TxtDisplay1.Text = Div(result.ToString().Replace(",", "."), TxtDisplay1.Text);
                        if (TxtDisplay1.Text == "Err")
                            MessageBox.Show("Нельзя делить на 0!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RtBoxDisplayHistory.AppendText($" {fstNum.Replace(",", ".")} {secNum.Replace(",", ".")} = {TxtDisplay1.Text}\n");
                        break;
                    default:
                        TxtDisplay2.Text = $"{TxtDisplay1.Text} = ";
                        break;
                }

                if (TxtDisplay1.Text != "Err")
                    result = Math.Round(double.Parse(TxtDisplay1.Text, NumberStyles.Any, CultureInfo.InvariantCulture), 3);
                else
                    result = 0;
                operation = "";
            }
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 0) ? PnlHistory.Height = 360 : 0;
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text.Length > 0)
                TxtDisplay1.Text = TxtDisplay1.Text.Remove(TxtDisplay1.Text.Length - 1, 1);
            else
                TxtDisplay1.Text = "0";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "0";
            TxtDisplay2.Text = "";
            fstNum = "";
            secNum = "";
            operation = "";
            result = 0;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "0";
        }

        private void BtnOperations_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.TextLength != 0 && TxtDisplay1.Text[TxtDisplay1.TextLength - 1] == '.')
                TxtDisplay1.Text = TxtDisplay1.Text.Substring(0, TxtDisplay1.TextLength - 1);

            if (Check())
            {
                MessageBox.Show("Некорректный ввод!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CustomButton button = (CustomButton)sender;
            string op = button.Text;

            if (TxtDisplay1.Text != "")
            {
                switch (op)
                {
                    case "%":
                        TxtDisplay2.Text = $"%{TxtDisplay1.Text}";
                        TxtDisplay1.Text = Convert.ToString(Math.Round(double.Parse(TxtDisplay1.Text, NumberStyles.Any, CultureInfo.InvariantCulture) / 100.0, 3)).Replace(",", ".");
                        result = 0;
                        break;
                    case "+/-":
                        if (TxtDisplay2.Text.Contains("=") || TxtDisplay2.Text.Contains("cos")
                            || TxtDisplay2.Text.Contains("sin") || TxtDisplay2.Text.Contains("%")
                            || TxtDisplay2.Text.Contains("log") || TxtDisplay2.Text.Contains("=")
                            || TxtDisplay2.Text.Contains("√") || TxtDisplay2.Text.Contains("∛")
                            || TxtDisplay2.Text.Contains("²") || TxtDisplay2.Text.Contains("³"))
                        {
                            TxtDisplay2.Text = "";
                            result = 0;
                        }
                        if(double.Parse(TxtDisplay1.Text, NumberStyles.Any, CultureInfo.InvariantCulture) <= 300000)
                            TxtDisplay1.Text = Inverse(TxtDisplay1.Text);
                        //if (TxtDisplay2.Text != "" && double.Parse(TxtDisplay1.Text, NumberStyles.Any, CultureInfo.InvariantCulture) <= 300000)
                            //secNum = Inverse(TxtDisplay1.Text);
                        break;
                    case "sin":
                        TxtDisplay2.Text = $"sin({TxtDisplay1.Text})";
                        TxtDisplay1.Text = Sin(TxtDisplay1.Text);
                        result = 0;
                        break;
                    case "cos":
                        TxtDisplay2.Text = $"cos({TxtDisplay1.Text})";
                        TxtDisplay1.Text = Cos(TxtDisplay1.Text);
                        result = 0;
                        break;
                }
                if (op != "+/-")
                    RtBoxDisplayHistory.AppendText($" {TxtDisplay2.Text} = {TxtDisplay1.Text}\n");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TitlePicture_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.Text == "Err")
                TxtDisplay1.Text = "0";
            else if (TxtDisplay1.Text == "-")
                TxtDisplay1.Text = "-";
            else if (Check())
            {
                MessageBox.Show("Некорректный ввод!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CustomButton button = (CustomButton)sender;

            if ((TxtDisplay1.Text == "0" || enterValue) && button.Text != "." && TxtDisplay1.Text != "-")
                TxtDisplay1.Text = "";

            enterValue = false;

            if (TxtDisplay2.Text.Contains("=") || TxtDisplay1.Text == "Err" || TxtDisplay2.Text.Contains("cos") || TxtDisplay2.Text.Contains("sin"))
            {
                TxtDisplay2.Text = "";
                result = 0;
            }

            if (button.Text == ".")
            {
                if (!TxtDisplay1.Text.Contains(".") && TxtDisplay1.Text != "")
                {
                    double num = 0;
                    if (TxtDisplay1.Text == "-")
                        return;
                    if (TxtDisplay1.Text != "")
                        num = double.Parse(TxtDisplay1.Text, NumberStyles.Any, CultureInfo.InvariantCulture);

                    if (num >= maxValue)
                        return;
                    else if (num <= minValue)
                        return;
                    else
                        TxtDisplay1.Text += button.Text;
                }
            }
            else if (button.Text == "e")
            {
                if (TxtDisplay2.Text == "")
                    result = 0;
                TxtDisplay1.Text = "";
                TxtDisplay1.Text += "2.718";
            }
            else if (button.Text == "π")
            {
                if (TxtDisplay2.Text == "")
                    result = 0;
                TxtDisplay1.Text = "";
                TxtDisplay1.Text += "3.141";
            }
            else
            {
                if (TxtDisplay1.Text.Contains("."))
                {
                    string afterDot = TxtDisplay1.Text.Substring(TxtDisplay1.Text.IndexOf("."));
                    if (afterDot.Length > 3)
                        return;
                    else
                        TxtDisplay1.Text += (string)button.Tag;
                }
                else
                {
                    double num = 0;
                    if (TxtDisplay1.Text != "")
                        num = double.Parse(TxtDisplay1.Text + (string)button.Tag, NumberStyles.Any, CultureInfo.InvariantCulture);

                    if (num > maxValue)
                        return;
                    else if (num < minValue)
                        return;
                    else
                        TxtDisplay1.Text += (string)button.Tag;
                }
            }

        }

        private void TxtDisplay1KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Check())
            {
                e.KeyChar = (char)Keys.None;
                return;
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-' || e.KeyChar == '.')
            {
                string s = TxtDisplay1.Text;
                double num = 0;

                if (e.KeyChar == '.')
                {
                    if (s.Contains(".") || s.Length == 0)
                        e.KeyChar = (char)Keys.None;

                    num = 0;
                    if (TxtDisplay1.Text != "")
                        num = double.Parse(TxtDisplay1.Text, NumberStyles.Any, CultureInfo.InvariantCulture);

                    if (num >= maxValue)
                        e.KeyChar = (char)Keys.None;
                    else if (num <= minValue)
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar == '-')
                {
                    s = TxtDisplay1.Text;
                    //если длина строки больше 0, то "-" не ввести
                    if (s.Length > 0)
                        e.KeyChar = (char)Keys.None;
                }
                if (Char.IsDigit(e.KeyChar))
                {
                    if (TxtDisplay1.Text.Contains("."))
                    {
                        string afterDot = TxtDisplay1.Text.Substring(TxtDisplay1.Text.IndexOf("."));
                        if (afterDot.Length > 3)
                            e.KeyChar = (char)Keys.None;
                    }
                    else
                    {
                        num = 0;
                        if (TxtDisplay1.Text != "")
                            num = double.Parse(TxtDisplay1.Text + e.KeyChar.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture);
                        if (num > maxValue)
                            e.KeyChar = (char)Keys.None;
                        else if (num < minValue)
                            e.KeyChar = (char)Keys.None;
                    }
                }
            }
            else
                // символ заменяем на "пустой символ" - клавиша не нажата
                e.KeyChar = (char)Keys.None;
        }

        private void AdditionalOperations_Click(object sender, EventArgs e)
        {
            if (TxtDisplay1.TextLength != 0 && TxtDisplay1.Text[TxtDisplay1.TextLength - 1] == '.')
                TxtDisplay1.Text = TxtDisplay1.Text.Substring(0, TxtDisplay1.TextLength - 1);

            if (Check())
            {
                MessageBox.Show("Некорректный ввод!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CustomButton button = (CustomButton)sender;
            string op = button.Text;

            if (TxtDisplay1.Text != "")
            {
                switch (op)
                {
                    case "x²":
                        TxtDisplay2.Text = $"({TxtDisplay1.Text})² = ";
                        TxtDisplay1.Text = Square(TxtDisplay1.Text);
                        break;
                    case "x³":
                        TxtDisplay2.Text = $"({TxtDisplay1.Text})³ = ";
                        TxtDisplay1.Text = Cube(TxtDisplay1.Text);
                        break;
                    case "√x":
                        TxtDisplay2.Text = $"√({TxtDisplay1.Text}) = ";
                        TxtDisplay1.Text = Sqrt(TxtDisplay1.Text);
                        if (TxtDisplay1.Text == "Err")
                            MessageBox.Show("Квадратный корень не может быть отрицательным!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "∛x":
                        TxtDisplay2.Text = $"∛({TxtDisplay1.Text}) = ";
                        TxtDisplay1.Text = CubeRoot(TxtDisplay1.Text);
                        break;
                    case "1/x":
                        TxtDisplay2.Text = $"1 ÷ {TxtDisplay1.Text} = ";
                        TxtDisplay1.Text = Fraction(TxtDisplay1.Text);
                        if (TxtDisplay1.Text == "Err")
                            MessageBox.Show("Нельзя делить на 0!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "lg(x)":
                        TxtDisplay2.Text = $"lg({TxtDisplay1.Text}) = ";
                        TxtDisplay1.Text = Log10(TxtDisplay1.Text);
                        if (TxtDisplay1.Text == "Err")
                            MessageBox.Show("Подлогарифмическое выражение не должно быть меньше или равно 0!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                result = 0;
                RtBoxDisplayHistory.AppendText($" {TxtDisplay2.Text}{TxtDisplay1.Text}\n");
            }
        }

        private bool Check()
        {
            if (TxtDisplay1.Text == "") return false;

            try
            {
                double.Parse(TxtDisplay1.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                return true;
            }

            return false;
        }
    }
}