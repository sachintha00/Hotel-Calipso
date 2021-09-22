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
    public partial class frmRoom : Form
    {
        private SmdDbManager dbManager;
        private GmailSender gmailSender;
        public frmRoom()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hotelcalipso;UID=root;PASSWORD=;");
            gmailSender = new GmailSender();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnSUbmit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtFirstname.Text) && string.IsNullOrEmpty(txtLastname.Text) && string.IsNullOrEmpty(txtMobile.Text) && string.IsNullOrEmpty(txtNic.Text) && string.IsNullOrEmpty(txtTotalRoom.Text) && cmbBedType.SelectedIndex == -1 && cmbMealplan.SelectedIndex == -1 && cmbRoomType.SelectedIndex == -1)
            {
                Validation.texBoxValidate(false, txtCity, lblCity, "Error");
                Validation.texBoxValidate(false, txtEmail, lblEmail, "Error");
                Validation.texBoxValidate(false, txtFirstname, lblFirstname, "Error");
                Validation.texBoxValidate(false, txtLastname, lblLastname, "Error");
                Validation.texBoxValidate(false, txtMobile, lblMobile, "Error");
                Validation.texBoxValidate(false, txtNic, lblMobile, "Error");
                Validation.texBoxValidate(false, txtTotalRoom, lblTotalRoom, "Error");
                Validation.comboValidate(false, cmbBedType, lblBedType, "error");
                Validation.comboValidate(false, cmbMealplan, lblMealPlan, "error");
                Validation.comboValidate(false, cmbRoomType, lblRoomType, "error");
            }
            else if (string.IsNullOrEmpty(txtCity.Text))
                Validation.texBoxValidate(false, txtCity, lblCity, "Error");
            else if (string.IsNullOrEmpty(txtEmail.Text))
                Validation.texBoxValidate(false, txtEmail, lblEmail, "Error");
            else if (string.IsNullOrEmpty(txtFirstname.Text))
                Validation.texBoxValidate(false, txtFirstname, lblFirstname, "Error");
            else if (string.IsNullOrEmpty(txtLastname.Text))
                Validation.texBoxValidate(false, txtLastname, lblLastname, "Error");
            else if (string.IsNullOrEmpty(txtMobile.Text))
                Validation.texBoxValidate(false, txtMobile, lblMobile, "Error");
            else if (string.IsNullOrEmpty(txtNic.Text))
                Validation.texBoxValidate(false, txtNic, lblMobile, "Error");
            else if (string.IsNullOrEmpty(txtMobile.Text))
                Validation.texBoxValidate(false, txtTotalRoom, lblTotalRoom, "Error");
            else if (cmbBedType.SelectedIndex == -1)
                Validation.comboValidate(false, cmbBedType, lblBedType, "error");
            else if (cmbMealplan.SelectedIndex == -1)
                Validation.comboValidate(false, cmbMealplan, lblMealPlan, "error");
            else if (cmbRoomType.SelectedIndex == -1)
                Validation.comboValidate(false, cmbRoomType, lblRoomType, "error");
            else
            {
                int i = dbManager.insrtUpdteDelt("INSERT INTO " +
                                                "`roombo0king`" +
                                                "(`firstname`, `lastname`, `email`, `city`, `mobile`, `roomtype`, `bedtype`, `nofroom`, `mealplan`) " +
                                                "VALUES " +
                                                "('" + txtFirstname.Text + "','" + txtLastname.Text + "','" + txtEmail.Text + "','" + txtCity.Text + "','" + txtMobile.Text + "','" + cmbRoomType.SelectedItem.ToString() + "','" + cmbBedType.SelectedItem.ToString() + "', '" + txtTotalRoom.Text + "', '" + cmbMealplan.SelectedItem.ToString() + "')");

                if (i != 0)
                {
                    txtCity.Text = "";
                    txtEmail.Text = "";
                    txtFirstname.Text = "";
                    txtLastname.Text = "";
                    txtMobile.Text = "";
                    txtNic.Text = "";
                    txtTotalRoom.Text = "";
                    cmbBedType.SelectedIndex = -1;
                    cmbMealplan.SelectedIndex = -1;
                    cmbRoomType.SelectedIndex = -1;
                    gmailSender.send("", "", "", "", "");
                    Alert.Show("success", "added success", Alert.AlertType.success, Color.FromArgb(240, 240, 240));
                }
            }
        }
    }
}
