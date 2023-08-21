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

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDeAtencionAlPúblico
{
    public partial class formularioEstados : Form
    {
        private GestorValidaciones gestorValidaciones;
        public formularioEstados()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formularioAtencionAlPublico formularioAtencionAlPublico = new formularioAtencionAlPublico();
            formularioAtencionAlPublico.Show();
            this.Close();
        }

        private void formularioEstados_Load(object sender, EventArgs e) { }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtId_Menu.Text) || string.IsNullOrEmpty(txtId_Pedido.Text)))
            {
                MessageBox.Show("Seleccione solo una ID a buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtId_Pedido.Text) || !gestorValidaciones.ContieneSoloNumeros(txtId_Menu.Text))
            {

                MessageBox.Show("Las IDs solo aceptan digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            { 
                MessageBox.Show("La busaqueda se realizo correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Resto del codigo

            }


        }
    }
}

