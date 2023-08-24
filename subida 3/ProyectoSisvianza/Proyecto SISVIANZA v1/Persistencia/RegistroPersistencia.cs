using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_SISVIANZA_v1.Persistencia
{
    internal class RegistroPersistencia
    {
        //DATOS PARA ENTRAR A BASE DE DATOS
        string server = "localhost";
        string user = "root";
        string pass = "";
        string dataBase = "proyectosisvianza";
        string connectionString;
        //Metodo para insertar datos en tabla usuario.
        public void Registrar(string ci, string password, string rol)
        {
            connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
            string sql = "INSERT INTO USUARIO (CI, CONTRASEÑA, ROL) VALUES (@CI, @PASSWORD, @ROL)";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CI", ci);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    cmd.Parameters.AddWithValue("@ROL", rol);
                    cmd.ExecuteNonQuery(); // Ejecutar el comando SQL
                }
            }
        }
        //Metodo para modificar datos en tabla usuario.
        public void Actualizar(string ci, string newPassword, string newRol)
        {
            connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
            string sql = "UPDATE USUARIO SET CONTRASEÑA = @NEWPASSWORD, ROL = @NEWROL WHERE CI = @CI";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CI", ci);
                    cmd.Parameters.AddWithValue("@NEWPASSWORD", newPassword);
                    cmd.Parameters.AddWithValue("@NEWROL", newRol);
                    cmd.ExecuteNonQuery(); // Ejecutar el comando SQL
                }
            }
        }
        //Metodo para eliminar datos en tabla usuario.
        public void Eliminar(string ci)
        {
            connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
            string sql = "DELETE FROM USUARIO WHERE CI = @CI";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CI", ci);
                    cmd.ExecuteNonQuery(); // Ejecutar el comando SQL
                }
            }
        }

        //Metodo para comprobar si la cedula ingresada ya existe.
        public Boolean VerificarRol(string rol)
        {
            List<string> rolesPermitidos = new List<string>() //Lista con los roles permitidos
                    {
                    "Gerente",
                    "Administrador",
                    "Jefe De Cocina",
                    "Encargado De Transporte",
                    "Atención Al Público",
                    "Informático"
                    };
            string rolIngresado = rol;
            bool esValido = rolesPermitidos.Contains(rolIngresado); //verifica si el valor ingresado(rolIngresado) se encuentra en esa lista utilizando el método Contains de la lista.
            return esValido;
        }
        //Metodo para comprobar si el rol  existe.
        public Boolean Cidiff(string ci)
        {
            connectionString = "Database=" + dataBase + "; Data Source=" + server + "; User Id=" + user + "; Password=" + pass + "";
            string sql = "SELECT CI FROM usuario WHERE CI = @Ci";// Se define la consulta SQL con marcadores de posición (@Nombre y @Contraseña) en lugar de concatenar los valores directamente.
            using (MySqlConnection con = new MySqlConnection(connectionString)) //la conexión se establece y se utiliza dentro del bloque using. Al finalizar el bloque, se liberan los recursos llamando automáticamente a Dispose() en el objeto SqlConnection, lo que garantiza que la conexión se cierre correctamente.
            {                                                                   //using es una estructura de control en C# que se utiliza para asegurar la liberación de recursos al finalizar un bloque de código
                con.Open(); // Se crea una instancia de MySqlConnection y se abre la conexión.

                using (MySqlCommand cmd = new MySqlCommand(sql, con)) // Se crea una instancia de MySqlCommand, pasando la consulta SQL y la conexión.
                {
                    cmd.Parameters.AddWithValue("@Ci", ci);

                    using (MySqlDataReader reader = cmd.ExecuteReader()) //Execute reader es para poder realizar la consulta
                    {
                        // Se crea una instancia de MySqlDataReader para leer los resultados de la consulta.
                        return reader.Read();
                        // Se utiliza el método Read() para intentar leer el primer registro devuelto por la consulta.
                        // Si hay al menos un registro, se retorna true; de lo contrario, se retorna false.
                    }
                }
            }
        }

    }
}
