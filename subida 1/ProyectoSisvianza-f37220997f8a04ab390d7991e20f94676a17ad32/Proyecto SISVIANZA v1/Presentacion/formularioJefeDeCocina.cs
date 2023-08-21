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
    public partial class formularioJefeDeCocina : Form
    {

        int Y = 0;
        int X = 0;

        //Grosor del borde blanco
        private int borderSize = 1;

        public formularioJefeDeCocina()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; //La ventana no tendrá ningún tipo de borde visible
            this.Padding = new Padding(borderSize);

            // Definir las columnas del DataGridView
            dgvNotificaciones.Columns.Add("ID", "ID");
            dgvNotificaciones.Columns.Add("cantidadM", "Cantidad de menús");
            dgvNotificaciones.Columns.Add("descripcion", "Descripción");
            dgvNotificaciones.Columns.Add("tipo", "Tipo de menú");
            dgvNotificaciones.Columns.Add("cantidadV", "Cantidad de viandas");
            dgvNotificaciones.Columns.Add("preferencias", "Preferencias dieteticas");
            dgvNotificaciones.Columns.Add("fecha", "Fecha de entrega");

            //Se refrezca el dataview
            dgvNotificaciones.Refresh();


        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            login cerarsecion = new login();
            cerarsecion.Show();
            this.Close();

           
        }

        private void formularioJefeDeCocina_Load(object sender, EventArgs e)
        {

        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            VentanasJefeDeCocina.formularioMenus formularioMenus = new VentanasJefeDeCocina.formularioMenus();
            formularioMenus.Show();
            this.Close();
        }

        private void btnViandas_Click(object sender, EventArgs e)
        {
            VentanasJefeDeCocina.formularioViandas formularioViandas = new VentanasJefeDeCocina.formularioViandas();
            formularioViandas.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login cerarsecion = new login();
            cerarsecion.Show();
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            VentanasJefeDeCocina.formularioMenus formularioMenus = new VentanasJefeDeCocina.formularioMenus();
            formularioMenus.Show();
            this.Close();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            VentanasJefeDeCocina.formularioViandas formularioViandas = new VentanasJefeDeCocina.formularioViandas();
            formularioViandas.Show();
            this.Close();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {

        }

        private void dgvNotificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formularioJefeDeCocina_MouseMove(object sender, MouseEventArgs e)
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
