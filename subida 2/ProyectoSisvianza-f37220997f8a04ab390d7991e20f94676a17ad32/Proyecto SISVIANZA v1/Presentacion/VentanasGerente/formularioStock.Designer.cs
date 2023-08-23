namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasGerente
{
    partial class formularioStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioStock));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnListar_Pedidos = new System.Windows.Forms.Button();
            this.lblID_Menu = new System.Windows.Forms.Label();
            this.txtID_Menu = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.txtIDPedido = new System.Windows.Forms.TextBox();
            this.btnListar_Menus = new System.Windows.Forms.Button();
            this.lblID_Vianda = new System.Windows.Forms.Label();
            this.txtID_Vianda = new System.Windows.Forms.TextBox();
            this.btnListar_Viandas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnAchicar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(131, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 33);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(7, 204);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(501, 250);
            this.dgvLista.TabIndex = 30;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // btnListar_Pedidos
            // 
            this.btnListar_Pedidos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListar_Pedidos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnListar_Pedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListar_Pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar_Pedidos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar_Pedidos.ForeColor = System.Drawing.Color.White;
            this.btnListar_Pedidos.Location = new System.Drawing.Point(358, 20);
            this.btnListar_Pedidos.Name = "btnListar_Pedidos";
            this.btnListar_Pedidos.Size = new System.Drawing.Size(150, 23);
            this.btnListar_Pedidos.TabIndex = 29;
            this.btnListar_Pedidos.Text = "Listar Pedidos";
            this.btnListar_Pedidos.UseVisualStyleBackColor = false;
            this.btnListar_Pedidos.Click += new System.EventHandler(this.btnListar_Pedidos_Click);
            // 
            // lblID_Menu
            // 
            this.lblID_Menu.AutoSize = true;
            this.lblID_Menu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblID_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_Menu.ForeColor = System.Drawing.Color.White;
            this.lblID_Menu.Location = new System.Drawing.Point(3, 46);
            this.lblID_Menu.Name = "lblID_Menu";
            this.lblID_Menu.Size = new System.Drawing.Size(89, 19);
            this.lblID_Menu.TabIndex = 35;
            this.lblID_Menu.Text = "ID del Menu:";
            // 
            // txtID_Menu
            // 
            this.txtID_Menu.Location = new System.Drawing.Point(131, 46);
            this.txtID_Menu.Name = "txtID_Menu";
            this.txtID_Menu.Size = new System.Drawing.Size(207, 20);
            this.txtID_Menu.TabIndex = 34;
            this.txtID_Menu.TextChanged += new System.EventHandler(this.txtID_Menu_TextChanged);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPedido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.Color.White;
            this.lblPedido.Location = new System.Drawing.Point(3, 20);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(97, 19);
            this.lblPedido.TabIndex = 37;
            this.lblPedido.Text = "ID del Pedido:";
            // 
            // txtIDPedido
            // 
            this.txtIDPedido.Location = new System.Drawing.Point(131, 20);
            this.txtIDPedido.Name = "txtIDPedido";
            this.txtIDPedido.Size = new System.Drawing.Size(207, 20);
            this.txtIDPedido.TabIndex = 36;
            this.txtIDPedido.TextChanged += new System.EventHandler(this.txtIDPedido_TextChanged);
            // 
            // btnListar_Menus
            // 
            this.btnListar_Menus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListar_Menus.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnListar_Menus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListar_Menus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar_Menus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar_Menus.ForeColor = System.Drawing.Color.White;
            this.btnListar_Menus.Location = new System.Drawing.Point(358, 46);
            this.btnListar_Menus.Name = "btnListar_Menus";
            this.btnListar_Menus.Size = new System.Drawing.Size(150, 23);
            this.btnListar_Menus.TabIndex = 38;
            this.btnListar_Menus.Text = "Listar Menus";
            this.btnListar_Menus.UseVisualStyleBackColor = false;
            this.btnListar_Menus.Click += new System.EventHandler(this.btnListar_Menus_Click_1);
            // 
            // lblID_Vianda
            // 
            this.lblID_Vianda.AutoSize = true;
            this.lblID_Vianda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblID_Vianda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_Vianda.ForeColor = System.Drawing.Color.White;
            this.lblID_Vianda.Location = new System.Drawing.Point(3, 72);
            this.lblID_Vianda.Name = "lblID_Vianda";
            this.lblID_Vianda.Size = new System.Drawing.Size(107, 19);
            this.lblID_Vianda.TabIndex = 41;
            this.lblID_Vianda.Text = "ID de la Vianda:";
            // 
            // txtID_Vianda
            // 
            this.txtID_Vianda.Location = new System.Drawing.Point(131, 72);
            this.txtID_Vianda.Name = "txtID_Vianda";
            this.txtID_Vianda.Size = new System.Drawing.Size(207, 20);
            this.txtID_Vianda.TabIndex = 40;
            this.txtID_Vianda.TextChanged += new System.EventHandler(this.txtID_Vianda_TextChanged);
            // 
            // btnListar_Viandas
            // 
            this.btnListar_Viandas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListar_Viandas.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnListar_Viandas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListar_Viandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar_Viandas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar_Viandas.ForeColor = System.Drawing.Color.White;
            this.btnListar_Viandas.Location = new System.Drawing.Point(358, 72);
            this.btnListar_Viandas.Name = "btnListar_Viandas";
            this.btnListar_Viandas.Size = new System.Drawing.Size(150, 23);
            this.btnListar_Viandas.TabIndex = 42;
            this.btnListar_Viandas.Text = "Listar viandas";
            this.btnListar_Viandas.UseVisualStyleBackColor = false;
            this.btnListar_Viandas.Click += new System.EventHandler(this.btnListar_Viandas_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnAchicar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 35);
            this.panel1.TabIndex = 115;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 101;
            this.label1.Text = "GERENTE-STOCK";
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(435, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 30);
            this.btnMaximizar.TabIndex = 12;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(394, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 32);
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnAchicar
            // 
            this.btnAchicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAchicar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAchicar.BackgroundImage")));
            this.btnAchicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAchicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAchicar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAchicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAchicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAchicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAchicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchicar.ForeColor = System.Drawing.Color.White;
            this.btnAchicar.Location = new System.Drawing.Point(433, 2);
            this.btnAchicar.Name = "btnAchicar";
            this.btnAchicar.Size = new System.Drawing.Size(31, 30);
            this.btnAchicar.TabIndex = 100;
            this.btnAchicar.UseVisualStyleBackColor = true;
            this.btnAchicar.Visible = false;
            this.btnAchicar.Click += new System.EventHandler(this.btnAchicar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(468, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 33);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lblPedido);
            this.panel2.Controls.Add(this.lblID_Menu);
            this.panel2.Controls.Add(this.lblID_Vianda);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.btnListar_Viandas);
            this.panel2.Controls.Add(this.txtIDPedido);
            this.panel2.Controls.Add(this.btnListar_Menus);
            this.panel2.Controls.Add(this.txtID_Vianda);
            this.panel2.Controls.Add(this.txtID_Menu);
            this.panel2.Controls.Add(this.btnListar_Pedidos);
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 163);
            this.panel2.TabIndex = 116;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(429, 460);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(79, 30);
            this.btnVolver.TabIndex = 121;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnCerrarSecion_Click);
            // 
            // formularioStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(513, 497);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLista);
            this.Name = "formularioStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formularioStock";
            this.Load += new System.EventHandler(this.formularioStock_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formularioStock_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnListar_Pedidos;
        private System.Windows.Forms.Label lblID_Menu;
        private System.Windows.Forms.TextBox txtID_Menu;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox txtIDPedido;
        private System.Windows.Forms.Button btnListar_Menus;
        private System.Windows.Forms.Label lblID_Vianda;
        private System.Windows.Forms.TextBox txtID_Vianda;
        private System.Windows.Forms.Button btnListar_Viandas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnAchicar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVolver;
    }
}