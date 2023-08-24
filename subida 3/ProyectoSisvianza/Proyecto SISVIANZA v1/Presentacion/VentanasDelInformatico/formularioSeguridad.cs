using Proyecto_SISVIANZA_v1.Logica;
using Proyecto_SISVIANZA_v1.Presentacion.VentanasEncargadoDeTransporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDelInformatico
{
    public partial class formularioSeguridad : Form
    {
        //Ventanita emergente
        private ToolTip toolTip;// Declarar ToolTip como una variable miembro

        private GestorValidaciones gestorValidaciones;

        //Asignar                             //Crear manualmente esta carpeta: ( carpeta prueba)
        // rutaPrueba = @"C:\Users\TuUsuario\Desktop\CarpetaPrueba";


        int Y = 0;
        int X = 0;

        //Grosor del borde blanco
        private int borderSize = 1;

        public formularioSeguridad()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();

            this.FormBorderStyle = FormBorderStyle.None; //La ventana no tendrá ningún tipo de borde visible
            this.Padding = new Padding(borderSize);

            //Ventanita emergente en el boton
            toolTip = new ToolTip();
        }

        private void formularioSeguridad_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioInformatico formularioInformatico = new formularioInformatico();
            formularioInformatico.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRealizar_Click(object sender, EventArgs e)                                                             /* C:\Users\Esteban\Desktop\CarpetaPrueba*/
        {


            string carpeta;
            string nombre;

            //Que lso campos noe sten vacios.
            if (string.IsNullOrEmpty(txtCarpeta.Text))
            {
                MessageBox.Show("Por favor, ingrese la ruta de la carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Verificar si existe.          
            else if (!(Directory.Exists(txtCarpeta.Text)))
            {
                MessageBox.Show("La carpeta no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }          
            else
            {
                //RUTA PARA REALIZAR EL ARCHIVO DE LA COPIA
                carpeta = txtCarpeta.Text;
                nombre = "/" + txtNombre.Text + ".sql";
                string ruta = @"" + carpeta + nombre;

                try
                {
                    if (File.Exists(ruta))
                    {
                        MessageBox.Show("Copia de seguridad existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Realizar copia de seguridad
                        Seguridad seg = new Seguridad();

                        seg.RealizarCopiaSeguridad(ruta);

                        //Vaciar campos
                        txtCarpeta.Text = "";
                        txtNombre.Text = "";

                        MessageBox.Show("Copia de seguridad realizada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear la copia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //Resto del codigo

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string carpeta = txtCarpeta.Text.Trim();

            string carpetaTxT;
            string nombre;

            //Que lso campos noe sten vacios.
            if (string.IsNullOrEmpty(carpeta))
            {
                MessageBox.Show("Por favor, ingrese la ruta de la carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Que la carpeta exista
            else if (!(Directory.Exists(txtCarpeta.Text)))
            {
                MessageBox.Show("La carpeta no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //RUTA PARA ELIMINAR EL ARCHIVO DE LA COPIA
                carpetaTxT = txtCarpeta.Text;
                nombre = "/" + txtNombre.Text + ".sql";
                string ruta = @"" + carpetaTxT + nombre;

                try
                {
                    if (File.Exists(ruta))
                    {
                        File.Delete(ruta);

                        //Vaciar campos
                        txtCarpeta.Text = "";
                        txtNombre.Text = "";

                        MessageBox.Show("Copia de seguridad eliminada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Copia de seguridad inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la copia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Resto del codigo

            }
        }

        //Arrastrar ventana

        private void formularioSeguridad_MouseMove(object sender, MouseEventArgs e)
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            formularioInformatico formularioInformatico = new formularioInformatico();
            formularioInformatico.Show();
            this.Close();
        }

        
    }
}
