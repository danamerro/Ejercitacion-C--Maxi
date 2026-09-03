using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    //SE DEFINE LA FUNCIONALIDAD DE LA CLASE (VENTANA) ACA VA EL CODIGO QUE VOY A TOCAR TODO EL TIEMPO PARA DARLE VIDA A LA APLICACION
    public partial class Form1 : Form
    {
        //CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
        }

        //EVENTO (POR DEFAULT)
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Mundo");
            string texto = txtNombre.Text;
            lblSaludo.Text = "HOLA " + texto;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("te doy la bienvenida...");
        }

        //EVENTO ASOCIADO A OTRO METODO
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Gracias por usar la APP");
        }


    }
}
