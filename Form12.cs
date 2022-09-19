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
    public partial class Form12 : Form
    {
        Queue<int> que=new Queue<int>(6);
        Stack<int> sta=new Stack<int>(6);
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd=new Random();
            int iData = rd.Next(1, 101);

            if (que.Count<6)
            {
                que.Enqueue(iData);
                fQueueDataDisplay();
            }
            if (sta.Count<6)
            {
                sta.Push(iData);
                fStackDataDisplay();
            }
        }
        private void fQueueDataDisplay()
        {
            int[] iArray = que.ToArray();
            Array.Resize(ref iArray, 6);
            label1.Text = (iArray[0] == 0) ? "" : iArray[0].ToString();
            label2.Text = (iArray[1] == 0) ? "" : iArray[0].ToString();
            label3.Text = (iArray[2] == 0) ? "" : iArray[0].ToString();
            label4.Text = (iArray[3] == 0) ? "" : iArray[0].ToString();
            label5.Text = (iArray[4] == 0) ? "" : iArray[0].ToString();
            label6.Text = (iArray[5] == 0) ? "" : iArray[0].ToString();
        }

        private void fStackDataDisplay()
        {
            int[] iArray = sta.ToArray();
            Array.Resize(ref iArray, 6);

            label7.Text = (iArray[0] == 0) ? "" : iArray[0].ToString();
            label8.Text = (iArray[1] == 0) ? "" : iArray[0].ToString();
            label9.Text = (iArray[2] == 0) ? "" : iArray[0].ToString();
            label10.Text = (iArray[3] == 0) ? "" : iArray[0].ToString();
            label11.Text = (iArray[4] == 0) ? "" : iArray[0].ToString();
            label12.Text = (iArray[5] == 0) ? "" : iArray[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fDataOut();
        }
        private void fDataOut()
        {
            if (que.Count>0)
            {
                que.Dequeue();
                fQueueDataDisplay();
            }
            if (sta.Count>0)
            {
                sta.Pop();
                fStackDataDisplay();
            }
        }
        System.Windows.Forms.Timer ot = new System.Windows.Forms.Timer();
        bool bt=false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (bt)
            {
                ot.Stop();
                bt = false;
            }
            else
            {
                ot.Interval = 2000;
                ot.Tick += ot_Tick;
                ot.Start();
                bt = true;
            }
        }
        private void ot_Tick(object sender, EventArgs e)
        {
            fDataOut();
        }
    }
}
