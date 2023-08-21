using System;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion
{
    public partial class formularioAdministrador : Form
    {

        public formularioAdministrador()
        {
            InitializeComponent();

        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            VentanasDelAdministrador.formularioClientes clientes = new VentanasDelAdministrador.formularioClientes();
            clientes.Show();
            this.Close();
        }

        private void lblAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            VentanasDelAdministrador.formularioPedidos pedidos = new VentanasDelAdministrador.formularioPedidos();
            pedidos.Show();
            this.Close();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            login cerrarsecion = new login();
            cerrarsecion.Show();
            this.Close();
        }
    }
}
