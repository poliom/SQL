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
    public partial class SelectOwnerForm : Form
    {
        public Owner VOwner { get; set; }
        public SelectOwnerForm()
        {
            InitializeComponent();
        }

        public SelectOwnerForm(Owner owner)
            : this()
        {
            this.VOwner = owner;
            displayOwner1.Visible = true;
            displayOwner1.Owner = VOwner;
            displayOwner1.SetOwnerInformation();
            cbxSelect.Visible = true;
            btnConfirm.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner(txtUCN.Text);

            if (owner.GetInfoObject() != null)
            {
                displayOwner1.Visible = true;
                cbxSelect.Visible = true;
                btnConfirm.Visible = true;
                this.VOwner = owner;
                displayOwner1.Owner = owner;
                displayOwner1.SetOwnerInformation();
            }
            else
            {
                MessageBox.Show("Не са открити съвпадения в системата!");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.Owner;
            if (cbxSelect.Checked)
            {
                parent.SetNewVehicleOwner(VOwner);
                this.Close();
            }
            else
            {
                if (MessageBox.Show(this, "Затваряне на формата без избор?", "Потвърждение", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
                     
            }
        }
    }
}
