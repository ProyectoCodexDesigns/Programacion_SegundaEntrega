using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto_SISVIANZA_v1.Logica
{
    internal class GestorValidaciones
    {
        public bool ContieneSoloNumeros(string texto)
        {
            string patron = "^[0-9]+$";
            return Regex.IsMatch(texto, patron);
        }
        public bool ContieneSoloTexto(string texto)
        {
            string patron = "^[a-zA-Z]+$";
            return Regex.IsMatch(texto, patron);
        }
        public bool Tiempo(string tiempo)
        {
            string patron = @"^(?:[0-1]?[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$";
            return Regex.IsMatch(tiempo, patron);
        }
        public bool ValidarFormatoEmail(string email)
        {
            string formato = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, formato);
        }
    
    }
}
