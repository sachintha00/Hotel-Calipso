using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDLogic;

namespace HotelCalipso
{
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmRegister(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmRegister(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmRoom(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmFood(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmTravel(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmReport(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }
    }
}
