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
    public partial class 圆形 : Form
    {
        public 圆形()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 圆形_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public double getarea(string unit,double dia)
        { double area = 0;
        switch(unit)
            {
                case "厘米":
                    area = dia * dia * (Math.PI) / 4;
                    break;
                case "英寸":
                    area = 1.27 * 1.27 * dia * dia * (Math.PI);
                    break;
            }
            return area;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double realdia = Convert.ToDouble(textBox1.Text);
            string realarea = comboBox1.Text;
            textBox2.Text = getarea(realarea, realdia).ToString();
        }
    }
}
