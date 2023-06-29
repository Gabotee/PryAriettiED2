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
                    txtCodigoSQL.Text = "Proyeccion Simple, En este caso me proyecta todos los titulos de la tabla libro";
                    SQL = "SELECT Titulo FROM Libro";
                    ObjB.Listar(dgvMostrar,SQL);
                    break;
                case "1":
                    txtCodigoSQL.Text = "Proyeccion MultiAtributo, En este caso me Listar Todas las columnas de la tabla Libro";
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
                    txtCodigoSQL.Text = "Seleccion Simple , Muestran todas las columnas de Libro en donde se cumpla la condicion WHERE, en este caso es idlibro >20";
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
                    txtCodigoSQL.Text = "Union, La unión de dos conjuntos es el conjunto que contiene todos los elementos que pertenecen a uno de los conjuntos o a ambos conjuntos , donde se cumpla la condicion WHERE ";
                    SQL = "SELECT * FROM Libro WHERE idIdioma = 2" +
                          " Union " +
                          "SELECT * FROM Libro WHERE idIdioma = 7";
                    ObjB.Listar(dgvMostrar, SQL);
                    break;
                case "7":
                    txtCodigoSQL.Text = "Interseccion, es el conjunto de elementos que son comunes a ambos conjuntos.";
                    SQL = "SELECT * FROM Libro where idIdioma = 2 AND exists (SELECT * FROM Libro where idAutor = 5) ORDER BY 5 ASC";
                    ObjB.Listar(dgvMostrar, SQL);
                    break;
                case "8": 
                    txtCodigoSQL.Text = "Diferencia ,La diferencia de dos conjuntos es el conjunto de elementos que pertenecen a uno de los conjuntos pero no al otro.";
                    SQL = "SELECT * FROM Libro where idIdioma = 2 AND idLibro not in (SELECT idLibro FROM Libro where idAutor = 83) ORDER BY 1 ASC";
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
