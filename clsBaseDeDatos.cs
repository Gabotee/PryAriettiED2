using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace PryAriettiED2
{
    internal class clsBaseDeDatos
    {

        private OleDbConnection conexion = new OleDbConnection(); // Crea Conexion 
        private OleDbCommand comando = new OleDbCommand(); // 
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private DataTable tabla = new DataTable();

        private string CadenaConexion = "provider=microsoft.jet.oledb.4.0;data source=Libreria.mdb";
        

        public void Listar(DataGridView Grilla)
        {
            try
            {
                // Le paso la conexion 
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                adaptador = new OleDbDataAdapter(comando);
                DataSet Ds = new DataSet();
                adaptador.Fill(Ds, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = Ds.Tables["Libro"];

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        public void Listar(DataGridView Grilla, string Sql)
        {
            try
            {
                // Le paso la conexion 
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;

                adaptador = new OleDbDataAdapter(comando);
                DataSet Ds = new DataSet();
                adaptador.Fill(Ds, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = Ds.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conexion.Close();
            }

        }



    }
}
