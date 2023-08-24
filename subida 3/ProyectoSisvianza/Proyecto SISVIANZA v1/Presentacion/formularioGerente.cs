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
    public partial class formularioGerente : Form
    {

        //Ventanita emergente
        private ToolTip toolTip;// Declarar ToolTip como una variable miembro

        int Y = 0;
        int X = 0;

        //Grosor del borde blanco
        private int borderSize = 1;

        public formularioGerente()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; //La ventana no tendrá ningún tipo de borde visible
            this.Padding = new Padding(borderSize);

            //Ventanita emergente en el boton
            toolTip = new ToolTip();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            login cerarsecion = new login();
            cerarsecion.Show();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            VentanasGerente.formularioStock formularioStock = new VentanasGerente.formularioStock();
            formularioStock.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentanasGerente.formularioReporte formularioReporte = new VentanasGerente.formularioReporte();
            formularioReporte.Show();
            this.Close();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            VentanasGerente.formularioDatosEstadisticos formularioDatosEstadisticos = new VentanasGerente.formularioDatosEstadisticos();
            formularioDatosEstadisticos.Show(); 
            this.Close();   
        }

        private void formularioGerente_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnAchicar.Visible = true;
        }

        private void btnAchicar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnAchicar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {

        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            VentanasGerente.formularioStock formularioStock = new VentanasGerente.formularioStock();
            formularioStock.Show();
            this.Close();
        }

        private void btnViandas_Click(object sender, EventArgs e)
        {
            VentanasGerente.formularioDatosEstadisticos formularioDatosEstadisticos = new VentanasGerente.formularioDatosEstadisticos();
            formularioDatosEstadisticos.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanasGerente.formularioReporte formularioReporte = new VentanasGerente.formularioReporte();
            formularioReporte.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login cerarsecion = new login();
            cerarsecion.Show();
            this.Close();
        }

        private void formularioGerente_MouseMove(object sender, MouseEventArgs e)
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

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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
