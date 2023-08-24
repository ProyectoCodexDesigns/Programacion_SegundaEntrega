using Proyecto_SISVIANZA_v1.Presentacion.VentanasDelInformatico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion
{
    public partial class formularioInformatico : Form
    {
        //Ventanita emergente
        private ToolTip toolTip;// Declarar ToolTip como una variable miembro

        int Y = 0;
        int X = 0;

        private int borderSize = 1;

        public formularioInformatico()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //La ventana no tendrá ningún tipo de borde visible
            this.Padding = new Padding(borderSize);

            //Ventanita emergente en el boton
            toolTip = new ToolTip();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            VentanasDelInformatico.formularioUsuarios formularioUsuarios = new VentanasDelInformatico.formularioUsuarios();
            formularioUsuarios.Show();
            this.Close();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            VentanasDelInformatico.formularioSeguridad formularioSeguridad = new VentanasDelInformatico.formularioSeguridad();
            formularioSeguridad.Show();
            this.Close();
        }
        private void formularioInformatico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnAchicar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        //Arrastrar ventana
        private void formularioInformatico_MouseMove(object sender, MouseEventArgs e)
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvNotificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
