namespace SQLMTD.View
{
    partial class SelectOwnerForm
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
            this.displayOwner1 = new SQLMTD.View.Controls.DisplayOwner();
            this.cbxSelect = new System.Windows.Forms.CheckBox();
            this.txtUCN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayOwner1
            // 
            this.displayOwner1.Location = new System.Drawing.Point(12, 44);
            this.displayOwner1.Name = "displayOwner1";
            this.displayOwner1.Owner = null;
            this.displayOwner1.Size = new System.Drawing.Size(284, 199);
            this.displayOwner1.TabIndex = 0;
            this.displayOwner1.Visible = false;
            // 
            // cbxSelect
            // 
            this.cbxSelect.AutoSize = true;
            this.cbxSelect.Location = new System.Drawing.Point(12, 249);
            this.cbxSelect.Name = "cbxSelect";
            this.cbxSelect.Size = new System.Drawing.Size(152, 17);
            this.cbxSelect.TabIndex = 1;
            this.cbxSelect.Text = "Избери като собственик";
            this.cbxSelect.UseVisualStyleBackColor = true;
            this.cbxSelect.Visible = false;
            // 
            // txtUCN
            // 
            this.txtUCN.Location = new System.Drawing.Point(90, 18);
            this.txtUCN.Name = "txtUCN";
            this.txtUCN.Size = new System.Drawing.Size(206, 20);
            this.txtUCN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ЕГН:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(324, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Търси";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(221, 245);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Потвърди";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // SelectOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 291);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUCN);
            this.Controls.Add(this.cbxSelect);
            this.Controls.Add(this.displayOwner1);
            this.Name = "SelectOwnerForm";
            this.Text = "Избиране на собственик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DisplayOwner displayOwner1;
        private System.Windows.Forms.CheckBox cbxSelect;
        private System.Windows.Forms.TextBox txtUCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnConfirm;
    }
}