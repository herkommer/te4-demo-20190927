using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Component;

namespace Calculator.GUI
{
    public partial class Form1 : Form
    {
        Calculator.Component.Calculator myCalculator = new Calculator.Component.Calculator();

        public Form1()
        {
            InitializeComponent();

            button1.Text = "+";
            button2.Text = "-";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string op = ((Button)sender).Text;
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int result = myCalculator.Add(x, y);
            ShowResult(op, x, y, result);
        }

        private void ShowResult(string op, int x, int y, int result)
        {
            listBox1.Items.Add(string.Format("{0} {3} {1} = {2}", x, y, result, op));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button b;
            b = (Button)sender;
            string op = b.Text;
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int result = myCalculator.Sub(x, y);

            ShowResult(op, x, y, result);
        }
    }
}
