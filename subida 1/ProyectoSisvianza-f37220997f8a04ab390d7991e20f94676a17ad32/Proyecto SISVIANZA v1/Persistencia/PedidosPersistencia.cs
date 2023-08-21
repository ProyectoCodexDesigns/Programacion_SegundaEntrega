using MySql.Data.MySqlClient;
using Proyecto_SISVIANZA_v1.Logica;
using System;
using System.Collections.Generic;

namespace Proyecto_SISVIANZA_v1.Persistencia
{
    class PedidosPersistencia
    {
        readonly string server = "localhost";
        readonly string user = "root";
        readonly string pass = "";
        readonly string dataBase = "proyectosisvianza";

        string connectionString;
        public void GuardarPedido(Pedido pedido)
        {
            try
            {
                connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string consulta = "INSERT INTO PEDIDO (ID, CI_CLIENTE, CANTIDAD_MENUS, CANTIDAD_VEHICULOS, DESCRIPCION, TIPO_MENU, CANTIDAD_VIANDAS, PREFERENCIAS_DIETETICAS, FECHA_ENTREGA, DIRECCION, ESTADO) VALUES (@Id, @ClienteCi, @CantidadMenus, @CantidadVehiculos, @Descripcion, @TipoMenu, @CantidadViandas, @PreferenciasDieteticas, @FechaEntrega, @Direccion, @Estado)";
                    MySqlCommand comando = new MySqlCommand(consulta, connection);
                    comando.Parameters.AddWithValue("@Id", pedido.Id);
                    comando.Parameters.AddWithValue("@ClienteCi", pedido.Cliente.Ci);
                    comando.Parameters.AddWithValue("@CantidadMenus", pedido.CantidadMenus);
                    comando.Parameters.AddWithValue("@CantidadVehiculos", pedido.CantidadVehiculos);
                    comando.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                    comando.Parameters.AddWithValue("@TipoMenu", pedido.TipoMenu);
                    comando.Parameters.AddWithValue("@CantidadViandas", pedido.CantidadViandas);
                    comando.Parameters.AddWithValue("@PreferenciasDieteticas", pedido.PreferenciasDieteticas);
                    // Convertir FechaEntrega a un string en el formato de fecha esperado por la base de datos
                    string fechaEntregaStr = pedido.FechaEntrega.ToString("yyyy-MM-dd");
                    comando.Parameters.AddWithValue("@FechaEntrega", fechaEntregaStr);
                    comando.Parameters.AddWithValue("@Direccion", pedido.Direccion);
                    comando.Parameters.AddWithValue("@Estado", pedido.Estado);
                    comando.ExecuteNonQuery();


                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al agregar el pedido a la base de datos: " + ex.Message);
            }
        }

        public List<Pedido> ObtenerTodosLosPedidos()
        {
            List<Pedido> listaPedidos = new List<Pedido>();

            try
            {
                connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT ID, CI_CLIENTE, CANTIDAD_MENUS, CANTIDAD_VEHICULOS, DESCRIPCION, TIPO_MENU, CANTIDAD_VIANDAS, PREFERENCIAS_DIETETICAS, FECHA_ENTREGA, DIRECCION, ESTADO FROM PEDIDO";

                    MySqlCommand comando = new MySqlCommand(sql, connection);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int pedidoId = reader.GetInt32(0);
                            int clienteCi = reader.GetInt32(1);
                            int cantidadMenus = reader.GetInt32(2);
                            int cantidadVehiculos = reader.GetInt32(3);
                            string descripcion = reader.GetString(4);
                            string tipoMenu = reader.GetString(5);
                            int cantidadViandas = reader.GetInt32(6);
                            string preferenciasDieteticas = reader.GetString(7);
                            DateTime fechaEntrega = reader.GetDateTime(8);
                            string direccion = reader.GetString(9);
                            string estado = reader.GetString(10);

                            // Crear objetos Cliente y Pedido
                            Cliente cliente = new Cliente(clienteCi, "", "", "", "", "", "", "");
                            Pedido pedido = new Pedido(pedidoId, cliente, cantidadMenus, cantidadVehiculos, descripcion, tipoMenu, cantidadViandas, preferenciasDieteticas, fechaEntrega, direccion, estado);

                            // Agregar el pedido a la lista
                            listaPedidos.Add(pedido);

                            Console.WriteLine("Consulta SQL: " + sql);

                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener los pedidos de la base de datos: " + ex.Message);
            }

            return listaPedidos;

        }

        public List<Pedido> ObtenerPedidoPorId(int id)
        {
            // Datos para la conexión a la base de datos
            string connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

            string sql = "SELECT ID, CI_CLIENTE, CANTIDAD_MENUS, CANTIDAD_VEHICULOS, DESCRIPCION, TIPO_MENU, CANTIDAD_VIANDAS, PREFERENCIAS_DIETETICAS, FECHA_ENTREGA, DIRECCION, ESTADO FROM PEDIDO WHERE ID = @Id";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    List<Pedido> listaPedidos = new List<Pedido>();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int pedidoId = reader.GetInt32(0);
                            int clienteCi = reader.GetInt32(1);
                            int cantidadMenus = reader.GetInt32(2);
                            int cantidadVehiculos = reader.GetInt32(3);
                            string descripcion = reader.GetString(4);
                            string tipoMenu = reader.GetString(5);
                            int cantidadViandas = reader.GetInt32(6);
                            string preferenciasDieteticas = reader.GetString(7);
                            DateTime fechaEntrega = reader.GetDateTime(8);
                            string direccion = reader.GetString(9);
                            string estado = reader.GetString(10);

                            Cliente cliente = new Cliente(clienteCi, "", "", "", "", "", "", "");

                            Pedido pedido = new Pedido(pedidoId, cliente, cantidadMenus, cantidadVehiculos, descripcion, tipoMenu, cantidadViandas, preferenciasDieteticas, fechaEntrega, direccion, estado);

                            listaPedidos.Add(pedido);
                        }
                    }

                    return listaPedidos;
                }
            }
        }
        public bool ExisteIDPedido(int idPedido)
        {
            bool existe = false;
            try
            {
                connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string consulta = "SELECT COUNT(*) FROM PEDIDO WHERE ID = @IdPedido";
                    MySqlCommand comando = new MySqlCommand(consulta, connection);
                    comando.Parameters.AddWithValue("@IdPedido", idPedido);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count > 0)
                    {
                        existe = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al verificar la existencia de la ID del pedido en la base de datos: " + ex.Message);
            }

            return existe;
        }




        /* CODIGO PARA PEDIDOS DEL JEFE DE COCINA

        public List<Pedido> ObtenerTodosLosPedidosJefe()
        {
            // Datos para la conexión a la base de datos
            string connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

            string sql = "SELECT ID, CANTIDAD_MENUS, DESCRIPCION, TIPO_MENU, CANTIDAD_VIANDAS, PREFERENCIAS_DIETETICAS, FECHA_ENTREGA FROM PEDIDO";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    List<Pedido> listaPedidos = new List<Pedido>();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int pedidoId = reader.GetInt32(0);
                            int cantidadMenus = reader.GetInt32(2);
                            string descripcion = reader.GetString(4);
                            string tipoMenu = reader.GetString(5);
                            int cantidadViandas = reader.GetInt32(6);
                            string preferenciasDieteticas = reader.GetString(7);
                            DateTime fechaEntrega = reader.GetDateTime(8);

                            Cliente cliente = new Cliente(0,"","","","","","","");
                            Pedido pedido = new Pedido(pedidoId, cliente, cantidadMenus, 0, descripcion, tipoMenu, cantidadViandas, preferenciasDieteticas, fechaEntrega, "", "");
                            listaPedidos.Add(pedido);


                        }
                    }
                    return listaPedidos;

                }
            }*/

        }

    }



