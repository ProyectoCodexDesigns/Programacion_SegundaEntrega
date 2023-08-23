namespace Proyecto_SISVIANZA_v1.Presentacion
{
    partial class formularioEncargadoTransporte
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
            this.btnCerrarSecion = new System.Windows.Forms.Button();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblRutas = new System.Windows.Forms.Label();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSecion
            // 
            this.btnCerrarSecion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCerrarSecion.Location = new System.Drawing.Point(532, 570);
            this.btnCerrarSecion.Name = "btnCerrarSecion";
            this.btnCerrarSecion.Size = new System.Drawing.Size(119, 25);
            this.btnCerrarSecion.TabIndex = 44;
            this.btnCerrarSecion.Text = "Cerrar secion";
            this.btnCerrarSecion.UseVisualStyleBackColor = false;
            this.btnCerrarSecion.Click += new System.EventHandler(this.btnCerrarSecion_Click);
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificaciones.Location = new System.Drawing.Point(18, 201);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(118, 19);
            this.lblNotificaciones.TabIndex = 41;
            this.lblNotificaciones.Text = "Notificaciones";
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(6, 239);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.Size = new System.Drawing.Size(645, 325);
            this.dgvNotificaciones.TabIndex = 40;
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTransporte.Location = new System.Drawing.Point(-2, 9);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(568, 46);
            this.lblTransporte.TabIndex = 91;
            this.lblTransporte.Text = "ventana Encargado Transporte";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.Location = new System.Drawing.Point(12, 73);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(157, 19);
            this.lblPedidos.TabIndex = 95;
            this.lblPedidos.Text = "Visualizar Pedidos:";
            // 
            // lblRutas
            // 
            this.lblRutas.AutoSize = true;
            this.lblRutas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutas.Location = new System.Drawing.Point(12, 106);
            this.lblRutas.Name = "lblRutas";
            this.lblRutas.Size = new System.Drawing.Size(186, 19);
            this.lblRutas.TabIndex = 94;
            this.lblRutas.Text = "Ir al apartado de Rutas:";
            // 
            // btnRutas
            // 
            this.btnRutas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRutas.Location = new System.Drawing.Point(204, 102);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(75, 23);
            this.btnRutas.TabIndex = 93;
            this.btnRutas.Text = "Rutas";
            this.btnRutas.UseVisualStyleBackColor = false;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPedidos.Location = new System.Drawing.Point(175, 69);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(75, 23);
            this.btnPedidos.TabIndex = 92;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.Location = new System.Drawing.Point(12, 143);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(216, 19);
            this.lblVehiculos.TabIndex = 104;
            this.lblVehiculos.Text = "Ir al apartado de Vehiculos:";
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVehiculos.Location = new System.Drawing.Point(234, 143);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(75, 23);
            this.btnVehiculos.TabIndex = 103;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = false;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRechazar.Location = new System.Drawing.Point(251, 201);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(78, 25);
            this.btnRechazar.TabIndex = 113;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = false;
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAprobar.Location = new System.Drawing.Point(150, 201);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(78, 25);
            this.btnAprobar.TabIndex = 112;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnActualizar.Location = new System.Drawing.Point(459, 201);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(78, 25);
            this.btnActualizar.TabIndex = 111;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBorrar.Location = new System.Drawing.Point(357, 201);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(78, 25);
            this.btnBorrar.TabIndex = 110;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // formularioEncargadoTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(657, 603);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblVehiculos);
            this.Controls.Add(this.btnVehiculos);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblRutas);
            this.Controls.Add(this.btnRutas);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.btnCerrarSecion);
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.dgvNotificaciones);
            this.Name = "formularioEncargadoTransporte";
            this.Text = "formulario Encargado de Transporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSecion;
        private System.Windows.Forms.Label lblNotificaciones;
        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblRutas;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
    }
}