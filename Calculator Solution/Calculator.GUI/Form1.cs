﻿using System;
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
        public Form1()
        {
            InitializeComponent();

            button1.Text = "+";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Add operationen
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            int result = x + y;

            listBox1.Items.Add(string.Format("{0} + {1} = {2}", x, y, result));
        }
    }
}
