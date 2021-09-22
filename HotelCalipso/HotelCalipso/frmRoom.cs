using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCalipso
{
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtFirstname.Text) && string.IsNullOrEmpty(txtLastname.Text) && string.IsNullOrEmpty(cmbMealplan.Text) && string.IsNullOrEmpty(txtMobile.Text) && string.IsNullOrEmpty(txtNic.Text) && string.IsNullOrEmpty(txtTotalRoom.Text) && cmbBedType.SelectedIndex == -1)
            {
                Validation.texBoxValidate(false, txtUsername, lblUsername, "Error");
                Validation.texBoxValidate(false, txtEmail, lblEmail, "Error");
                Validation.texBoxValidate(false, txtPassword, lblPassword, "Error");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
                Validation.texBoxValidate(false, txtUsername, lblUsername, "Error");
            else if (string.IsNullOrEmpty(txtEmail.Text))
                Validation.texBoxValidate(false, txtEmail, lblEmail, "Error");
            else if (string.IsNullOrEmpty(txtPassword.Text))
                Validation.texBoxValidate(false, txtPassword, lblPassword, "Error");
            else if (string.IsNullOrEmpty(txtCpassword.Text))
                Validation.texBoxValidate(false, txtCpassword, lblCpassword, "cannot match password");
            else if (txtCpassword.Text != txtPassword.Text)
                Validation.texBoxValidate(false, txtCpassword, lblCpassword, "cannot match password");
            else
            {
                int i = dbManager.insrtUpdteDelt("INSERT INTO `login`(`rollname`, `username`, `email`, `password`) " +
                                                 "VALUES('USER','" + txtUsername.Text + "','" + txtEmail.Text + "','" + txtCpassword.Text + "')");

                if (i != 0)
                {
                    txtUsername.Text = "";
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    txtCpassword.Text = "";
                    Alert.Show("success", "added success", Alert.AlertType.success, Color.FromArgb(240, 240, 240));
                }
            }
        }
    }
}
