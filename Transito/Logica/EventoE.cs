using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EventoE
    {
        private int id;
        private string lugarChoque;
        private string placaVehiculo;
        private string linkFoto;
        private string estado;
        private string propietario;
        private string numeroParte;
        private int numeroRegistro;

        public EventoE(int pId, string pLugarChoque, string pPlacaVehiculo, string pLinkFoto, string pEstado, string pPropietario, string pNumeroParte, int pNumeroRegistro)
        {
            this.id = pId;
            this.lugarChoque = pLugarChoque;
            this.placaVehiculo = pPlacaVehiculo;
            this.linkFoto = pLinkFoto;
            this.estado = pEstado;
            this.propietario = pPropietario;
            this.numeroParte = pNumeroParte;
            this.numeroRegistro = pNumeroRegistro;
        }

        public EventoE(string pLugarChoque, string pPlacaVehiculo, string pLinkFoto, string pEstado, string pPropietario, string pNumeroParte, int pNumeroRegistro)
        {
            this.lugarChoque = pLugarChoque;
            this.placaVehiculo = pPlacaVehiculo;
            this.linkFoto = pLinkFoto;
            this.estado = pEstado;
            this.propietario = pPropietario;
            this.numeroParte = pNumeroParte;
            this.numeroRegistro = pNumeroRegistro;
        }

        public int Id { get => id; set => id = value; }
        public string LugarChoque { get => lugarChoque; set => lugarChoque = value; }
        public string PlacaVehiculo { get => placaVehiculo; set => placaVehiculo = value; }
        public string LinkFoto { get => linkFoto; set => linkFoto = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Propietario { get => propietario; set => propietario = value; }
        public string NumeroParte { get => numeroParte; set => numeroParte = value; }
        public int NumeroRegistro { get => numeroRegistro; set => numeroRegistro = value; }

        public override string ToString()
        {
            return ("Lugar: " + this.LugarChoque + "\n" + "Estado: " + this.Estado);
        }
    }
}
