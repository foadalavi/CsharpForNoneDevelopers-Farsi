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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this._x = e.X;
                this._y = e.Y;
                _g.FillPie(_b, this._x, this._y, 30, 50,0,360);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _g = this.CreateGraphics();
            _b = new SolidBrush(Color.Red);
        }
    }
}
