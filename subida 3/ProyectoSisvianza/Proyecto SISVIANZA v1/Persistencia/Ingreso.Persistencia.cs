using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Proyecto_SISVIANZA_v1.Persistencia
{
    class IngresoPersistencia
    {
        //Readonly es solo para lectura
        // DATOS PARA ENTRAR A BASE DE DATOS
        readonly string server = "localhost";
        readonly string user = "root";
        readonly string pass = "";
        readonly string dataBase = "proyectosisvianza";

        string connectionString;

        // Método de verificación de datos sin riesgo de ataque de inyección de datos.
        public bool Verificar(string nombre, string contraseña)
        {
            connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

            string sql = "SELECT CI, CONTRASEÑA FROM USUARIO WHERE CI = @Nombre AND CONTRASEÑA = @Contraseña";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }

        // Método para extraer el rol que concuerda con la cédula de identidad (nombre) que el usuario ingresó.
        public string ObtenerRol(string nombre)
        {
            connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

            string sql = "SELECT ROL FROM USUARIO WHERE CI = @Nombre";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    string resultado = "";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string valorColumna = reader.GetString(0);
                            resultado += valorColumna;
                        }

                        return resultado;
                    }
                }
            }
        }
    }
}