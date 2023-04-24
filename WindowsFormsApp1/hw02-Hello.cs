using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class hw02 : Form
    {
        public hw02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            string name = textBox1.Text;
            string Ename = textBox2.Text;
            string sex = textBox3.Text;
            string sign = textBox4.Text;

            MessageBox.Show("Hello," + "我是" + name + "\n" + "我的英文名字是" + Ename + "\n" +"我的性別是" + sex + "\n" + "我的星座是" + sign);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string Ename = textBox2.Text;
            string sex = textBox3.Text;
            string sign = textBox4.Text;

            MessageBox.Show("Hi," + "我是" + name + "\n" + "我的英文名字是" + Ename + "\n" + "我的性別是" + sex + "\n" + "我的星座是" + sign);
        }

        
    }
}
