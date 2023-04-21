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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void datosProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProgramador VentanaProgramador = new FrmProgramador();
            VentanaProgramador.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraDinamicaLinealCola VentanaCola = new FrmEstructuraDinamicaLinealCola();
            VentanaCola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraDinamicaLinealPila VentanaPila = new FrmEstructuraDinamicaLinealPila();
            VentanaPila.ShowDialog();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraDinamicaLineaListaSimple VentanaListaSimple = new FrmEstructuraDinamicaLineaListaSimple();
            VentanaListaSimple.ShowDialog();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraDinamicaLinealListaDoble VentanaListaDoble = new FrmEstructuraDinamicaLinealListaDoble();
            VentanaListaDoble.ShowDialog();
        }
    }
}
