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
    public partial class FrmPrincipal : Form
    {
        private Form frmActive = null;
        public static Bomba bomba1 = new Bomba
        {
            Id = 1,
            Estatus = false
        };
        public static Bomba bomba2 = new Bomba
        {
            Id = 2,
            Estatus=false
        };
        public static Bomba bomba3 = new Bomba
        {
            Id = 3,
            Estatus=false
        };
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Functions

        private void Exit()
        {
            Application.Exit();
        }

        private void openChildForm(Form childForm)
        {
            if (frmActive != null)
                frmActive.Close();
            frmActive = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pPrincipal.Controls.Add(childForm);
            pPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        private void btnrExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmControl());
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMonitoring());
        }
    }
}
