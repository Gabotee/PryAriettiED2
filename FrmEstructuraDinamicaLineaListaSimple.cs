using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAriettiED2
{
    public partial class FrmEstructuraDinamicaLineaListaSimple : Form
    {
        clsListaSimple FilaPersonas = new clsListaSimple();
       

        public FrmEstructuraDinamicaLineaListaSimple()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            FilaPersonas.Agregar(ObjNodo);
            FilaPersonas.Recorrer(DgvMostrar);
            FilaPersonas.Recorrer(lstListaSimple);

            //Llena el combo box
            lstCodigo.Text = "";
            FilaPersonas.Recorrer(lstCodigo);

            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)       
        {
            clsListaSimple ObjLista = new clsListaSimple();

            if (ObjLista.Primero != null)
            {
              
                int Eliminar = Convert.ToInt32(lstCodigo.Text);
                ObjLista.Eliminar(Eliminar);
                ObjLista.Recorrer(DgvMostrar);
                ObjLista.Recorrer(lstCodigo);

            }
            else
            {
                MessageBox.Show("Lista Vacia");
            }
            lstCodigo.Enabled = false;


        }
    }
}
