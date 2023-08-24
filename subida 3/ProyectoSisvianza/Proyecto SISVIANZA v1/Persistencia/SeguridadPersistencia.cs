using System;
using MySql.Data.MySqlClient;

namespace Proyecto_SISVIANZA_v1.Persistencia
{
    internal class SeguridadPersistencia
    {
        // DATOS PARA ENTRAR A BASE DE DATOS
        string server = "localhost";
        string user = "root";
        string pass = "";
        string dataBase = "proyectosisvianza";
        string connectionString;

        public void RealizarCopiaSeguridad(string backupPath)
        {
            connectionString = $"Server={server};Database={dataBase};Uid={user};Pwd={pass};";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Comando SQL para realizar la copia de seguridad utilizando mysqldump
                    string backupCommand = $"mysqldump --user={user} --password={pass} --host={server} {dataBase} > \"{backupPath}\"";

                    // Iniciar un proceso para ejecutar el comando de copia de seguridad
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
                    psi.FileName = "cmd.exe";
                    psi.RedirectStandardInput = true;
                    psi.RedirectStandardOutput = true;
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    System.Diagnostics.Process process = System.Diagnostics.Process.Start(psi);
                    process.StandardInput.WriteLine(backupCommand);
                    process.StandardInput.Flush();
                    process.StandardInput.Close();
                    process.WaitForExit();

                    Console.WriteLine("Copia de seguridad realizada con éxito.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al realizar la copia de seguridad: " + ex.Message);
            }
        }
    }
}
