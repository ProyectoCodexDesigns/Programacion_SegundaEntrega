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
    public partial class formularioVehiculos : Form
    {
        //int id;
        //string tipo;
        //string disponibilidad;
        //int capacidadCarga;


        private GestorValidaciones gestorValidaciones;
        public formularioVehiculos()
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtTipo.Text) || string.IsNullOrEmpty(txtDisponibilidad.Text) || string.IsNullOrEmpty(txtCapacidad_Carga.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Que acepten solo texto 
            else if (!gestorValidaciones.ContieneSoloTexto(txtTipo.Text) || !gestorValidaciones.ContieneSoloTexto(txtDisponibilidad.Text))
            {
                MessageBox.Show("El tipo y la Disponibilidad solo aceptan digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }//Que tengan solo numeros
            else if (!gestorValidaciones.ContieneSoloNumeros(txtCapacidad_Carga.Text))
            {

                MessageBox.Show("La capacidad de carga solo acepta digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {



                MessageBox.Show("El vehiculo se agrego correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // id= GenerarID();


                // Resto del codigo


            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtTipo.Text) || string.IsNullOrEmpty(txtDisponibilidad.Text) || string.IsNullOrEmpty(txtCapacidad_Carga.Text))
            {
                MessageBox.Show("Complete la id ademas de los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Que acepten solo texto 
            else if (!gestorValidaciones.ContieneSoloTexto(txtTipo.Text ) || !gestorValidaciones.ContieneSoloTexto(txtDisponibilidad.Text))  {
                MessageBox.Show("El tipo dey la Disponibilidad solo aceptan digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }//Que acepten solo numeros
            else if (!gestorValidaciones.ContieneSoloNumeros(txtCapacidad_Carga.Text) || !gestorValidaciones.ContieneSoloNumeros(txtId.Text))
            {

                MessageBox.Show("La capacidad de carga y la ID solo aceptan digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {



                MessageBox.Show("El vehiculo se actualizo correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // id= GenerarID();


                // Resto del codigo


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // DEJAR LOS CAMPOS EN SU ESTADO INICIAL
            txtId.Text = "";
            txtTipo.Text = "";
            txtDisponibilidad.Text = "";
            txtCapacidad_Carga.Text = "";

            MessageBox.Show("Campos vaciados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Indique la ID a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!gestorValidaciones.ContieneSoloNumeros(txtId.Text))
            {

                MessageBox.Show("La ID solo acepta digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {

                MessageBox.Show("Se busco el vehiculo correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Resto del codigo


            }
        }
    }
}
