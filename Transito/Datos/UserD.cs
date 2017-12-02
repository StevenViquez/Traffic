using Logica;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UserD
    {
        private AccesoDatosPostgre conexion;

        private bool error;
        public bool Error
        {
            get { return error; }
        }

        private string errorMsg;
        public string ErrorMsg
        {
            get { return errorMsg; }
        }

        public UserD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        /// <summary>
        /// Obtiene un UserE de la BD
        /// </summary>
        /// <returns>Retorna un objeto UserE</returns>
        public UserE obtenerUser(string pUser)
        {

            this.limpiarError();
            DataSet dsetUsers;
            UserE user = null;
            string sql = "SELECT * FROM scheventos.usuario WHERE usuario= " +"'"+pUser +"'";

            dsetUsers = this.conexion.ejecutarConsultaSQL(sql);

            string error = this.conexion.ErrorDescripcion;

            if (!this.conexion.IsError)
            {
                if (dsetUsers.Tables[0].Rows.Count > 0)
                {
                    user = new UserE(dsetUsers.Tables[0].Rows[0]["usuario"].ToString(), dsetUsers.Tables[0].Rows[0]["nombre"].ToString(),
                    dsetUsers.Tables[0].Rows[0]["contrasenna"].ToString(), dsetUsers.Tables[0].Rows[0]["rol"].ToString());
                }
            }
            return user;
        }

        /// <summary>
        /// agrega un usuario a la BD
        /// </summary>
        /// <param name="oUser">Objeto de la clase UserE</param>
        /// <returns>Retorna un boleano dando a conocer si se guardo en la BD o no</returns>
        public bool agregarUser(UserE oUser)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO scheventos.usuario(" +
                "usuario, nombre, contrasenna, rol) "+
                "VALUES(@user, @nombre, @contrasenna, @rol); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@user", NpgsqlDbType.Varchar, oUser.User);
                oP.agregarParametro("@nombre", NpgsqlDbType.Varchar, oUser.Nombre);
                oP.agregarParametro("@contrasenna", NpgsqlDbType.Varchar, oUser.Contrasenna);
                oP.agregarParametro("@rol", NpgsqlDbType.Varchar, oUser.Rol);
                this.conexion.ejecutarSQL(sql, oP.obtenerParametros());
                if (this.conexion.IsError)
                {

                    estado = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }

            }
            catch (Exception e)
            {
                estado = false;
                this.errorMsg = e.Message;
            }
            return estado;
        }

        /// <summary>
        /// Borra el usuario deseado de la BD
        /// </summary>
        /// <param name="oUserE">Objeto de la clase UserE</param>
        /// <returns>Retorna un boleano dando a conocer si se borro en la BD o no</returns>
        public bool borrarUser(UserE oUserE)
        {
            bool estado = true;
            try
            {
                string sql = "DELETE FROM scheventos.usuario WHERE usuario = @user";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@user";
                parametros[0].Value = oUserE.User;

                this.conexion.ejecutarSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    estado = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                estado = false;
                this.errorMsg = e.Message;
            }
            return estado;
        }

        /// <summary>
        /// Modifica user de la BD
        /// </summary>
        /// <param name="oUserE">Objeto de la clase UserE</param>
        /// <param name="pUser">String que contiene el "user" para realizar la busqueda en la BD</param>
        /// /// <param name="oUser">Objeto User para realizar todos los cambios en BD</param>
        /// <returns>Retorna un boleano dando a conocer si se borro en la bd o no</returns>
        public bool modificarCliente(UserE oUserE, string pUser)
        {
            bool estado = true;

            try
            {

                string sql = "UPDATE scheventos.usuario " +
                        "SET usuario = @user, nombre = @nombre, contrasenna = @contrasenna, rol = @rol " +
                        "WHERE usuario = @idUser;";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();

                oP.agregarParametro("@user", NpgsqlDbType.Varchar, oUserE.User);
                oP.agregarParametro("@nombre", NpgsqlDbType.Varchar, oUserE.Nombre);
                oP.agregarParametro("@contrasenna", NpgsqlDbType.Varchar, oUserE.Contrasenna);
                oP.agregarParametro("@rol", NpgsqlDbType.Varchar, oUserE.Rol);
                oP.agregarParametro("@idUser", NpgsqlDbType.Varchar, pUser);

                this.conexion.ejecutarSQL(sql, oP.obtenerParametros());
                if (this.conexion.IsError)
                {
                    estado = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }

            }
            catch (Exception e)
            {
                estado = false;
                this.errorMsg = e.Message;
            }
            return estado;
        }

    }

}