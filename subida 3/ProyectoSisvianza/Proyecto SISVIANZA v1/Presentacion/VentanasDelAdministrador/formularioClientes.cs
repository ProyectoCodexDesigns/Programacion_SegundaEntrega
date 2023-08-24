using Proyecto_SISVIANZA_v1.Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDelAdministrador
{
    public partial class formularioClientes : Form
    {
        int X = 0; int Y = 0;

        // ATRIBUTOS DEL CLIENTE
        public int Ci { get; private set; }
        public string Nombre { get; private set; }
        public string Telefono { get; private set; }
        public string Direccion { get; private set; }
        public string Mail { get; private set; }
        public string Alergias { get; private set; }
        public string Tipo { get; private set; }
        public int Estado { get; private set; }


        private GestorValidaciones gestorValidaciones;
        private GestorClientes gestorClientes;

        public formularioClientes()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();
            gestorClientes = new GestorClientes();
            //Que el dataGridView Sea solo lectura, para que no puedan modificar el texto.
            dgvNotificaciones.ReadOnly = true;
        }
      

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void FormularioClientes_Load(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
           
            // VALIDACIONES.

            // QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtCi.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtAlergias.Text) || string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCi.Text.Length != 8)
            {
                MessageBox.Show("La cédula debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtCi.Text, out int ciValue))
            {
                MessageBox.Show("La cédula debe contener únicamente números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTelefono.Text.Length > 10)
            {
                MessageBox.Show("El número de teléfono debe tener 10 dígitos como máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtTelefono.Text, out int telefonoValue) || !int.TryParse(txtEstado.Text, out int estadoValue))
            {
                MessageBox.Show("El número de teléfono  y el estado deben contener únicamente números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ValidarFormatoEmail(txtMail.Text))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!txtTipo.Text.Equals("Individual", StringComparison.OrdinalIgnoreCase) && !txtTipo.Text.Equals("Empresarial", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El tipo de cliente debe ser 'Individual' o 'Empresarial'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (gestorClientes.ExisteCliente(ciValue))
            {
                MessageBox.Show("El cliente ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ContieneSoloTexto(txtNombre.Text) || !gestorValidaciones.ContieneSoloTexto(txtAlergias.Text))
            {
                MessageBox.Show("Formato inválido, el NOMBRE y las ALERGIAS solo aceptan caracteres alfabéticos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // SI TODAS LAS VALIDACIONES PASAN, AGREGAR EL CLIENTE.
                Ci = ciValue;
                Telefono = telefonoValue.ToString();
                Mail = txtMail.Text;
                Nombre = txtNombre.Text;
                Direccion = txtDireccion.Text;
                Alergias = txtAlergias.Text;
                Tipo = txtTipo.Text;

                Cliente nuevoCliente = new Cliente(Ci, Nombre, Telefono, Direccion, Mail, Alergias, Tipo, estadoValue);

                gestorClientes.AgregarCliente(nuevoCliente);

                MessageBox.Show("El cliente ha sido agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

            // VALIDACIONES.

            // QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtCi.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCi.Text.Length != 8)
            {
                MessageBox.Show("La cédula debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtCi.Text, out int ciValue))
            {
                MessageBox.Show("La cédula debe contener únicamente números del 0-9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTelefono.Text.Length > 10)
            {
                MessageBox.Show("El número de teléfono debe tener 10 dígitos como máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtTelefono.Text, out int telefonoValue) || !int.TryParse(txtEstado.Text, out int estadoValue))
            {
                MessageBox.Show("El número de teléfono  y el estado deben contener únicamente números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorValidaciones.ValidarFormatoEmail(txtMail.Text))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!txtTipo.Text.Equals("Individual", StringComparison.OrdinalIgnoreCase) && !txtTipo.Text.Equals("Empresarial", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El tipo de cliente debe ser 'Individual' o 'Empresarial'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!gestorClientes.ExisteCliente(ciValue))
            {
                MessageBox.Show("El cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // SI TODAS LAS VALIDACIONES PASAN, ACTUALIZAR EL CLIENTE.

                Telefono = telefonoValue.ToString();
                Mail = txtMail.Text;
                Nombre = txtNombre.Text;
                Direccion = txtDireccion.Text;
                Alergias = txtAlergias.Text;
                Tipo = txtTipo.Text;

                Cliente clienteActualizado = new Cliente(ciValue, Nombre, Telefono, Direccion, Mail, Alergias, Tipo, estadoValue);

                gestorClientes.ActualizarCliente(clienteActualizado);

                MessageBox.Show("El cliente ha sido actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // DEJAR LOS CAMPOS EN SU ESTADO INICIAL
            txtCi.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtMail.Text = "";
            txtAlergias.Text = "";
            txtTipo.Text = "";
            txtEstado.Text = "";
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string ci = txtCi.Text.Trim();

            // VALIDACIONES.

            // QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(ci))
            {
                MessageBox.Show("Ingrese el número de cédula a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCi.Text.Length != 8)
            {
                MessageBox.Show("La cédula debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtCi.Text, out int ciValue))
            {
                MessageBox.Show("La cédula debe contener únicamente números del 0-9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // SI TODAS LAS VALIDACIONES PASAN, BUSCAR CLIENTE.

                // Obtener la lista de clientes desde la capa lógica
                List<Cliente> listaClientes = gestorClientes.ObtenerClientesPorCedula(ci);

                if (listaClientes.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún cliente con la cédula ingresada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Asignar la lista de clientes al DataGridView
                dgvNotificaciones.DataSource = listaClientes;
            }
        }

        private void btnListar_Clientes_Click(object sender, EventArgs e)
        {
            // Obtener la lista de clientes desde la capa lógica
            List<Cliente> listaClientes = gestorClientes.ObtenerClientes();

            // Asignar la lista de clientes al DataGridView
            dgvNotificaciones.DataSource = listaClientes;
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void btnVolver_Click(object sender, EventArgs e)
        {
           formularioAdministrador volver = new formularioAdministrador();
           volver.Show();
               this.Close();
        }


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

        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btnMaximizar_Click(object sender, EventArgs e) {
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

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit ();

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}




















