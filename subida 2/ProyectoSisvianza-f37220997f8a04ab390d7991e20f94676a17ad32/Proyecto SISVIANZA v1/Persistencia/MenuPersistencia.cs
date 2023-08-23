using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_SISVIANZA_v1.Logica;
using MySql.Data.MySqlClient;
namespace Proyecto_SISVIANZA_v1.Persistencia
{
    class MenuPersistencia
    {
        readonly string server = "localhost";
        readonly string user = "root";
        readonly string pass = "";
        readonly string dataBase = "proyectosisvianza";
        string connectionString;

        public List<Menu> ObtenerTodosLosMenus()
        {
            List<Menu> listaMenus = new List<Menu>();

            try
            {
                connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT ID_MENU, STOCK, NOMBRE, STOCK_MINIMO FROM MENU";

                    MySqlCommand comando = new MySqlCommand(sql, connection);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int menuId = reader.GetInt32(0);
                            int stock = reader.GetInt32(1);
                            string nombre = reader.GetString(2);
                            int stock_Minimo = reader.GetInt32(3);
                            

                            // Crear objetos Cliente y Pedido
                            Menu menu = new Menu(menuId, stock, nombre, stock_Minimo);

                            // Agregar el pedido a la lista
                            listaMenus.Add(menu);

                            Console.WriteLine("Consulta SQL: " + sql);

                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener los pedidos de la base de datos: " + ex.Message);
            }

            return listaMenus;

        }
        public List<Menu> ObtenerMenusPorId(int id)
        {
            string connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

            string sql = "SELECT ID_MENU, STOCK, NOMBRE, STOCK_MINIMO FROM MENU WHERE ID_MENU = @Id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand comando = new MySqlCommand(sql, connection);
                {
                    comando.Parameters.AddWithValue("@Id", id);

                    List<Menu> listaMenus = new List<Menu>();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int menuId = reader.GetInt32(0);
                            int stock = reader.GetInt32(1);
                            string nombre = reader.GetString(2);
                            int stock_Minimo = reader.GetInt32(3);


                            // Crear objetos y Pedido
                            Menu menu = new Menu(menuId, stock, nombre, stock_Minimo);

                            // Agregar el pedido a la lista
                            listaMenus.Add(menu);

                        }

                    }
                    return listaMenus;


                }

            }



            


        }
    }
}
