using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class hw07螢幕保護程式 : Form
    {
        public hw07螢幕保護程式()
        {
            InitializeComponent();
        }

        private void homework08_螢幕保護程式_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Text = DateTime.Now.ToString();
            pictureBox1.Left += 5;
            if (pictureBox1.Right < 0) { pictureBox1.Left = this.ClientSize.Width; }
            pictureBox1.Left += 5;
            if (pictureBox1.Right < 0) { pictureBox1.Left = this.ClientSize.Width; }
        }

        private void homework08_螢幕保護程式_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
