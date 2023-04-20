using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAriettiED2
{
    internal class clsListaSimple
    {
        public clsNodo Primero;
        clsNodo Codigo;
        clsNodo Aux;



        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null) // Si no hay nada
            {
                Primero = Nuevo; //El primero es el nuevo 
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo Anterior = Primero;
                    clsNodo Aux = Primero;

                    while (Nuevo.Codigo > Aux.Codigo)
                    {
                        Anterior = Aux;
                        Aux = Aux.Siguiente;
                        if (Aux == null)
                        {
                            break;
                        }

                    }
                    Anterior.Siguiente = Nuevo;
                    Nuevo.Siguiente = Aux;
                    

                }
            }
        }

        public void Eliminar(Int32 Cod)
        {
            if (Primero.Codigo == Cod)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo Anterior = Primero;
                clsNodo Aux = Primero;

                while (Aux.Codigo != Cod)
                {
                    Anterior = Aux;
                    Aux = Aux.Siguiente;

                }

                Anterior.Siguiente = Aux.Siguiente;
            }

        }

        public void Recorrer(DataGridView Grilla)
        {
            Aux = Primero;

            Grilla.Rows.Clear();

            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            Aux = Primero;
            Lista.Items.Clear();

            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo + " " + Aux.Nombre + " " + Aux.Tramite);
                Aux = Aux.Siguiente;
            }

        }

        public void Recorrer(ComboBox Combo)
        {
            Aux = Primero;
            Combo.Items.Clear();

            while (Aux != null)
            {
                Combo.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }

        }

    }
}
