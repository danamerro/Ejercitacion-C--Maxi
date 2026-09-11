

using System.Collections.Generic;
using System.Data.SqlClient;

namespace winform_app
{
    //clase acceso a datos
    internal class PokemonNegocio
    {
        public List<Pokemon> listar() {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=localhost,1433; database=POKEDEX_DB; user id=sa; password=CONTRASEÑA; TrustServerCertificate=True;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero,Nombre,Descripcion from POKEMONS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) { 
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }
    }
}
