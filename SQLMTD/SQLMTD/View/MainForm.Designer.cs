namespace SQLMTD.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCars = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVinNumber = new System.Windows.Forms.RadioButton();
            this.rdoRegistrationNumber = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabOwners = new System.Windows.Forms.TabPage();
            this.gbOwnedVehicles = new System.Windows.Forms.GroupBox();
            this.lblNoVehicles = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnUpdateAddress = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearchUcn = new System.Windows.Forms.Button();
            this.txtSearchUcn = new System.Windows.Forms.TextBox();
            this.tabNewCar = new System.Windows.Forms.TabPage();
            this.btnGenerateNewRegistrationNumber = new System.Windows.Forms.Button();
            this.btnAddNewVehicle = new System.Windows.Forms.Button();
            this.tabNewOwner = new System.Windows.Forms.TabPage();
            this.btnAddNewOwner = new System.Windows.Forms.Button();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.btnAverageCarAge = new System.Windows.Forms.Button();
            this.cbAverrageAge = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAverageCreationDate = new System.Windows.Forms.Button();
            this.cbAverageYearCreation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVehicleCountByType = new System.Windows.Forms.Button();
            this.cbVehicleTypeCount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowAvgUserAge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMainMenu = new System.Windows.Forms.GroupBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnLoginLogout = new System.Windows.Forms.Button();
            this.displayOwner1 = new SQLMTD.View.Controls.DisplayOwner();
            this.displayVehicle = new SQLMTD.View.Controls.DisplayVehicle();
            this.displayOwnerOwners = new SQLMTD.View.Controls.DisplayOwner();
            this.newVehicle1 = new SQLMTD.View.Controls.NewVehicle();
            this.newOwner1 = new SQLMTD.View.Controls.NewOwner();
            this.tabControl1.SuspendLayout();
            this.tabCars.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabOwners.SuspendLayout();
            this.gbOwnedVehicles.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabNewCar.SuspendLayout();
            this.tabNewOwner.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.gbMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabCars);
            this.tabControl1.Controls.Add(this.tabOwners);
            this.tabControl1.Controls.Add(this.tabNewCar);
            this.tabControl1.Controls.Add(this.tabNewOwner);
            this.tabControl1.Controls.Add(this.tabStatistics);
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCars
            // 
            this.tabCars.Controls.Add(this.groupBox3);
            this.tabCars.Controls.Add(this.groupBox2);
            this.tabCars.Controls.Add(this.groupBox1);
            this.tabCars.Location = new System.Drawing.Point(4, 22);
            this.tabCars.Name = "tabCars";
            this.tabCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabCars.Size = new System.Drawing.Size(702, 382);
            this.tabCars.TabIndex = 0;
            this.tabCars.Text = "МПС";
            this.tabCars.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.displayOwner1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(375, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 309);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация за Собственика";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.displayVehicle);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 309);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация за МПС";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVinNumber);
            this.groupBox1.Controls.Add(this.rdoRegistrationNumber);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Търсене на МПС";
            // 
            // rdoVinNumber
            // 
            this.rdoVinNumber.AutoSize = true;
            this.rdoVinNumber.Location = new System.Drawing.Point(375, 41);
            this.rdoVinNumber.Name = "rdoVinNumber";
            this.rdoVinNumber.Size = new System.Drawing.Size(162, 17);
            this.rdoVinNumber.TabIndex = 3;
            this.rdoVinNumber.Text = "Търси по номер на рамата";
            this.rdoVinNumber.UseVisualStyleBackColor = true;
            // 
            // rdoRegistrationNumber
            // 
            this.rdoRegistrationNumber.AutoSize = true;
            this.rdoRegistrationNumber.Checked = true;
            this.rdoRegistrationNumber.Location = new System.Drawing.Point(375, 18);
            this.rdoRegistrationNumber.Name = "rdoRegistrationNumber";
            this.rdoRegistrationNumber.Size = new System.Drawing.Size(192, 17);
            this.rdoRegistrationNumber.TabIndex = 2;
            this.rdoRegistrationNumber.TabStop = true;
            this.rdoRegistrationNumber.Text = "Търси по регистрационен номер";
            this.rdoRegistrationNumber.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(269, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Търси";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // tabOwners
            // 
            this.tabOwners.Controls.Add(this.gbOwnedVehicles);
            this.tabOwners.Controls.Add(this.groupBox5);
            this.tabOwners.Controls.Add(this.groupBox4);
            this.tabOwners.Location = new System.Drawing.Point(4, 22);
            this.tabOwners.Name = "tabOwners";
            this.tabOwners.Padding = new System.Windows.Forms.Padding(3);
            this.tabOwners.Size = new System.Drawing.Size(702, 382);
            this.tabOwners.TabIndex = 1;
            this.tabOwners.Text = "Собственици";
            this.tabOwners.UseVisualStyleBackColor = true;
            // 
            // gbOwnedVehicles
            // 
            this.gbOwnedVehicles.Controls.Add(this.lblNoVehicles);
            this.gbOwnedVehicles.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbOwnedVehicles.Location = new System.Drawing.Point(317, 72);
            this.gbOwnedVehicles.Name = "gbOwnedVehicles";
            this.gbOwnedVehicles.Size = new System.Drawing.Size(382, 307);
            this.gbOwnedVehicles.TabIndex = 2;
            this.gbOwnedVehicles.TabStop = false;
            this.gbOwnedVehicles.Text = "Притежавани МПС";
            // 
            // lblNoVehicles
            // 
            this.lblNoVehicles.AutoSize = true;
            this.lblNoVehicles.Location = new System.Drawing.Point(122, 142);
            this.lblNoVehicles.Name = "lblNoVehicles";
            this.lblNoVehicles.Size = new System.Drawing.Size(135, 13);
            this.lblNoVehicles.TabIndex = 0;
            this.lblNoVehicles.Text = "Няма регистрирани МПС";
            this.lblNoVehicles.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnUpdateAddress);
            this.groupBox5.Controls.Add(this.displayOwnerOwners);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(3, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 307);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Информация за собственика";
            // 
            // btnUpdateAddress
            // 
            this.btnUpdateAddress.Location = new System.Drawing.Point(129, 263);
            this.btnUpdateAddress.Name = "btnUpdateAddress";
            this.btnUpdateAddress.Size = new System.Drawing.Size(161, 23);
            this.btnUpdateAddress.TabIndex = 1;
            this.btnUpdateAddress.Text = "Промени адреса";
            this.btnUpdateAddress.UseVisualStyleBackColor = true;
            this.btnUpdateAddress.Visible = false;
            this.btnUpdateAddress.Click += new System.EventHandler(this.btnUpdateAddress_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearchUcn);
            this.groupBox4.Controls.Add(this.txtSearchUcn);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(696, 69);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Търсене на собственик на ПМС";
            // 
            // btnSearchUcn
            // 
            this.btnSearchUcn.Location = new System.Drawing.Point(255, 28);
            this.btnSearchUcn.Name = "btnSearchUcn";
            this.btnSearchUcn.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUcn.TabIndex = 1;
            this.btnSearchUcn.Text = "Търси";
            this.btnSearchUcn.UseVisualStyleBackColor = true;
            this.btnSearchUcn.Click += new System.EventHandler(this.btnSearchUcn_Click);
            // 
            // txtSearchUcn
            // 
            this.txtSearchUcn.Location = new System.Drawing.Point(24, 30);
            this.txtSearchUcn.Name = "txtSearchUcn";
            this.txtSearchUcn.Size = new System.Drawing.Size(194, 20);
            this.txtSearchUcn.TabIndex = 0;
            // 
            // tabNewCar
            // 
            this.tabNewCar.Controls.Add(this.btnGenerateNewRegistrationNumber);
            this.tabNewCar.Controls.Add(this.btnAddNewVehicle);
            this.tabNewCar.Controls.Add(this.newVehicle1);
            this.tabNewCar.Location = new System.Drawing.Point(4, 22);
            this.tabNewCar.Name = "tabNewCar";
            this.tabNewCar.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewCar.Size = new System.Drawing.Size(702, 382);
            this.tabNewCar.TabIndex = 2;
            this.tabNewCar.Text = "Добави МПС";
            this.tabNewCar.UseVisualStyleBackColor = true;
            // 
            // btnGenerateNewRegistrationNumber
            // 
            this.btnGenerateNewRegistrationNumber.Location = new System.Drawing.Point(558, 124);
            this.btnGenerateNewRegistrationNumber.Name = "btnGenerateNewRegistrationNumber";
            this.btnGenerateNewRegistrationNumber.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateNewRegistrationNumber.TabIndex = 3;
            this.btnGenerateNewRegistrationNumber.Text = "Генерирай";
            this.btnGenerateNewRegistrationNumber.UseVisualStyleBackColor = true;
            this.btnGenerateNewRegistrationNumber.Click += new System.EventHandler(this.btnGenerateNewRegistrationNumber_Click);
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.Location = new System.Drawing.Point(558, 62);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewVehicle.TabIndex = 1;
            this.btnAddNewVehicle.Text = "Добави";
            this.btnAddNewVehicle.UseVisualStyleBackColor = true;
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
            // 
            // tabNewOwner
            // 
            this.tabNewOwner.Controls.Add(this.btnAddNewOwner);
            this.tabNewOwner.Controls.Add(this.newOwner1);
            this.tabNewOwner.Location = new System.Drawing.Point(4, 22);
            this.tabNewOwner.Name = "tabNewOwner";
            this.tabNewOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewOwner.Size = new System.Drawing.Size(702, 382);
            this.tabNewOwner.TabIndex = 3;
            this.tabNewOwner.Text = "Добави Собственик";
            this.tabNewOwner.UseVisualStyleBackColor = true;
            // 
            // btnAddNewOwner
            // 
            this.btnAddNewOwner.Location = new System.Drawing.Point(483, 56);
            this.btnAddNewOwner.Name = "btnAddNewOwner";
            this.btnAddNewOwner.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewOwner.TabIndex = 1;
            this.btnAddNewOwner.Text = "Добави";
            this.btnAddNewOwner.UseVisualStyleBackColor = true;
            this.btnAddNewOwner.Click += new System.EventHandler(this.btnAddNewOwner_Click);
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.btnAverageCarAge);
            this.tabStatistics.Controls.Add(this.cbAverrageAge);
            this.tabStatistics.Controls.Add(this.label4);
            this.tabStatistics.Controls.Add(this.btnAverageCreationDate);
            this.tabStatistics.Controls.Add(this.cbAverageYearCreation);
            this.tabStatistics.Controls.Add(this.label3);
            this.tabStatistics.Controls.Add(this.btnVehicleCountByType);
            this.tabStatistics.Controls.Add(this.cbVehicleTypeCount);
            this.tabStatistics.Controls.Add(this.label2);
            this.tabStatistics.Controls.Add(this.btnShowAvgUserAge);
            this.tabStatistics.Controls.Add(this.label1);
            this.tabStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(702, 382);
            this.tabStatistics.TabIndex = 4;
            this.tabStatistics.Text = "Статистики";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // btnAverageCarAge
            // 
            this.btnAverageCarAge.Location = new System.Drawing.Point(474, 234);
            this.btnAverageCarAge.Name = "btnAverageCarAge";
            this.btnAverageCarAge.Size = new System.Drawing.Size(75, 23);
            this.btnAverageCarAge.TabIndex = 10;
            this.btnAverageCarAge.Text = "Покажи";
            this.btnAverageCarAge.UseVisualStyleBackColor = true;
            this.btnAverageCarAge.Click += new System.EventHandler(this.btnAverageCarAge_Click);
            // 
            // cbAverrageAge
            // 
            this.cbAverrageAge.FormattingEnabled = true;
            this.cbAverrageAge.Location = new System.Drawing.Point(452, 189);
            this.cbAverrageAge.Name = "cbAverrageAge";
            this.cbAverrageAge.Size = new System.Drawing.Size(121, 21);
            this.cbAverrageAge.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Средна възраст на МПС от тип:";
            // 
            // btnAverageCreationDate
            // 
            this.btnAverageCreationDate.Location = new System.Drawing.Point(474, 101);
            this.btnAverageCreationDate.Name = "btnAverageCreationDate";
            this.btnAverageCreationDate.Size = new System.Drawing.Size(75, 23);
            this.btnAverageCreationDate.TabIndex = 7;
            this.btnAverageCreationDate.Text = "Покажи";
            this.btnAverageCreationDate.UseVisualStyleBackColor = true;
            this.btnAverageCreationDate.Click += new System.EventHandler(this.btnAverageCreationDate_Click);
            // 
            // cbAverageYearCreation
            // 
            this.cbAverageYearCreation.FormattingEnabled = true;
            this.cbAverageYearCreation.Location = new System.Drawing.Point(452, 63);
            this.cbAverageYearCreation.Name = "cbAverageYearCreation";
            this.cbAverageYearCreation.Size = new System.Drawing.Size(121, 21);
            this.cbAverageYearCreation.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Средна дата на производство на МПС от тип:";
            // 
            // btnVehicleCountByType
            // 
            this.btnVehicleCountByType.Location = new System.Drawing.Point(70, 189);
            this.btnVehicleCountByType.Name = "btnVehicleCountByType";
            this.btnVehicleCountByType.Size = new System.Drawing.Size(75, 23);
            this.btnVehicleCountByType.TabIndex = 4;
            this.btnVehicleCountByType.Text = "Покажи";
            this.btnVehicleCountByType.UseVisualStyleBackColor = true;
            this.btnVehicleCountByType.Click += new System.EventHandler(this.btnVehicleCountByType_Click);
            // 
            // cbVehicleTypeCount
            // 
            this.cbVehicleTypeCount.FormattingEnabled = true;
            this.cbVehicleTypeCount.Location = new System.Drawing.Point(28, 151);
            this.cbVehicleTypeCount.Name = "cbVehicleTypeCount";
            this.cbVehicleTypeCount.Size = new System.Drawing.Size(121, 21);
            this.cbVehicleTypeCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Брои МПС от тип:";
            // 
            // btnShowAvgUserAge
            // 
            this.btnShowAvgUserAge.Location = new System.Drawing.Point(70, 61);
            this.btnShowAvgUserAge.Name = "btnShowAvgUserAge";
            this.btnShowAvgUserAge.Size = new System.Drawing.Size(75, 23);
            this.btnShowAvgUserAge.TabIndex = 1;
            this.btnShowAvgUserAge.Text = "Покажи";
            this.btnShowAvgUserAge.UseVisualStyleBackColor = true;
            this.btnShowAvgUserAge.Click += new System.EventHandler(this.btnShowAvgUserAge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Средна възрас на собствениците:";
            // 
            // gbMainMenu
            // 
            this.gbMainMenu.Controls.Add(this.lblCurrentUser);
            this.gbMainMenu.Controls.Add(this.btnLoginLogout);
            this.gbMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMainMenu.Location = new System.Drawing.Point(0, 0);
            this.gbMainMenu.Name = "gbMainMenu";
            this.gbMainMenu.Size = new System.Drawing.Size(710, 42);
            this.gbMainMenu.TabIndex = 1;
            this.gbMainMenu.TabStop = false;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(600, 16);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentUser.TabIndex = 1;
            // 
            // btnLoginLogout
            // 
            this.btnLoginLogout.Location = new System.Drawing.Point(6, 13);
            this.btnLoginLogout.Name = "btnLoginLogout";
            this.btnLoginLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLoginLogout.TabIndex = 0;
            this.btnLoginLogout.Text = "Вход";
            this.btnLoginLogout.UseVisualStyleBackColor = true;
            this.btnLoginLogout.Click += new System.EventHandler(this.btnLoginLogout_Click);
            // 
            // displayOwner1
            // 
            this.displayOwner1.Location = new System.Drawing.Point(6, 33);
            this.displayOwner1.Name = "displayOwner1";
            this.displayOwner1.Owner = null;
            this.displayOwner1.Size = new System.Drawing.Size(284, 228);
            this.displayOwner1.TabIndex = 0;
            this.displayOwner1.Visible = false;
            // 
            // displayVehicle
            // 
            this.displayVehicle.Location = new System.Drawing.Point(5, 33);
            this.displayVehicle.Name = "displayVehicle";
            this.displayVehicle.Size = new System.Drawing.Size(330, 252);
            this.displayVehicle.TabIndex = 0;
            this.displayVehicle.Vehicle = null;
            this.displayVehicle.Visible = false;
            // 
            // displayOwnerOwners
            // 
            this.displayOwnerOwners.Location = new System.Drawing.Point(6, 35);
            this.displayOwnerOwners.Name = "displayOwnerOwners";
            this.displayOwnerOwners.Owner = null;
            this.displayOwnerOwners.Size = new System.Drawing.Size(284, 222);
            this.displayOwnerOwners.TabIndex = 0;
            this.displayOwnerOwners.Visible = false;
            // 
            // newVehicle1
            // 
            this.newVehicle1.Location = new System.Drawing.Point(49, 21);
            this.newVehicle1.Name = "newVehicle1";
            this.newVehicle1.Owner = null;
            this.newVehicle1.Size = new System.Drawing.Size(413, 330);
            this.newVehicle1.TabIndex = 2;
            // 
            // newOwner1
            // 
            this.newOwner1.Location = new System.Drawing.Point(50, 38);
            this.newOwner1.Name = "newOwner1";
            this.newOwner1.Size = new System.Drawing.Size(318, 215);
            this.newOwner1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.gbMainMenu);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Регистрационна система на МПС";
            this.tabControl1.ResumeLayout(false);
            this.tabCars.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabOwners.ResumeLayout(false);
            this.gbOwnedVehicles.ResumeLayout(false);
            this.gbOwnedVehicles.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabNewCar.ResumeLayout(false);
            this.tabNewOwner.ResumeLayout(false);
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            this.gbMainMenu.ResumeLayout(false);
            this.gbMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCars;
        private System.Windows.Forms.TabPage tabOwners;
        private System.Windows.Forms.TabPage tabNewCar;
        private System.Windows.Forms.TabPage tabNewOwner;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.GroupBox gbMainMenu;
        private System.Windows.Forms.Button btnLoginLogout;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdoVinNumber;
        private System.Windows.Forms.RadioButton rdoRegistrationNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.DisplayVehicle displayVehicle;
        private System.Windows.Forms.GroupBox groupBox3;
        private Controls.DisplayOwner displayOwner1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearchUcn;
        private System.Windows.Forms.TextBox txtSearchUcn;
        private System.Windows.Forms.GroupBox gbOwnedVehicles;
        private Controls.DisplayOwner displayOwnerOwners;
        private System.Windows.Forms.Label lblNoVehicles;
        private System.Windows.Forms.Button btnAddNewVehicle;
        private Controls.NewVehicle newVehicle1;
        private System.Windows.Forms.Button btnGenerateNewRegistrationNumber;
        private System.Windows.Forms.Button btnAddNewOwner;
        private Controls.NewOwner newOwner1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAvgUserAge;
        private System.Windows.Forms.ComboBox cbVehicleTypeCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVehicleCountByType;
        private System.Windows.Forms.ComboBox cbAverageYearCreation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAverageCreationDate;
        private System.Windows.Forms.ComboBox cbAverrageAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAverageCarAge;
        private System.Windows.Forms.Button btnUpdateAddress;
    }
}