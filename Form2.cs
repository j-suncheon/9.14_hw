﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._14_hw
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt32(textBox2.Text) / Convert.ToInt32(textBox3.Text)).ToString();
        }
    }
}
