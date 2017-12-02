namespace GUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.lugarChoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroParte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCrearEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAprobarCompletar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lugarChoque,
            this.placa,
            this.estado,
            this.propietario,
            this.numeroParte});
            this.mainGrid.Location = new System.Drawing.Point(12, 51);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Size = new System.Drawing.Size(547, 329);
            this.mainGrid.TabIndex = 0;
            // 
            // lugarChoque
            // 
            this.lugarChoque.DataPropertyName = "lugarChoque";
            this.lugarChoque.HeaderText = "Lugar del Choque";
            this.lugarChoque.Name = "lugarChoque";
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placaVehiculo";
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // propietario
            // 
            this.propietario.DataPropertyName = "propietario";
            this.propietario.HeaderText = "Propietario";
            this.propietario.Name = "propietario";
            // 
            // numeroParte
            // 
            this.numeroParte.DataPropertyName = "numeroParte";
            this.numeroParte.HeaderText = "Numero de parte";
            this.numeroParte.Name = "numeroParte";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOpciones
            // 
            this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCrearEvento,
            this.menuUsuarios});
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(69, 20);
            this.menuOpciones.Text = "Opciones";
            // 
            // menuCrearEvento
            // 
            this.menuCrearEvento.Name = "menuCrearEvento";
            this.menuCrearEvento.Size = new System.Drawing.Size(203, 22);
            this.menuCrearEvento.Text = "Crear evento";
            this.menuCrearEvento.Click += new System.EventHandler(this.menuCrearEvento_Click);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(203, 22);
            this.menuUsuarios.Text = "Mantenimiento usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // btnAprobarCompletar
            // 
            this.btnAprobarCompletar.Location = new System.Drawing.Point(13, 22);
            this.btnAprobarCompletar.Name = "btnAprobarCompletar";
            this.btnAprobarCompletar.Size = new System.Drawing.Size(153, 23);
            this.btnAprobarCompletar.TabIndex = 2;
            this.btnAprobarCompletar.Text = "Aprobar";
            this.btnAprobarCompletar.UseVisualStyleBackColor = true;
            this.btnAprobarCompletar.Click += new System.EventHandler(this.btnAprobarCompletar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(464, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 392);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAprobarCompletar);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.Text = "Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem menuCrearEvento;
        private System.Windows.Forms.Button btnAprobarCompletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarChoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParte;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.Button btnSalir;
    }
}

