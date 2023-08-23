namespace Proyecto_SISVIANZA_v1.Logica
{
    //Atajos:  

    //Ctrl+A+K+F : Ordena el codigo

    //Ctrl+K+C   : Comenta el codigo

    //Ctrl+K+U   : Descomenta el codigo

    // F7 va al codigo shift + F7 va al diseño

    //Deshacer : Ctrl + Z , Rehacer : Ctrl + Y


    //Falta editar
    public class Cliente
    {
        public int Ci { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Alergias { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }

        public Cliente(int ci, string nombre, string telefono, string direccion, string mail, string alergias, string tipo, string estado)
        {
            this.Ci = ci;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Mail = mail;
            this.Alergias = alergias;
            this.Tipo = tipo;
            this.Estado = estado;
        }
    }
}

