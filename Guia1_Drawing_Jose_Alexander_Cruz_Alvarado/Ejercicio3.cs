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
    public partial class Ejercicio3 : Form
    {
        enum Posicion
        {
            izquierda, derecha, arriba, abajo
        }

        private int x;
        private int y;
        private int xComida;
        private int yComida;
        private int contadorComida;

        private Boolean juegoFinalizado = false;

        private Posicion objposicion;
        Estructura_Pila pilax = new Estructura_Pila();
        Estructura_Pila pilay = new Estructura_Pila();

        public Ejercicio3()
        {
            InitializeComponent();
            x = 50; 
            y = 50;
            xComida = 100; 
            yComida = 100;
            contadorComida = 0;

            objposicion = Posicion.abajo;
        }

        private void Ejercicio3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && objposicion != Posicion.derecha)
            {
                objposicion = Posicion.izquierda;
            }
            else if (e.KeyCode == Keys.Right && objposicion != Posicion.izquierda)
            {
                objposicion = Posicion.derecha;
            }
            else if (e.KeyCode == Keys.Up && objposicion != Posicion.abajo)
            {
                objposicion = Posicion.arriba;
            }
            else if (e.KeyCode == Keys.Down && objposicion != Posicion.arriba)
            {
                objposicion = Posicion.abajo;
            }
        }

        private void Ejercicio3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("Pokemon.png"), xComida, yComida, 45, 45);
            e.Graphics.DrawImage(new Bitmap("Pokemon.png"), x, y, 45, 45);

            if (contadorComida > 0)
            {

                for (int i = 1; i <= contadorComida; i++)
                {
                    int xCoordenada = pilax.recorrerPilaActual(); 
                    int yCoordenada = pilay.recorrerPilaActual();
                    e.Graphics.DrawImage(new Bitmap("Gusanito2.png"), xCoordenada, yCoordenada, 45, 45);
                    e.Graphics.DrawImage(new Bitmap("Gusanito2.png"), xCoordenada, yCoordenada, 45, 45);
                }
            }
        }

        private void timermov_Tick(object sender, EventArgs e)
        {
            int maxWidth = (Width - 60);
            int maxHeight = (Height - 100);

            if (y <= maxHeight && x <= maxWidth && x > 0 && y > 0 && !juegoFinalizado)
            {
                if (objposicion == Posicion.derecha)
                {
                    if (x + 45 >= maxWidth)
                    {
                        juegoFinalizado = true;
                    }
                    else
                    {
                        //Registramos coordenada
                        pilax.agregar(x); pilay.agregar(y);
                        x += 45;
                    }
                }
                else if (objposicion == Posicion.izquierda)
                {
                    if (x - 45 <= 0)
                    {
                        x = 0;
                        juegoFinalizado = true;
                    }
                    else
                    {
                        //Registramos coordenada
                        pilax.agregar(x); pilay.agregar(y);
                        x -= 45;
                    }
                }
                else if (objposicion == Posicion.arriba)
                {
                    if (y - 45 <= 0)
                    {
                        y = 0;
                        juegoFinalizado = true;
                    }
                    else
                    {
                        //Registramos coordenada
                        pilax.agregar(x); pilay.agregar(y);
                        y -= 45;
                    }
                }
                else if (objposicion == Posicion.abajo)
                {
                    if (y + 45 >= maxHeight)
                    {
                        juegoFinalizado = true;
                    }
                    else
                    {
                        //Registramos coordenada
                        pilax.agregar(x); pilay.agregar(y);
                        y += 45;
                    }
                }

                //Actualizamos coordenadas
                for (int i = 1; i <= contadorComida; i++)
                {
                    int xCoordenada = pilax.recorrerPila(); 
                    int yCoordenada = pilay.recorrerPila();
                    pilax.agregarPilaActual(xCoordenada);
                    pilay.agregarPilaActual(yCoordenada);
                }

                //Ordena la pila
                pilax.ordenarPila(contadorComida);
                pilay.ordenarPila(contadorComida);

                //Mueve la comida de lugar
                if ((x >= xComida - 30 && x <= xComida + 30)
                    && (y >= yComida - 30 && y <= yComida + 30))
                {
                    Random rnd = new Random();
                    xComida = rnd.Next(0, maxWidth);
                    yComida = rnd.Next(0, maxHeight);

                    contadorComida += 1;
                }
            }
            else
            {
                //Fin del juego
                juegoFinalizado = true;
                timermov.Enabled = false;
                DialogResult dialog = MessageBox.Show("¡Fin del juego!. ¿Reintentar ?", "Juego Finalizado", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }

            Invalidate();
        }
    }
}
