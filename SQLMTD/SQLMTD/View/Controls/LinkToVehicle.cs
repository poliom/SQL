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
    public partial class LinkToVehicle : UserControl
    {
        public Vehicle Vehicle { get; set; }

        public LinkToVehicle()
        {
            InitializeComponent();
        }

        public LinkToVehicle(Vehicle vehicle)
            : this()
        {
            this.Vehicle = vehicle;
            this.SetVehicleInformation();
        }

        public void SetVehicleInformation()
        {
            if (Vehicle != null)
            {
                lnkVehicle.Text = Vehicle.RegistrationNumber;
            }
        }

        private void lnkVehicle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VehicleInformationForm form = new VehicleInformationForm(this.Vehicle);
            form.Owner = this.Parent.Parent as Form;
            form.Show(this.Parent.Parent as Form);
        }
    }
}
