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

    public partial class Form9 : Form
    {
        cData da=new cData();
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));
            foreach (EnumItem oitem in ei)
            {
                comboBox1.Items.Add(oitem.ToString());
            }
            foreach(EnumRate oitem in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                comboBox2.Items.Add(oitem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.fDataResult();

            da.StrItem=comboBox1.Text;
            da.IRate = (int)Enum.Parse(typeof(EnumRate), comboBox2.Text);
            da.ICount = (int)numericUpDown1.Value;
            if (!String.IsNullOrEmpty(da.StrErrorName))
            {
                textBox1.Text = da.StrErrorName;
                return;
            }
            double dPrice = da.fItemPrice();
            listBox1.Items.Add(da.fResult(dPrice));
            da.DTotalPrice = dPrice;
            textBox1.Text=da.DTotalPrice.ToString()+"원";
        }
    }
    public enum EnumItem
    {
        고기 = 10000,
        과자=3000,
        계란=5000,
        물=800,
        라면=3500,
        즉석식품=6500,
        냉동식품=8500,
    }
    public enum EnumRate
    {
        없음=0,
        할인_3=3,
        할인_5=5,
        할인_10=10,
        할인_20=20,
        사장할인_80=80,
    }
    partial class cData
    {
        private double dTotalPrice = 0.0;
        public double DTotalPrice
        {
            get => dTotalPrice;
            set
            {
                dTotalPrice = dTotalPrice + value;
            }
        }
        private string strItem = string.Empty;
        public string StrItem
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    strErrorName = "물건이 선택되지 않았습니다.";
                }
                else
                {
                    strItem= value;
                }
            }
        }
        private int iRate = 0;
        public int IRate
        {
            set
            {
                if (value>20)
                {
                    strErrorName = "사장님";
                }
                else
                {
                    iRate = value;
                }
            }
        }
        private int iCount = 0;
        public int ICount
        {
            set
            {
                if (value>5)
                {
                    strErrorName = "5개이하";
                }
                else if (value==0)
                {
                    strErrorName = "0개";
                }
                else
                {
                    iCount = value;
                }
            }
        }
        private string strErrorName = string.Empty;
        public string StrErrorName
        {
            get => strErrorName;
        }

        public double fItemPrice()
        {
            double dPrice = 0;
            int iItemPrice = 0;
            if (string.IsNullOrEmpty(strErrorName))
            {
                iItemPrice = (int)Enum.Parse(typeof(EnumItem), strItem);
                dPrice = iItemPrice - Math.Round((double)iItemPrice * (double)iRate / 100, 2);
            }
            return dPrice * iCount;
        }

        public string fResult(double dPrice)
        {
            if (iRate == 0)
            {
                return string.Format("{0} X {1} : {2}원", strItem, iCount, dPrice);
            }
            else
            {
                return string.Format("{0} X {1} : {2}원 (할인율 : {3}%)", strItem, iCount, dPrice, iRate);
            }
        }
        public void fDataResult()
        {
            strErrorName = string.Empty;
            strItem = string.Empty;
            iRate = 0;
            iCount = 0;
        }
    }
}