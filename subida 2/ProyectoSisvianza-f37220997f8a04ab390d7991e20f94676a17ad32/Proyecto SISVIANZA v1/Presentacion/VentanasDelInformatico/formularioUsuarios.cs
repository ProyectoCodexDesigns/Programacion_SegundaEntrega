using Google.Protobuf.WellKnownTypes;
using Proyecto_SISVIANZA_v1.Logica;
using System;
using System.Drawing;
using System.Text.RegularExpressions; // Para poder utilizar metodo Regex
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDelInformatico
{
    public partial class formularioUsuarios : Form
    {
        //Ventanita emergente
        private ToolTip toolTip;// Declarar ToolTip como una variable miembro

        int Y = 0;
        int X = 0;

        //Grosor del borde blanco
        private int borderSize = 1;

        public formularioUsuarios()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; //La ventana no tendrá ningún tipo de borde visible
            this.Padding = new Padding(borderSize);

            //Ventanita emergente en el boton
            toolTip = new ToolTip();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra la aplicacion por completo

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (txtCI.Text == "Ingrese cedula de identidad")
            {

                txtCI.Text = "";
                txtCI.ForeColor = Color.Black;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCI_Leave(object sender, EventArgs e)
        {
            if (txtCI.Text == "") //if condicion: Cuando el TextBox (txtUser) este vacio
            {
                txtCI.Text = "Ingrese cedula de identidad"; // el TextBox mostrara el mensaje "Ingrese su usuario"
                txtCI.ForeColor = Color.Silver; // se establece el color de primer plano (foreground color) del control TextBox user. El color de primer plano determina el color del texto que se muestra en el control.
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Ingrese contraseña")
            {

                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Ingrese contraseña";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtPassagain.Text == "Vuelva a ingresar contraseña")
            {

                txtPassagain.Text = "";
                txtPassagain.ForeColor = Color.Black;

            }
        }

        private void txtPassagain_Leave(object sender, EventArgs e)
        {
            if (txtPassagain.Text == "")
            {
                txtPassagain.Text = "Vuelva a ingresar contraseña";
                txtPassagain.ForeColor = Color.Silver;
            }
        }



        private void txtRol_Enter(object sender, EventArgs e)
        {
            if (txtRol.Text == "Ingrese rol")
            {

                txtRol.Text = "";
                txtRol.ForeColor = Color.Black;

            }
        }

        private void txtRol_Leave(object sender, EventArgs e)
        {
            if (txtRol.Text == "")
            {
                txtRol.Text = "Ingrese rol";
                txtRol.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e) //BOTÓN REGISTRAR
        {

            //RESTRICCIONES
            Registro reg = new Registro();

            string ci, pass, rol;

            //VERIFICACIÓN DE QUE NINGUN CAMPO ESTE VACIO.

            if (txtCI.Text == "Ingrese cedula de identidad" || txtPassword.Text == "Ingrese Contraseña" || txtPassagain.Text == "Vuelva a ingresar contraseña" || txtRol.Text == "Ingrese rol" || txtCI.Text == "" || txtPassword.Text == "" || txtPassagain.Text == "" || txtRol.Text == "")
            {
                MessageBox.Show("Ninguno de lo campos puede estar vacio.");
            }

            //VERIFICACIÓN DE CONTRASEÑAS IGUALES.
            else if (txtPassword.Text == txtPassagain.Text)
            {
                //VERIFICACIÓN DE CEDULA.

                bool esValida = Regex.IsMatch(txtCI.Text, @"^\d{9}$|^\d{8}$"); // Esta expresión regular comprueba si la cadena contiene únicamente dígitos del 0 al 9.

                if (esValida)

                {

                    if (reg.Cidiff(txtCI.Text)) // metodo para validar que la cedula no se repita.
                    {
                        MessageBox.Show("La cedula de identidad ingresada ya existe.");
                    }
                    else
                    {

                        //VERIFICACIÓN DE ROL VALIDO.

                        if (reg.VerificarRol(txtRol.Text))
                        {
                            //El rol es válido.
                            

                            //CODIGO
                            pass = txtPassword.Text;
                            ci = txtCI.Text;
                            rol = txtRol.Text;


                            reg.Registrar(ci, pass, rol); //metodo para insertar los datos en la tabla correspondiente, en este caso usuario.

                            txtPassword.Text = "Ingrese contraseña";
                            txtPassword.ForeColor = Color.Silver;
                            txtPassagain.Text = "Vuelva a ingresar contraseña";
                            txtPassagain.ForeColor = Color.Silver;
                            txtCI.Text = "Ingrese cedula de identidad";
                            txtCI.ForeColor = Color.Silver;
                            txtRol.Text = "Ingrese rol";
                            txtRol.ForeColor = Color.Silver;

                            MessageBox.Show("Usuario registrado correctamente!");
                        }

                        else
                        {
                            //El rol es inválido. 
                            MessageBox.Show("El rol ingresado es inválido, lista de roles permitidos ( Gerente, Administración, Jefe De Cocina, Encargado De Transporte, Atención Al público, Informático ). ");
                        }
                    }
                    //FIN -----------------------------------------------------------------
                }
                else
                {
                    MessageBox.Show("La cédula es inválida. No se permiten letras o números inferiores a 8 dígitos.");
                }


            }
            else
            {
                MessageBox.Show("Las contraseñas deben ser iguales.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            //RESTRICCIONES
            Registro reg = new Registro();

            string ci, pass, rol;

            //VERIFICACIÓN DE QUE NINGUN CAMPO ESTE VACIO.

            if (txtCI.Text == "Ingrese cedula de identidad" || txtPassword.Text == "Ingrese Contraseña" || txtPassagain.Text == "Vuelva a ingresar contraseña" || txtRol.Text == "Ingrese rol" || txtCI.Text == "" || txtPassword.Text == "" || txtPassagain.Text == "" || txtRol.Text == "")
            {
                MessageBox.Show("Ninguno de lo campos puede estar vacio.");
            }

            //VERIFICACIÓN DE CONTRASEÑAS IGUALES.
            else if (txtPassword.Text == txtPassagain.Text)
            {
                //VERIFICACIÓN DE CEDULA.

                bool esValida = Regex.IsMatch(txtCI.Text, @"^\d{9}$|^\d{8}$"); // Esta expresión regular comprueba si la cadena contiene únicamente dígitos del 0 al 9.

                if (esValida)

                {

                    if (reg.Cidiff(txtCI.Text)) // metodo para validar que la cedula exista.
                    {
                        //VERIFICACIÓN DE ROL VALIDO.

                        if (reg.VerificarRol(txtRol.Text))
                        {
                            //El rol es válido. 




                            //CODIGO
                            pass = txtPassword.Text;
                            ci = txtCI.Text;
                            rol = txtRol.Text;

                            reg.Actualizar(ci, pass, rol); //metodo para modificar los datos en la tabla correspondiente, en este caso usuario.


                            txtPassword.Text = "Ingrese contraseña";
                            txtPassword.ForeColor = Color.Silver;
                            txtPassagain.Text = "Vuelva a ingresar contraseña";
                            txtPassagain.ForeColor = Color.Silver;
                            txtCI.Text = "Ingrese cedula de identidad";
                            txtCI.ForeColor = Color.Silver;
                            txtRol.Text = "Ingrese rol";
                            txtRol.ForeColor = Color.Silver;

                            MessageBox.Show("Usuario modificado correctamente!");
                        }

                        else
                        {
                            //El rol es inválido. 
                            MessageBox.Show("El rol ingresado es inválido, lista de roles permitidos ( Gerente, Administración, Jefe De Cocina, Encargado De Transporte, Atención Al público, Informático ). ");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("La cedula de identidad ingresada no existe.");

                    }
                    //FIN -----------------------------------------------------------------
                }
                else
                {
                    MessageBox.Show("La cédula es inválida. No se permiten letras o números inferiores a 8 dígitos.");
                }


            }
            else
            {
                MessageBox.Show("Las contraseñas deben ser iguales.");
            }
            //Resto del codigo

        }




        private void button4_Click(object sender, EventArgs e)
        {

            //RESTRICCIONES
            Registro reg = new Registro();

            string ci;


            //VERIFICACIÓN DE CEDULA.

            bool esValida = Regex.IsMatch(txtCI.Text, @"^\d{9}$|^\d{8}$"); // Esta expresión regular comprueba si la cadena contiene únicamente dígitos del 0 al 9.

            if (esValida)

                {

                    if (reg.Cidiff(txtCI.Text)) // metodo para validar que la cedula no se repita.
                    {
                    //CODIGO

                    ci = txtCI.Text;

                    reg.Eliminar(ci); //metodo para eliminar los datos en la tabla correspondiente, en este caso usuario.

                    txtPassword.Text = "Ingrese contraseña";
                    txtPassword.ForeColor = Color.Silver;
                    txtPassagain.Text = "Vuelva a ingresar contraseña";
                    txtPassagain.ForeColor = Color.Silver;
                    txtCI.Text = "Ingrese cedula de identidad";
                    txtCI.ForeColor = Color.Silver;
                    txtRol.Text = "Ingrese rol";
                    txtRol.ForeColor = Color.Silver;

                    MessageBox.Show("Usuario eliminado correctamente!");

                    }
                    else
                    {
                    MessageBox.Show("La cedula de identidad ingresada no existe.");

                    }
                    //FIN -----------------------------------------------------------------
                }
                else
                {
                    MessageBox.Show("La cédula es inválida. No se permiten letras o números inferiores a 8 dígitos.");
                }


            
            

            //Resto del codigo
        }





        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void txtPassagain_TextChanged(object sender, EventArgs e) { }
        private void txtRol_TextChanged(object sender, EventArgs e) { }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioInformatico formularioInformatico = new formularioInformatico();
            formularioInformatico.Show();
            this.Close();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            formularioInformatico formularioInformatico = new formularioInformatico();
            formularioInformatico.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formularioUsuarios_MouseMove(object sender, MouseEventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
