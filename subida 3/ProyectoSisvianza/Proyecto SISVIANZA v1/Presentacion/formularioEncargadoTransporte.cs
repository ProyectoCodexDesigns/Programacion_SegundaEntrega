using Proyecto_SISVIANZA_v1.Presentacion.VentanasEncargadoDeTransporte;
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
    public partial class formularioEncargadoTransporte : Form
    {
        public formularioEncargadoTransporte()
        {
            InitializeComponent();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e) { }

        private void formularioEncargadoTransporte_Load(object sender, EventArgs e) { }

        private void MenuVertical_Paint_1(object sender, PaintEventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }


        private void btnRutas_Click(object sender, EventArgs e)
        {
            VentanasEncargadoDeTransporte.formularioAsignarRuta formularioAsignarRuta = new VentanasEncargadoDeTransporte.formularioAsignarRuta();
            formularioAsignarRuta.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VentanasEncargadoDeTransporte.formularioGestionarPedidos formulario = new VentanasEncargadoDeTransporte.formularioGestionarPedidos();
            formulario.Show();
            this.Close();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            VentanasEncargadoDeTransporte.formularioVehiculos formularioVehiculos = new VentanasEncargadoDeTransporte.formularioVehiculos();
            formularioVehiculos.Show();
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void BarraTitulo_Paint(object sender, PaintEventArgs e) { }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            login cerarsecion = new login();
            cerarsecion.Show();
            this.Close();
        }
    }
}
