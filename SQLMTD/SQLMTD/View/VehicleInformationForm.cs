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
    public partial class VehicleInformationForm : Form
    {
        public VehicleInformationForm()
        {
            InitializeComponent();
        }

        public VehicleInformationForm(Vehicle vehicle)
            : this()
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException("vehicle");
            }

            displayVehicle1.Vehicle = vehicle;
            displayVehicle1.SetVehicleInformation();
        }
    }
}
