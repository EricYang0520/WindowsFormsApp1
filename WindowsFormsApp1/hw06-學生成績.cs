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
    public partial class hw06 : Form
    {
        public hw06()
        {
            InitializeComponent();
        }
        string Name = "";
        double ch, en, ma = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            double[] arr = { ch,en,ma };
            showTextBox2.Text = "最高分:" + arr.Max() + "\n" + "最低分:" + arr.Min();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Click += new EventHandler(button1_Click);
            button2.Click += Button2_Click;

            Name = txtName.Text;
            ch = double.Parse(txtChinese.Text);
            en = double.Parse(txtEnglish.Text);
            ma = double.Parse(txtMath.Text);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            showTextBox1.Text = "我的姓名:" + Name + "\n" + "國文:" + ch + "\n" + "英文:" + en + "\n" + "數學:" + ma;
        }
    }
}
