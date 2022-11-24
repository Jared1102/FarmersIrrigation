using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesFarmersIrrigation;

namespace PresentacionFarmersIrrigation
{
    public partial class FrmMonitoring : Form
    {
        public FrmMonitoring()
        {
            InitializeComponent();
            getEstatus(FrmPrincipal.bomba1, ptrbDrip1, lDrip1);
            getEstatus(FrmPrincipal.bomba2, ptrbDrip2, lDrip2);
            getEstatus(FrmPrincipal.bomba3, ptrbDrip3, lDrip3);
        }

        #region Functions

        private void getEstatus(Bomba bomba, PictureBox ptrbDrip, Label lDrip)
        {
            DateTime now = DateTime.Now;
            DateTime activacion = Convert.ToDateTime(bomba.Activacion);
            TimeSpan diferencia = new TimeSpan();

            diferencia = now-activacion;

            if (bomba.Estatus)
            {
                ptrbDrip.Image = Properties.Resources.pump_On;
                lDrip.Text = string.Format("Tiempo activa: {0}:{1}:{2}", diferencia.Hours,diferencia.Minutes, diferencia.Seconds);
            }
            else
                ptrbDrip.Image = Properties.Resources.pump_Off;
        }

        #endregion

        private void tTiempo_Tick(object sender, EventArgs e)
        {
            getEstatus(FrmPrincipal.bomba1, ptrbDrip1, lDrip1);
            getEstatus(FrmPrincipal.bomba2, ptrbDrip2, lDrip2);
            getEstatus(FrmPrincipal.bomba3, ptrbDrip3, lDrip3);
        }
    }
}
