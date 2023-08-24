using Google.Protobuf.WellKnownTypes;
using Proyecto_SISVIANZA_v1.Logica;
using Proyecto_SISVIANZA_v1.Persistencia;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDelAdministrador
{
    //Falta editar
    public partial class formularioPedidos : Form
    {

        int X = 0, Y = 0;
        int id;
        int Ci;
        int cantidadMenus;
        string descripcion;
        int estado;
        int tipoMenu;
        int cantidadViandas;

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

        private void btnListar_Pedidos_Click_1(object sender, EventArgs e) { }




        private void txtCedula_TextChanged(object sender, EventArgs e) { }
        private void txtCantidad_Vehiculos_TextChanged(object sender, EventArgs e) { }
        private void formularioPedido_Load(object sender, EventArgs e) { }
        private void lblPedidos_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }










        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
          

            if (string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtCantidad_Menus.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtFecha_Entrega.Text)  || string.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtCedula.Text) || !gestorValidaciones.ContieneSoloNumeros(txtCantidad_Menus.Text) || !gestorValidaciones.ContieneSoloNumeros(txtEstado.Text) || !gestorValidaciones.ContieneSoloNumeros(txtTipoMenu.Text) || !gestorValidaciones.ContieneSoloNumeros(txtCantidad_Viandas.Text))
            {
                MessageBox.Show("La cédula, la cantidad de menús, el estado, tipo de menu y cantidad de viandas deben tener únicamente dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCedula.Text.Length != 8)
            {
                MessageBox.Show("La cédula debe tener 8 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorCliente.ExisteCliente(int.Parse(txtCedula.Text)))
            {
                MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorCliente.ExisteCliente(int.Parse(txtCedula.Text)))
            {
                MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!DateTime.TryParse(txtFecha_Entrega.Text, out DateTime fechaEntrega))
            {
                MessageBox.Show("Formato de fecha de entrega es inválido. Utilice el formato dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloTexto(txtDescripcion.Text))
            {
                MessageBox.Show("Formato inválido, la descripción solo acepta caracteres alfabéticos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                 Ci = int.Parse(txtCedula.Text);
                 cantidadMenus = int.Parse(txtCantidad_Menus.Text);
                 descripcion = txtDescripcion.Text;
                 estado = int.Parse(txtEstado.Text);
                tipoMenu=int.Parse(txtTipoMenu.Text);
                cantidadViandas = int.Parse(txtCantidad_Viandas.Text);

                DateTime fechaCreacion = DateTime.Now; //La fecha y hora actual.

                Cliente cliente = new Cliente(Ci, "", "", "", "", "","",0);

                Pedido pedido = new Pedido(0, cantidadMenus, descripcion, fechaEntrega,fechaCreacion, cliente, estado,tipoMenu,cantidadViandas);

                gestorPedido.AgregarPedido(pedido);

                MessageBox.Show("¡Pedido registrado en la base de datos exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

            }

        }




































        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtCantidad_Menus.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtFecha_Entrega.Text) || string.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtId.Text) || !gestorValidaciones.ContieneSoloNumeros(txtCantidad_Menus.Text) || !gestorValidaciones.ContieneSoloNumeros(txtEstado.Text) || !gestorValidaciones.ContieneSoloNumeros(txtTipoMenu.Text) || !gestorValidaciones.ContieneSoloNumeros(txtCantidad_Viandas.Text))
            {
                MessageBox.Show("La id, la cédula, la cantidad de menús, el estado, tipo de menu y cantidad de viandas deben tener únicamente dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorPedido.ExistenPedidos())
            {
                MessageBox.Show("El pedido no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!DateTime.TryParse(txtFecha_Entrega.Text, out DateTime fechaEntrega))
            {
                MessageBox.Show("Formato de fecha de entrega es inválido. Utilice el formato dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloTexto(txtDescripcion.Text))
            {
                MessageBox.Show("Formato inválido, la descripción solo acepta caracteres alfabéticos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Obtener el pedido existente para obtener la fecha de creación
                Pedido pedidoExistente = gestorPedido.ObtenerPedidoPorId(int.Parse(txtId.Text));

                // Si todas las validaciones pasan, ACTUALIZAR EL PEDIDO.

                 id = int.Parse(txtId.Text);
                 cantidadMenus = int.Parse(txtCantidad_Menus.Text);
                 descripcion = txtDescripcion.Text;
                 estado = int.Parse(txtEstado.Text);
                tipoMenu=int.Parse(txtTipoMenu.Text);
                cantidadViandas=int.Parse(txtCantidad_Viandas.Text);

                Pedido pedidoActualizado = new Pedido(id, cantidadMenus, descripcion, fechaEntrega, pedidoExistente.FechaCreacion, pedidoExistente.Cliente, estado,tipoMenu,cantidadViandas);

                gestorPedido.ActualizarPedido(pedidoActualizado);

                MessageBox.Show("El pedido ha sido actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            }
        }
































        private void btnBuscar_Click_1(object sender, EventArgs e)
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

                int pedidoid=int.Parse(txtId.Text);

                List<Pedido> listaPedidos = gestorPedido.ObtenerPedidoPorIdTipoLista(pedidoid); 

                //Pedido pedidoEncontrado = gestorPedido.ObtenerPedidoPorId(pedidoId);

                if (listaPedidos.Count ==0)
                {
                    MessageBox.Show("No se encontró ningún pedido con la id ingresada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvPedidos.DataSource = listaPedidos;
                }




            }
        }
        private void LimpiarCampos()
        {
            txtCantidad_Menus.Text = "";
            txtDescripcion.Text = "";
            txtFecha_Entrega.Text = "";
            txtEstado.Text = "";
            txtTipoMenu.Text = "";
            txtCantidad_Viandas.Text = "";
        }

















        private void btnListar_Pedidos_Click_2(object sender, EventArgs e)
        {
            List<Pedido> listaPedidos = gestorPedido.ObtenerTodosLosPedidos();

            dgvPedidos.DataSource = listaPedidos;



        }










        private void btnVolver_Click_1(object sender, EventArgs e)
        {

            formularioAdministrador volver = new formularioAdministrador();
            volver.Show();
            this.Close();
        }









        private void btnEliminar_Click_1(object sender, EventArgs e)
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
                int pedidoId = int.Parse(txtId.Text);

                if (gestorPedido.EliminarPedido(pedidoId))
                {
                    MessageBox.Show("Pedido eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el pedido o no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }










        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void txtId_TextChanged(object sender, EventArgs e) { }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e) { }










        //personalizar la visualización 
        private void dgvPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvPedidos.Columns["Cliente"].Index && e.RowIndex >= 0)
            {
                if (dgvPedidos.Rows[e.RowIndex].DataBoundItem is Pedido pedido)
                {
                    e.Value = pedido.Cliente.Ci; // Mostrar la cédula del cliente en lugar del objeto cliente
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e) { }

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {

                X = e.X;
                Y = e.Y;

            }
            else
            {

                Left = Left + (e.X - X);
                Top = Top + (e.Y - Y);
            }
        }
    }
}
