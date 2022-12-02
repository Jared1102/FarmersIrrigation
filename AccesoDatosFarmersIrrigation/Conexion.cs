using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Common;

namespace AccesoDatosFarmersIrrigation
{
    public class Conexion
    {
        private MySqlConnection _connection;

        public Conexion(string servidor, string usuario, string password, string basedatos, uint puerto)
        {
            MySqlConnectionStringBuilder cadenaConexion = new MySqlConnectionStringBuilder();
            cadenaConexion.Server = servidor;
            cadenaConexion.UserID = usuario;
            cadenaConexion.Password = password;
            cadenaConexion.Database = basedatos;
            cadenaConexion.Port = puerto;

            _connection = new MySqlConnection(cadenaConexion.ToString());
        }

        public void EjecutarConsulta(string consulta)
        {
            _connection.Open();
            var command = new MySqlCommand(consulta, _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public DataSet ObtenerDatos(string consulta, string tabla)
        {
            var ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, _connection);
            da.Fill(ds, tabla);
            return ds;
        }
    }
}
