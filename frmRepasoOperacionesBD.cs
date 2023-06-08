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
    public partial class frmRepasoOperacionesBD : Form
    {
        clsBaseDeDatos ObjB = new clsBaseDeDatos();
        string SQL = "";

        public frmRepasoOperacionesBD()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string Operacion = cbOperaciones.SelectedIndex.ToString();

            switch (Operacion)
            {
                case "0":
                    txtCodigoSQL.Text = "Listar Todos los titulos del Libro";
                    SQL = "SELECT Titulo FROM Libro";
                    ObjB.Listar(dgvMostrar,SQL);
                    break;
                case "1":
                    txtCodigoSQL.Text = "Listar Todas las columnas del Libro";
                    SQL = "SELECT * FROM Libro";
                    ObjB.Listar(dgvMostrar, SQL);
                    break;
                case "2":
                    txtCodigoSQL.Text = "Juntar, En este caso junta Todas las columnas en donde el id de idioma sea igual a 2 y tambien igual a 7 ";
                    SQL = "SELECT * FROM Libro WHERE idIdioma = 2" +
                          " Union " +
                          "SELECT * FROM Libro WHERE idIdioma = 7";
                    ObjB.Listar(dgvMostrar, SQL);
                    break;
                case "3":
                    txtCodigoSQL.Text = "Seleccion simple, Muestran todas las columnas de Libro en donde se cumpla la condicion WHERE, en este caso es idlibro >20";
                    SQL = "SELECT * FROM Libro WHERE idlibro > 20";
                    ObjB.Listar(dgvMostrar, SQL);
                    break;
                case "4":
                    txtCodigoSQL.Text = "Seleccion Multi Atributo,Se usa con el Operador AND, en este caso posee 2 condiciones, que al cumplirse muestran todas las tablas de libro " +
                        "en donde las condiciones sean: WHERE IdIdioma = 2 And IdAutor = 3";
                    SQL = "SELECT * FROM Libro WHERE idIdioma = 2 And idAutor = 3";
                    ObjB.Listar(dgvMostrar, SQL);
                    break;
                case "5":
                    txtCodigoSQL.Text = "Seleccion Por Convolucion";
                    SQL = "SELECT * FROM (select * from libro Where idautor = 4 ) as x Where ididioma = 1 ";
                    ObjB.Listar(dgvMostrar, SQL);
                    break;
                case "6":
                    txtCodigoSQL.Text = "Union, Une las tablas elejidas Usando el operador UNION, donde se cumpla la condicion WHERE " +
                        "Ejemplo : Select * from libro WHERE idIdioma = 2 Union select * from libro Where idIdioma = 7";
                    SQL = "SELECT * FROM Libro WHERE idIdioma = 2" +
                          " Union " +
                          "SELECT * FROM Libro WHERE idIdioma = 7";
                    ObjB.Listar(dgvMostrar, SQL);
                    break;
                case "7":
                    txtCodigoSQL.Text = "Interseccion,";
                    SQL = "SELECT * FROM Libro WHERE idIdioma = 2 and idlibro in (Select * from libro WHERE idIdioma = 7)";
                    ObjB.Listar(dgvMostrar, SQL);
                    break;
                case "8":
                    txtCodigoSQL.Text = "Diferencia";
                    SQL = "SELECT * FROM Libro WHERE idIdioma = 2" +
                          " and idLibro not in " +
                          "(SELECT idLibro FROM Libro WHERE idpais = 3)";
                    ObjB.Listar(dgvMostrar, SQL);
                    break;
                default:
                    MessageBox.Show("Debes Elegir una opcion");
                    break;
            }
        }

        private void frmRepasoOperacionesBD_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
