using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1
{
    static class Ejecutor
    {
        [STAThread] // Asegura que la aplicación se ejecute en modo de subproceso de un solo hilo (Single-Threaded Apartment)
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login loginForm = new login();
            Application.Run(loginForm);
        }
    }
}
