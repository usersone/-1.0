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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            三角形 mypic = new 三角形();
            mypic.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            正方形 mypic = new 正方形();
            mypic.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            长方形 mypic = new 长方形();
            mypic.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            圆形 mypic = new 圆形();
            mypic.ShowDialog();
        }
    }
}
