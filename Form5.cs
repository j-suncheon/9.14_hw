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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(numericUpDown1.Value);
            double b = Convert.ToDouble(numericUpDown2.Value);

            if (a>b)
            {
                label3.Text = "Number1)가 Number2)보다 크다.";
            }
            else if (a<b)
            {
                label3.Text = "Number2)가 Number1)보다 크다.";
            }
            else
            {
                label3.Text = "Number1)와 Number2)는 같다.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text.ToString())
            {
                case "월": case "화": case "수": case "목":case "금": label5.Text = "평일입니다.";
                    break;
                default:
                    label5.Text = "주말입니다.";
                    break;
            }
        }
    }
}
