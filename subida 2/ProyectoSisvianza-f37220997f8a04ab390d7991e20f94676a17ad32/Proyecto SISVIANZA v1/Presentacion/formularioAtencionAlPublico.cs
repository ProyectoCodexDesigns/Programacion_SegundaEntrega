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

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            VentanasDeAtencionAlPúblico.formularioMensaje solicitar = new VentanasDeAtencionAlPúblico.formularioMensaje();
            solicitar.Show();
            this.Close();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            login cerarsecion = new login(); 
            cerarsecion.Show();
            this.Close();
        }
    }
}
 