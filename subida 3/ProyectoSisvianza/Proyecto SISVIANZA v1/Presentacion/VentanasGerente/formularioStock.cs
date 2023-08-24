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

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasGerente
{
    public partial class formularioStock : Form
    {

        //Ventanita emergente
        private ToolTip toolTip;// Declarar ToolTip como una variable miembro

        int Y = 0;
        int X = 0;

        //Grosor del borde blanco
        private int borderSize = 1;


        private GestorValidaciones gestorValidaciones;
        private GestorPedidos pedido;
        private GestorMenu menu;
        private GestorViandas vianda;

        public formularioStock()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();

            this.FormBorderStyle = FormBorderStyle.None; //La ventana no tendrá ningún tipo de borde visible
            this.Padding = new Padding(borderSize);

            //Ventanita emergente en el boton
            toolTip = new ToolTip();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioGerente formularioGerente = new formularioGerente();  
            formularioGerente.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int contadorIDs = 0;

            // Validación de campos vacíos y contar cuántas IDs se completaron
            if (!string.IsNullOrEmpty(txtIDPedido.Text))
            {
                contadorIDs++;
            }
            if (!string.IsNullOrEmpty(txtID_Menu.Text))
            {
                contadorIDs++;
            }
            if (!string.IsNullOrEmpty(txtID_Vianda.Text))
            {
                contadorIDs++;
            }

            // Comprobar que solo se complete una ID
            if (contadorIDs == 0)
            {
                MessageBox.Show("Por favor, ingrese al menos una ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (contadorIDs > 1)
            {
                MessageBox.Show("Por favor, ingrese solo una ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que los datos numéricos sean solo números.
            if (!string.IsNullOrEmpty(txtIDPedido.Text) && !gestorValidaciones.ContieneSoloNumeros(txtIDPedido.Text))
            {
                MessageBox.Show("La ID del pedido debe contener únicamente dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(txtID_Menu.Text) && !gestorValidaciones.ContieneSoloNumeros(txtID_Menu.Text))
            {
                MessageBox.Show("La ID del menú debe contener únicamente dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(txtID_Vianda.Text) && !gestorValidaciones.ContieneSoloNumeros(txtID_Vianda.Text))
            {
                MessageBox.Show("La ID de la vianda debe contener únicamente dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("La búsqueda se realizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Resto del código...

            if (!string.IsNullOrEmpty(txtIDPedido.Text) && string.IsNullOrEmpty(txtID_Menu.Text) && string.IsNullOrEmpty(txtID_Vianda.Text))
            {
                int id = int.Parse(txtIDPedido.Text);
                pedido = new GestorPedidos();
                List<Pedido> listaPedidos = pedido.ObtenerPedidoPorIdTipoLista(id);
                dgvLista.DataSource = listaPedidos;
            }
            if (string.IsNullOrEmpty(txtIDPedido.Text) && !string.IsNullOrEmpty(txtID_Menu.Text) && string.IsNullOrEmpty(txtID_Vianda.Text))
            {
                int id = int.Parse(txtID_Menu.Text);
                menu = new GestorMenu();
                List<Logica.Menu> listaMenus = menu.ObtenerMenusPorId(id);
                dgvLista.DataSource = listaMenus;
            }
            if (string.IsNullOrEmpty(txtIDPedido.Text) && string.IsNullOrEmpty(txtID_Menu.Text) && !string.IsNullOrEmpty(txtID_Vianda.Text))
            {
                int id = int.Parse(txtID_Vianda.Text);
                vianda = new GestorViandas();
                List<Vianda> listaViandas = vianda.ObtenerViandasPorId(id);
                dgvLista.DataSource = listaViandas;

            }
        }

        private void formularioStock_Load(object sender, EventArgs e)
        {
   
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Pedidos_Click(object sender, EventArgs e)
        {
            pedido = new GestorPedidos();
            List<Pedido> listaPedidos = pedido.ObtenerTodosLosPedidos();
            dgvLista.DataSource = listaPedidos;

        }

        private void btnListar_Menus_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Viandas_Click(object sender, EventArgs e)
        {

        }

        private void txtIDPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Menu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Vianda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Menus_Click_1(object sender, EventArgs e)
        {
            menu = new GestorMenu();
            List<Logica.Menu> listaMenus = menu.ObtenerTodosLosMenu();
            dgvLista.DataSource = listaMenus;
        }

        private void btnListar_Viandas_Click_1(object sender, EventArgs e)
        {
            vianda = new GestorViandas();
            List<Vianda> listaViandas = vianda.ObtenerTodasLasViandas();
            dgvLista.DataSource = listaViandas;
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

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            formularioGerente formularioGerente = new formularioGerente();
            formularioGerente.Show();
            this.Close();
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

        private void formularioStock_MouseMove(object sender, MouseEventArgs e)
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
