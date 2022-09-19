using System.Diagnostics;

namespace _9._14_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                label_Sh.Text = ((short)Convert.ToDouble(textBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                label_In.Text = ((int)Convert.ToDouble(textBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                label_Do.Text = Convert.ToDouble(textBox1.Text).ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label_Sh.Text = ((short)Convert.ToDouble(textBox1.Text)).ToString();
                label_In.Text = ((int)Convert.ToDouble(textBox1.Text)).ToString();
                label_Do.Text = Convert.ToDouble(textBox1.Text).ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}