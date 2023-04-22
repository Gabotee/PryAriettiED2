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
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtTramite.Text == "")
            {
                MessageBox.Show("Porfavor Asegurese de que todos los campos contengan Datos", "Mensaje");
            }
            else
            {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;

                FilaPersonas.Agregar(ObjNodo);
                FilaPersonas.Recorrer(DgvMostrar);
                FilaPersonas.Recorrer(lstListaSimple);

                
                lstCodigo.Text = "";

                // Llena el combo box 
                FilaPersonas.Recorrer(lstCodigo);

                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtTramite.Text = "";
            }
            
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
