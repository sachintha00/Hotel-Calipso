using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDMySQLDBManager;

namespace HotelCalipso
{
    public partial class frmReport : Form
    {
        private SmdDbManager dbManager;
        public frmReport()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hotelcalipso;UID=root;PASSWORD=;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = dbManager.getdata("SELECT * FROM `roombo0king`");
            dgvRoomBook.DataSource = dt1;
            dgvRoomBook.AutoGenerateColumns = false;

            DataTable dt2 = new DataTable();
            dt2 = dbManager.getdata("SELECT * FROM `travel_package`");
            dgvTravel.DataSource = dt2;
            dgvTravel.AutoGenerateColumns = false;
        }
    }
}
