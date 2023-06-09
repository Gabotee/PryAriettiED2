﻿using System;
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
                FilaPersonas.Recorrer(lstListaDoble);

                // Limpia el combo, por si ya tenia algo cargado.
                lstCodigo.Text = "";
                //Llena el combo box
                FilaPersonas.Recorrer(lstCodigo);

                txtNombre.Text = "";
                txtCodigo.Text = "";
                txtTramite.Text = "";
            }
            
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
            if (FilaPersonas.Primero != null && (lstCodigo.Text != ""))
            {
                cmdEliminar.Enabled = true;
                int Eliminar = Convert.ToInt32(lstCodigo.SelectedItem);
                FilaPersonas.Eliminar(Eliminar);
                FilaPersonas.Recorrer(DgvMostrar);
                FilaPersonas.Recorrer(lstCodigo);
                FilaPersonas.Recorrer(lstListaDoble);

            }
            else
            {
                MessageBox.Show("Lista Vacia");

            }
        }

        private void FrmEstructuraDinamicaLinealListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidacion Numero = new ClsValidacion();
            Numero.SoloNumeros(e);
        }
    }
}
