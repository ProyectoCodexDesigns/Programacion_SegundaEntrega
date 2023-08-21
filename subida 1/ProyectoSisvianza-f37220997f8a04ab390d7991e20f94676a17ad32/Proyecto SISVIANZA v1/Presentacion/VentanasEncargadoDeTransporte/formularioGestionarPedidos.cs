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

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasEncargadoDeTransporte
{
    public partial class formularioGestionarPedidos : Form
    {
        private GestorValidaciones gestorValidaciones;
        public formularioGestionarPedidos()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioEncargadoTransporte formularioEncargadoTransporte = new formularioEncargadoTransporte();
            formularioEncargadoTransporte.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Contar la cantidad de campos llenos
            int camposLlenos = 0;

            // Verificar si cada campo tiene un valor y si está en el formato correcto
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                camposLlenos++;
                if (!gestorValidaciones.ContieneSoloNumeros(txtId.Text))
                {
                    MessageBox.Show("La ID solo acepta dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtFecha_Entrega.Text))
            {
                camposLlenos++;
                if (!DateTime.TryParse(txtFecha_Entrega.Text, out DateTime fechaEntrega))
                {
                    MessageBox.Show("Formato de fecha de entrega inválida. Utilice el formato dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtDireccion.Text))
            {
                camposLlenos++;
                if (!gestorValidaciones.ContieneSoloTexto(txtDireccion.Text))
                {
                    MessageBox.Show("La dirección solo acepta caracteres alfabéticos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtEstado.Text))
            {
                camposLlenos++;
                string estado = txtEstado.Text.Trim().ToLower();
                if (estado != "solicitado" && estado != "en stock" && estado != "en produccion" && estado != "envasado" && estado != "entregado" && estado != "devuelto")
                {
                    MessageBox.Show("El estado del pedido debe ser 'Solicitado', 'En Stock', 'En Produccion', 'Envasado', 'Entregado' o 'Devuelto'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Verificar que solo se haya ingresado un dato
            if (camposLlenos != 1)
            {
                MessageBox.Show("Por favor, ingrese solo un dato para realizar la búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Realizar la búsqueda según el dato ingresado
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Búsqueda por ID realizada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!string.IsNullOrEmpty(txtFecha_Entrega.Text))
            {
                MessageBox.Show("Búsqueda por fecha de entrega realizada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Búsqueda por dirección realizada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!string.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("Búsqueda por estado realizada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
