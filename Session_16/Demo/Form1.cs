using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        private Color brushSelectedColor;
        private Graphics graphic;
        private SolidBrush brush;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.graphic = pnlDrawing.CreateGraphics();
            this.brush = new SolidBrush(this.brushSelectedColor);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblSelectedColor.BackColor = Color.Red;
            this.brushSelectedColor = Color.Red;
            this.brush = new SolidBrush(this.brushSelectedColor);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblSelectedColor.BackColor = Color.Blue;
            this.brushSelectedColor = Color.Blue;
            this.brush = new SolidBrush(this.brushSelectedColor);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            lblSelectedColor.BackColor = Color.Green;
            this.brushSelectedColor = Color.Green;
            this.brush = new SolidBrush(this.brushSelectedColor);

        }

        private void pnlDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.graphic.FillPie(this.brush, e.X, e.Y, 50, 50, 0, 360);
            }
        }
    }
}
