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
    public partial class FrmOperacionesBaseDeDatos : Form
    {
        clsBaseDeDatos ObjB = new clsBaseDeDatos();

        public FrmOperacionesBaseDeDatos()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT Titulo FROM Libro";
            ObjB.Listar(dgvMostrar,Sql);

        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro";
            ObjB.Listar(dgvMostrar, Sql);
            
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE idlibro > 20";
            ObjB.Listar(dgvMostrar, Sql);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE idIdioma = 2 And idAutor = 2";
            ObjB.Listar(dgvMostrar, Sql);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE idIdioma = 2" + 
                " Union " + 
                "SELECT * FROM Libro WHERE idIdioma = 7";
            ObjB.Listar(dgvMostrar, Sql);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE idIdioma = 2" +
                " and exists " +
                "(SELECT * FROM Libro WHERE idIdioma = 7)";
            ObjB.Listar(dgvMostrar, Sql);
        }


        // Interseccion.. 
    }
}
