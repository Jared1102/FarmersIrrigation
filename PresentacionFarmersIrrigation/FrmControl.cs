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
    public partial class FrmControl : Form
    {
        public FrmControl()
        {
            InitializeComponent();
            getEstatus(FrmPrincipal.bomba1, ptrbDrip1, btnDrip1);
            getEstatus(FrmPrincipal.bomba2, ptrbDrip2, btnDrip2);
            getEstatus(FrmPrincipal.bomba3, ptrbDrip3, btnDrip3);
        }
        private void btnDrip1_Click(object sender, EventArgs e)
        {
            FrmPrincipal.bomba1 = changeEstatus(FrmPrincipal.bomba1, ptrbDrip1, btnDrip1);
        }
        private void btnDrip2_Click(object sender, EventArgs e)
        {
            FrmPrincipal.bomba2 = changeEstatus(FrmPrincipal.bomba2, ptrbDrip2, btnDrip2);
        }

        private void btnDrip3_Click(object sender, EventArgs e)
        {
            FrmPrincipal.bomba3 = changeEstatus(FrmPrincipal.bomba3, ptrbDrip3, btnDrip3);
        }


        #region Functions
        private void getEstatus(Bomba bomba, PictureBox ptrbDrip, Button btnDrip)
        {
            if (bomba.Estatus)
            {
                ptrbDrip.Image = Properties.Resources.pump_On;
                btnDrip.Text = "Desactivar";
            }
            else
            {
                ptrbDrip.Image = Properties.Resources.pump_Off;
                btnDrip.Text = "Activar";
            }
        }

        private Bomba changeEstatus(Bomba bomba, PictureBox ptrbDrip, Button btnDrip)
        {
            bomba.Estatus = !bomba.Estatus;
            if (bomba.Estatus)
            {
                bomba.Activacion = DateTime.Now.ToString("T");
                bomba.Fecha = DateTime.Now.ToString("d");
            }
            getEstatus(bomba, ptrbDrip, btnDrip);
            return bomba;
        }
        #endregion
    }
}
