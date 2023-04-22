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
    public partial class FrmEstructuraDinamicaLinealCola : Form
    {
        clsCola FilaDePersonas = new clsCola();

        public FrmEstructuraDinamicaLinealCola()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmEstructuraDinamicaLinealCola_Load(object sender, EventArgs e)
        {
            
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

                FilaDePersonas.Agregar(ObjNodo);
                FilaDePersonas.Recorrer(DgvMostrar);
                FilaDePersonas.Recorrer(lstCola);

                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtTramite.Text = "";
            }
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero !=null)
            {
                txtMostrarCodigo.Text = FilaDePersonas.Primero.Codigo.ToString();
                txtMostrarNombre.Text = FilaDePersonas.Primero.Nombre;
                txtMostrarTramite.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                //Recorrer = Mostrar
                FilaDePersonas.Recorrer(DgvMostrar);
                FilaDePersonas.Recorrer(lstCola);
            }
            else
            {
                txtMostrarCodigo.Text = "";
                txtMostrarNombre.Text = "";
                txtMostrarTramite.Text = "";
                
            }
           
        }

        private void lstPila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
