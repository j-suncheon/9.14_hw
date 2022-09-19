using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private string[] name = { "나연", "정연", "모모", "사나", "지효", "쯔위", "미나", "다현", "채영" };
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                textBox1.Text += name[i] + " 선생님은 " + (i + 1).ToString() + "반\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string s in name)
            {
                textBox1.Text += s + " 선생님은 "  + "반\r\n";
                
            }
        }
    }
}
