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
    public partial class hw03 : Form
    {
        public hw03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double loanAmountText = double.Parse(txt01.Text);
            double rateText = double.Parse(txt03.Text);
            int periodText = int.Parse(txt02.Text);
            double downpaymentText = double.Parse(txt04.Text);
            MessageBox.Show("PMT=" + PMT(rateText, periodText, loanAmountText, downpaymentText));
            
        }
       
        public static int PMT(double yearlyInterestRate, int totalNumberOfMonths, double loanAmount, double downPayment)
        {
            var rate = (double)yearlyInterestRate / 100 / 12;
            var denominator = Math.Pow((1 + rate), totalNumberOfMonths * 12) - 1;
            double result = (rate + (rate / denominator)) * (loanAmount - downPayment);
            return (int)result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double loanAmountText = double.Parse(txt01.Text);
            double rateText = double.Parse(txt03.Text);
            int periodText = int.Parse(txt02.Text);
            double downpaymentText = double.Parse(txt04.Text);
            double totalAmount = PMT(rateText, periodText, loanAmountText, downpaymentText) * periodText * 12;
            MessageBox.Show("總金額=" + totalAmount);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double loanAmountText = double.Parse(txt01.Text);
            double rateText = double.Parse(txt03.Text);
            int periodText = int.Parse(txt02.Text);
            double downpaymentText = double.Parse(txt04.Text);
            int pmtResult = PMT(rateText, periodText, loanAmountText, downpaymentText);
            int totalAmout = PMT(rateText, periodText, loanAmountText, downpaymentText) * periodText * 12;


            hw0301 h31 = new hw0301();
            h31.txet01.Text = txt01.Text;
            h31.txet02.Text = txt02.Text;
            h31.txet03.Text = txt03.Text;
            h31.txet04.Text = pmtResult.ToString();
            h31.txet05.Text = totalAmout.ToString();
            h31.Show();







        }

        
    }
        





}

