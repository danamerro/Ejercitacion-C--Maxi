

using System.Collections.Generic;
using System.Data.SqlClient;

namespace winform_app
{
    //clase acceso a datos
     class PokemonNegocio
    {
        //se declara la clase PokemonNegocio
        public List<Pokemon> listar() {
            //se declara el metodo listar
            List<Pokemon> lista = new List<Pokemon>();
            //objeto que representa la conexion a la db
            SqlConnection conexion = new SqlConnection();
            //representa el comando sql que se va a mandar a la base
            SqlCommand comando = new SqlCommand();
            //lee fila x fila los resultados que devuelve sql
            SqlDataReader lector;

            try
            {
                //conf de conexion a db
                conexion.ConnectionString = "server=localhost,1433; database=POKEDEX_DB; user id=sa; password=CONTRASEÑA; TrustServerCertificate=True;";
                //indica que el comando que se va a ejecutar es de tipo Text
                comando.CommandType = System.Data.CommandType.Text;
                //se define consulta que se va a ejecutar
                comando.CommandText = "Select Numero,Nombre,Descripcion from POKEMONS";
                //se asocia el comando a la conexion
                comando.Connection = conexion;
                //inicia conexion
                conexion.Open();
                //se ejecuta el select
                lector = comando.ExecuteReader();

                //intenta avanzar a la sig fila mientras devuelva true
                while (lector.Read()) {
                    //se crea un obj llamado Pokemon
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    lista.Add(aux);
                }
                //se cierra conexion
                conexion.Close();
                //devuelve la lista completa al lugar que llamo al metodo
                return lista;
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }
    }
}
