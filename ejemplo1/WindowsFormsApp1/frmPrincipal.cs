using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //creo la ventana y le pido que se muestre la ventana de Perfil Persona
            Form1 ventana = new Form1();
            //abre la ruta sin importar cuantas veces de click al boton que acciona este show
            //ventana.Show();
            //forma de abrir esta pantalla pero no te va a dejar abrir la misma 2 veces hasta no salir de la misma
            ventana.ShowDialog();

        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
