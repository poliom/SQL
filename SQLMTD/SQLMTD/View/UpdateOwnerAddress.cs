using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLMTD.Logic;

namespace SQLMTD.View
{
    public partial class UpdateOwnerAddress : Form
    {
        private Owner _Owner;

        public UpdateOwnerAddress()
        {
            InitializeComponent();
        }

        public UpdateOwnerAddress(Owner owner)
            : this()
        {
            this._Owner = owner;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Задължително!");
                return;
            }

            this._Owner.UpdateAddress(txtAddress.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
