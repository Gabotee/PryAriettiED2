using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAriettiED2
{
    internal class ClsValidacion
    {
        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                // Pregunto si lo que se esta escribiendo es tipo Numero
                if (char.IsNumber(e.KeyChar))
                {
                    // Si es Numero lo dejo escribir 
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    // Esto es para que me deje borrar en caso de que lo necesite 
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    // Bloqueo el uso de espacios  
                    e.Handled = true;
                }
                else
                {
                    // Si lo que se esta escribiendo no es de tipo Letra.. Lo bloqueo. 
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
