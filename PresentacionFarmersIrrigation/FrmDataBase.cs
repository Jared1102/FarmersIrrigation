using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadoresFarmersIrrigation;

namespace PresentacionFarmersIrrigation
{
    public partial class FrmDataBase : Form
    {
        private ManejadorBombas manejadorBombas;
        public FrmDataBase()
        {
            InitializeComponent();
            manejadorBombas = new ManejadorBombas();
        }

        private void FrmDataBase_Load(object sender, EventArgs e)
        {
            manejadorBombas.VerHistorial(dtgHistorial);
        }
    }
}
