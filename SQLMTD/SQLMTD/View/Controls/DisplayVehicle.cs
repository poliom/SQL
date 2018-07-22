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
    public partial class DisplayVehicle : UserControl
    {
        public Vehicle Vehicle { get; set; }
        public DisplayVehicle()
        {
            InitializeComponent();
        }

        public void SetVehicleInformation()
        {
            if (Vehicle != null)
            {
                txtManifacture.Text = Vehicle.Manifacture;
                txtModel.Text = Vehicle.Model;
                txtRegistrationNumber.Text = Vehicle.RegistrationNumber;
                txtVinNumber.Text = Vehicle.VinNumber;
                txtEngineNumber.Text = Vehicle.EngineNumber;
                txtPower.Text = Vehicle.EnginePower.ToString() + " hp";
                txtEngineValue.Text = Vehicle.EngineValume.ToString() + " cc";
                txtFirstRegistrationDate.Text = Vehicle.FirstRegistrationDate.Date.ToShortDateString();
                txtRegistrationDate.Text = Vehicle.RegistrationDate.Date.ToShortDateString();
                txtType.Text = Vehicle.Type.ToString();
            }
        }
    }
}
