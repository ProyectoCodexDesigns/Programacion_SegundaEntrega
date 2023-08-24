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
    public partial class formularioAtencionAlPublico : Form
    {
        public formularioAtencionAlPublico()
        {
            InitializeComponent();
        }
      

        private void btnEstados_Click(object sender, EventArgs e)
        {
            VentanasDeAtencionAlPúblico.formularioEstados estados = new VentanasDeAtencionAlPúblico.formularioEstados();
            estados.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login cerarsecion = new login();
            cerarsecion.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

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

        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        int X=0, Y=0;

        private void btnClientes_Click(object sender, EventArgs e)
        {
            VentanasDeAtencionAlPúblico.formularioSolicitar clientes = new VentanasDeAtencionAlPúblico.formularioSolicitar();
            clientes.Show();
            this.Hide(); // Ocultar el formulario actual en lugar de cerrarlo directamente
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
    }
}
 