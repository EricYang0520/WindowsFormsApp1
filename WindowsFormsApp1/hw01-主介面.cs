using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class hw01 : Form
    {
        public hw01()
        {
            InitializeComponent();
        }

        private void homework02_Click(object sender, EventArgs e)
        {
            hw02 frm = new hw02();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hw04 frm = new hw04();  
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hw03 frm = new hw03();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hw05 frm = new hw05();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hw06 frm = new hw06();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hw07螢幕保護程式 frm = new hw07螢幕保護程式();
             frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hw08 frm = new hw08();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hw09 frm = new hw09();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hw10 frm = new hw10();
            frm.Show();
        }
    }
}
