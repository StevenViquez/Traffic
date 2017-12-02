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
    public partial class FrmMain : Form
    {
        UserE oUserE = null;
        EventoD oEventoD = new EventoD();
        List<EventoE> listEventoE;


        public FrmMain(UserE oUserE)
        {
            InitializeComponent();
            this.oUserE = oUserE;
            this.OpcionesDeInterfaz();
            this.CenterToScreen();
            this.CargarDGview();
        }

        private void menuCrearEvento_Click(object sender, EventArgs e)
        {
            FrmCrearEvento oFrmCrearEvento = new FrmCrearEvento();
            oFrmCrearEvento.ShowDialog();

            if (oFrmCrearEvento.Aceptar) {
                oFrmCrearEvento.OEvento.Propietario = oUserE.User;
                oEventoD.agregarEvento(oFrmCrearEvento.OEvento);
                if (oEventoD.Error)
                {
                    MessageBox.Show("Error al ingresar evento, por favor ingrese los datos nuevamente.");
                }
                else {
                    MessageBox.Show("¡El evento fue registrado exitosamente!");
                }
            }
        }

        private void btnAprobarCompletar_Click(object sender, EventArgs e)
        {
            if (this.mainGrid.Rows.Count > 0)
            {
                int fila = this.mainGrid.CurrentRow.Index;
                EventoE oEventoE = this.listEventoE.ElementAt(fila);

                if (this.oUserE.Rol == "Juez")
                {
                    this.EditarSiendoJuez(oEventoE);
                }
                else
                {
                    this.EditarSiendoOficial(oEventoE);
                }
            }
        }
        
        public void EditarSiendoOficial(EventoE oEventoE)
        {
            FrmNumeroParte oFrmNumeroParte = new FrmNumeroParte();
            oFrmNumeroParte.ShowDialog();


            if (!oFrmNumeroParte.Aceptar)
            {
                oEventoE.NumeroParte = oFrmNumeroParte.NumeroParte;//Se coloca el numero de parte
                oEventoE.Estado = "Por aprobar";
                if (oEventoD.modificarEvento(oEventoE, oEventoE.Id)) ;
                {
                    this.CargarDGview();
                    MessageBox.Show("Evento por aprobar");
                }

            }
        }

        public void EditarSiendoJuez(EventoE oEventoE)
        {
            FrmAgregarNumeroRegistro oFrmAgregarNumeroRegistro = new FrmAgregarNumeroRegistro();
            oFrmAgregarNumeroRegistro.ShowDialog();


            if (!oFrmAgregarNumeroRegistro.Aceptar)
            {
                oEventoE.NumeroRegistro = oFrmAgregarNumeroRegistro.NumeroRegistro;//Se coloca el numero de parte
                oEventoE.Estado = "Completo";
                if (oEventoD.modificarEvento(oEventoE, oEventoE.Id)) ;
                {
                    this.CargarDGview();
                    MessageBox.Show("Evento por completado");
                }

            }
        }

        private void CargarDGview()
        {
            string query;
            this.mainGrid.DataSource = "";

            if (oUserE.Rol == "Juez")
            {
                query = "Abierto" + "'" + " or estado = " + "'" + "Por aprobar" + "'";
            }
            else if (oUserE.Rol == "Oficial")
            {
                query = "Abierto" + "'";
            }
            else
            {
                query = "Abierto" + "'" + " and propietario = " + "'" + this.oUserE.User + "'";
            }

            this.listEventoE = oEventoD.obtenerEventos(query);
            if (!oEventoD.Error)
            {
                this.mainGrid.DataSource = listEventoE;
            }
        }

        private void OpcionesDeInterfaz()
        {
            if (oUserE.Rol == "Juez")
            {
                this.btnAprobarCompletar.Text = "Comprobar";
                this.btnAprobarCompletar.Visible = true;
                this.menuCrearEvento.Visible = false;
                this.menuUsuarios.Visible = false;
            }
            else if (oUserE.Rol == "Oficial")
            {
                this.btnAprobarCompletar.Text = "Aprobar";
                this.btnAprobarCompletar.Visible = true;
                this.menuCrearEvento.Visible = false;
                this.menuUsuarios.Visible = false;
            }
            else if(oUserE.Rol == "Usuario")
            {
                this.btnAprobarCompletar.Visible = false;
                this.menuUsuarios.Visible = false;
            }
            else if (oUserE.Rol == "Administrador")
            {
                this.btnAprobarCompletar.Visible = false;
                this.menuCrearEvento.Visible = false;
            }
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios oFrmUsuarios = new FrmUsuarios();
            oFrmUsuarios.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin oFrmLogin = new FrmLogin();
            oFrmLogin.Show();
            this.Close();
        }
    }
}
