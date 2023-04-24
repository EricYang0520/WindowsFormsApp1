using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class hw04 : Form
    {
        public hw04()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            float b = 0;
            bool Add = float.TryParse(textBox1.Text, out b);
            
            if (Add)
            {
                float text1 = float.Parse(textBox1.Text.ToString());
                float text2 = float.Parse(textBox2.Text.ToString());
                float answer = 0;
                float a = text1 + text2;
                textBox3.Text = a.ToString();
                
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float text1 = float.Parse(textBox1.Text);
            float text2 = float.Parse(textBox2.Text);
            float answer = 0;
            float a = text1 - text2;
            textBox3.Text = a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float text1 = float.Parse(textBox1.Text);
            float text2 = float.Parse(textBox2.Text);
            float answer = 0;
            float a = text1 * text2;
            textBox3.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float text1 = float.Parse(textBox1.Text);
            float text2 = float.Parse(textBox2.Text);
            float answer = 0;
            float a = text1 / text2;
            textBox3.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
    }
}
