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
    public partial class DisplayOwner : UserControl
    {
        public Owner Owner { get; set; }

        public DisplayOwner()
        {
            InitializeComponent();
        }

        public void SetOwnerInformation()
        {
            if (this.Owner != null)
            {
                txtFirstName.Text = this.Owner.FirstName;
                txtLastName.Text = this.Owner.LastName;
                txtUCN.Text = this.Owner.UniformCivilNumber;
                txtAddress.Text = this.Owner.Address;
                txtBirthDate.Text = this.Owner.BirthDate.ToShortDateString();
            }
        }
    }
}
