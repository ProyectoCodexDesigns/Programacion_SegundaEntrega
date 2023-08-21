namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDelAdministrador
{
    partial class formularioPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnListar_Pedidos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.txtCantidad_Menus = new System.Windows.Forms.TextBox();
            this.lblCantidad_Menus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo_Menu = new System.Windows.Forms.TextBox();
            this.txtCantidad_Viandas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreferencias_Dieteticas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFecha_Entrega = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(174, 380);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(174, 159);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCedula.Location = new System.Drawing.Point(43, 96);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(124, 16);
            this.lblCedula.TabIndex = 5;
            this.lblCedula.Text = "Cedula del cliente:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(82, 160);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(85, 16);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(174, 350);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(207, 20);
            this.txtEstado.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEstado.Location = new System.Drawing.Point(112, 349);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // btnListar_Pedidos
            // 
            this.btnListar_Pedidos.Location = new System.Drawing.Point(478, 67);
            this.btnListar_Pedidos.Name = "btnListar_Pedidos";
            this.btnListar_Pedidos.Size = new System.Drawing.Size(113, 23);
            this.btnListar_Pedidos.TabIndex = 12;
            this.btnListar_Pedidos.Text = "Listar pedidos";
            this.btnListar_Pedidos.UseVisualStyleBackColor = true;
            this.btnListar_Pedidos.Click += new System.EventHandler(this.btnListar_Pedidos_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(306, 380);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(768, 26);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(902, 454);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(174, 96);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(207, 20);
            this.txtCedula.TabIndex = 4;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(673, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Datos del pedido:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(414, 93);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(563, 355);
            this.dgvPedidos.TabIndex = 24;
            // 
            // txtCantidad_Menus
            // 
            this.txtCantidad_Menus.Location = new System.Drawing.Point(174, 128);
            this.txtCantidad_Menus.Name = "txtCantidad_Menus";
            this.txtCantidad_Menus.Size = new System.Drawing.Size(207, 20);
            this.txtCantidad_Menus.TabIndex = 3;
            // 
            // lblCantidad_Menus
            // 
            this.lblCantidad_Menus.AutoSize = true;
            this.lblCantidad_Menus.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCantidad_Menus.Location = new System.Drawing.Point(34, 128);
            this.lblCantidad_Menus.Name = "lblCantidad_Menus";
            this.lblCantidad_Menus.Size = new System.Drawing.Size(134, 16);
            this.lblCantidad_Menus.TabIndex = 7;
            this.lblCantidad_Menus.Text = "Cantidad de menus:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(70, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tipo de menu:";
            // 
            // txtTipo_Menu
            // 
            this.txtTipo_Menu.Location = new System.Drawing.Point(174, 189);
            this.txtTipo_Menu.Name = "txtTipo_Menu";
            this.txtTipo_Menu.Size = new System.Drawing.Size(207, 20);
            this.txtTipo_Menu.TabIndex = 26;
            // 
            // txtCantidad_Viandas
            // 
            this.txtCantidad_Viandas.Location = new System.Drawing.Point(174, 219);
            this.txtCantidad_Viandas.Name = "txtCantidad_Viandas";
            this.txtCantidad_Viandas.Size = new System.Drawing.Size(207, 20);
            this.txtCantidad_Viandas.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(27, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cantidad de viandas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Preferencias dieteticas:";
            // 
            // txtPreferencias_Dieteticas
            // 
            this.txtPreferencias_Dieteticas.Location = new System.Drawing.Point(174, 253);
            this.txtPreferencias_Dieteticas.Name = "txtPreferencias_Dieteticas";
            this.txtPreferencias_Dieteticas.Size = new System.Drawing.Size(207, 20);
            this.txtPreferencias_Dieteticas.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.Location = new System.Drawing.Point(63, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Fecha entrega:";
            // 
            // txtFecha_Entrega
            // 
            this.txtFecha_Entrega.Location = new System.Drawing.Point(174, 285);
            this.txtFecha_Entrega.Name = "txtFecha_Entrega";
            this.txtFecha_Entrega.Size = new System.Drawing.Size(207, 20);
            this.txtFecha_Entrega.TabIndex = 32;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(174, 317);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(207, 20);
            this.txtDireccion.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(97, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Direccion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.Location = new System.Drawing.Point(411, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "ID del pedido:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(510, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(138, 20);
            this.txtId.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Lista:";
            // 
            // formularioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(989, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFecha_Entrega);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPreferencias_Dieteticas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad_Viandas);
            this.Controls.Add(this.txtTipo_Menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnListar_Pedidos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCantidad_Menus);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtCantidad_Menus);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnAgregar);
            this.Name = "formularioPedidos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formularioPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnListar_Pedidos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.TextBox txtCantidad_Menus;
        private System.Windows.Forms.Label lblCantidad_Menus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipo_Menu;
        private System.Windows.Forms.TextBox txtCantidad_Viandas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreferencias_Dieteticas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFecha_Entrega;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
    }
}