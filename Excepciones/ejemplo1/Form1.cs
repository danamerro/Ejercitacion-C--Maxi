using System;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //int a, b, r;
            int resultado;
            
            try
            {
                resultado = calcular();
                /*
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                r = a + b;
                */

                lblResultado.Text = "= " + resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no conocido...");
            }
            finally 
            { 
                    //instrucciones
                    //operacion sensible...
            }
        }

        private int calcular() {
            int a, b, r;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                r = a / b;
                return r;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
