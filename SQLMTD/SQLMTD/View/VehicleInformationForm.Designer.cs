namespace SQLMTD.View
{
    partial class VehicleInformationForm
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
            this.displayVehicle1 = new SQLMTD.View.Controls.DisplayVehicle();
            this.SuspendLayout();
            // 
            // displayVehicle1
            // 
            this.displayVehicle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayVehicle1.Location = new System.Drawing.Point(0, 0);
            this.displayVehicle1.Name = "displayVehicle1";
            this.displayVehicle1.Size = new System.Drawing.Size(494, 305);
            this.displayVehicle1.TabIndex = 0;
            this.displayVehicle1.Vehicle = null;
            // 
            // VehicleInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 305);
            this.Controls.Add(this.displayVehicle1);
            this.Name = "VehicleInformationForm";
            this.Text = "Информация за МПС";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DisplayVehicle displayVehicle1;

    }
}