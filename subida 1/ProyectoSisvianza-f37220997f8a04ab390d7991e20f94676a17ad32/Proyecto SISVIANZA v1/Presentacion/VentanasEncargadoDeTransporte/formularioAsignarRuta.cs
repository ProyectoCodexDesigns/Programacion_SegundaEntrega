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
    public partial class formularioAsignarRuta : Form
    {
        private GestorValidaciones gestorValidaciones;
        public formularioAsignarRuta()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void formularioAsignarRuta_Load(object sender, EventArgs e) { }





        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioEncargadoTransporte formularioEncargadoTransporte = new formularioEncargadoTransporte();
            formularioEncargadoTransporte.Show();
            this.Close();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

            //QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtId_Vehiculo.Text) || string.IsNullOrEmpty(txtId_Pedido.Text) || string.IsNullOrEmpty(txtId_Caja.Text)|| string.IsNullOrEmpty(txtId_Ruta.Text) || string.IsNullOrEmpty(txtOrigen.Text) || string.IsNullOrEmpty(txtDestino.Text) || string.IsNullOrEmpty(txtTipo_Calle.Text) || string.IsNullOrEmpty(txtDuracion_Estimada.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Que acepten solo texto 
            else if (!gestorValidaciones.ContieneSoloTexto(txtOrigen.Text) || !gestorValidaciones.ContieneSoloTexto(txtDestino.Text) || !gestorValidaciones.ContieneSoloTexto(txtTipo_Calle.Text))
            {
                MessageBox.Show("El origen, destino y tipo de calle solo aceptan caracteres alfabéticos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }//Que tengan solo numeros
            else if (!gestorValidaciones.ContieneSoloNumeros(txtId_Caja.Text) || !gestorValidaciones.ContieneSoloNumeros(txtId_Pedido.Text) || !gestorValidaciones.ContieneSoloNumeros(txtId_Vehiculo.Text)|| !gestorValidaciones.ContieneSoloNumeros(txtId_Ruta.Text))
            {
                MessageBox.Show("Las IDs solo aceptan digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }// Que el tiempo sea valido.
            else if (!gestorValidaciones.Tiempo(txtDuracion_Estimada.Text))
            {
                MessageBox.Show("Formato de duración estiamda invalida. Utilice el formato 00:00:00.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show("Se asigno el pedido y la ruta al vehiculo correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Resto del codigo

               // string OrdenEntrega = GenerarOrdenEntrega();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtId_Vehiculo.Text) || string.IsNullOrEmpty(txtId_Ruta.Text))
            {
                MessageBox.Show("Por favor, complete la ID del vehiculo y de la ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtId_Vehiculo.Text) || !gestorValidaciones.ContieneSoloNumeros(txtId_Ruta.Text))
            {
                MessageBox.Show("Las IDs solo aceptan digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {

                MessageBox.Show("Se aborto la entrega del pedido correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Resto del codigo
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtId_Vehiculo.Text))
            {
                MessageBox.Show("Por favor, complete la ID del vehiculo a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtId_Vehiculo.Text))
            {
                MessageBox.Show("La ID del vehiculo solo acepta digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                MessageBox.Show("Se busco el vehiuclo correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Resto del codigo
            }

        }
    }
}
