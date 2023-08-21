using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_SISVIANZA_v1.Logica;
using MySql.Data.MySqlClient;

namespace Proyecto_SISVIANZA_v1.Persistencia
{
    class ViandasPersistencia
    {
        readonly string server = "localhost";
        readonly string user = "root";
        readonly string pass = "";
        readonly string dataBase = "proyectosisvianza";
        string connectionString;

        public List<Vianda> ObtenerTodasLasViandas()
        {
            List<Vianda> listaViandas = new List<Vianda>();

            try
            {
                connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT ID, NOMBRE, FECHA_CADUCIDAD, TIPO_DIETA, TIEMPO_HORAS, DESCRIPCION, TIPO_POSTRE FROM VIANDA";

                    MySqlCommand comando = new MySqlCommand(sql, connection);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int viandaId = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            DateTime fechaCaducidad = reader.GetDateTime(2);
                            string tipoDieta = reader.GetString(3);
                            int tiempoHoras = reader.GetInt32(4);
                            string descripcion = reader.GetString(5);
                            string tipoPostre = reader.GetString(6);


                            // Crear objetos Pedido
                            Vianda vianda = new Vianda(viandaId, nombre, fechaCaducidad, tipoDieta, tiempoHoras, descripcion, tipoPostre);

                            // Agregar el pedido a la lista
                            listaViandas.Add(vianda);

                            Console.WriteLine("Consulta SQL: " + sql);

                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener los pedidos de la base de datos: " + ex.Message);
            }

            return listaViandas;
        }
        public List<Vianda> ObtenerViandasPorId(int id)
        {
            List<Vianda> listaViandas = new List<Vianda>();

            try
            {
                connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT ID, NOMBRE, FECHA_CADUCIDAD, TIPO_DIETA, TIEMPO_HORAS, DESCRIPCION, TIPO_POSTRE FROM VIANDA WHERE ID = @Id";

                    MySqlCommand comando = new MySqlCommand(sql, connection);

                    comando.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int viandaId = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            DateTime fechaCaducidad = reader.GetDateTime(2);
                            string tipoDieta = reader.GetString(3);
                            int tiempoHoras = reader.GetInt32(4);
                            string descripcion = reader.GetString(5);
                            string tipoPostre = reader.GetString(6);


                            // Crear objetos Pedido
                            Vianda vianda = new Vianda(viandaId, nombre, fechaCaducidad, tipoDieta, tiempoHoras, descripcion, tipoPostre);

                            // Agregar el pedido a la lista
                            listaViandas.Add(vianda);

                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener los pedidos de la base de datos: " + ex.Message);
            }

            return listaViandas;
        }

    }
}
