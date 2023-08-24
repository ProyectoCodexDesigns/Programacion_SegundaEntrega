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

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasJefeDeCocina
{
    public partial class formularioMenus : Form
    {

        //Ventanita emergente
        private ToolTip toolTip;// Declarar ToolTip como una variable miembro

        int Y = 0;
        int X = 0;

        //Grosor del borde blanco
        private int borderSize = 1;

        private GestorValidaciones gestorValidaciones;
        public formularioMenus()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();

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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //VALIDACIONES.

            //Que los campos no esten vacios.
            if (string.IsNullOrEmpty(txtStock.Text) || string.IsNullOrEmpty(txtStock_Minimo.Text) || string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  // Verificación de que el stock y el stock mínimo sean dígitos numéricos.
            else if (!gestorValidaciones.ContieneSoloNumeros(txtStock.Text) || !gestorValidaciones.ContieneSoloNumeros(txtStock_Minimo.Text))
            {
                MessageBox.Show("Los campos de stock y stock mínimo deben contener solo dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }// Que el tipo sea valido
            else if (txtTipo.Text != "Vegetariana" && txtTipo.Text != "Baja Calorías" && txtTipo.Text != "Celíacos")
            {
                MessageBox.Show("El tipo de menu debe ser 'Vegetariana', 'Baja Calorías' o 'Celíacos'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Resto del codigo...
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ////Que la id solo sea numerica.
            if (!gestorValidaciones.ContieneSoloNumeros(txtId.Text))
            {
                MessageBox.Show("El número de ID debe tener unicamente dígitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("El menu se busco correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Resto del codigo
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ////Que la id solo sea numerica.
            if (!gestorValidaciones.ContieneSoloNumeros(txtId.Text))
            {
                MessageBox.Show("El número de ID debe tener unicamente dígitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("El menu se borro correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Resto del codigo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // DEJAR LOS CAMPOS EN SU ESTADO INICIAL
            txtStock.Text = "";
            txtStock_Minimo.Text = "";
            txtTipo.Text = "";

            MessageBox.Show("Campos vaciados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void formularioMenus_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblStock_Minimo_Click(object sender, EventArgs e)
        {

        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void lblDatos_Click(object sender, EventArgs e)
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

        private void formularioMenus_MouseMove(object sender, MouseEventArgs e)
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
