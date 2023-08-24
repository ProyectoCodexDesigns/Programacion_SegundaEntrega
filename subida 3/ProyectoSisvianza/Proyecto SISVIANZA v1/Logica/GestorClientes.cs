using System.Collections.Generic;
using Proyecto_SISVIANZA_v1.Persistencia;
using System.Text.RegularExpressions;
using System.Linq;
using Proyecto_SISVIANZA_v1.Presentacion;

namespace Proyecto_SISVIANZA_v1.Logica { 

    public class GestorClientes
    {
       // private formularioAdministrador administrador;
        private ClientesPersistencia clientePersistencia;

        public GestorClientes()
        {
            clientePersistencia = new ClientesPersistencia();
          // administrador = new formularioAdministrador();
        }

        public void AgregarCliente(Cliente nuevoCliente)
        {
            clientePersistencia.AgregarCliente(nuevoCliente);
        }
        public void ActualizarCliente(Cliente clienteActualizado)
        {
            clientePersistencia.ActualizarCliente(clienteActualizado);
        }
        public List<Cliente> ObtenerClientes()
        {
            return clientePersistencia.ObtenerClientes();
        }

        public List<Cliente> ObtenerClientesPorCedula(string ci)
        {
            return clientePersistencia.ObtenerClientesPorCedula(ci);
        }
        public bool ExisteCliente(int ci)
        {
            List<Cliente> clientes = ObtenerClientes();
            return clientes.Any(c => c.Ci == ci);
        }



        private static List<Cliente> Clientes = new List<Cliente>();



        public void EnviarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
           // administrador.RecibirCliente(cliente);
        }





    }
}
