using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System; // Importa el espacio de nombres System
using System.IO; // Importa el espacio de nombres System.IO para manejo de archivos

namespace Proyecto_SISVIANZA_v1.Logica
{
    internal class ConexionBaseDeDatos
    {


        public class DatabaseConnectionInfo
        {
            // Clase que representa la información de conexión a la base de datos
            public string Server { get; set; } // Propiedad para almacenar el nombre del servidor
            public string Database { get; set; } 
            public string Username { get; set; } 
            public string Password { get; set; } 
            public string Puerto { get; set; }
        }

        public static class ConnectionStringReader
        {
            // Clase estática para leer la información de conexión desde un archivo
            public static DatabaseConnectionInfo ReadConnectionInfo(string filePath)
            {
                try
                {
                    // Intenta leer todas las líneas del archivo en la ruta especificada
                    string[] lines = File.ReadAllLines(filePath);

                    if (lines.Length >= 5)
                    {
                        // Si hay al menos cinco líneas, crea un objeto DatabaseConnectionInfo y asigna los valores
                        return new DatabaseConnectionInfo
                        {
                            Server = lines[0], // Asigna la primera línea al nombre del servidor
                            Database = lines[1], // Asigna la segunda línea al nombre de la base de datos
                            Username = lines[2], // Asigna la tercera línea al nombre de usuario
                            Password = lines[3], // Asigna la cuarta línea a la contraseña
                            Puerto = lines[4] // Asigna la quinta línea a la contraseña
                        };
                    }
                    else
                    {
                        // Si no hay suficientes líneas, lanza una excepción indicando un archivo de configuración incorrecto
                        throw new InvalidOperationException("Archivo de configuración incorrecto.");
                    }
                }
                catch (Exception ex)
                {
                    // Captura cualquier excepción ocurrida durante el proceso y lanza una nueva excepción con un mensaje personalizado
                    throw new Exception("Error al leer el archivo de conexión: " + ex.Message);
                }
            }
        }
    }
}


