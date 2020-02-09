using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak2TextBoxKontrole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string var;
            var = textBox1.Text;
            string var1;
            var1 = textBox2.Text;
            MessageBox.Show(""+var + var1);
        }
    }
}
