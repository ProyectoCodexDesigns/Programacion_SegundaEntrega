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
    public partial class formularioMensaje : Form
    {

        int ciValue;
        int telefonoValue;
        private GestorValidaciones gestorValidaciones;
        public formularioMensaje()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioAtencionAlPublico formularioAtencionAlPublico = new formularioAtencionAlPublico();
            formularioAtencionAlPublico.Show();
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //VALIDACIONES.

            //QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtSolicitud.Text) || string.IsNullOrEmpty(txtCi.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtAlergias.Text) || string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//VALIDACIONES DE LA CEDULA.
            else if (txtCi.Text.Length != 8)
            {
                MessageBox.Show("La cédula debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(txtCi.Text, out ciValue))
            {
                MessageBox.Show("La cédula debe contener únicamente números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//VALIDACIONES DEL TELEFONO.
            else if (txtTelefono.Text.Length > 10)
            {
                MessageBox.Show("El número de teléfono debe tener 10 dígitos como máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Validar el teléfono 
            else if (!int.TryParse(txtTelefono.Text, out telefonoValue))
            {
                MessageBox.Show("El número de teléfono debe contener únicamente números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//VALIDACIONES DEL MAIL.
            else if (!gestorValidaciones.ValidarFormatoEmail(txtMail.Text))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//VALIDACIONES DEL TIPO.
            else if (!txtTipo.Text.Equals("Individual", StringComparison.OrdinalIgnoreCase) && !txtTipo.Text.Equals("Empresarial", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El tipo de cliente debe ser 'Individual' o 'Empresarial'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!gestorValidaciones.ContieneSoloTexto(txtNombre.Text) || !gestorValidaciones.ContieneSoloTexto(txtAlergias.Text))
            {
                MessageBox.Show("Formato inválido, el NOMBRE y la DIETA solo aceptan caracteres alfabéticos.");
                return;
            }
            else
            {
                // SI TODAS LAS VALIDACIONES PASAN, Enviar solicitud

                MessageBox.Show("Solicitud enviada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Resto del codigo
            }
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
    }
}