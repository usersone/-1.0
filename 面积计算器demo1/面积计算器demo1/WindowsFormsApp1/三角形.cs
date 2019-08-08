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
    public partial class 三角形 : Form
    {
        public 三角形()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double trans1,trans2;
            if (unit1.Text == "cm")
            {
                trans1 = 1.0;
            }
            else
                trans1 = 2.54;
            if (unit2.Text == "cm")
            {
                trans2 = 1.0;
            }
            else
                trans2 = 2.54;
            double areavalue=Double.Parse(bottom.Text) * Double.Parse(height.Text)/2*trans1*trans2;
            area.Text = areavalue.ToString("0.000");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Height_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
