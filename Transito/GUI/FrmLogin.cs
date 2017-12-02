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
using Datos;

namespace GUI
{
    public partial class FrmLogin : Form
    {
        UserE oUser = null;
        UserD UserD = new UserD();

        public UserE OUser { get => oUser;}

        public FrmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if ((this.txtContrasenna.Text != "") && (this.txtUsuario.Text != "")) {
                this.oUser = this.UserD.obtenerUser(this.txtUsuario.Text);
                if ((this.oUser != null) && (this.txtContrasenna.Text == this.oUser.Contrasenna))
                {
                    MessageBox.Show("Bienvenido "+ oUser.Nombre +"!");
                    this.Hide();
                    FrmMain oFrmMain = new FrmMain(this.oUser);
                    oFrmMain.Show();
                }
                else {
                    MessageBox.Show("Usuario o contraseña incorrecto");
                    this.txtContrasenna.Text = "";
                    this.txtUsuario.Text = "";

                }
            }
        }
        
    }
}
