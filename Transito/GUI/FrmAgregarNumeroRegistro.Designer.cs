namespace GUI
{
    partial class FrmAgregarNumeroRegistro
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNumeroDeRegistro = new System.Windows.Forms.TextBox();
            this.lblNumeroDeRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(43, 90);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(215, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNumeroDeRegistro
            // 
            this.txtNumeroDeRegistro.Location = new System.Drawing.Point(115, 41);
            this.txtNumeroDeRegistro.Name = "txtNumeroDeRegistro";
            this.txtNumeroDeRegistro.Size = new System.Drawing.Size(173, 20);
            this.txtNumeroDeRegistro.TabIndex = 1;
            // 
            // lblNumeroDeRegistro
            // 
            this.lblNumeroDeRegistro.AutoSize = true;
            this.lblNumeroDeRegistro.Location = new System.Drawing.Point(13, 44);
            this.lblNumeroDeRegistro.Name = "lblNumeroDeRegistro";
            this.lblNumeroDeRegistro.Size = new System.Drawing.Size(99, 13);
            this.lblNumeroDeRegistro.TabIndex = 2;
            this.lblNumeroDeRegistro.Text = "Número de registro:";
            // 
            // FrmAgregarNumeroRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 125);
            this.Controls.Add(this.lblNumeroDeRegistro);
            this.Controls.Add(this.txtNumeroDeRegistro);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmAgregarNumeroRegistro";
            this.Text = "Ingresar numero de registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNumeroDeRegistro;
        private System.Windows.Forms.Label lblNumeroDeRegistro;
    }
}