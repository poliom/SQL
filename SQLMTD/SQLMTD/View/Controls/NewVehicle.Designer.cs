namespace SQLMTD.View.Controls
{
    partial class NewVehicle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbManifacture = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.lnkOwner = new System.Windows.Forms.LinkLabel();
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.txtVinNumber = new System.Windows.Forms.TextBox();
            this.txtEngineNumber = new System.Windows.Forms.TextBox();
            this.txtEnginePower = new System.Windows.Forms.TextBox();
            this.txtEngineValume = new System.Windows.Forms.TextBox();
            this.dtpFirstRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.cbVehicleType = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxNoFirstRegistrationDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модел: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Собственик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Регистрационен номер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер на рама:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Номер на двигател:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Мощност:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Обем на двигателя:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Дата на първа регистрация:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Тип МПС:";
            // 
            // cbManifacture
            // 
            this.cbManifacture.FormattingEnabled = true;
            this.cbManifacture.Location = new System.Drawing.Point(201, 14);
            this.cbManifacture.Name = "cbManifacture";
            this.cbManifacture.Size = new System.Drawing.Size(194, 21);
            this.cbManifacture.TabIndex = 10;
            this.cbManifacture.SelectedIndexChanged += cbManifacture_SelectedIndexChanged;
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(201, 42);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(194, 21);
            this.cbModel.TabIndex = 11;
            // 
            // lnkOwner
            // 
            this.lnkOwner.AutoSize = true;
            this.lnkOwner.Location = new System.Drawing.Point(266, 69);
            this.lnkOwner.Name = "lnkOwner";
            this.lnkOwner.Size = new System.Drawing.Size(107, 13);
            this.lnkOwner.TabIndex = 12;
            this.lnkOwner.TabStop = true;
            this.lnkOwner.Text = "Избери собственик";
            this.lnkOwner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOwner_LinkClicked);
            // 
            // lblRegistrationNumber
            // 
            this.lblRegistrationNumber.AutoSize = true;
            this.lblRegistrationNumber.Location = new System.Drawing.Point(277, 98);
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            this.lblRegistrationNumber.Size = new System.Drawing.Size(0, 13);
            this.lblRegistrationNumber.TabIndex = 13;
            // 
            // txtVinNumber
            // 
            this.txtVinNumber.Location = new System.Drawing.Point(201, 126);
            this.txtVinNumber.Name = "txtVinNumber";
            this.txtVinNumber.Size = new System.Drawing.Size(194, 20);
            this.txtVinNumber.TabIndex = 14;
            // 
            // txtEngineNumber
            // 
            this.txtEngineNumber.Location = new System.Drawing.Point(201, 152);
            this.txtEngineNumber.Name = "txtEngineNumber";
            this.txtEngineNumber.Size = new System.Drawing.Size(194, 20);
            this.txtEngineNumber.TabIndex = 15;
            // 
            // txtEnginePower
            // 
            this.txtEnginePower.Location = new System.Drawing.Point(201, 176);
            this.txtEnginePower.Name = "txtEnginePower";
            this.txtEnginePower.Size = new System.Drawing.Size(194, 20);
            this.txtEnginePower.TabIndex = 16;
            // 
            // txtEngineValume
            // 
            this.txtEngineValume.Location = new System.Drawing.Point(201, 210);
            this.txtEngineValume.Name = "txtEngineValume";
            this.txtEngineValume.Size = new System.Drawing.Size(194, 20);
            this.txtEngineValume.TabIndex = 17;
            // 
            // dtpFirstRegistrationDate
            // 
            this.dtpFirstRegistrationDate.Location = new System.Drawing.Point(201, 240);
            this.dtpFirstRegistrationDate.Name = "dtpFirstRegistrationDate";
            this.dtpFirstRegistrationDate.Size = new System.Drawing.Size(194, 20);
            this.dtpFirstRegistrationDate.TabIndex = 18;
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Location = new System.Drawing.Point(201, 290);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(194, 21);
            this.cbVehicleType.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbxNoFirstRegistrationDate
            // 
            this.cbxNoFirstRegistrationDate.AutoSize = true;
            this.cbxNoFirstRegistrationDate.Location = new System.Drawing.Point(201, 267);
            this.cbxNoFirstRegistrationDate.Name = "cbxNoFirstRegistrationDate";
            this.cbxNoFirstRegistrationDate.Size = new System.Drawing.Size(79, 17);
            this.cbxNoFirstRegistrationDate.TabIndex = 20;
            this.cbxNoFirstRegistrationDate.Text = "Ново МПС";
            this.cbxNoFirstRegistrationDate.UseVisualStyleBackColor = true;
            // 
            // NewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxNoFirstRegistrationDate);
            this.Controls.Add(this.cbVehicleType);
            this.Controls.Add(this.dtpFirstRegistrationDate);
            this.Controls.Add(this.txtEngineValume);
            this.Controls.Add(this.txtEnginePower);
            this.Controls.Add(this.txtEngineNumber);
            this.Controls.Add(this.txtVinNumber);
            this.Controls.Add(this.lblRegistrationNumber);
            this.Controls.Add(this.lnkOwner);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbManifacture);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewVehicle";
            this.Size = new System.Drawing.Size(413, 330);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
          
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbManifacture;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.LinkLabel lnkOwner;
        private System.Windows.Forms.Label lblRegistrationNumber;
        private System.Windows.Forms.TextBox txtVinNumber;
        private System.Windows.Forms.TextBox txtEngineNumber;
        private System.Windows.Forms.TextBox txtEnginePower;
        private System.Windows.Forms.TextBox txtEngineValume;
        private System.Windows.Forms.DateTimePicker dtpFirstRegistrationDate;
        private System.Windows.Forms.ComboBox cbVehicleType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cbxNoFirstRegistrationDate;
    }
}
