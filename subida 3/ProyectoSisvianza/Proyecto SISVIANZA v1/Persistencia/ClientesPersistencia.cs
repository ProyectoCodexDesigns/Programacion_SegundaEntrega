using System;
using System.Collections.Generic;
using System.Net.PeerToPeer.Collaboration;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using Mysqlx;
using Mysqlx.Prepare;
using Proyecto_SISVIANZA_v1.Logica;

namespace Proyecto_SISVIANZA_v1.Persistencia
{    //Falta editar
    public class ClientesPersistencia
    {
        // DATOS PARA ENTRAR A BASE DE DATOS
        readonly string server = "localhost";
        readonly string user = "root";
        readonly string pass = "";
        readonly string dataBase = "proyectosisvianza";

        string connectionString;

        public void AgregarCliente(Cliente nuevoCliente)
        {
            try
            {
                //Datos para la coneccion a la base de datos
                connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
                //Se usa la clase MySqlConnection y se crea un objeto de esta y se le pasa como argumento los datos mismo para esa coneccion.
                using (MySqlConnection coneccion = new MySqlConnection(connectionString))
                {//Se utiliza using para asegurarse de que se realice una limpieza adecuada de recursos después de que se haya completado su uso.
                    coneccion.Open();
                    string consulta = "INSERT INTO CLIENTE (CI, NOMBRE, TELEFONO, DIRECCION, MAIL, TIPO, ALERGIAS, ESTADO) VALUES (@Ci, @Nombre, @Telefono, @Direccion, @Mail, @Tipo, @Alergias, @Estado)";
                    //Se crea el objeto comando2 q es basicamente leer la consulta mediante la coneccion
                    MySqlCommand comando2 = new MySqlCommand(consulta, coneccion);
                    //Al objeto se le agrega un parametro mediante AddWithValue para poder darle un valor a ese parametro en especifico ( @Ci )
                    comando2.Parameters.AddWithValue("@Ci", nuevoCliente.Ci);
                    comando2.Parameters.AddWithValue("@Nombre", nuevoCliente.Nombre);
                    comando2.Parameters.AddWithValue("@Telefono", nuevoCliente.Telefono);
                    comando2.Parameters.AddWithValue("@Direccion", nuevoCliente.Direccion);
                    comando2.Parameters.AddWithValue("@Mail", nuevoCliente.Mail);
                    comando2.Parameters.AddWithValue("@Alergias", nuevoCliente.Alergias);
                    comando2.Parameters.AddWithValue("@Tipo", nuevoCliente.Tipo);
                    comando2.Parameters.AddWithValue("@Estado", nuevoCliente.Estado);
                    //Ejecuta la consulta y realiza los cambios en la base de datos según la consulta del comando
                    comando2.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)// catch captura las excepciones osea errores de lo q esta dentrod el try, dentro de la clase MySqlException y lo guarda en ex si hay algo mal
            {
                Console.WriteLine("Error al agregar el cliente a la base de datos: " + ex.Message);
            }
        }


        public void ActualizarCliente(Cliente clienteActualizado)
        {
            try
            {
                //Datos para la coneccion a la base de datos
                connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
                //Se usa la clase MySqlConnection y se crea un objeto de esta y se le pasa como argumento los datos mismo para esa coneccion.
                using (MySqlConnection coneccion = new MySqlConnection(connectionString))
                {
                    //Se abre la coneccion.
                    coneccion.Open();
                    //Actualizar los datos del cliente
                    string consulta = "UPDATE CLIENTE SET NOMBRE = @Nombre, TELEFONO = @Telefono, DIRECCION = @Direccion, MAIL = @Mail, ALERGIAS = @Alergias, TIPO = @Tipo, ESTADO = @Estado WHERE CI = @Ci";
                    //Se crea el objeto comando3 q es basicamente leer la consulta mediante la coneccion
                    MySqlCommand comando3 = new MySqlCommand(consulta, coneccion);
                    comando3.Parameters.AddWithValue("@Ci", clienteActualizado.Ci);
                    comando3.Parameters.AddWithValue("@Nombre", clienteActualizado.Nombre);
                    comando3.Parameters.AddWithValue("@Telefono", clienteActualizado.Telefono);
                    comando3.Parameters.AddWithValue("@Direccion", clienteActualizado.Direccion);
                    comando3.Parameters.AddWithValue("@Mail", clienteActualizado.Mail);
                    comando3.Parameters.AddWithValue("@Tipo", clienteActualizado.Tipo);
                    comando3.Parameters.AddWithValue("@Alergias", clienteActualizado.Alergias);
                    comando3.Parameters.AddWithValue("@Estado", clienteActualizado.Estado);
                    //Ejecuta la consulta y realiza los cambios en la base de datos según la consulta del comando
                    comando3.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)//Catch captura las excepciones osea errores de lo q esta dentrod el try, dentro de la clase MySqlException y lo guarda en ex si hay algo mal
            {
                Console.WriteLine("Error al actualizar el cliente a la base de datos: " + ex.Message);
            }
        }

        //Metodo para listar los clientes
        public List<Cliente> ObtenerClientes()
        {
            //Datos para la coneccion a la base de datos
            connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

            //Creacion una lista clientes que puede tener datos del tipo Cliente
            List<Cliente> clientes = new List<Cliente>();
            //Se usa la clase MySqlConnection y se crea un objeto de esta y se le pasa como argumento los datos mismo para esa coneccion.
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                //Se abre la coneccion.
                connection.Open();
                //Que muestre todos los clientes
                string consulta = "SELECT * FROM CLIENTE";
                //Se crea el objeto comando4 q es basicamente leer la consulta mediante la coneccion
                MySqlCommand comando4 = new MySqlCommand(consulta, connection);
                //ExecuteReader:Devuelve un DataReader que te permite leer y acceder a los resultados de la consulta fila por fila y columna por columna.
                using (MySqlDataReader lector = comando4.ExecuteReader())
                {//MySqlDataReader permite leer y acceder a los datos de una consulta de forma secuencial, fila por fila, y realizar operaciones con esos datos en el código.
                    while (lector.Read())
                    {
                        int ci = lector.IsDBNull(lector.GetOrdinal("CI")) ? 0 : lector.GetInt32("CI");
                        string nombre = lector.IsDBNull(lector.GetOrdinal("NOMBRE")) ? string.Empty : lector.GetString("NOMBRE");
                        string telefono = lector.IsDBNull(lector.GetOrdinal("TELEFONO")) ? string.Empty : lector.GetString("TELEFONO");
                        string direccion = lector.IsDBNull(lector.GetOrdinal("DIRECCION")) ? string.Empty : lector.GetString("DIRECCION");
                        string mail = lector.IsDBNull(lector.GetOrdinal("MAIL")) ? string.Empty : lector.GetString("MAIL");
                        string alergias = lector.IsDBNull(lector.GetOrdinal("ALERGIAS")) ? string.Empty : lector.GetString("ALERGIAS");
                        string tipo = lector.IsDBNull(lector.GetOrdinal("TIPO")) ? string.Empty : lector.GetString("TIPO");
                        int estado = lector.IsDBNull(lector.GetOrdinal("ESTADO")) ? 0 : lector.GetInt32("ESTADO");

                        Cliente cliente = new Cliente(ci, nombre, telefono, direccion, mail, alergias, tipo, estado);
                        clientes.Add(cliente);
                    }
                }
            }
            //Después de leer todos los datos del DataReader y agregar los objetos Cliente a la lista clientes, se devuelve la lista de los clientes
            return clientes;
        }
        public List<Cliente> ObtenerClientesPorCedula(string cedula)
        {
            //Datos para la coneccion a la base de datos
            connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";

            string sql = "SELECT CI, NOMBRE, TELEFONO, DIRECCION, MAIL, ALERGIAS, TIPO, ESTADO FROM CLIENTE WHERE CI = @Cedula";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    List<Cliente> listaClientes = new List<Cliente>();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ci = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string telefono = reader.GetString(2);
                            string direccion = reader.GetString(3);
                            string mail = reader.GetString(4);
                            string alergias = reader.GetString(5);
                            string tipo = reader.GetString(6);
                            int estado = reader.GetInt32(7);
                            Cliente cliente = new Cliente(ci, nombre, telefono, direccion, mail, alergias, tipo, estado);
                            listaClientes.Add(cliente);
                        }
                    }

                    return listaClientes;
                }
            }
        }
    }
}
