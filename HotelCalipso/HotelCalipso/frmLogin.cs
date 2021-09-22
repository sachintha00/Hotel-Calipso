using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDMessageBox;

namespace HotelCalipso
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void login()
        {

            if (1 == DBManager.chek("SELECT * FROM other_staff_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' "))
            {
                passingRollName = DBManager.ReadValue("SELECT * FROM other_staff_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 1);
                passingRollId = DBManager.ReadValue("SELECT * FROM other_staff_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 0);
            }
            else if (1 == DBManager.chek("SELECT * FROM student_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' "))
            {
                passingRollName = DBManager.ReadValue("SELECT * FROM student_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 1);
                passingRollId = DBManager.ReadValue("SELECT * FROM student_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 0);
            }

            if (!(passingRollName == "Error"))
            {
                this.Hide();
                new frmLoard().Show();
            }
            else
                SMDMessage.show("Error", "Username or Password incorrect", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
