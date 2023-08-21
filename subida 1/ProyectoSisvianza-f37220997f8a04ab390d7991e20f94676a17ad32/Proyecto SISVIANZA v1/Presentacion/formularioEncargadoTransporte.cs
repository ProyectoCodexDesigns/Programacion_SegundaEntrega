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

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            login cerarsecion = new login();
            cerarsecion.Show();
            this.Close();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

            VentanasEncargadoDeTransporte.formularioGestionarPedidos formulario = new VentanasEncargadoDeTransporte.formularioGestionarPedidos();
            formulario.Show();
            this.Close();

        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            VentanasEncargadoDeTransporte.formularioAsignarRuta formularioAsignarRuta = new VentanasEncargadoDeTransporte.formularioAsignarRuta();  
            formularioAsignarRuta.Show();
            this.Close();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            VentanasEncargadoDeTransporte.formularioVehiculos formularioVehiculos = new VentanasEncargadoDeTransporte.formularioVehiculos();    
            formularioVehiculos.Show();
            this.Close();
        }
    }
}
