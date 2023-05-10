using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryAriettiED2
{
    public partial class FrmArbolBinario : Form
    {
        clsArbolBinario ObjArbol = new clsArbolBinario();
        StreamWriter Archivo;

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

                if (ObjArbol.Raiz != null)
                {
                    ObjArbol.Equilibrar();
                }

                Recorridos();
                

                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtTramite.Text = "";
            }

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjArbol.Raiz != null)
            {
                ObjArbol.RecorrerInOrdenAsc(lstCodigo);
                ObjArbol.RecorrerInOrdenAsc(DgvMostrar);
                ObjArbol.RecorrerInOrdenAsc(lstArbolBinario);
                Archivo = new StreamWriter("ArchivoArbol.csv", false);
                ObjArbol.RecorrerInOrdenAsc(Archivo);
                Archivo.Close();
                Archivo.Dispose();
            }
                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjArbol.Raiz != null)
            {
                ObjArbol.RecorrerInOrdenDesc(lstCodigo);
                ObjArbol.RecorrerInOrdenDesc(DgvMostrar);
                ObjArbol.RecorrerInOrdenDesc(lstArbolBinario);
                Archivo = new StreamWriter("ArchivoArbol.csv", false);
                ObjArbol.RecorrerInOrdenDesc(Archivo);
                Archivo.Close();
                Archivo.Dispose();
            }
                
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjArbol.Raiz != null)
            {
                ObjArbol.RecorrerPreOrden(lstCodigo);
                ObjArbol.RecorrerPreOrden(DgvMostrar);
                ObjArbol.RecorrerPreOrden(lstArbolBinario);
                Archivo = new StreamWriter("ArchivoArbol.csv", false);
                ObjArbol.RecorrerPreOrden(Archivo);
                Archivo.Close();
                Archivo.Dispose();
            }
                
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjArbol.Raiz != null)
            {
                ObjArbol.RecorrerPostOrden(lstCodigo);
                ObjArbol.RecorrerPostOrden(DgvMostrar);
                ObjArbol.RecorrerPostOrden(lstArbolBinario);
                Archivo = new StreamWriter("ArchivoArbol.csv", false);
                ObjArbol.RecorrerPostOrden(Archivo);
                Archivo.Close();
                Archivo.Dispose();
            }
               
        }

        private void FrmArbolBinario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (ObjArbol.Raiz != null && lstCodigo.SelectedIndex != -1)
            {
                ObjArbol.Eliminar(Convert.ToInt32(lstCodigo.SelectedItem));

                Recorridos();

                if (ObjArbol.Raiz == null)
                {

                    DgvMostrar.Rows.Clear();
                    lstCodigo.Items.Clear();
                    lstArbolBinario.Items.Clear();
                    tvMostrar.Nodes.Clear();
                }

                
            }
        }

        private void Recorridos()
        {
            if (ObjArbol.Raiz != null)
            {
                ObjArbol.RecorrerPreOrden(tvMostrar);

                if (rbOrdenAsc.Checked == true)
                {
                    ObjArbol.RecorrerInOrdenAsc(lstArbolBinario);
                    ObjArbol.RecorrerInOrdenAsc(lstCodigo);
                    ObjArbol.RecorrerInOrdenAsc(DgvMostrar);

                }
                if (rbInOrdenDesc.Checked == true)
                {
                    ObjArbol.RecorrerInOrdenDesc(lstArbolBinario);
                    ObjArbol.RecorrerInOrdenDesc(lstCodigo);
                    ObjArbol.RecorrerInOrdenDesc(DgvMostrar);

                }
                if (rbPreOrden.Checked == true)
                {
                    ObjArbol.RecorrerPreOrden(lstArbolBinario);
                    ObjArbol.RecorrerPreOrden(lstCodigo);
                    ObjArbol.RecorrerPreOrden(DgvMostrar);

                }
                if (rbPostOrden.Checked == true)
                {
                    ObjArbol.RecorrerPostOrden(lstArbolBinario);
                    ObjArbol.RecorrerPostOrden(lstCodigo);
                    ObjArbol.RecorrerPostOrden(DgvMostrar);

                }
            }
        }
            
    }
}
