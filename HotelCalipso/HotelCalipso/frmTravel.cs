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
using SMDMySQLDBManager;
using SMDnotify;
using SMDGmailSender;

namespace HotelCalipso
{
    public partial class frmTravel : Form
    {
        private SmdDbManager dbManager;
        private GmailSender gmailSender;
        public frmTravel()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hotelcalipso;UID=root;PASSWORD=;");
            gmailSender = new GmailSender();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtFullname.Text) && string.IsNullOrEmpty(txtMobile.Text) && string.IsNullOrEmpty(txtNic.Text) && cmbNational.SelectedIndex == -1 && cmbTravel.SelectedIndex == -1)
            {
                Validation.texBoxValidate(false, txtEmail, lblEmail, "Error");
                Validation.texBoxValidate(false, txtFullname, lblFullname, "Error");
                Validation.texBoxValidate(false, txtMobile, lblMobile, "Error");
                Validation.texBoxValidate(false, txtNic, lblNic, "Error");
                Validation.comboValidate(false, cmbNational, lblNational, "error");
                Validation.comboValidate(false, cmbTravel, lblTravel, "error");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
                Validation.texBoxValidate(false, txtEmail, lblEmail, "Error");
            else if (string.IsNullOrEmpty(txtFullname.Text))
                Validation.texBoxValidate(false, txtFullname, lblFullname, "Error");
            else if (string.IsNullOrEmpty(txtMobile.Text))
                Validation.texBoxValidate(false, txtMobile, lblMobile, "Error");
            else if (string.IsNullOrEmpty(txtNic.Text))
                Validation.texBoxValidate(false, txtNic, lblNic, "Error");
            else if (cmbNational.SelectedIndex == -1)
                Validation.comboValidate(false, cmbNational, lblNational, "error");
            else if (cmbTravel.SelectedIndex == -1)
                Validation.comboValidate(false, cmbTravel, lblTravel, "error");
            else
            {
                int i = dbManager.insrtUpdteDelt("INSERT INTO " +
                                                "`travel_package`" +
                                                "(`fullname`, `nic`, `travelemail`, `nationality`, `travelmobile`, `typeOfplace`) " +
                                                "VALUES ('"+txtFullname.Text+"','"+txtNic.Text+"','"+txtEmail.Text+"','"+cmbNational.SelectedItem.ToString()+"','"+txtMobile.Text+"','"+cmbTravel.SelectedItem.ToString()+"')");

                if (i != 0)
                {
                    txtEmail.Text = "";
                    txtFullname.Text = "";
                    txtMobile.Text = "";
                    txtNic.Text = "";
                    cmbNational.SelectedIndex = -1;
                    cmbTravel.SelectedIndex = -1;
                    gmailSender.send("hotelcalipsoonline@gmail.com", "password", txtEmail.Text, "subject", "body");
                    Alert.Show("success", "added success", Alert.AlertType.success, Color.FromArgb(240, 240, 240));
                }
            }
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtFullname.Text))
                Validation.texBoxValidate(true, txtFullname, lblFullname);
        }

        private void txtNic_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNic.Text))
                Validation.texBoxValidate(true, txtNic, lblNic);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
                Validation.texBoxValidate(true, txtEmail, lblEmail);
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMobile.Text))
                Validation.texBoxValidate(true, txtMobile, lblMobile);
        }

        private void cmbNational_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNational.SelectedIndex != -1)
                Validation.comboValidate(true, cmbNational, lblNational);
        }

        private void cmbTravel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTravel.SelectedIndex != -1)
                Validation.comboValidate(true, cmbTravel, lblTravel);
        }
    }
}
