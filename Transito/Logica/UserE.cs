using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UserE
    {
        private string user;
        private string nombre;
        private string contrasenna;
        private string rol;

        public UserE(string pUser, string pNombre, string pContrasenna, string pRol)
        {
            this.user = pUser;
            this.nombre = pNombre;
            this.contrasenna = pContrasenna;
            this.rol = pRol;
        }
        public UserE() {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contrasenna { get => contrasenna; set => contrasenna = value; }
        public string Rol { get => rol; set => rol = value; }
        public string User { get => user; set => user = value; }

        public override string ToString()
        {
            return (this.User + "@" + this.Nombre ) ;
        }
    }
}
