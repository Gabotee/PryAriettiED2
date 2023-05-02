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
    public partial class FrmArbolBinario : Form
    {
        clsArbolBinario ObjArbol = new clsArbolBinario();

        public FrmArbolBinario()
        {
            InitializeComponent();
           
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCodigo.Text == "" || txtTramite.Text == "")
            {
                MessageBox.Show("Porfavor Asegurese de completar todos los datos", "AVISO");
            }
            else
            {
                clsNodo Persona = new clsNodo();

                Persona.Nombre = txtNombre.Text;
                Persona.Tramite = txtTramite.Text;
                Persona.Codigo = Convert.ToInt32(txtCodigo.Text);

                ObjArbol.Agregar(Persona);
                ObjArbol.RecorrerInOrdenAsc(lstArbolBinario);
                ObjArbol.RecorrerInOrdenAsc(DgvMostrar);
                ObjArbol.RecorrerInOrdenAsc(lstCodigo);

                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtTramite.Text = "";
            }

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbol.RecorrerInOrdenAsc(lstCodigo);
            ObjArbol.RecorrerInOrdenAsc(DgvMostrar);
            ObjArbol.RecorrerInOrdenAsc(lstArbolBinario);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbol.RecorrerInOrdenDesc(lstCodigo);
            ObjArbol.RecorrerInOrdenDesc(DgvMostrar);
            ObjArbol.RecorrerInOrdenDesc(lstArbolBinario);
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbol.RecorrerPreOrden(lstCodigo);
            ObjArbol.RecorrerPreOrden(DgvMostrar);
            ObjArbol.RecorrerPreOrden(lstArbolBinario);
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbol.RecorrerPostOrden(lstCodigo);
            ObjArbol.RecorrerPostOrden(DgvMostrar);
            ObjArbol.RecorrerPostOrden(lstArbolBinario);
        }

        private void FrmArbolBinario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
