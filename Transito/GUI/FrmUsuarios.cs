using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Logica;

namespace GUI
{
    public partial class FrmUsuarios : Form
    {
        UserD oUserD = new UserD();
        List<UserE> listUserE;

        public FrmUsuarios()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.CargarDGview();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUser oFrmAgregarUsuarios = new FrmAgregarUser();
            oFrmAgregarUsuarios.ShowDialog();

            if (oFrmAgregarUsuarios.Aceptar)
            {
                if (oUserD.agregarUser(oFrmAgregarUsuarios.OUserE))
                {
                    MessageBox.Show("Usuario agregado exitosamente!");
                    this.CargarDGview();
                }
            }
        }

        private void CargarDGview()
        {
            this.userGrid.DataSource = "";

            this.listUserE = oUserD.obtenerUsuarios();
            if (!oUserD.Error)
            {
                this.userGrid.DataSource = listUserE;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
