using Google.Protobuf.WellKnownTypes;
using Proyecto_SISVIANZA_v1.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasJefeDeCocina
{
    public partial class formularioViandas : Form
    {
        //Ventanita emergente
        private ToolTip toolTip;// Declarar ToolTip como una variable miembro

        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public string TipoDieta { get; private set; }
        public string Tiempo { get; private set; }
        public string Postre { get; private set; }
        public string Estado { get; private set; }


        int Y = 0;
        int X = 0;

        //Grosor del borde blanco
        private int borderSize = 1;

        private Logica.GestorValidaciones gestorValidaciones;
        public formularioViandas()
        {
            InitializeComponent();
            gestorValidaciones = new Logica.GestorValidaciones();

            this.FormBorderStyle = FormBorderStyle.None; //La ventana no tendrá ningún tipo de borde visible
            this.Padding = new Padding(borderSize);

            //Ventanita emergente en el boton
            toolTip = new ToolTip();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioJefeDeCocina formularioJefeDeCocina = new formularioJefeDeCocina();
            formularioJefeDeCocina.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void formularioViandas_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // VALIDACIONES.

            // QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtTipo_Dieta.Text) || string.IsNullOrEmpty(txtFecha_Caducidad.Text) || string.IsNullOrEmpty(txtTiempo.Text) || string.IsNullOrEmpty(txtPostre.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // QUE LOS CAMPOS DE TEXTO SOLO TENGAN DATOS DE TIPO TEXTO.
            else if (!gestorValidaciones.ContieneSoloTexto(txtNombre.Text) || !gestorValidaciones.ContieneSoloTexto(txtDescripcion.Text) || !gestorValidaciones.ContieneSoloTexto(txtPostre.Text))
            {
                MessageBox.Show("Formato inválido, el NOMBRE, la DESCRIPCIÓN y el POSTRE solo aceptan caracteres alfabéticos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // PARSEAR LA FECHA DE ENTREGA.
            else if (!DateTime.TryParse(txtFecha_Caducidad.Text, out DateTime fechaCaducidad))
            {
                MessageBox.Show("Formato de fecha de caducidad inválida. Utilice el formato dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // QUE EL TIEMPO SEA VÁLIDO.
            else if (!gestorValidaciones.Tiempo(txtTiempo.Text))
            {
                MessageBox.Show("Formato del tiempo inválido. Utilice el formato 00:00:00.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // VERIFICAR EL TIPO DE DIETA.
            else if (txtTipo_Dieta.Text != "Vegetariana" && txtTipo_Dieta.Text != "Baja Calorías" && txtTipo_Dieta.Text != "Celíacos")
            {
                MessageBox.Show("El tipo de dieta debe ser 'Vegetariana', 'Baja Calorías' o 'Celíacos'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // SI TODAS LAS VALIDACIONES PASAN, GUARDAR LOS DATOS.

                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Resto del código...
                // Id = GenerarID();
                // Nombre = txtNombre.Text;
                // Descripcion = txtDescripcion.Text;
                // TipoDieta = txtTipo_Dieta.Text;
                // Tiempo = txtTiempo.Text;
                // Postre = txtPostre.Text;
                // Estado = "Solicitada";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ////Que la id solo sea numerica.
            if (!gestorValidaciones.ContieneSoloNumeros(txtId.Text))
            {
                MessageBox.Show("El número de ID debe tener unicamente dígitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("El número de ID se busco correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Resto del codigo..


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // DEJAR LOS CAMPOS EN SU ESTADO INICIAL
            txtId.Text = "";
            txtNombre.Text = "";
            txtTipo_Dieta.Text = "";
            txtTiempo.Text = "";
            txtPostre.Text = "";

            MessageBox.Show("Campos vaciados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNotificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            formularioJefeDeCocina formularioJefeDeCocina = new formularioJefeDeCocina();
            formularioJefeDeCocina.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnAchicar.Visible = true;
        }

        private void btnAchicar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnAchicar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void formularioViandas_MouseMove(object sender, MouseEventArgs e)
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

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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
