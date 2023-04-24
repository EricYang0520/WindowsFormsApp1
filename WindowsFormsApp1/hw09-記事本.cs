using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class hw09 : Form
    {
        public hw09()
        {
            InitializeComponent();
        }

        

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 搜尋取代ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int P;
            if(textBox1.SelectionLength > 0)
            {
                P = textBox1.Text.IndexOf(textBox2.Text, textBox1.SelectionStart + 1);
            }
            else
            {
                P = textBox1.Text.IndexOf(textBox2.Text, textBox1.SelectionStart);
                if(P<0)
                {
                    MessageBox.Show("未發現搜尋字串!");
                }
                else
                {
                    textBox1.SelectionStart = P;
                    textBox1.SelectionLength = textBox2.Text.Length;
                    textBox1.Select();
                }
            }
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox3.Text;
        }

        int mdx,mdy;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panel1.Left += e.X - mdx;
                panel1.Top += e.Y - mdy;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
          mdx = e.X;
          mdy = e.Y;
        }
        private void 自訂CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            textBox1.Font = fontDialog.Font;
        }

        private void 選項OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }
    }
}
