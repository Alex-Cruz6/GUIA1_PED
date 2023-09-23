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
    public partial class Form3 : Form
    {
        enum Posicion
        {
            izquierda, derecha, arriba, abajo
        }

        private int x;
        private int y;
        private Posicion objposicion;

        public Form3()
        {
            InitializeComponent();
            x = 50; 
            y = 50;
            objposicion = Posicion.abajo;
        }

        private void timermov_Tick(object sender, EventArgs e)
        {
            if(objposicion == Posicion.derecha)
            {
                x += 10;
            }
            else if(objposicion == Posicion.izquierda)
            {
                x -= 10;
            }
            else if (objposicion == Posicion.arriba)
            {
                y -= 10;
            }
            else if (objposicion == Posicion.abajo)
            {
                y += 10;
            }

            Invalidate();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("Pokemon.png"), x, y, 65, 65);
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                objposicion = Posicion.izquierda;
            }
            else if (e.KeyCode == Keys.Right)
            {
                objposicion = Posicion.derecha;
            }
            else if (e.KeyCode == Keys.Up)
            {
                objposicion = Posicion.arriba;
            }
            else if (e.KeyCode == Keys.Down)
            {
                objposicion = Posicion.abajo;
            }
        }
    }
}
