namespace SQLMTD.View.Controls
{
    partial class LinkToVehicle
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
            this.lnkVehicle = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkVehicle
            // 
            this.lnkVehicle.AutoSize = true;
            this.lnkVehicle.Location = new System.Drawing.Point(18, 10);
            this.lnkVehicle.Name = "lnkVehicle";
            this.lnkVehicle.Size = new System.Drawing.Size(55, 13);
            this.lnkVehicle.TabIndex = 0;
            this.lnkVehicle.TabStop = true;
            this.lnkVehicle.Text = "linkLabel1";
            this.lnkVehicle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVehicle_LinkClicked);
            // 
            // LinkToVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnkVehicle);
            this.Name = "LinkToVehicle";
            this.Size = new System.Drawing.Size(94, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkVehicle;
    }
}
