using Google.Protobuf.WellKnownTypes;
using Proyecto_SISVIANZA_v1.Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDelAdministrador
{
    //Falta editar
    public partial class formularioPedidos : Form
    {
        int id;
        int clienteCi;
        int cantidadMenus;
        readonly int cantidadVehiculos = 0;
        string tipoMenu;
        int cantidadViandas;
        string preferenciasDieteticas;
        string direccion;
        string descripcion;
        string estado;

        private GestorPedidos gestorPedido;
        private GestorClientes gestorCliente;
        private GestorValidaciones gestorValidaciones;
        public formularioPedidos()
        {
            InitializeComponent();
            gestorPedido = new GestorPedidos();
            gestorCliente = new GestorClientes();
            gestorValidaciones = new GestorValidaciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            id = GenerarID();

            if (string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtCantidad_Menus.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtTipo_Menu.Text) || string.IsNullOrEmpty(txtCantidad_Viandas.Text) || string.IsNullOrEmpty(txtPreferencias_Dieteticas.Text) || string.IsNullOrEmpty(txtFecha_Entrega.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtCedula.Text) || !gestorValidaciones.ContieneSoloNumeros(txtCantidad_Menus.Text) || !gestorValidaciones.ContieneSoloNumeros(txtCantidad_Viandas.Text))
            {
                MessageBox.Show("La cédula, cantidad de menús y la cantidad de viandas deben tener únicamente dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCedula.Text.Length != 8)
            {
                MessageBox.Show("La cédula debe tener 8 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorCliente.ExisteCliente(int.Parse(txtCedula.Text)))
            {
                MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEstado.Text != "Solicitado" && txtEstado.Text != "En Stock" && txtEstado.Text != "En Produccion" && txtEstado.Text != "Envasado" && txtEstado.Text != "Entregado" && txtEstado.Text != "Devuelto")
            {
                MessageBox.Show("El estado del pedido debe ser 'En Stock', 'En Produccion', 'Envasado', 'Entregado' o 'Devuelto'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!DateTime.TryParse(txtFecha_Entrega.Text, out DateTime fechaEntrega))
            {
                MessageBox.Show("Formato de fecha de entrega es inválido. Utilice el formato dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloTexto(txtDescripcion.Text) || !gestorValidaciones.ContieneSoloTexto(txtPreferencias_Dieteticas.Text))
            {
                MessageBox.Show("Formato inválido, la descripción y las preferencias dietéticas solo aceptan caracteres alfabéticos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clienteCi = int.Parse(txtCedula.Text);
                cantidadMenus = int.Parse(txtCantidad_Menus.Text);
                descripcion = txtDescripcion.Text;
                tipoMenu = txtTipo_Menu.Text;
                cantidadViandas = int.Parse(txtCantidad_Viandas.Text);
                preferenciasDieteticas = txtPreferencias_Dieteticas.Text;
                direccion = txtDireccion.Text;
                estado = txtEstado.Text;

                Cliente cliente = new Cliente(clienteCi, "", "", "", "", "", "", "");
                Pedido pedido = new Pedido(id, cliente, cantidadMenus, cantidadVehiculos, descripcion, tipoMenu, cantidadViandas, preferenciasDieteticas, fechaEntrega, direccion, estado);

                gestorPedido.AgregarPedido(pedido);

                MessageBox.Show("Pedido guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int GenerarID()
        {
            // Obtener la fecha y hora actual en milisegundos como "semilla" para el generador de "hash"
            long timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            // Calcular el hash de la "semilla" (timestamp) para obtener una ID única
            int nuevaID = Math.Abs(timestamp.GetHashCode());

            // Verificar si la ID generada ya existe en la base de datos
            bool idExistente;
            do
            {
                idExistente = gestorPedido.ExisteIDPedido(nuevaID); // Debes implementar el método ExisteIDPedido en tu clase GestorPedido

                // Si la ID generada ya existe, aumentamos en 1 la ID y volvemos a verificar
                if (idExistente)
                {
                    nuevaID++;
                }
            }
            while (idExistente);

            return nuevaID;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioAdministrador volver = new formularioAdministrador();
            volver.Show();
            this.Close();
        }
        private void btnListar_Pedidos_Click(object sender, EventArgs e)
        {
            //// obtener la lista de pedidos desde la capa lógica
            //     list<pedido> listapedidos = gestorpedido.obtenerpedido();

            // // asignar la lista de pedidos al datagridview
            // datagridview.datasource = listapedidos;
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtCantidad_Menus.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtTipo_Menu.Text) || string.IsNullOrEmpty(txtCantidad_Viandas.Text) || string.IsNullOrEmpty(txtPreferencias_Dieteticas.Text) || string.IsNullOrEmpty(txtFecha_Entrega.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("Por favor, complete la ID ademas de los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtCedula.Text) || !gestorValidaciones.ContieneSoloNumeros(txtCantidad_Menus.Text) || !gestorValidaciones.ContieneSoloNumeros(txtCantidad_Viandas.Text))
            {
                MessageBox.Show("La cédula, cantidad de menús y la cantidad de viandas deben tener únicamente dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCedula.Text.Length != 8)
            {
                MessageBox.Show("La cédula debe tener 8 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtId.Text))
            {
                MessageBox.Show("La ID solo debe tener dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorCliente.ExisteCliente(int.Parse(txtCedula.Text)))
            {
                MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEstado.Text != "Solicitado" && txtEstado.Text != "En Stock" && txtEstado.Text != "En Produccion" && txtEstado.Text != "Envasado" && txtEstado.Text != "Entregado" && txtEstado.Text != "Devuelto")
            {
                MessageBox.Show("El estado del pedido debe ser 'En Stock', 'En Produccion', 'Envasado', 'Entregado' o 'Devuelto'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!DateTime.TryParse(txtFecha_Entrega.Text, out DateTime fechaEntrega))
            {
                MessageBox.Show("Formato de fecha de entrega es inválido. Utilice el formato dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloTexto(txtDescripcion.Text) || !gestorValidaciones.ContieneSoloTexto(txtPreferencias_Dieteticas.Text))
            {
                MessageBox.Show("Formato inválido, la descripción y las preferencias dietéticas solo aceptan caracteres alfabéticos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si todas las validaciones pasan, mostrar mensaje de éxito y continuar con el resto del código
                MessageBox.Show("Pedido actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Resto del código para actualizar el pedido
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Por favor, complete la ID a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtId.Text))
            {
                MessageBox.Show("La ID solo debe tener dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si todas las validaciones pasan, mostrar mensaje de éxito y continuar con el resto del código
                MessageBox.Show("Pedido eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Resto del código para eliminar el pedido
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Por favor, complete la ID a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtId.Text))
            {
                MessageBox.Show("La ID solo debe tener dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si todas las validaciones pasan, mostrar mensaje de éxito y continuar con el resto del código
                MessageBox.Show("Pedido buscado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Resto del código para buscar el pedido
            }
        }





        private void btnListar_Pedidos_Click_1(object sender, EventArgs e)
        {





        }




        private void txtCedula_TextChanged(object sender, EventArgs e) { }
        private void txtCantidad_Vehiculos_TextChanged(object sender, EventArgs e) { }
        private void formularioPedido_Load(object sender, EventArgs e) { }
        private void lblPedidos_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }


    }
}
