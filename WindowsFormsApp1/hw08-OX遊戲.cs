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
    public partial class hw08 : Form
    {
        bool OX = true;



        public hw08()
        {
            InitializeComponent();
        }
        private void testWin()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") MessageBox.Show("X獲勝，你是冠軍!!");
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X") MessageBox.Show("X獲勝，你是冠軍!!");
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") MessageBox.Show("X獲勝，你是冠軍!!");
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X") MessageBox.Show("X獲勝，你是冠軍!!");
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X") MessageBox.Show("X獲勝，你是冠軍!!");
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X") MessageBox.Show("X獲勝，你是冠軍!!");
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") MessageBox.Show("X獲勝，你是冠軍!!");
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") MessageBox.Show("X獲勝，你是冠軍!!");

            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") MessageBox.Show("O獲勝，你是冠軍!!");
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") MessageBox.Show("O獲勝，你是冠軍!!");
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") MessageBox.Show("O獲勝，你是冠軍!!");
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O") MessageBox.Show("O獲勝，你是冠軍!!");
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O") MessageBox.Show("O獲勝，你是冠軍!!");
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O") MessageBox.Show("O獲勝，你是冠軍!!");
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") MessageBox.Show("O獲勝，你是冠軍!!");
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") MessageBox.Show("O獲勝，你是冠軍!!");
        }

        public void btn1_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                btn1.Text = "X";
                OX = false;
            }
            else
            {
                btn1.Text = "O";
                OX = true;
            }
            testWin();
            int count = 9;
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                btn2.Text = "X";
                OX = false;
            }
            else
            {
                btn2.Text = "O";
                OX = true;
            }
            testWin();
            int count = 9;
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                btn3.Text = "X";
                OX = false;
            }
            else
            {
                btn3.Text = "O";
                OX = true;
            }
            testWin();
            int count = 9;
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                btn4.Text = "X";
                OX = false;
            }
            else
            {
                btn4.Text = "O";
                OX = true;
            }
            testWin();
            int count = 9;
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                btn5.Text = "X";
                OX = false;
            }
            else
            {
                btn5.Text = "O";
                OX = true;
            }
            testWin();
            int count = 9;
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                btn6.Text = "X";
                OX = false;
            }
            else
            {
                btn6.Text = "O";
                OX = true;
            }
            testWin();
            int count = 9;
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                btn7.Text = "X";
                OX = false;
            }
            else
            {
                btn7.Text = "O";
                OX = true;
            }
            testWin();
            int count = 9;
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                btn8.Text = "X";
                OX = false;
            }
            else
            {
                btn8.Text = "O";
                OX = true;
            }
            testWin();
            int count = 9;
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                btn9.Text = "X";
                OX = false;
            }
            else
            {
                btn9.Text = "O";
                OX = true;
            }
            testWin();
            int count = 9;
            btn9.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = true;  
                    btn1.Text = "";      
                    btn2.Text = "";
                    btn3.Text = "";
                    btn4.Text = "";
                    btn5.Text = "";
                    btn6.Text = "";
                    btn7.Text = "";
                    btn8.Text = "";
                    btn9.Text = "";
                }
            }

        }
    }      }
