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
    public partial class hw0301 : Form
    {
        public hw0301()
        {
            InitializeComponent();

           hw03 h03=new hw03();
            txet01.Text = h03.txt01.Text;
        }

       
    }
}
