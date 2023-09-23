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
    public partial class Ejercicio2 : Form
    {
        Graphics area;
        public Ejercicio2()
        {
            InitializeComponent();
            area = areadibujo.CreateGraphics();
            //Elementos que dependerán de la inclinación
            txtpuntoinicio.Enabled = false;
            txtpuntofin.Enabled = false;
        }

        private void btndibujar_Click(object sender, EventArgs e)
        {
            Boolean invalid = false;
            Pen lapicero = new Pen(Color.Black);
            switch (cmbcolor.SelectedIndex)
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero = new Pen(Color.Red); break;
                case 2: lapicero = new Pen(Color.Blue); break;
                case 3: lapicero = new Pen(Color.Black); break;
            }

            if (cmborientacion.SelectedIndex == -1)
            {
                invalid = true;
                lblrequerido.Text = "Campo requerido";
            }
            else
            {
                lblrequerido.Text = "";
            }

            if (cmborientacion.SelectedIndex == 2)
            {
                if (string.IsNullOrWhiteSpace(txtpuntoinicio.Text))
                {
                    invalid = true;
                    lblerrorpi.Text = "Campo requerido";
                }
                else
                {
                    lblerrorpi.Text = "";
                }

                if (string.IsNullOrWhiteSpace(txtpuntofin.Text))
                {
                    invalid = true;
                    lblrequerido.Text = "Campo requerido";
                }
                else
                {
                    lblrequerido.Text = "";
                }
            }



            if (!invalid)
            {

                int iteraciones = int.Parse(txtcantidad.Text);
                int espacio = int.Parse(txtespaciado.Text);
                int puntoinicio = 50, puntoFin = 50;

                if (cmborientacion.SelectedIndex == 2)
                {
                    puntoinicio = int.Parse(txtpuntoinicio.Text);
                    puntoFin = int.Parse(txtpuntofin.Text);
                }

                area.Clear(Color.White);

                for (int i = 0; i < iteraciones; i++)
                {
                    if (cmborientacion.SelectedIndex == 1)
                    {
                        area.DrawLine(lapicero, puntoinicio + (espacio * i), 20, puntoFin + (espacio * i), 200);
                    }
                    else
                    {
                        area.DrawLine(lapicero, 20, puntoinicio + (espacio * i), 200, puntoFin + (espacio * i));
                    }
                }
            }
        }

        private void cmborientacion_TextChanged(object sender, EventArgs e)
        {
            if (cmborientacion.SelectedIndex == 2)
            {
                txtpuntoinicio.Enabled = true;
                txtpuntofin.Enabled = true;
            }
            else
            {
                txtpuntoinicio.Enabled = false;
                txtpuntofin.Enabled = false;
            }
        }
    }
}
