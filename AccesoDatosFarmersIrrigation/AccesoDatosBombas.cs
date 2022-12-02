using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesFarmersIrrigation;

namespace AccesoDatosFarmersIrrigation
{
    public class AccesoDatosBombas
    {
        private Conexion conexion;

        public AccesoDatosBombas()
        {
            conexion = new Conexion("localhost", "root", "", "farmersirrigation", 3306);
        }

        public List<Bomba> getHistorial()
        {
            var listBombas = new List<Bomba>();
            var ds =new DataSet();
            string consulta ="SELECT * FROM monitoreo";

            ds = conexion.ObtenerDatos(consulta, "monitoreo");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var bomba = new Bomba
                {
                    Id = Convert.ToInt32(row["ID"]),
                    IdBomba = Convert.ToInt32(row["Bomba"]),
                    Fecha = DateTime.Parse(row["Fecha"].ToString()).ToString("d"),
                    Activacion = row["Hora"].ToString(),
                    Duracion = row["Duracion"].ToString()
                };

                listBombas.Add(bomba);
            }

            return listBombas;
        }

        public void guardarBomba(Bomba bomba)
        {
            string consulta = string.Format("INSERT INTO monitoreo(Bomba,Fecha,Hora,Duracion) values({0},'{1}','{2}','{3}')",
                bomba.IdBomba.ToString(),
                bomba.Fecha,
                bomba.Activacion,
                bomba.Duracion);
            conexion.EjecutarConsulta(consulta);
        }
    }
}
