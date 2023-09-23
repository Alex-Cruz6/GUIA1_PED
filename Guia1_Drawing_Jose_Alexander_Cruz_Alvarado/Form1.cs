using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_Drawing_Jose_Alexander_Cruz_Alvarado
{
    public partial class Form1 : Form
    {
        int x, y; //variables globales que permiten determinar la ubicación del click

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);

            if (listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(Color.Red);
                g.DrawEllipse(lapiz, x - 50, y - 50, 100, 100);
                g.FillEllipse(sb, x - 50, y - 50, 100, 100);
            }

            if (listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(Color.Green);
                g.DrawRectangle(lapiz, x - 50, y - 50, 100, 100);
                g.FillRectangle(sb, x - 50, y - 50, 100, 100);
            }
        }
    }
}
