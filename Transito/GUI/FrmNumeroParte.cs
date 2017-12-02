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
    public partial class FrmNumeroParte : Form
    {
        Boolean aceptar = false;
        string numeroParte;

        public bool Aceptar { get => aceptar; }
        public string NumeroParte { get => numeroParte; }

        public FrmNumeroParte()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtNumeroParte.Text != "") {
                this.numeroParte = this.txtNumeroParte.Text;
                this.Hide();
            }
        }

        private void FrmNumeroParte_Load(object sender, EventArgs e)
        {

        }
    }
}
