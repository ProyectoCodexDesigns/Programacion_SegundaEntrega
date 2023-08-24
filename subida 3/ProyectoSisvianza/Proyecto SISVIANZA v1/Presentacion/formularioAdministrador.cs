using System;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion
{
    public partial class formularioAdministrador : Form
    {
        public formularioAdministrador()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            VentanasDelAdministrador.formularioClientes abrir = new VentanasDelAdministrador.formularioClientes();
            abrir.Show();
            this.Close();
        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            VentanasDelAdministrador.formularioPedidos abrir = new VentanasDelAdministrador.formularioPedidos();
            abrir.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)=>Application.Exit();

        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        int X=0,Y=0;    
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
