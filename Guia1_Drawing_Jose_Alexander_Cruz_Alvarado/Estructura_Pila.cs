using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1_Drawing_Jose_Alexander_Cruz_Alvarado
{
    internal class Estructura_Pila
    {
        public Nodo tope;
        Nodo pilaActual = new Nodo();

        public Estructura_Pila()
        {
            tope = null;
        }

        public void agregar(int valor)
        {
            Nodo aux = new Nodo();
            aux.valor = valor;

            if (tope == null)
            {
                tope = aux;
                aux.siguiente = null;
            }
            else
            {
                aux.siguiente = tope;
                tope = aux;
            }
        }

        public void agregarPilaActual(int valor)
        {
            Nodo aux = new Nodo();
            aux.valor = valor;

            if (pilaActual == null)
            {
                pilaActual = aux;
                aux.siguiente = null;
            }
            else
            {
                aux.siguiente = pilaActual;
                pilaActual = aux;
            }
        }

        public void ordenarPila(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                int valor = pilaActual.valor;

                pilaActual = pilaActual.siguiente;

                this.agregar(valor);
            }

            pilaActual = tope;
        }

        public int recorrerPilaActual()
        {
            int valor = pilaActual.valor;

            pilaActual = pilaActual.siguiente;

            return valor;
        }

        public int recorrerPila()
        {
            int valor = tope.valor;

            tope = tope.siguiente;

            return valor;
        }
    }
}
