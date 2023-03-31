using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryAriettiED2
{
    internal class Nodo
    {

        private Int32 cod;
        private string Nom;
        private string Tra;

        private Nodo Sig;

        //Propiedades.. Interactuan con la interfaz.. puede tomar y mostrar datos 



        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public string Tramite
        {
            get { return Tra; }
            set { Tra = value; }
        }

        public Nodo Siguiente
        {
            get { return Sig; }
            set { Sig = value; }
        }

    }
}
