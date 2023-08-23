namespace Proyecto_SISVIANZA_v1.Presentacion
{
    partial class formularioAdministrador
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

        private void InitializeComponent()
        {
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnCerrarSecion = new System.Windows.Forms.Button();
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClientes.Location = new System.Drawing.Point(215, 118);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 23);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblAdministrador.Location = new System.Drawing.Point(2, 22);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(425, 46);
            this.lblAdministrador.TabIndex = 1;
            this.lblAdministrador.Text = "Ventana Administrador";
            this.lblAdministrador.Click += new System.EventHandler(this.lblAdministrador_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPedidos.Location = new System.Drawing.Point(215, 88);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(75, 23);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnCerrarSecion
            // 
            this.btnCerrarSecion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCerrarSecion.Location = new System.Drawing.Point(520, 526);
            this.btnCerrarSecion.Name = "btnCerrarSecion";
            this.btnCerrarSecion.Size = new System.Drawing.Size(133, 23);
            this.btnCerrarSecion.TabIndex = 3;
            this.btnCerrarSecion.Text = "Cerrar seción";
            this.btnCerrarSecion.UseVisualStyleBackColor = false;
            this.btnCerrarSecion.Click += new System.EventHandler(this.btnCerrarSecion_Click);
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(11, 194);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.Size = new System.Drawing.Size(642, 323);
            this.dgvNotificaciones.TabIndex = 4;
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificaciones.Location = new System.Drawing.Point(6, 165);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(118, 19);
            this.lblNotificaciones.TabIndex = 24;
            this.lblNotificaciones.Text = "Notificaciones";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.Location = new System.Drawing.Point(6, 90);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(203, 19);
            this.lblPedidos.TabIndex = 27;
            this.lblPedidos.Text = "Ir al apartado de pedidos:";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(6, 122);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(200, 19);
            this.lblClientes.TabIndex = 28;
            this.lblClientes.Text = "Ir al apartado de clientes:";
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRechazar.Location = new System.Drawing.Point(247, 159);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(78, 25);
            this.btnRechazar.TabIndex = 113;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = false;
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAprobar.Location = new System.Drawing.Point(146, 159);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(78, 25);
            this.btnAprobar.TabIndex = 112;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnActualizar.Location = new System.Drawing.Point(455, 159);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(78, 25);
            this.btnActualizar.TabIndex = 111;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBorrar.Location = new System.Drawing.Point(353, 159);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(78, 25);
            this.btnBorrar.TabIndex = 110;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // formularioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(669, 557);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.dgvNotificaciones);
            this.Controls.Add(this.btnCerrarSecion);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.btnClientes);
            this.Name = "formularioAdministrador";
            this.Text = "formulario Administrador";
            this.Load += new System.EventHandler(this.RegistroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnCerrarSecion;
        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.Label lblNotificaciones;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
    }
}