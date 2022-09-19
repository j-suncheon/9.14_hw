using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _9._14_hw
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text += textBox2.Text.ToString() + "\r\n";
                if (checkBox1.Checked==true)
                {
                    textBox1.Text += "true\r\n";
                }
                else
                {
                    textBox1.Text += "false\r\n";
                }
                textBox1.Text += numericUpDown1.Value.ToString() + "\r\n";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:/lecture/C_project/C#/9.14_hw/SF1.txt", textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=File.ReadAllText("C:/lecture/C_project/C#/9.14_hw/SF1.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] st = textBox1.Text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            textBox2.Text = st[0];
            checkBox1.Checked =bool.Parse( st[1]);
            numericUpDown1.Value=int.Parse( st[2]);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
