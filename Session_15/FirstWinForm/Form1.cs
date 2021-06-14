using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            button1.Text = "Test Text";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToInt32(textBox1.Text);
            var number2 = Convert.ToInt32(textBox2.Text);
            label3.Text = (number1 + number2).ToString();

        }
    }
}
