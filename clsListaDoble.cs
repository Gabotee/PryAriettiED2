using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAriettiED2
{
    internal class clsListaDoble
    {

        private clsNodo Pri;
        private clsNodo Ult;


        public clsNodo Primero
        {
            get { return Pri; }
            set { Pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return Ult; }
            set { Ult = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Primero.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;

                        while (Aux.Codigo < Nuevo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = Aux;
                        Aux.Anterior = Nuevo;
                        Nuevo.Anterior = Ant;
                    }
                }
            }
        }

        public void Eliminar(Int32 Cod)
        {

            if (Primero.Codigo == Cod && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Cod)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Cod)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo < Cod)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Aux.Siguiente;
                        Aux = Aux.Siguiente;
                        Aux.Anterior = Ant;
                    }
                }
            }

        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo Aux = Primero;

            Grilla.Rows.Clear();

            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo Aux = Primero;
            Lista.Items.Clear();

            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo + " " + Aux.Nombre + " " + Aux.Tramite);
                Aux = Aux.Siguiente;
            }

        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;

            Combo.Items.Clear();

            while (Aux != null)
            {
                Combo.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }

        }

        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo Aux = Ultimo;

            Grilla.Rows.Clear();

            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Anterior;
            }
        }

        public void RecorrerDes(ListBox Lista)
        {
            clsNodo Aux = Ultimo;
            Lista.Items.Clear();

            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo + " " + Aux.Nombre + " " + Aux.Tramite);
                Aux = Aux.Anterior;
            }

        }

        public void RecorrerDes(ComboBox Combo)
        {
            clsNodo Aux = Ultimo;

            Combo.Items.Clear();

            while (Aux != null)
            {
                Combo.Items.Add(Aux.Nombre);
                Aux = Aux.Anterior;
            }

        }


    }
}
