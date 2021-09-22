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
using MySql.Data.MySqlClient;
using MySql.Data;
using SMDnotify;

namespace HotelCalipso
{
    public partial class frmRegister : Form
    {
        private SmdDbManager dbManager;
        public frmRegister()
        {
            InitializeComponent();
            dbManager = new SmdDbManager("SERVER=127.0.0.1;PORT=3306;DATABASE=hotelcalipso;UID=root;PASSWORD=;");
        }

        private void btnSUbmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                Validation.texBoxValidate(false,txtUsername, lblUsername, "Error");
                Validation.texBoxValidate(false,txtEmail, lblEmail, "Error");
                Validation.texBoxValidate(false,txtPassword, lblPassword, "Error");
            }
            else if(string.IsNullOrEmpty(txtUsername.Text))
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
                                                 "VALUES('USER','"+txtUsername.Text+"','"+txtEmail.Text+"','"+txtCpassword.Text+"')");

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

        private void btnSUbmit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
