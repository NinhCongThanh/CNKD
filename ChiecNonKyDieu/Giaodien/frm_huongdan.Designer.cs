namespace ChiecNonKyDIeu.Giaodien
{
    partial class frm_HuongDan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HuongDan));
            this.lb_ChonChuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_VeMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ChonChuDe
            // 
            this.lb_ChonChuDe.AutoSize = true;
            this.lb_ChonChuDe.BackColor = System.Drawing.Color.Transparent;
            this.lb_ChonChuDe.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChonChuDe.ForeColor = System.Drawing.Color.Yellow;
            this.lb_ChonChuDe.Location = new System.Drawing.Point(378, 24);
            this.lb_ChonChuDe.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_ChonChuDe.Name = "lb_ChonChuDe";
            this.lb_ChonChuDe.Size = new System.Drawing.Size(540, 90);
            this.lb_ChonChuDe.TabIndex = 3;
            this.lb_ChonChuDe.Text = "HƯỚNG DẪN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1183, 210);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // bt_VeMenu
            // 
            this.bt_VeMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_VeMenu.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_VeMenu.ImageKey = "(none)";
            this.bt_VeMenu.Location = new System.Drawing.Point(503, 504);
            this.bt_VeMenu.Name = "bt_VeMenu";
            this.bt_VeMenu.Size = new System.Drawing.Size(289, 57);
            this.bt_VeMenu.TabIndex = 7;
            this.bt_VeMenu.Text = "VỀ MENU";
            this.bt_VeMenu.UseVisualStyleBackColor = false;
            this.bt_VeMenu.Click += new System.EventHandler(this.bt_VeMenu_Click);
            // 
            // frm_HuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChiecNonKyDIeu.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1307, 600);
            this.Controls.Add(this.bt_VeMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_ChonChuDe);
            this.Name = "frm_HuongDan";
            this.Text = "From_huongdan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ChonChuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_VeMenu;
    }
}