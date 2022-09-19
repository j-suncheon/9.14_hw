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
    public partial class Form3 : Form
    {
        private enum enDay
        {
            Monday,Tuesday, Wednesday,Thursday,Friday,Saturday,Sunday
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add((enDay)0);
            listBox1.Items.Add((enDay)1);
            listBox1.Items.Add((enDay)2);
            listBox1.Items.Add((enDay)3);
            listBox1.Items.Add((enDay)4);
            listBox1.Items.Add((enDay)5);
            listBox1.Items.Add((enDay)6);

            listBox2.Items.Add("Morning");
            listBox2.Items.Add("Afternoon");
            listBox2.Items.Add("Evening");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text=textBox1.Text+"와 "+listBox1.SelectedItem.ToString()+"(요일) "+ listBox2.SelectedItem.ToString()+"에 만나기로 했습니다.";
        }
    }
}
