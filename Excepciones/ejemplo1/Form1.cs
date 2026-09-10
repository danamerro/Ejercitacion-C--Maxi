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
            int a, b, r;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                r = a / b;
                lblResultado.Text = "= " + r;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor cargar solo numeros...");
            }
            catch (DivideByZeroException ex) {
                MessageBox.Show("No se puede dividir por 0...");
            }
            
            

        }
    }
}
