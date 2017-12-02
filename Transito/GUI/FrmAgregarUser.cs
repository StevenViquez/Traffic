using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace GUI
{
    public partial class FrmAgregarUser : Form
    {
        private Boolean aceptar = false;
        private UserE oUserE = null;

        public bool Aceptar { get => aceptar;}
        public UserE OUserE { get => oUserE;}

        public FrmAgregarUser()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.llenarCombo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((this.txtContrasenna.Text != "") && (this.txtNombre.Text != "")
                && (this.txtUsuario.Text != "") && (this.cmbRol.SelectedItem != null))
            {
                this.oUserE = new UserE(this.txtUsuario.Text, this.txtNombre.Text, this.txtContrasenna.Text, (string)this.cmbRol.SelectedItem);
                this.aceptar = true;
                this.Close();
            }                      
        }

        public void llenarCombo()
        {
            this.cmbRol.Items.Add("Administrador");
            this.cmbRol.Items.Add("Juez");
            this.cmbRol.Items.Add("Oficial");
            this.cmbRol.Items.Add("Usuario");
        }
    }
}
