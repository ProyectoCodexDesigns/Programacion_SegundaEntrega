using Google.Protobuf.WellKnownTypes;
using Proyecto_SISVIANZA_v1.Logica;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDeAtencionAlPúblico
{
    public partial class formularioSolicitar : Form
    {
        private GestorValidaciones gestorValidaciones;
        private GestorClientes gestorClientes;
        public formularioSolicitar()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();
            gestorClientes = new GestorClientes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioAtencionAlPublico formularioAtencionAlPublico = new formularioAtencionAlPublico();
            formularioAtencionAlPublico.Show();
            this.Close();
        }

   

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // DEJAR LOS CAMPOS EN SU ESTADO INICIAL
            txtCi.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtAlergias.Text = "";
            txtMail.Text = "";
            txtTipo.Text = "";

            MessageBox.Show("Campos vaciados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        int X=0; int Y=0;

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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            //btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            //btnRestaurar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void btnListar_Clientes_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void btnEnviar_Click_1(object sender, EventArgs e)
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
            else if (!int.TryParse(txtTelefono.Text, out int telefonoValue))
            {
                MessageBox.Show("El número de teléfono debe contener únicamente números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // SI TODAS LAS VALIDACIONES PASAN, ENVIAR AL CLIENTE AL ADMINISTRADOR


                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                string mail = txtMail.Text;
                string alergias = txtAlergias.Text;
                string tipo = txtTipo.Text;
                int estado = 0;
                string tel=telefonoValue.ToString();




                Cliente nuevoCliente = new Cliente(ciValue, nombre, tel, direccion, mail, alergias, tipo, estado);

                gestorClientes.EnviarCliente(nuevoCliente);
                
                MessageBox.Show("El cliente ha sido enviado al administrador exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                formularioAdministrador admin = new formularioAdministrador();
                
                admin.Show();

            }
        }






        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            formularioAtencionAlPublico formularioAtencionAlPublico = new formularioAtencionAlPublico();
            formularioAtencionAlPublico.Show();
            this.Close();
        }
    }
}