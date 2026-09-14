using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.UrlImagen = txtUrlImagen.Text;
                pokemon.Tipo = (Elemento)cboxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboxDebilidad.SelectedItem;

                if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                    
                }
                else { 
                negocio.agregar(pokemon);
                MessageBox.Show("Agregado Exitosamente");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cboxTipo.DataSource = elementoNegocio.listar();
                cboxTipo.ValueMember = "Id";
                cboxTipo.DisplayMember = "Descripcion";
                cboxDebilidad.DataSource = elementoNegocio.listar();
                cboxDebilidad.ValueMember = "Id";
                cboxDebilidad.DisplayMember = "Descripcion";

                //tengo un pokemon para cargar
                if (pokemon != null) {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtUrlImagen.Text  =pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    cboxTipo.SelectedValue = pokemon.Tipo.Id;
                    cboxDebilidad.SelectedValue = pokemon.Debilidad.Id;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception)
            {

                pbxPokemon.Load("https://media.istockphoto.com/id/1980276924/vector/no-photo-thumbnail-graphic-element-no-found-or-available-image-in-the-gallery-or-album-flat.jpg?s=612x612&w=0&k=20&c=ZBE3NqfzIeHGDPkyvulUw14SaWfDj2rZtyiKv3toItk=");
            }

        }
    }
}
