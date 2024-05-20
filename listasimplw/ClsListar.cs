using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasimple
{
    internal class ClsListar
    {
        Clsnodo inicio;
        Clsnodo fin;

        public ClsListar()
        {
            inicio = null;
            fin = null;
        }

        public void Listar(ListBox lstLista)
        {
            lstLista.Items.Clear();
            if (inicio != null)
            {
                Clsnodo aux = inicio;
                while (aux != null)
                {
                    lstLista.Items.Add(aux.nombreArchivo);
                    aux = aux.siguiente;
                }
            }
            else lstLista.Items.Add("Lista vacia");

        }

        public void Insertar(int dato)
        {

            Clsnodo nuevo = new Clsnodo(nombreArchivo);
            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                if (nuevo.nombreArchivo < inicio.nombreArchivo)
                {
                    nuevo.siguiente = inicio;
                    inicio = nuevo;
                }
                else
                {
                    if (nuevo.dato > fin.dato)
                    {
                        fin.siguiente = nuevo;
                        fin = nuevo;
                    }
                    else
                    {
                        Clsnodo anterior = inicio;
                        Clsnodo actual = inicio;
                        while (nuevo.dato > actual.dato)
                        {
                            anterior = actual;
                            actual = actual.siguiente;
                        }
                        anterior.siguiente = nuevo;
                        nuevo.siguiente = actual;
                    }
                }
            }
        }
        public bool Buscar(int dato)
        {
            bool existe = false;
            if (inicio != null)
            {
                Clsnodo aux = inicio;
                while (aux != null)
                {
                    if (aux.nombreArchivo == ) { existe = true; break; }
                    aux = aux.siguiente;
                }
            }
            return existe;
        }

        public void Eliminar(int dato)
        {
            if (inicio == null) MessageBox.Show("Lista vacia");
            else
            {
                if (inicio.dato == dato)
                {
                    Clsnodo aux = inicio;
                    inicio = aux.siguiente;
                    aux = null;
                }
                else
                {
                    Clsnodo anterior = inicio;
                    Clsnodo actual = inicio;
                    while (dato != actual.dato)
                    {
                        anterior = actual;
                        actual = actual.siguiente;
                    }
                    if (actual == fin)
                    {
                        fin = anterior;
                        fin.siguiente = null;
                        actual = null;
                    }
                    else
                    {
                        anterior.siguiente = actual.siguiente;
                        actual = null;
                    }
                }
            }
        }
    }
}



