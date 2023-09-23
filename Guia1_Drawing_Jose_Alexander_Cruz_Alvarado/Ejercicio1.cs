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
    public partial class Ejercicio1 : Form
    {
        int x, y;

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
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            int randomSize = random.Next(50, 100);

            if (listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(randomColor);
                g.DrawEllipse(lapiz, x - 50, y - 50, randomSize, randomSize);
                g.FillEllipse(sb, x - 50, y - 50, randomSize, randomSize);
            }

            if (listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(randomColor);
                g.DrawRectangle(lapiz, x - 50, y - 50, randomSize, randomSize);
                g.FillRectangle(sb, x - 50, y - 50, randomSize, randomSize);
            }
        }

        public Ejercicio1()
        {
            InitializeComponent();
        }
    }
}
