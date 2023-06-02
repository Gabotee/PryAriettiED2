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
    public partial class FrmBaseDeDatosConsulta : Form
    {
        clsBaseDeDatos ObjB = new clsBaseDeDatos();

        public FrmBaseDeDatosConsulta()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string Instruccion = txtSQL.Text;

            ObjB.Listar(dgvMostrar, Instruccion);

        }
    }
}
