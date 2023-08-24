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
    public partial class informatico : Form
    {
        public informatico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register reg = new register(); // Instancie la ventana register
            reg.Show(); // Muestra la ventana 'register'
            this.Hide(); // Oculta la ventana actual
        }
    }
}
