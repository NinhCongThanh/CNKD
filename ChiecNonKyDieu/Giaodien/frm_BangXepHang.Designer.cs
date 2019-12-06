namespace ChiecNonKyDIeu.Giaodien
{
    partial class frm_BangXepHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BangXepHang));
            this.lb_ChonChuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_ChonChuDe
            // 
            this.lb_ChonChuDe.AutoSize = true;
            this.lb_ChonChuDe.BackColor = System.Drawing.Color.Transparent;
            this.lb_ChonChuDe.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChonChuDe.ForeColor = System.Drawing.Color.Yellow;
            this.lb_ChonChuDe.Location = new System.Drawing.Point(383, 40);
            this.lb_ChonChuDe.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_ChonChuDe.Name = "lb_ChonChuDe";
            this.lb_ChonChuDe.Size = new System.Drawing.Size(579, 90);
            this.lb_ChonChuDe.TabIndex = 2;
            this.lb_ChonChuDe.Text = "Bảng Xếp Hạng";
            // 
            // frm_BangXepHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 770);
            this.Controls.Add(this.lb_ChonChuDe);
            this.Name = "frm_BangXepHang";
            this.Text = "frm_BangXepHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ChonChuDe;
    }
}