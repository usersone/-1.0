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
    public partial class 长方形 : Form
    {
        public 长方形()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            double c, d;

            if (unit1.Text == "cm")
                c = a;
            else
                c = 2.540 * a;
            if (unit2.Text == "cm")
                d = b;
            else
                d = 2.540 * b;


            double areavalue =  c*d;
                     textBox3.Text = areavalue.ToString("0.000");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 长方形_Load(object sender, EventArgs e)
        {

        }
    }
}
