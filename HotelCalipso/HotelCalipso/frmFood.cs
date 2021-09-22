using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDValidation;

namespace HotelCalipso
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }

        private void frmFood_Load(object sender, EventArgs e)
        {

        }

        private void imgFood1_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "240";
        }

        private void imgFood2_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "300";
        }

        private void imgFood3_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "350";
        }

        private void imgFood4_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "600";
        }

        private void btnSUbmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtQuantity.Text))
                Validation.texBoxValidate(false, txtQuantity, lblQuantty, "Error");
            else
                lblBill.Text = (Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQuantity.Text)).ToString();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text))
                Validation.texBoxValidate(true, txtQuantity, lblQuantty);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtQuantity.Text = "";
            lblBill.Text = "";
        }
    }
}
