using Proyecto_SISVIANZA_v1.Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDeAtencionAlPúblico
{
    public partial class formularioEstados : Form
    {
        private GestorValidaciones gestorValidaciones;
        private GestorPedidos gestorPedidos;
        private GestorMenu gestorMenu;
        public formularioEstados()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();
            gestorPedidos = new GestorPedidos();
            gestorMenu = new GestorMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formularioAtencionAlPublico formularioAtencionAlPublico = new formularioAtencionAlPublico();
            formularioAtencionAlPublico.Show();
            this.Close();
        }

        private void formularioEstados_Load(object sender, EventArgs e) { }












        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

            //Un poquito de lógica
            if ((!string.IsNullOrEmpty(txtId_Menu.Text) ^ !string.IsNullOrEmpty(txtId_Pedido.Text)))
            {

                if (!string.IsNullOrEmpty(txtId_Menu.Text))
                {
                        
                    if (gestorValidaciones.ContieneSoloNumeros(txtId_Menu.Text))
                    {
                        int menuid = int.Parse(txtId_Menu.Text);

                        List<Logica.Menu> listaMenus = gestorMenu.ObtenerMenusPorId(menuid);

                        if (listaMenus.Count == 0)
                        {
                            MessageBox.Show("No se encontró ningún menu con la id ingresada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dgvEstados.DataSource = listaMenus;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La id solo debe tener digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (gestorValidaciones.ContieneSoloNumeros(txtId_Pedido.Text))
                    {
                        int pedidoid = int.Parse(txtId_Pedido.Text);

                        List<Logica.Pedido> listaPedidos = gestorPedidos.ObtenerPedidoPorIdTipoLista(pedidoid);


                        if (listaPedidos.Count == 0)
                        {
                            MessageBox.Show("No se encontró ningún pedido con la id ingresada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            dgvEstados.DataSource = listaPedidos;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La id solo debe tener digitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete uno de los campos a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }






        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioAtencionAlPublico formularioAtencionAlpublico = new formularioAtencionAlPublico();

            formularioAtencionAlpublico.Show();

            this.Close();

        }
        int X = 0, Y = 0;

        private void btbListarEstadosMenus_Click(object sender, EventArgs e)
        {

            List<Logica.Menu> listaMenus = gestorMenu.ObtenerTodosLosMenu();
            dgvEstados.DataSource = listaMenus;




        }

        private void btnListarEstadosPedidos_Click(object sender, EventArgs e)
        {

            List<Pedido> listaPedidos = gestorPedidos.ObtenerTodosLosPedidos();
            dgvEstados.DataSource = listaPedidos;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId_Menu.Text = "";
            txtId_Pedido.Text = "";
        }

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
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

