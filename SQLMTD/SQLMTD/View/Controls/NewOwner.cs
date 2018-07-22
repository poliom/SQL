using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLMTD.Logic;

namespace SQLMTD.View.Controls
{
    public partial class NewOwner : UserControl
    {
        public bool IsValid
        {
            get
            {
                return this.ValidateInput();
            }
        }

        public NewOwner()
        {
            InitializeComponent();
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-16);
        }

        private bool ValidateInput()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtFirstName, "Задължително!");
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtLastName, "Задължително!");
            }

            if (string.IsNullOrEmpty(txtUCN.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtUCN, "Задължително!");
            }
            else
            {
                string ucn = txtUCN.Text;
                if (ucn.Length != 10)
                {
                    isValid = false;
                    errorProvider1.SetError(txtUCN, "Трябва да бъде точно 10 цифри!");
                }

                try
                {
                    IEnumerable<int> result = ucn.Cast<int>();
                }
                catch (InvalidCastException)
                {
                    isValid = false;
                    errorProvider1.SetError(txtUCN, "Позволени са само цифри!");
                }

                if (isValid)
                {
                    if (Owner.CheckUcnExists(txtUCN.Text))
                    {
                        isValid = false;
                        errorProvider1.SetError(txtUCN, "Собственик с това ЕГН вече съществува!");
                    }
                }
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtAddress, "Задължително!");
            }

            return isValid;
        }

        public Owner GetOwner()
        {
            Owner owner = null;

            if (this.ValidateInput())
            {
                owner = new Owner();
                owner.FirstName = txtFirstName.Text;
                owner.LastName = txtLastName.Text;
                owner.UniformCivilNumber = txtUCN.Text;
                owner.Address = txtAddress.Text;
                owner.BirthDate = dtpBirthDate.Value;
            }

            return owner;
        }
    }
}
