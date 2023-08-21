using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasGerente
{
    public partial class formularioDatosEstadisticos : Form
    {
        //Ventanita emergente
        private ToolTip toolTip;// Declarar ToolTip como una variable miembro

        int Y = 0;
        int X = 0;

        //Grosor del borde blanco
        private int borderSize = 1;

        public formularioDatosEstadisticos()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; //La ventana no tendrá ningún tipo de borde visible
            this.Padding = new Padding(borderSize);

            //Ventanita emergente en el boton
            toolTip = new ToolTip();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioGerente formularioGerente = new formularioGerente();
            formularioGerente.Show();
            this.Close();
        }

        private void formularioDatosEstadisticos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación de selección de un solo checkbox usando XOR
            if (!(chkbxPedidosMes.Checked ^ chkbxPedidosPopulares.Checked ^ chkbxClientesFrecuentes.Checked ^ chkbxCancelacion.Checked))
            {
                MessageBox.Show("Seleccione solo un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Se busco correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación de selección de un solo checkbox usando XOR
            if (!(chkbxPedidosMes.Checked ^ chkbxPedidosPopulares.Checked ^ chkbxClientesFrecuentes.Checked ^ chkbxCancelacion.Checked))
            {
                MessageBox.Show("Seleccione solo un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                MessageBox.Show("Se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación de selección de un solo checkbox usando XOR
            if (!(chkbxPedidosMes.Checked ^ chkbxPedidosPopulares.Checked ^ chkbxClientesFrecuentes.Checked ^ chkbxCancelacion.Checked))
            {
                MessageBox.Show("Seleccione solo un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Se busco correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formularioGerente formularioGerente = new formularioGerente();
            formularioGerente.Show();
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Validación de selección de un solo checkbox usando XOR
            if (!(chkbxPedidosMes.Checked ^ chkbxPedidosPopulares.Checked ^ chkbxClientesFrecuentes.Checked ^ chkbxCancelacion.Checked))
            {
                MessageBox.Show("Seleccione solo un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void formularioDatosEstadisticos_MouseMove(object sender, MouseEventArgs e)
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
