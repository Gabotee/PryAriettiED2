using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAriettiED2
{
    internal class clsCola
    {
        public clsNodo Primero;
        public clsNodo Ultimo;
        public clsNodo Aux;


         
        public void Agregar(clsNodo Nuevo)
        {
            //si no hay nadie en la cola.. el primero que llega es primero y ultimo.
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                
                Ultimo.Siguiente = Nuevo; // Al ultimo se le engancha el nuevo 

                Ultimo = Nuevo; // El nuevo pasa al ultimo 
            }
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                // si hay uno solo.. cuando se elimina pasa a no quedar nada
                Primero = null;
                Ultimo = null;
            }
            else
            {
                //el primero se elimina y el siguiente pasa a ser primero
                Primero = Primero.Siguiente;  

            }


        }


        public void Recorrer(DataGridView Grilla)
        {
            Aux = Primero;

            Grilla.Rows.Clear();
            
            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo,Aux.Nombre,Aux.Tramite);
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
