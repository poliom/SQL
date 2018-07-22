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
    public partial class NewVehicle : UserControl
    {
        private const string DEFAULT_MANIFACTURE = "--- Избери Производител ---";
        private const string DEFAULT_MODEL = "--- Избери Модел ---";

        public Vehicle Vehicle
        {
            get
            {
                return this.GetVehicle();
            }
        }

        public bool IsValid
        {
            get
            {
                return this.ValidateInput();
            }
        }

        public Owner Owner { get; set; }

        public void SetNewRegistrationNumber(string regNumber)
        {
            lblRegistrationNumber.Text = regNumber;
        }

        public NewVehicle()
        {
            InitializeComponent();
            //this.BindComboBoxes(); 

            //lblRegistrationNumber.Text = Logic.Vehicle.GenerateNewRegistrationNumber("СА");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.BindComboBoxes();
        }

        private void BindComboBoxes()
        {
            Dictionary<int, string> items = Data.DB.DatabaseManager.ManifacturesSelectAll();

            cbManifacture.ValueMember = "Value";
            cbManifacture.DisplayMember = "Value";
            cbManifacture.Items.Add(new { Value = DEFAULT_MANIFACTURE });
            cbManifacture.SelectedIndex = 0;
            foreach (KeyValuePair<int, string> keyValue in items)
            {
                cbManifacture.Items.Add(keyValue);
            }

            cbVehicleType.DataSource = Enum.GetValues(typeof(Data.Info.VehicleType));
            
        }

        private bool ValidateInput()
        {
            bool isValid = true;

            //if (Owner == null)
            //{
            //    isValid = false;
            //    errorProvider1.SetError(lnkOwner, "Моля изберете собственик!");
            //}

            if (string.IsNullOrEmpty(lblRegistrationNumber.Text))
            {
                isValid = false;
                errorProvider1.SetError(lblRegistrationNumber, "Моля изберете регистрационен номер!");
            }

            if (string.IsNullOrEmpty(txtVinNumber.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtVinNumber, "Моля въведете номер на рама!");
            }

            if (string.IsNullOrEmpty(txtEnginePower.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtEnginePower, "Моля въведете мощност на двигателя!");
            }
            else
            {
                int enginePower = 0;
                if (!int.TryParse(txtEnginePower.Text, out enginePower))
                {
                    isValid = false;
                    errorProvider1.SetError(txtEnginePower, "Трябва да бъде цяло число!");
                }
            }

            if (string.IsNullOrEmpty(txtEngineValume.Text))
            {
                isValid = false;
                errorProvider1.SetError(txtEngineValume, "Моля въведете обем на двигателя!");
            }
            else
            {
                int engineValume = 0;
                if (!int.TryParse(txtEngineValume.Text, out engineValume))
                {
                    isValid = false;
                    errorProvider1.SetError(txtEngineValume, "Трябва да бъде цяло число!");
                }
            }

            if (cbManifacture.SelectedIndex == 0)
            {
                isValid = false;
                errorProvider1.SetError(cbManifacture, "Задължително за въвеждане!");
            }

            if (cbModel.SelectedIndex == 0)
            {
                isValid = false;
                errorProvider1.SetError(cbModel, "Задължително за въвеждане!");
            }

            return isValid;
        }

        private Vehicle GetVehicle()
        {
            Vehicle vehicle = null;

            if (this.ValidateInput())
            {
                vehicle = new Vehicle();
                vehicle.Manifacture = cbManifacture.Text.ToString();
                vehicle.Model = cbModel.Text.ToString();
                vehicle.Owner = new Logic.Owner("9011266787");//this.Owner;
                vehicle.RegistrationNumber = lblRegistrationNumber.Text;
                vehicle.VinNumber = txtVinNumber.Text;
                vehicle.EngineNumber = txtEngineNumber.Text;
                vehicle.EnginePower = int.Parse(txtEnginePower.Text);
                vehicle.EngineValume = int.Parse(txtEngineValume.Text);
                vehicle.FirstRegistrationDate = cbxNoFirstRegistrationDate.Checked ? dtpFirstRegistrationDate.Value : DateTime.MinValue;
                vehicle.RegistrationDate = DateTime.Now;
                vehicle.Type = (Data.Info.VehicleType)Enum.Parse(typeof(Data.Info.VehicleType), cbVehicleType.Text);//(SQLMTD.Data.Info.VehicleType)cbVehicleType.SelectedValue;
            }

            return vehicle;
        }

        private void cbManifacture_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            cbModel.Items.Clear();

            if (!string.IsNullOrEmpty(cb.Text) && !cb.Text.ToString().Equals(DEFAULT_MANIFACTURE))
            {
                Dictionary<int, string> items = Data.DB.DatabaseManager.ModelsSelectByManifacture(cb.Text);
                cbModel.ValueMember = "Value";
                cbModel.DisplayMember = "Value";
                cbModel.Items.Add(new { Value = DEFAULT_MODEL });
                cbModel.SelectedIndex = 0;
                foreach (KeyValuePair<int, string> pair in items)
                {
                    cbModel.Items.Add(pair);
                }
            }
        }

        private void cbxNoFirstRegistrationDate_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox cbx = sender as CheckBox;

            if (cbx.Checked)
            {
                dtpFirstRegistrationDate.Enabled = false;
            }
            else
            {
                dtpFirstRegistrationDate.Enabled = true;
            }
        }

        private void lnkOwner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectOwnerForm form = null;
            if (this.Owner != null)
            {
                form = new SelectOwnerForm(this.Owner);
            }
            else
            {
                form = new SelectOwnerForm();
            }

            form.Show(this);
        }
    }
}
