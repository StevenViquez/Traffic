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
    public partial class FrmCrearEvento : Form
    {
        Boolean aceptar = false;
        EventoE oEvento = null;

        public bool Aceptar { get => aceptar;}
        public EventoE OEvento { get => oEvento;}

        public FrmCrearEvento()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((this.txtLugarChoque.Text != "") && (this.txtPlacaVehiculo.Text != ""))
            {
                oEvento = new EventoE(this.txtLugarChoque.Text, this.txtPlacaVehiculo.Text,
                    "Link", "Abierto", "", "", 0);
                this.aceptar = true;
                this.Hide();
            }
            else {
                MessageBox.Show("Debe llenar todos los espacios");
            }
        }
    }
}
