using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Proyecto_SISVIANZA_v1.Logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

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

                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO PEDIDO (CANTIDAD_MENUS, DESCRIPCION, FECHA_ENTREGA,FECHA_CREACION, CI_CLIENTE, ESTADO,TIPO_MENU,CANTIDAD_VIANDAS) VALUES (@CantidadMenus, @Descripcion, @FechaEntrega,@FechaCreacion, @CiCliente, @Estado, @Tipo_Menu,@Cantidad_Viandas)";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@CantidadMenus", pedido.CantidadMenus);
                    comando.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                    comando.Parameters.AddWithValue("@FechaEntrega", pedido.FechaEntrega);
                    comando.Parameters.AddWithValue("@FechaCreacion", pedido.FechaCreacion);
                    comando.Parameters.AddWithValue("@CiCliente", pedido.Cliente.Ci);
                    comando.Parameters.AddWithValue("@Estado", pedido.Estado);
                    comando.Parameters.AddWithValue("@Tipo_Menu", pedido.Tipo_Menu);
                    comando.Parameters.AddWithValue("@Cantidad_Viandas", pedido.Cantidad_VIandas);

                    comando.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al guardar el pedido en la base de datos: " + ex.Message);
            }
        }




































        public void ActualizarPedido(Pedido pedido)
        {
            try
            {
                connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    string consulta = "UPDATE PEDIDO SET CANTIDAD_MENUS = @CantidadMenus, DESCRIPCION = @Descripcion, FECHA_ENTREGA = @FechaEntrega, ESTADO = @Estado WHERE ID_PEDIDO = @IdPedido";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@CantidadMenus", pedido.CantidadMenus);
                    comando.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                    comando.Parameters.AddWithValue("@FechaEntrega", pedido.FechaEntrega);
                    comando.Parameters.AddWithValue("@Estado", pedido.Estado);
                    comando.Parameters.AddWithValue("@IdPedido", pedido.Id);

                    comando.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al actualizar el pedido en la base de datos: " + ex.Message);
            }
        }





















        public List<Pedido> ObtenerTodosLosPedidos()
        {
            // Datos para la conexión a la base de datos
            string connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

            string sql = "SELECT ID_PEDIDO, CI_CLIENTE, CANTIDAD_MENUS, DESCRIPCION, FECHA_ENTREGA, FECHA_CREACION, ESTADO, TIPO_MENU, CANTIDAD_VIANDAS FROM PEDIDO";

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
                            int clienteCi = reader.GetInt32(1);
                            int cantidadMenus = reader.GetInt32(2);
                            string descripcion = reader.GetString(3);
                            DateTime fechaEntrega = reader.GetDateTime(4);
                            DateTime fechaCreacion = reader.GetDateTime(5);
                            int estado = reader.GetInt32(6);
                            int tipomenu = reader.GetInt32(7);
                            int cantidadviandas = reader.GetInt32(8);

                            Cliente cliente = new Cliente(clienteCi, "", "", "", "", "", "", 0);

                            Pedido pedido = new Pedido(pedidoId, cantidadMenus, descripcion, fechaEntrega, fechaCreacion, cliente, estado, tipomenu, cantidadviandas);

                            listaPedidos.Add(pedido);
                        }
                    }

                    return listaPedidos;
                }
            }
        }









        public List<Pedido> ObtenerPedidoPorIdTipoLista(int id)
        {
            List<Pedido> listaPedidos = new List<Pedido>();

            // Datos para la conexión a la base de datos
            string connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

            string sql = "SELECT ID_PEDIDO, CANTIDAD_MENUS, DESCRIPCION, FECHA_ENTREGA, FECHA_CREACION, CI_CLIENTE, ESTADO, TIPO_MENU, CANTIDAD_VIANDAS FROM PEDIDO WHERE ID_PEDIDO = @Id";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int pedidoId = reader.GetInt32(0);
                            int cantidadMenus = reader.GetInt32(1);
                            string descripcion = reader.GetString(2);
                            DateTime fechaEntrega = reader.GetDateTime(3);
                            DateTime fechaCreacion = reader.GetDateTime(4);
                            int clienteCi = reader.GetInt32(5);
                            int estado = reader.GetInt32(6);
                            int tipomenu = reader.GetInt32(7);
                            int cantidadviandas = reader.GetInt32(8);

                            Cliente cliente = new Cliente(clienteCi, "", "", "", "", "", "", 0);

                            Pedido pedido = new Pedido(pedidoId, cantidadMenus, descripcion, fechaEntrega, fechaCreacion, cliente, estado, tipomenu, cantidadviandas);

                            listaPedidos.Add(pedido);
                        }
                    }
                }
            }

            return listaPedidos;
        }






        public Pedido ObtenerPedidoPorId(int id)
        {
            // Datos para la conexión a la base de datos
            string connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

            string sql = "SELECT ID_PEDIDO, CANTIDAD_MENUS, DESCRIPCION, FECHA_ENTREGA, FECHA_CREACION, CI_CLIENTE, ESTADO, TIPO_MENU, CANTIDAD_VIANDAS FROM PEDIDO WHERE ID_PEDIDO = @Id";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Solo tiene q ser   un único pedidoOOOOOOOOOOOOOOOOOOOOO
                        {
                            int pedidoId = reader.GetInt32(0);
                            int cantidadMenus = reader.GetInt32(1);
                            string descripcion = reader.GetString(2);
                            DateTime fechaEntrega = reader.GetDateTime(3);
                            DateTime fechaCreacion = reader.GetDateTime(4);
                            int clienteCi = reader.GetInt32(5);
                            int estado = reader.GetInt32(6);
                            int tipomenu = reader.GetInt32(7);
                            int cantidadviandas = reader.GetInt32(8);



                            Cliente cliente = new Cliente(clienteCi, "", "", "", "", "", "", 0);

                            Pedido pedido = new Pedido(pedidoId, cantidadMenus, descripcion, fechaEntrega, fechaCreacion, cliente, estado, tipomenu, cantidadviandas);

                            return pedido;
                        }
                    }
                }
            }

            return null; // Si no se encontró el pedido
        }






        public bool EliminarPedido(int idpedido)
        {
            string connectionString = "Server=" + server + "; Database=" + dataBase + "; User=" + user + "; Password=" + pass;

            using (var conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();

                using (var cmd = new MySqlCommand("DELETE FROM Pedido WHERE ID_PEDIDO = @PedidoId", conexion))
                {
                    cmd.Parameters.AddWithValue("@PedidoId", idpedido);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
        }










    }
}
