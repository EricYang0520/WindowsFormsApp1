using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class hw05 : Form
    {
        public hw05()
        {
            InitializeComponent();
        }

        int btndrink = 0;
        int btndrinkQ = 0;
        string btn = "";
        string btn2 = "";

        private void btndrink1_Click(object sender, EventArgs e)
        {

            btndrink += 500;
            btndrinkQ += 1;
            
            btn += "紅酒*" + btndrinkQ + ",NTD" + btndrink + "\r\n" ;

            txtList.Text = btn;
            txtTotalAmount.Text = "NTD:" + (btndrink02 + btndrink + btndrink03 + btndrink04);

        }
        int btndrink02 = 0;
        int btndrinkQ2 = 0;
        private void btndrink2_Click(object sender, EventArgs e)
        {
   
            btndrink02 += 1000;
            btndrinkQ2 += 1;
            btn +="藍酒*" + btndrinkQ2 + ",NTD" + btndrink02 + "\r\n";
            txtList.Text = btn;
            txtTotalAmount.Text = "NTD:" + (btndrink02 + btndrink + btndrink03 + btndrink04);
            
        }
        int btndrink03 = 0;
        int btndrinkQ3 = 0;
        private void btnjuice3_Click(object sender, EventArgs e)
        {
            btndrink03 += 1500;
            btndrinkQ3 += 1;
            txtList.Text += "黃酒*" + btndrinkQ3 + ",NTD" + btndrink03 + "\r\n";
           
            txtTotalAmount.Text = "NTD:" + (btndrink02 + btndrink +btndrink03 + btndrink04);
        }
        int btndrink04 = 0;
        int btndrinkQ4 = 0;
        private void btnjuice4_Click(object sender, EventArgs e)
        {
            btndrink04 += 2000;
            btndrinkQ4 += 1;
            txtList.Text += "綠酒*" + btndrinkQ4 + ",NTD" + btndrink04 + "\r\n";
            txtTotalAmount.Text = "NTD:" + (btndrink02 + btndrink + btndrink03 + btndrink04);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總共:" + (btndrink02 + btndrink + btndrink03 + btndrink04));
        }

        private void btnCredict_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總共:" + (btndrink02 + btndrink + btndrink03 + btndrink04)*0.9);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtList.Text = "";
            txtTotalAmount.Text = "NTD 0";
        }
    }
}
