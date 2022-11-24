using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesFarmersIrrigation
{
    public class Bomba
    {
        private int _Id;
        private string _Fecha;
        private string _Activacion;
        private string _Duracion;
        private bool _Estatus;

        public int Id { get => _Id; set => _Id = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string Activacion { get => _Activacion; set => _Activacion = value; }
        public string Duracion { get => _Duracion; set => _Duracion = value; }
        public bool Estatus { get => _Estatus; set => _Estatus = value; }
    }
}
