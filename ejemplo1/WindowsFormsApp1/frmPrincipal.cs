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
            //valida que ventanas estan abiertas y si ya esta abierta no permite abrir otra
            //Application.OpenForms
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1)) {
                    MessageBox.Show("Ya existe esta ventana abierta,termine de trabajar allí...");
                    return;
                }
                    
            }
            //creo la ventana y le pido que se muestre la ventana de Perfil Persona
            Form1 ventana = new Form1();
            //abre la ruta sin importar cuantas veces de click al boton que acciona este show
            //ventana.Show();
            //esta ventana se va a abrir dentro de la ventana actual (frmPrincipal) como ventana hija
            ventana.MdiParent = this;
            //forma de abrir esta pantalla pero no te va a dejar abrir la misma 2 veces hasta no salir de la misma
            //ventana.ShowDialog();
            ventana.Show();

        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
