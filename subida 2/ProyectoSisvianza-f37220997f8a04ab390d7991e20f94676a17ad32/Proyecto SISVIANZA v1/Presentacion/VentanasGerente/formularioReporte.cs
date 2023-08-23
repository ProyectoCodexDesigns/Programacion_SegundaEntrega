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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasGerente
{
    public partial class formularioReporte : Form
    {
        //Ventanita emergente
        private ToolTip toolTip;// Declarar ToolTip como una variable miembro

        int Y = 0;
        int X = 0;

        //Grosor del borde blanco
        private int borderSize = 1;

        private GestorValidaciones gestorValidaciones;
        public formularioReporte()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();

            this.FormBorderStyle = FormBorderStyle.None; //La ventana no tendrá ningún tipo de borde visible
            this.Padding = new Padding(borderSize);

            //Ventanita emergente en el boton
            toolTip = new ToolTip();
        }

        private void formularioReporte_Load(object sender, EventArgs e) { }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioGerente formularioGerente = new formularioGerente();
            formularioGerente.Show();
            this.Close();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos y CheckBox seleccionados
            if (string.IsNullOrEmpty(txtTitulo.Text) || string.IsNullOrEmpty(txtPeriodo.Text) || string.IsNullOrEmpty(txtContacto.Text) || string.IsNullOrEmpty(txtConclusion.Text) || string.IsNullOrEmpty(txtRecomendacion.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Que se seleccione al menos un checkBox
            else if (!chkbxClientes_Activos.Checked && !chkbxClientes_Bajos.Checked && !chkbxClientes_Inactivos.Checked && !chkbxUsuarios_Registrados.Checked && !chkbxPedidos_Entregados.Checked && !chkbxPedidos_Solicitados.Checked){
                MessageBox.Show("Por favor, seleccione almenos un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Que el contacto tenga digitos numericos.
            else if (!gestorValidaciones.ContieneSoloNumeros(txtContacto.Text))
            {
                MessageBox.Show("El contacto debe tener únicamente digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show("Se realizo el reporte correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Resto del codigo



            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        { 
            // DEJAR LOS CAMPOS EN SU ESTADO INICIAL
            txtTitulo.Text = "";
            txtPeriodo.Text = "";
            txtContacto.Text = "";
            txtConclusion.Text = "";
            txtRecomendacion.Text = "";

            // Desmarcar los CheckBox
            chkbxClientes_Activos.Checked = false;
            chkbxClientes_Bajos.Checked = false;
            chkbxClientes_Inactivos.Checked = false;
            chkbxUsuarios_Registrados.Checked = false;
            chkbxPedidos_Entregados.Checked = false;
            chkbxPedidos_Solicitados.Checked = false;

            MessageBox.Show("Campos vaciados y CheckBox desmarcados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Que se seleccione al menos un checkBox
            if (!chkbxClientes_Activos.Checked && !chkbxClientes_Bajos.Checked && !chkbxClientes_Inactivos.Checked && !chkbxUsuarios_Registrados.Checked && !chkbxPedidos_Entregados.Checked && !chkbxPedidos_Solicitados.Checked)
            {
                MessageBox.Show("Por favor, seleccione almenos un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else { MessageBox.Show("Se listo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information); }
             //Resto del codigo
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos y CheckBox seleccionados
            if (string.IsNullOrEmpty(txtTitulo.Text) || string.IsNullOrEmpty(txtPeriodo.Text) || string.IsNullOrEmpty(txtContacto.Text) || string.IsNullOrEmpty(txtConclusion.Text) || string.IsNullOrEmpty(txtRecomendacion.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Que se seleccione al menos un checkBox
            else if (!chkbxClientes_Activos.Checked && !chkbxClientes_Bajos.Checked && !chkbxClientes_Inactivos.Checked && !chkbxUsuarios_Registrados.Checked && !chkbxPedidos_Entregados.Checked && !chkbxPedidos_Solicitados.Checked)
            {
                MessageBox.Show("Por favor, seleccione almenos un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Que el contacto tenga digitos numericos.
            else if (!gestorValidaciones.ContieneSoloNumeros(txtContacto.Text))
            {
                MessageBox.Show("El contacto debe tener únicamente digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show("Se realizo el reporte correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Resto del codigo



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formularioGerente formularioGerente = new formularioGerente();
            formularioGerente.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Que se seleccione al menos un checkBox
            if (!chkbxClientes_Activos.Checked && !chkbxClientes_Bajos.Checked && !chkbxClientes_Inactivos.Checked && !chkbxUsuarios_Registrados.Checked && !chkbxPedidos_Entregados.Checked && !chkbxPedidos_Solicitados.Checked)
            {
                MessageBox.Show("Por favor, seleccione almenos un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else { MessageBox.Show("Se listo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            //Resto del codigo
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

        private void formularioReporte_MouseMove(object sender, MouseEventArgs e)
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
