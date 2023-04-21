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
    public partial class FrmEstructuraDinamicaLinealListaDoble : Form
    {
        clsListaDoble FilaPersonas = new clsListaDoble();

        public FrmEstructuraDinamicaLinealListaDoble()
        {
            InitializeComponent();
            rbAscendente.Checked = true;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();

            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            FilaPersonas.Agregar(ObjNodo);
            FilaPersonas.Recorrer(DgvMostrar);
            FilaPersonas.Recorrer(lstListaDoble);

            //Llena el combo box
            lstCodigo.Text = "";

            FilaPersonas.Recorrer(lstCodigo);

            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtTramite.Text = "";
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            FilaPersonas.Recorrer(lstCodigo);
            FilaPersonas.Recorrer(DgvMostrar);
            FilaPersonas.Recorrer(lstListaDoble);
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            FilaPersonas.RecorrerDes(lstCodigo);
            FilaPersonas.RecorrerDes(DgvMostrar);
            FilaPersonas.RecorrerDes(lstListaDoble);
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (FilaPersonas.Primero != null)
            {
                cmdEliminar.Enabled = true;
                int Eliminar = Convert.ToInt32(lstCodigo.Text);
                FilaPersonas.Eliminar(Eliminar);
                FilaPersonas.Recorrer(DgvMostrar);
                FilaPersonas.Recorrer(lstCodigo);

            }
            else
            {
                MessageBox.Show("Lista Vacia");

            }
        }
    }
}
