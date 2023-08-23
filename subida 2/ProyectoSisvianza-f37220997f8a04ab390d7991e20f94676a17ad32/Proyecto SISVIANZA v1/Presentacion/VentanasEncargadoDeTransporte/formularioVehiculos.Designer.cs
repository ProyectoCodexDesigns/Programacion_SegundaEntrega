namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasEncargadoDeTransporte
{
    partial class formularioVehiculos
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
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnListar_Vehiculos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtDisponibilidad = new System.Windows.Forms.TextBox();
            this.lblAlergias = new System.Windows.Forms.Label();
            this.lblCi = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCapacidad_Carga = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(15, 45);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(228, 24);
            this.lblDatos.TabIndex = 55;
            this.lblDatos.Text = "Datos de los vehiculos:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(267, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 21);
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 259);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(643, 296);
            this.dgvLista.TabIndex = 49;
            // 
            // btnListar_Vehiculos
            // 
            this.btnListar_Vehiculos.Location = new System.Drawing.Point(66, 230);
            this.btnListar_Vehiculos.Name = "btnListar_Vehiculos";
            this.btnListar_Vehiculos.Size = new System.Drawing.Size(150, 23);
            this.btnListar_Vehiculos.TabIndex = 48;
            this.btnListar_Vehiculos.Text = "Listar Vehiculos";
            this.btnListar_Vehiculos.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(300, 159);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 47;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(580, 561);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 46;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Location = new System.Drawing.Point(168, 102);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(207, 20);
            this.txtDisponibilidad.TabIndex = 45;
            // 
            // lblAlergias
            // 
            this.lblAlergias.AutoSize = true;
            this.lblAlergias.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAlergias.Location = new System.Drawing.Point(25, 105);
            this.lblAlergias.Name = "lblAlergias";
            this.lblAlergias.Size = new System.Drawing.Size(99, 16);
            this.lblAlergias.TabIndex = 44;
            this.lblAlergias.Text = "Disponibilidad:";
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCi.Location = new System.Drawing.Point(22, 14);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(22, 16);
            this.lblCi.TabIndex = 39;
            this.lblCi.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(51, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(207, 20);
            this.txtId.TabIndex = 38;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNombre.Location = new System.Drawing.Point(23, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(38, 16);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(168, 72);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(207, 20);
            this.txtTipo.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(168, 159);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCapacidad_Carga
            // 
            this.txtCapacidad_Carga.Location = new System.Drawing.Point(168, 129);
            this.txtCapacidad_Carga.Name = "txtCapacidad_Carga";
            this.txtCapacidad_Carga.Size = new System.Drawing.Size(207, 20);
            this.txtCapacidad_Carga.TabIndex = 32;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTelefono.Location = new System.Drawing.Point(23, 130);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(139, 16);
            this.lblTelefono.TabIndex = 36;
            this.lblTelefono.Text = "Capacidad de carga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 65;
            this.label5.Text = "Lista:";
            // 
            // formularioVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 592);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnListar_Vehiculos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtDisponibilidad);
            this.Controls.Add(this.lblAlergias);
            this.Controls.Add(this.lblCi);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCapacidad_Carga);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "formularioVehiculos";
            this.Text = "formularioVehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnListar_Vehiculos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtDisponibilidad;
        private System.Windows.Forms.Label lblAlergias;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCapacidad_Carga;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label5;
    }
}