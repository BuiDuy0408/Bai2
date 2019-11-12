namespace Bai2_TruongTHPT
{
    partial class Hoc_Sinh
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
            this.txtHoTen_HS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMa_HS = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHoTen_HS
            // 
            this.txtHoTen_HS.Location = new System.Drawing.Point(155, 91);
            this.txtHoTen_HS.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen_HS.Name = "txtHoTen_HS";
            this.txtHoTen_HS.Size = new System.Drawing.Size(235, 22);
            this.txtHoTen_HS.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 97);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 53;
            this.label15.Text = "Họ Tên";
            // 
            // txtMa_HS
            // 
            this.txtMa_HS.Enabled = false;
            this.txtMa_HS.Location = new System.Drawing.Point(155, 32);
            this.txtMa_HS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa_HS.Name = "txtMa_HS";
            this.txtMa_HS.Size = new System.Drawing.Size(235, 22);
            this.txtMa_HS.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "Mã HS";
            // 
            // Hoc_Sinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 510);
            this.Controls.Add(this.txtHoTen_HS);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMa_HS);
            this.Controls.Add(this.label16);
            this.Name = "Hoc_Sinh";
            this.Text = "Hoc_Sinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen_HS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMa_HS;
        private System.Windows.Forms.Label label16;
    }
}