using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.GUI
{
    public partial class Form1 : Form
    {
        Calculator myCalculator = new Calculator();

        public Form1()
        {
            InitializeComponent();

            button1.Text = "+";
            button2.Text = "-";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string op = button1.Text;
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int result = myCalculator.Add(x, y);

            listBox1.Items.Add(string.Format("{0} {3} {1} = {2}", x, y, result, op));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int result = myCalculator.Sub(x, y);

            listBox1.Items.Add(string.Format("{0} - {1} = {2}", x, y, result));
        }
    }
}
