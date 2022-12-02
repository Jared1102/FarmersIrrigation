using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesFarmersIrrigation;
using AccesoDatosFarmersIrrigation;
using System.Windows.Forms;

namespace ManejadoresFarmersIrrigation
{
    public class ManejadorBombas
    {
        private AccesoDatosBombas accesoDatosBombas = new AccesoDatosBombas();

        public void VerHistorial(DataGridView tabla)
        {
            tabla.Columns.Clear();

            tabla.DataSource = accesoDatosBombas.getHistorial();

            tabla.Columns["ID"].Visible = false;
            tabla.Columns["Estatus"].Visible = false;

            tabla.Columns["IdBomba"].HeaderText = "Bomba";
            tabla.Columns["Activacion"].HeaderText = "Activación";
            tabla.Columns["Duracion"].HeaderText = "Duración";

            tabla.AutoResizeColumns();
        }

        public void GuardarBomba(Bomba bomba)
        {
            accesoDatosBombas.guardarBomba(bomba);
        }

    }
}
