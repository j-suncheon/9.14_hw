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
    public partial class Form11 : Form
    {
        private double iTick = 0;
        private double iTotal = 0;
        private int i1Add = 1;
        private int i1Level = 1;
        private int i3Add = 3;
        private int i3Level = 1;
        private int i50Add = 0;
        private int i50Level = 0;
        public Form11()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i3Add + i50Add;
            iTotal += iTick;
            label1.Text = String.Format("{0} (1:{1}), (3:{2}), (50:{3})", iTick.ToString(), i1Level.ToString(), i3Level.ToString(), i50Level.ToString());
            label2.Text=iTotal.ToString();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (iTotal>100)
            {
                iTotal -= 100;
                i1Level++;
                i1Add = 1 * i1Level;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (iTotal > 300)
            {
                iTotal -= 300;
                i3Level++;
                i3Add = 3 * i3Level;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (iTotal > 5000)
            {
                iTotal -= 5000;
                i50Level++;
                i50Add = 50 * i50Level;
            }
        }
    }
}
