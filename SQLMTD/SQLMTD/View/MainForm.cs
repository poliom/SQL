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
using SQLMTD.View.Controls;

namespace SQLMTD.View
{
    public partial class MainForm : Form
    {
        private User CurrentUser;

        private Owner _SearchedOwner;

        public MainForm()
        {
            InitializeComponent();
            this.DisableControls();
            this.AcceptButton = btnSearch;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.BindComboBoxes();
            System.Diagnostics.Debug.WriteLine(Logic.Login.LoginManager.GetHash("123"));
            System.Diagnostics.Debug.WriteLine(Logic.Login.LoginManager.GetHash("1234"));
        }

        private void DisableControls()
        {
            tabControl1.Enabled = false;
        }

        public void EnableControls()
        {
            tabControl1.Enabled = true;
        }

        public void SetCurrentUser(User user)
        {
            this.CurrentUser = user;

            if (this.CurrentUser == null)
            {
                lblCurrentUser.Text = string.Empty;
                return;
            }

            lblCurrentUser.Text = this.CurrentUser.FirstName + " " + this.CurrentUser.LastName;
            btnLoginLogout.Text = "Изход";
        }

        private void btnLoginLogout_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Owner = this;
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.Show(this);
            }
            else
            {
                this.SetCurrentUser(null);
                this.DisableControls();
                btnLoginLogout.Text = "Вход";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            VehicleSelectionType selectionType;
            selectionType = rdoRegistrationNumber.Checked ? VehicleSelectionType.RegistrationNumber : VehicleSelectionType.VinNumber;

            Vehicle vehicle = new Vehicle(txtSearch.Text.Replace(" ", null), selectionType);

            if (vehicle.VehicleExists)
            {
                displayVehicle.Visible = true;
                displayVehicle.Vehicle = vehicle;
                displayVehicle.SetVehicleInformation();
                displayOwner1.Visible = true;
                displayOwner1.Owner = vehicle.Owner;
                displayOwner1.SetOwnerInformation();
            }
            else
            {
                MessageBox.Show("Няма намерено МПС");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;

            int index = tabControl.SelectedIndex;

            switch (index)
            {
                case 0:
                    this.AcceptButton = btnSearch;
                    break;
                case 1:
                    this.AcceptButton = btnSearchUcn;
                    break;
            }
        }

        private void BindVehicles(List<Vehicle> items)
        {
            int i = 30;
            foreach (Vehicle v in items)
            {
                gbOwnedVehicles.Controls.Add(
                    new LinkToVehicle(v) { Location = new Point(10, i)}
                    );
                i += 30;
            }
        }

        private void btnSearchUcn_Click(object sender, EventArgs e)
        {
            Logic.Owner owner = new Owner(txtSearchUcn.Text);
            if (owner.GetInfoObject() != null)
            {
                displayOwnerOwners.Owner = owner;
                displayOwnerOwners.Visible = true;
                displayOwnerOwners.SetOwnerInformation();
                btnUpdateAddress.Visible = true;
                if (owner.Vehicles != null && owner.Vehicles.Count > 0)
                {
                    this.BindVehicles(owner.Vehicles);
                    lblNoVehicles.Visible = false;
                }
                else
                {
                    lblNoVehicles.Visible = true;
                }
                this._SearchedOwner = owner;
            }
            else
            {
                gbOwnedVehicles.Controls.Clear();
                displayOwnerOwners.Visible = false;
                btnUpdateAddress.Visible = false;
                this._SearchedOwner = null;
                MessageBox.Show("Не са открити данни в системата!");
            }
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            if (newVehicle1.IsValid)
            {
                try
                {
                    Vehicle vehicle = null;
                    vehicle = newVehicle1.Vehicle;
                    vehicle.Create();
                }
                catch (Data.Info.Exceptions.ManifactureNotFoundException)
                {
                    MessageBox.Show("Избраният производител не е намерен!");
                }
                catch (Data.Info.Exceptions.ModelNotFoundException)
                {
                    MessageBox.Show("Избраният модел не е намерен!");
                }

                MessageBox.Show("МПС е добавено успешно в системата!");
            }
        }

        public void SetNewVehicleOwner(Owner owner)
        {
            newVehicle1.Owner = owner;
        }

        private void btnGenerateNewRegistrationNumber_Click(object sender, EventArgs e)
        {
            newVehicle1.SetNewRegistrationNumber(Vehicle.GenerateNewRegistrationNumber(CurrentUser.City.RegistrationCode));
        }

        private void btnAddNewOwner_Click(object sender, EventArgs e)
        {
            if (newOwner1.IsValid)
            {
                Logic.Owner owner = newOwner1.GetOwner();
                owner.Create();
                MessageBox.Show("Добавянето е успешно!");
            }
        }

        private void BindComboBoxes()
        {
            cbVehicleTypeCount.DataSource = Enum.GetValues(typeof(Data.Info.VehicleType));
            cbAverageYearCreation.DataSource = Enum.GetValues(typeof(Data.Info.VehicleType));
            cbAverrageAge.DataSource = Enum.GetValues(typeof(Data.Info.VehicleType));
        }

        private void btnShowAvgUserAge_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Средна възраст на собствениците на МПС: " + Environment.NewLine
                    + Statistics.GetAverageOwnersAge().ToString("0.00") + " години.");
        }

        private void btnVehicleCountByType_Click(object sender, EventArgs e)
        {
            Data.Info.VehicleType type;
            type = (Data.Info.VehicleType)Enum.Parse(typeof(Data.Info.VehicleType), cbVehicleTypeCount.Text);
            MessageBox.Show(
                "Брой МПС от тип " + type.ToString() + " : "
                + Statistics.GetVehiclesCountByType(type).ToString());
        }

        private void btnAverageCreationDate_Click(object sender, EventArgs e)
        {
            Data.Info.VehicleType type;
            type = (Data.Info.VehicleType)Enum.Parse(typeof(Data.Info.VehicleType), cbAverageYearCreation.Text);
            MessageBox.Show(
                "Средна година на производство на МПС от тип " + type.ToString() + " : "
                + Statistics.GetAverageVehiclesCreationDate(type).ToShortDateString());
        }

        private void btnAverageCarAge_Click(object sender, EventArgs e)
        {
            Data.Info.VehicleType type;
            type = (Data.Info.VehicleType)Enum.Parse(typeof(Data.Info.VehicleType), cbAverrageAge.Text);
            MessageBox.Show(
                "Средна възраст на МПС от тип " + type.ToString() + " : "
                + Statistics.GetAverageVehiclesAge(type).ToString("0.00")
                + " години");
        }

        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            if (this._SearchedOwner != null)
            {
                UpdateOwnerAddress form = new UpdateOwnerAddress(this._SearchedOwner);
                form.Show(this);
            }
        }
    }
}
