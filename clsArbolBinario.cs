using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAriettiED2
{
    internal class clsArbolBinario
    {

        private clsNodo Inicio;

        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }


        public void Agregar(clsNodo Nuevo)
        {

            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }

            }

        }




        public void Eliminar(Int32 Cod)
        {



        }


        // InOrden I-R-D
        // PreOrden R-I-D
        // PostOrden I-D-R
        public void Recorrer(DataGridView Grilla)
        {
           


        }

        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista,Raiz);

        }

        public void Recorrer(ComboBox Combo)
        {
            

        }

        // Cargar ListBox Asc-Desc
        public void InOrdenAsc(ListBox Lst , clsNodo Raiz)
        {

            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lst, Raiz.Izquierdo);
            }
            Lst.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lst, Raiz.Derecho);
            }

        }

        public void InOrdenDesc(ListBox Lst , clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lst, Raiz.Derecho);
            }
            Lst.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lst, Raiz.Izquierdo);
            }
        }

        // Cargar ComboBox Asc-Desc

        public void InOrdenAsc(ComboBox Comb, clsNodo Raiz)
        {

            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Comb, Raiz.Izquierdo);
            }
            Comb.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Comb, Raiz.Derecho);
            }

        }

        public void InOrdenDesc(ComboBox Comb, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Comb, Raiz.Derecho);
            }
            Comb.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Comb, Raiz.Izquierdo);
            }
        }

        // Cargar Grilla Asc-Desc

        public void InOrdenAsc(DataGridView Grilla, clsNodo Raiz)
        {

            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Grilla, Raiz.Izquierdo);
            }
            Grilla.Rows.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Grilla, Raiz.Derecho);
            }

        }

        public void InOrdenDesc(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Grilla, Raiz.Derecho);
            }
            Grilla.Rows.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Grilla, Raiz.Izquierdo);
            }
        }

        // PreOrden 

        public void PreOrden(ListBox Lst, clsNodo Raiz)
        {
            Lst.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lst, Raiz.Izquierdo);
            }
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lst, Raiz.Derecho);
            }
        }

        public void PreOrden(ComboBox Combo, clsNodo Raiz)
        {
            Combo.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Combo, Raiz.Izquierdo);
            }
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Combo, Raiz.Derecho);
            }
        }

        public void PreOrden(DataGridView Grilla, clsNodo Raiz)
        {
            Grilla.Rows.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Grilla, Raiz.Izquierdo);
            }
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Grilla, Raiz.Derecho);
            }
        }

        //PostOrden
        public void PostOrden(ListBox Lst, clsNodo Raiz)
        {
            
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lst, Raiz.Izquierdo);
            }
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lst, Raiz.Derecho);
            }
            Lst.Items.Add(Raiz.Codigo);
        }

        public void PostOrden(ComboBox Combo, clsNodo Raiz)
        {

            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Combo, Raiz.Izquierdo);
            }
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Combo, Raiz.Derecho);
            }
            Combo.Items.Add(Raiz.Codigo);
        }

        public void PostOrden(DataGridView Grilla, clsNodo Raiz)
        {

            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Grilla, Raiz.Izquierdo);
            }
            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Grilla, Raiz.Derecho);
            }
            Grilla.Rows.Add(Raiz.Codigo);
        }
    }
}
