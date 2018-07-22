using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLMTD.Logic.Login;

namespace SQLMTD.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            this.MaximizeBox = false;
        }

        private bool ValidateInput()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Задължително");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Задължително");
                isValid = false;
            }

            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.ValidateInput())
            {
                if (LoginManager.Login(txtUsername.Text, txtPassword.Text))
                {
                    MainForm form = (MainForm)this.Owner;
                    form.EnableControls();
                    form.SetCurrentUser(new Logic.User(txtUsername.Text));
                    this.Close();

                }
                else
                {
                    lblLoginFailed.Visible = true;
                }
            }
        }
    }
}
