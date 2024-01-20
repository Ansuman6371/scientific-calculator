*   using System;
*   using System.Collections.Generic;
*   using System.ComponentModel;
*   using System.Data;
*   using System.Drawing;
*     using System.Linq;
*   using System.Text;
*   using System.Threading.Tasks;
*   using System.Windows.Forms;
*
*   namespace Scientificcalculator
*	{
* public partial class Form1 : Form
*
{
*	        double a, b, c;
*	        string d;
*	        public Form1()
*	        {
*	            InitializeComponent();
*	        }
* public void process(string s)
*	        {
*	            if (T.Text.Contains("-"))
* T2.Text = T.Text;
* d = s;
*	            if (d == "/")
* T2.Text += "/";
*	            if (d == "*")
* T2.Text += "*";
*	            if (d == "+")
* T2.Text += "+";
*	            if (d == "-")
* T2.Text += "-";
* a = Convert.ToDouble(T.Text);
* T.Clear();
*
}
*
*           private void textBox1_TextChanged(object sender, EventArgs e)
*           {
    *
    *           }
*
*           private void button22_Click(object sender, EventArgs e)
*           {
    *KeyEnter(0);
    *           }
*
*            private void KeyEnter(int i)
*           {
    *               if (T.Text == "0")
        *               {
        *T.Text = i.ToString();
        *T2.Text = i.ToString();
        *               }
    *               else
        *               {
        *T.Text = i.ToString();
        *T2.Text = i.ToString();
        *               }
    *T.Text += i.ToString();
    *           }
*
*           private void button19_Click(object sender, EventArgs e)
*           {
    *KeyEnter(3);
    *           }
*
*           private void OneButton_Click(object sender, EventArgs e)
*           {
    *KeyEnter(1);
    *           }
*
*            private void TwoButton_Click(object sender, EventArgs e)
*           {
    *KeyEnter(2);
    *           }
*
*           private void SixButton_Click(object sender, EventArgs e)
*            {
    *KeyEnter(6);
    *           }
*
*           private void FiveButton_Click(object sender, EventArgs e)
*           {
    *KeyEnter(5);
    *           }
*
*           private void FourButton_Click(object sender, EventArgs e)
*           {
    *KeyEnter(4);
    *           }
*
*           private void NineButton_Click(object sender, EventArgs e)
*           {
    *KeyEnter(9);
    *           }
*
*           private void EightButton_Click(object sender, EventArgs e)
*           {
    *KeyEnter(8);
    *           }
*
*           private void Divide_Click(object sender, EventArgs e)
*           {
    *process("/");
    *           }
*
*           private void Mult_Click(object sender, EventArgs e)
*           {
    *process("*");
    *           }
*
*           private void Plus_Click(object sender, EventArgs e)
*           {
    *process("+");
    *           }
*
*           private void Minus_Click(object sender, EventArgs e)
*           {
    *process("-");
    *           }
*
*           private void EqualButton_Click(object sender, EventArgs e)
*           {
    *T2.Clear();
    *b = Convert.ToDouble(T.Text);
    *               switch(d)
    *               {
*                   case "/":
*c = a / b;
    *                       break;
    *                   case "*":
*c = a * b;
    *                       break;
    *                   case "+":
*c = a + b;
    *                       break;
    *                   case "-":
*c = a - b;
    *                       break;
    *               }
*T.Text = c.ToString();
*           }
*
*           private void Factorial_Click(object sender, EventArgs e)
*           {
    *double h = Convert.ToDouble(T.Text);
    *T2.Text = h + "!";
    *double fact = 1;
    *               for (; h > 0.0; h--)
        *               {
        *fact = fact * h;
        *               }
    *T.Text = fact.ToString();
    *           }
*
*           private void Pi_Click(object sender, EventArgs e)
*           {
    *T.Text = "3.141592653";
    *           }
*
*           private void UnderRoot_Click(object sender, EventArgs e)
*           {
    *double h = Convert.ToDouble(T.Text);
    *T2.Text = "√" + h;
    *h = Convert.ToDouble(System.Math.Sqrt(h));
    *T.Text = h.ToString();
    *           }
*
*           private void Inverse_Click(object sender, EventArgs e)
*            {
    *double h = Convert.ToDouble(T.Text);
    *T2.Text = "Inv(" + h + ")";
    *h = 1 / h;
    *T.Text = h.ToString();
    *           }
*
*           private void Cube_Click(object sender, EventArgs e)
*           {
    *double h = Convert.ToDouble(T.Text);
    *T2.Text = "Cube(" + h + ")";
    *h = h * h * h;
    *T.Text = h.ToString();
    *           }
*
*           private void Square_Click(object sender, EventArgs e)
*           {
    *double h = Convert.ToDouble(T.Text);
    *T2.Text = "Sqrt(" + h + ")";
    *h = h * h;
    *T.Text = h.ToString();
    *           }
*
*           private void PlusMinusButton_Click(object sender, EventArgs e)
*           {
    *               if (!T.Text.Contains("-"))
        *T.Text = "-" + T.Text.Trim('+');
    *               else
        *T.Text = "+" + T.Text.Trim('-');
    *           }
*
*           private void SevenButton_Click(object sender, EventArgs e)
*           {
    *KeyEnter(7);
    *           }
*
*           private void AC_Click(object sender, EventArgs e)
*           {
    *T.Clear();
    *T.Text = "0";
    *           }
*       }
*   }
*
*
