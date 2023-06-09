﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryAriettiED2
{
    internal class clsArbolBinario
    {

        private clsNodo Inicio;
        private clsNodo[] Vector = new clsNodo[100];
        int I;
        int EliminarNodo;
       

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

        public void Equilibrar()
        {
            EliminarNodo = default;
            I = 0;
            CargarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, I - 1);
        }

        public void Eliminar(int Nodo)
        {
            EliminarNodo = Nodo;
            I = 0;
            CargarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, I - 1);
        }

        

        private void CargarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorInOrden(NodoPadre.Izquierdo);
            }
            if (NodoPadre.Codigo != EliminarNodo)
            {
                Vector[I] = NodoPadre;
                I = I + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                CargarVectorInOrden(NodoPadre.Derecho);
            }

        }

        // Equilibrar

        //Declarar vector(Clase Nodo).. listar InOrden 
        //Destruir Arbol.. Raiz = Null
        //Metodo Agregar. 
        // Indices Inicio + Final , Promedio 
        // Le pasamos el promedio a la raiz 
        // Variable Promedio -1 
        // Repetir 

        public void EquilibrarArbol(Int32 Ini, Int32 Fin)
        {
            Int32 Med = (Ini + Fin) / 2;

            if (Ini <= Fin)
            {
                Agregar(Vector[Med]);
                EquilibrarArbol(Ini, Med - 1);
                EquilibrarArbol(Med + 1, Fin);

            }

        }

        public clsNodo DatosNodotv(int DatosNodo)
        {
            clsNodo Aux = Raiz;
            while (Aux.Codigo != DatosNodo)
            {
                if (DatosNodo < Aux.Codigo)
                {
                    Aux = Aux.Izquierdo;
                }
                else
                {
                    Aux = Aux.Derecho;
                }
            }
            return Aux;
        }

        // InOrden I-R-D
        // PreOrden R-I-D
        // PostOrden I-D-R

        // Recorrer Ascendente 
        public void RecorrerInOrdenAsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);

        }

        public void RecorrerInOrdenAsc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista,Raiz);

        }

        public void RecorrerInOrdenAsc(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);

        }

        public void RecorrerInOrdenAsc(StreamWriter Archivo)
        {
            InOrdenAcs(Archivo, Raiz);
        }

        // Recorrer Descendente 

        public void RecorrerInOrdenDesc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDesc(Grilla, Raiz);


        }

        public void RecorrerInOrdenDesc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDesc(Lista, Raiz);

        }

        public void RecorrerInOrdenDesc(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDesc(Combo, Raiz);

        }

        public void RecorrerInOrdenDesc(StreamWriter Archivo)
        {
            InOrdenDesc(Archivo, Raiz);
        }

        // Recorrer PreOrden 

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);


        }

        public void RecorrerPreOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);

        }

        public void RecorrerPreOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);

        }

        public void RecorrerPreOrden(TreeView TreeArbol)
        {
            TreeArbol.Nodes.Clear();
            PreOrden(TreeArbol.Nodes, Raiz);
        }

        public void RecorrerPreOrden(StreamWriter Archivo)
        {
            PreOrden(Archivo, Raiz);
        }

        // Recorrer PostOrden

        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);


        }

        public void RecorrerPostOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);

        }

        public void RecorrerPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);

        }

        public void RecorrerPostOrden(StreamWriter Archivo)
        {
            PostOrden(Archivo, Raiz);
        }



        // InOrden 

        // Cargar ListBox Asc-Desc
        public void InOrdenAsc(ListBox Lst , clsNodo Raiz)
        {

            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Lst, Raiz.Izquierdo);
            }
            Lst.Items.Add(Raiz.Codigo);
            if (Raiz.Derecho != null)
            {
                InOrdenAsc(Lst, Raiz.Derecho);
            }

        }

        public void InOrdenDesc(ListBox Lst , clsNodo Raiz)
        {
            if (Raiz.Derecho != null)
            {
                InOrdenDesc(Lst, Raiz.Derecho);
            }
            Lst.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenDesc(Lst, Raiz.Izquierdo);
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
            if (Raiz.Derecho != null)
            {
                InOrdenAsc(Comb, Raiz.Derecho);
            }

        }

        public void InOrdenDesc(ComboBox Comb, clsNodo Raiz)
        {
            if (Raiz.Derecho != null)
            {
                InOrdenDesc(Comb, Raiz.Derecho);
            }
            Comb.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                InOrdenDesc(Comb, Raiz.Izquierdo);
            }
        }

        // Cargar Grilla Asc-Desc

        public void InOrdenAsc(DataGridView Grilla, clsNodo Raiz)
        {

            if (Raiz.Izquierdo != null)
            {
                InOrdenAsc(Grilla, Raiz.Izquierdo);
            }
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(Grilla, Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Derecho != null)
            {
                InOrdenAsc(Grilla, Raiz.Derecho);
            }

            

        }

        public void InOrdenDesc(DataGridView Grilla, clsNodo Raiz)
        {
            if (Raiz.Derecho != null)
            {
                InOrdenDesc(Grilla, Raiz.Derecho);
            }
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(Grilla, Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Izquierdo != null)
            {
                InOrdenDesc(Grilla, Raiz.Izquierdo);
            }
            Grilla.Refresh();

        }

        // Cargar Archivo CSV Asc-Desc

        private void InOrdenAcs(StreamWriter Writer, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null) InOrdenAcs(Writer, Raiz.Izquierdo);
            Writer.Write(Raiz.Codigo);
            Writer.Write(";");
            Writer.Write(Raiz.Nombre);
            Writer.Write(";");
            Writer.WriteLine(Raiz.Tramite);
            if (Raiz.Derecho != null) InOrdenAcs(Writer, Raiz.Derecho);
        }

        private void InOrdenDesc(StreamWriter Writer, clsNodo Raiz)
        {
            if (Raiz.Derecho != null) InOrdenDesc(Writer, Raiz.Derecho);
            Writer.Write(Raiz.Codigo);
            Writer.Write(";");
            Writer.Write(Raiz.Nombre);
            Writer.Write(";");
            Writer.WriteLine(Raiz.Tramite);
            if (Raiz.Izquierdo != null) InOrdenDesc(Writer, Raiz.Izquierdo);
        }

        // PreOrden 

        public void PreOrden(ListBox Lst, clsNodo Raiz)
        {
            Lst.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                PreOrden(Lst, Raiz.Izquierdo);
            }
            if (Raiz.Derecho != null)
            {
                PreOrden(Lst, Raiz.Derecho);
            }
        }

        public void PreOrden(ComboBox Combo, clsNodo Raiz)
        {
            Combo.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                PreOrden(Combo, Raiz.Izquierdo);
            }
            if (Raiz.Derecho != null)
            {
                PreOrden(Combo, Raiz.Derecho);
            }
        }

        public void PreOrden(DataGridView Grilla, clsNodo Raiz)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(Grilla, Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            Grilla.Refresh();
            if (Raiz.Izquierdo != null)
            {
                PreOrden(Grilla, Raiz.Izquierdo);
            }
            if (Raiz.Derecho != null)
            {
                PreOrden(Grilla, Raiz.Derecho);
            }

            

        }

        public void PreOrden(TreeNodeCollection NodoPadre , clsNodo Raiz)
        {
            TreeNode Hijo = NodoPadre.Add(Raiz.Codigo.ToString());
            if (Raiz.Izquierdo != null)
            {
                PreOrden(Hijo.Nodes, Raiz.Izquierdo);
            }
            if (Raiz.Derecho != null)
            {
                PreOrden(Hijo.Nodes, Raiz.Derecho);
            }
        }

        private void PreOrden(StreamWriter Writer, clsNodo Raiz)
        {
            Writer.Write(Raiz.Codigo);
            Writer.Write(";");
            Writer.Write(Raiz.Nombre);
            Writer.Write(";");
            Writer.WriteLine(Raiz.Tramite);
            if (Raiz.Izquierdo != null) PreOrden(Writer, Raiz.Izquierdo);
            if (Raiz.Derecho != null) PreOrden(Writer, Raiz.Derecho);
        }

        //PostOrden
        public void PostOrden(ListBox Lst, clsNodo Raiz)
        {
            
            if (Raiz.Izquierdo != null)
            {
               PostOrden(Lst, Raiz.Izquierdo);
            }
            if (Raiz.Derecho != null)
            {
                PostOrden(Lst, Raiz.Derecho);
            }
            Lst.Items.Add(Raiz.Codigo);
        }

        public void PostOrden(ComboBox Combo, clsNodo Raiz)
        {

            if (Raiz.Izquierdo != null)
            {
                PostOrden(Combo, Raiz.Izquierdo);
            }
            if (Raiz.Derecho != null)
            {
                PostOrden(Combo, Raiz.Derecho);
            }
            Combo.Items.Add(Raiz.Codigo);
        }

        public void PostOrden(DataGridView Grilla, clsNodo Raiz)
        {

            if (Raiz.Izquierdo != null)
            {
                PostOrden(Grilla, Raiz.Izquierdo);
            }
            if (Raiz.Derecho != null)
            {
                PostOrden(Grilla, Raiz.Derecho);
            }
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(Grilla, Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            Grilla.Rows.Add(Raiz.Codigo, Raiz.Nombre, Raiz.Tramite);
            Grilla.Refresh();


        }

        private void PostOrden(StreamWriter Writer, clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null) PostOrden(Writer, Raiz.Izquierdo);
            if (Raiz.Derecho != null) PostOrden(Writer, Raiz.Derecho);
            Writer.Write(Raiz.Codigo);
            Writer.Write(";");
            Writer.Write(Raiz.Nombre);
            Writer.Write(";");
            Writer.WriteLine(Raiz.Tramite);
        }

    }
}
