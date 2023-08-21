using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Proyecto_SISVIANZA_v1.Presentacion;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Threading.Tasks;

namespace Proyecto_SISVIANZA_v1
{
    public partial class login : Form
    {
        //Ventanita emergente
        private ToolTip toolTip;// Declarar ToolTip como una variable miembro

        //Fields      
        private int borderSize = 1;
        
        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //La ventana no tendrá ningún tipo de borde visible
            this.Padding = new Padding(borderSize);

            //Ventanita emergente en el boton
            toolTip = new ToolTip();         
        }
        //Metodo para arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = 0x20000; // Minimize boderless from taskbar
                return cp;
            }
        }


        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void pass_TextChanged(object sender, EventArgs e) { }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            Logica.Ingreso ver = new Logica.Ingreso(); // instancie la clase verificacion
            //Guardado de datos desde los textBox a variables
            string nombre, contraseña;
            nombre = txtUser.Text;
            contraseña = txtPass.Text;
            //Realizar la validación a través del metodo Verifi
            bool usuarioValido = ver.Verificar(nombre, contraseña); // Guuardará lo que retorne el metodo Verifi en la variable usuarioValido, es decir un true o un false por ser un booleano.

            if (usuarioValido)
            {
                String rol = ver.ObtenerRol(nombre); //Llamara el metodo interfazUsuario con el valor nombre, y lo que retorne lo guardara en rol

                if (rol == "Gerente")
                {
                    formularioGerente formularioGerente = new formularioGerente();
                    formularioGerente.Show();
                    this.Hide();
                }
                else if (rol == "Administrador")
                {
                    formularioAdministrador formularioAdministrador = new formularioAdministrador();
                    formularioAdministrador.Show();
                    this.Hide();
                }
                else if (rol == "Jefe De Cocina")
                {
                    formularioJefeDeCocina formularioJefeDeCocina = new formularioJefeDeCocina();
                    formularioJefeDeCocina.Show();
                    this.Hide();
                }
                else if (rol == "Encargado De Transporte")
                {  
                    formularioEncargadoTransporte formularioEncargadoTransporte = new formularioEncargadoTransporte();
                    formularioEncargadoTransporte.Show();
                    this.Hide();
                }
                else if (rol == "Atención Al Público")
                {
               
                    formularioAtencionAlPublico formularioAtencionAlPublico = new formularioAtencionAlPublico();
                    formularioAtencionAlPublico.Show();
                    this.Hide();

                }
                else if (rol == "Informático")
                {
                    formularioInformatico infor = new formularioInformatico();
                    infor.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }
        //----------------------------------------------------------------------------------------
        // Diseño interfaz
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra la aplicacion por completo
        }

        private void txtUser_Leave_1(object sender, EventArgs e) //Puedes usar el evento "Leave" para realizar acciones o validaciones cuando el usuario deja un campo de texto.
        {
            if (txtUser.Text == "") //if condicion: Cuando el TextBox (txtUser) este vacio
            {
                txtUser.Text = "Ingrese su usuario"; // el TextBox mostrara el mensaje "Ingrese su usuario"
                txtUser.ForeColor = Color.Silver; // se establece el color de primer plano (foreground color) del control TextBox user. El color de primer plano determina el color del texto que se muestra en el control.
            }
        }

        private void txtUser_Enter_1(object sender, EventArgs e)// Puedes utilizar el evento "Enter" para realizar acciones o cambios en el control TextBox cuando el usuario lo selecciona o comienza a interactuar con él.
        {
            if (txtUser.Text == "Ingrese su usuario")
            {

                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;

            }
        }

        private void txtPass_Leave_1(object sender, EventArgs e)//Puedes usar el evento "Leave" para realizar acciones o validaciones cuando el usuario deja un campo de texto.
        {
            if (txtPass.Text == "") //if condicion: Cuando el TextBox (txtUser) este vacio
            {
                txtPass.Text = "Ingrese su contraseña"; // el TextBox mostrara el mensaje "Ingrese su contraseña"
                txtPass.ForeColor = Color.Silver; // se establece el color de primer plano (foreground color) del control TextBox user. El color de primer plano determina el color del texto que se muestra en el control.
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtPass_Enter_1(object sender, EventArgs e)
        {
            if (txtPass.Text == "Ingrese su contraseña")
            {

                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;

            }
        }

        private void view_CheckedChanged_1(object sender, EventArgs e)
        {
            if (view.Checked) /*La propiedad Checked en un control CheckBox en C# indica si el CheckBox está marcado (seleccionado) o no.
                                 La propiedad Checked es de tipo bool, lo que significa que puede tener dos valores posibles: true o false. */
            {
                // Acciones a realizar cuando el CheckBox está marcado
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                // Acciones a realizar cuando el CheckBox no está marcado
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Verifica si la tecla presionada es "Enter"
            {
                // Ejecutar el botón automáticamente
                btnLogin.PerformClick(); // Simula un clic en el botón "btnLogin"
                e.SuppressKeyPress = true; // Suprime el sonido de "beep" al presionar "Enter"
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ejecutar el botón automáticamente
                btnLogin.PerformClick();
                e.SuppressKeyPress = true; // Suprimir el sonido de "beep" al presionar "Enter"
            }
        }

        private void view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ejecutar el botón automáticamente
                btnLogin.PerformClick();
                e.SuppressKeyPress = true; // Suprimir el sonido de "beep" al presionar "Enter"
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        //Arrastre de ventana
        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Minimizar ventana
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {   
            
        }

        private async void button1_MouseHover(object sender, EventArgs e)
        {
            // Esperar 3 segundos antes de mostrar el tooltip
            await Task.Delay(2000);

            // Mostrar el tooltip del metodo
            ShowToolTipCerrar();
        }

        private void ShowToolTipCerrar()
        {
            toolTip.Show("Cerrar ventana", btnCerrar);
            Task.Delay(2000).ContinueWith(_ => this.Invoke(new Action(() => toolTip.Hide(btnCerrar)))); // Ocultar después de 3 segundos
        }

        private async void btnMinimizar_MouseHover(object sender, EventArgs e)
        {
            // Esperar 3 segundos antes de mostrar el tooltip
            await Task.Delay(2000);

            // Mostrar el tooltip del metodo
            ShowToolTipMinimizar();
        }

        private void ShowToolTipMinimizar()
        {
            toolTip.Show("Minimizar Ventana", btnMinimizar);
            Task.Delay(2000).ContinueWith(_ => this.Invoke(new Action(() => toolTip.Hide(btnMinimizar)))); // Ocultar después de 3 segundos
        }

        
    }
}


