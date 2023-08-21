namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDeAtencionAlPúblico
{
    partial class formularioEstados
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
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId_Menu = new System.Windows.Forms.TextBox();
            this.txtId_Pedido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListarEstadosPedidos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.btnListarEstadosMenus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblAdministrador.Location = new System.Drawing.Point(202, -44);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(367, 46);
            this.lblAdministrador.TabIndex = 83;
            this.lblAdministrador.Text = "Formulario Estados";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(451, 400);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 82;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "ID del pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "ID del menu:";
            // 
            // txtId_Menu
            // 
            this.txtId_Menu.Location = new System.Drawing.Point(16, 136);
            this.txtId_Menu.Name = "txtId_Menu";
            this.txtId_Menu.Size = new System.Drawing.Size(207, 20);
            this.txtId_Menu.TabIndex = 78;
            // 
            // txtId_Pedido
            // 
            this.txtId_Pedido.Location = new System.Drawing.Point(19, 71);
            this.txtId_Pedido.Name = "txtId_Pedido";
            this.txtId_Pedido.Size = new System.Drawing.Size(207, 20);
            this.txtId_Pedido.TabIndex = 77;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(16, 179);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 76;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListarEstadosPedidos
            // 
            this.btnListarEstadosPedidos.Location = new System.Drawing.Point(83, 224);
            this.btnListarEstadosPedidos.Name = "btnListarEstadosPedidos";
            this.btnListarEstadosPedidos.Size = new System.Drawing.Size(134, 23);
            this.btnListarEstadosPedidos.TabIndex = 72;
            this.btnListarEstadosPedidos.Text = "Listar Estados Pedidos";
            this.btnListarEstadosPedidos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label3.Location = new System.Drawing.Point(15, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Lista:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 131);
            this.dataGridView1.TabIndex = 70;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.Location = new System.Drawing.Point(7, 2);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(360, 45);
            this.lblPedidos.TabIndex = 84;
            this.lblPedidos.Text = "Formulario Estados";
            // 
            // btnListarEstadosMenus
            // 
            this.btnListarEstadosMenus.Location = new System.Drawing.Point(233, 224);
            this.btnListarEstadosMenus.Name = "btnListarEstadosMenus";
            this.btnListarEstadosMenus.Size = new System.Drawing.Size(134, 23);
            this.btnListarEstadosMenus.TabIndex = 85;
            this.btnListarEstadosMenus.Text = "Listar Estados Menus";
            this.btnListarEstadosMenus.UseVisualStyleBackColor = true;
            // 
            // formularioEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 427);
            this.Controls.Add(this.btnListarEstadosMenus);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId_Menu);
            this.Controls.Add(this.txtId_Pedido);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListarEstadosPedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formularioEstados";
            this.Text = "formularioEstados";
            this.Load += new System.EventHandler(this.formularioEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId_Menu;
        private System.Windows.Forms.TextBox txtId_Pedido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListarEstadosPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Button btnListarEstadosMenus;
    }
}