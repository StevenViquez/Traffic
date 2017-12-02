using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using Npgsql;
using NpgsqlTypes;

namespace Datos
{
    class EventoD
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

        public EventoD()
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
        /// Obtiene una lista cargada de todo los eventos, se filtra con el parametro pEstado
        /// </summary>
        /// <returns>Retorna una lista de tipo EventoE</returns>
        public List<EventoE> obtenerEventos(string pComando)
        {

            this.limpiarError();
            List<EventoE> eventos = new List<EventoE>();
            DataSet dsetEventos;
            string sql = "SELECT id, lugar_choque, placa_vehiculo, link_foto, estado, propietario, numero_de_parte, numero_de_registro " +
                        "FROM scheventos.evento WHERE estado ="+ "'" + pComando +";";

            dsetEventos = this.conexion.ejecutarConsultaSQL(sql);
            string error = this.conexion.ErrorDescripcion;
            foreach (DataRow tupla in dsetEventos.Tables[0].Rows)
            {
                EventoE oEventos = new EventoE(Convert.ToInt32(tupla[0].ToString()), tupla[1].ToString(),
                    tupla[2].ToString(), tupla[3].ToString(), tupla[4].ToString(), tupla[5].ToString(), tupla[6].ToString(), Convert.ToInt32(tupla[0].ToString()));
                eventos.Add(oEventos);
            }
            return eventos;
        }

        /// <summary>
        /// Agrega un evento a la BD
        /// </summary>
        /// <param name="oEvento">Objeto de la clase EventoE</param>
        /// <returns>Retorna un boleano dando a conocer si se guardo en la BD o no</returns>
        public bool agregarEvento(EventoE oEvento)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO scheventos.evento(" +
                    "lugar_choque, placa_vehiculo, link_foto, estado, propietario) "+
                    "VALUES(@lugarChoque, @placaVehiculo, @linkFoto, @estado, @propietario); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@lugarChoque", NpgsqlDbType.Varchar, oEvento.LugarChoque);
                oP.agregarParametro("@placaVehiculo", NpgsqlDbType.Varchar, oEvento.PlacaVehiculo);
                oP.agregarParametro("@linkFoto", NpgsqlDbType.Varchar, oEvento.LinkFoto);
                oP.agregarParametro("@estado", NpgsqlDbType.Varchar, oEvento.Estado);
                oP.agregarParametro("@propietario", NpgsqlDbType.Varchar, oEvento.Propietario);
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
        /// Borra el evento deseado de la BD
        /// </summary>
        /// <param name="oEventoE">Objeto de la clase EventoE</param>
        /// <returns>Retorna un boleano dando a conocer si se borro en la BD o no</returns>
        public bool borrarEvento(EventoE oEventoE)
        {
            bool estado = true;
            try
            {
                string sql = "DELETE FROM user WHERE user = @id";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id";
                parametros[0].Value = oEventoE.Id;

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
        public bool modificarEvento(EventoE oEvento, int pEventoId)
        {
            bool estado = true;

            try
            {
                string sql = "UPDATE scheventos.evento "+
                    "SET id = @id, lugar_choque = @lugarChoque, placa_vehiculo = @placaVehiculo, link_foto = @linkFoto, estado = @estado, propietario = @propietario, numero_de_parte = @numeroParte, numero_de_registro = @numeroRegistro " +
                    "WHERE id = @EventoId;";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id", NpgsqlDbType.Integer, oEvento.Id);
                oP.agregarParametro("@lugarChoque", NpgsqlDbType.Varchar, oEvento.LugarChoque);
                oP.agregarParametro("@placaVehiculo", NpgsqlDbType.Varchar, oEvento.PlacaVehiculo);
                oP.agregarParametro("@linkFoto", NpgsqlDbType.Varchar, oEvento.LinkFoto);
                oP.agregarParametro("@estado", NpgsqlDbType.Varchar, oEvento.Estado);
                oP.agregarParametro("@propietario", NpgsqlDbType.Varchar, oEvento.Propietario);
                oP.agregarParametro("@numeroParte", NpgsqlDbType.Varchar, oEvento.NumeroParte);
                oP.agregarParametro("@numeroRegistro", NpgsqlDbType.Integer, oEvento.NumeroRegistro);
                oP.agregarParametro("@EventoId", NpgsqlDbType.Integer, pEventoId);

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
