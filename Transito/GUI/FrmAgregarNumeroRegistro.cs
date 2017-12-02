using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmAgregarNumeroRegistro : Form
    {
        private Boolean aceptar = false;
        private int numeroRegistro;

        public bool Aceptar { get => aceptar; set => aceptar = value; }
        public int NumeroRegistro { get => numeroRegistro; set => numeroRegistro = value; }

        public FrmAgregarNumeroRegistro()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtNumeroDeRegistro.Text != "")
            {
                this.numeroRegistro = Convert.ToInt32(this.txtNumeroDeRegistro.Text);
                this.Hide();
            }
        }
    }
}
