﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_7_Task_1
{
    public partial class CalculatorForm : Form
    {
        private Calculator calc;
        private string result;

        public CalculatorForm()
        {
            calc = new Calculator();
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            result = calc.TryCalculate((sender as Button).Text);
            textBox.Text = result;
        }

        private void button16Click(object sender, EventArgs e)
        {
            result = "";
            textBox.Clear();
        }
    }
}
