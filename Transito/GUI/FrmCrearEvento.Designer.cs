namespace GUI
{
    partial class FrmCrearEvento
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
            this.txtLugarChoque = new System.Windows.Forms.TextBox();
            this.txtPlacaVehiculo = new System.Windows.Forms.TextBox();
            this.lblLugarChoque = new System.Windows.Forms.Label();
            this.lblPlacaVehiculo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLugarChoque
            // 
            this.txtLugarChoque.Location = new System.Drawing.Point(100, 13);
            this.txtLugarChoque.Name = "txtLugarChoque";
            this.txtLugarChoque.Size = new System.Drawing.Size(143, 20);
            this.txtLugarChoque.TabIndex = 0;
            // 
            // txtPlacaVehiculo
            // 
            this.txtPlacaVehiculo.Location = new System.Drawing.Point(100, 62);
            this.txtPlacaVehiculo.Name = "txtPlacaVehiculo";
            this.txtPlacaVehiculo.Size = new System.Drawing.Size(143, 20);
            this.txtPlacaVehiculo.TabIndex = 1;
            // 
            // lblLugarChoque
            // 
            this.lblLugarChoque.AutoSize = true;
            this.lblLugarChoque.Location = new System.Drawing.Point(1, 16);
            this.lblLugarChoque.Name = "lblLugarChoque";
            this.lblLugarChoque.Size = new System.Drawing.Size(93, 13);
            this.lblLugarChoque.TabIndex = 2;
            this.lblLugarChoque.Text = "Lugar del choque:";
            // 
            // lblPlacaVehiculo
            // 
            this.lblPlacaVehiculo.AutoSize = true;
            this.lblPlacaVehiculo.Location = new System.Drawing.Point(1, 69);
            this.lblPlacaVehiculo.Name = "lblPlacaVehiculo";
            this.lblPlacaVehiculo.Size = new System.Drawing.Size(95, 13);
            this.lblPlacaVehiculo.TabIndex = 3;
            this.lblPlacaVehiculo.Text = "Placa de vehiculo:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(18, 119);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(225, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmCrearEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 187);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPlacaVehiculo);
            this.Controls.Add(this.lblLugarChoque);
            this.Controls.Add(this.txtPlacaVehiculo);
            this.Controls.Add(this.txtLugarChoque);
            this.Name = "FrmCrearEvento";
            this.Text = "Nuevo Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLugarChoque;
        private System.Windows.Forms.TextBox txtPlacaVehiculo;
        private System.Windows.Forms.Label lblLugarChoque;
        private System.Windows.Forms.Label lblPlacaVehiculo;
        private System.Windows.Forms.Button btnAceptar;
    }
}