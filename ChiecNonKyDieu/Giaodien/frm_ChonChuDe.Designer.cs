namespace ChiecNonKyDIeu.Giaodien
{
    partial class frm_ChonChuDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChonChuDe));
            this.lb_ChonChuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ChonChuDe = new System.Windows.Forms.ComboBox();
            this.bt_DongY = new System.Windows.Forms.Button();
            this.bt_VeMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ChonChuDe
            // 
            this.lb_ChonChuDe.AutoSize = true;
            this.lb_ChonChuDe.BackColor = System.Drawing.Color.Transparent;
            this.lb_ChonChuDe.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChonChuDe.ForeColor = System.Drawing.Color.Yellow;
            this.lb_ChonChuDe.Location = new System.Drawing.Point(433, 33);
            this.lb_ChonChuDe.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_ChonChuDe.Name = "lb_ChonChuDe";
            this.lb_ChonChuDe.Size = new System.Drawing.Size(504, 90);
            this.lb_ChonChuDe.TabIndex = 1;
            this.lb_ChonChuDe.Text = "Chọn Chủ Đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(170, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Chủ Đề :";
            // 
            // cb_ChonChuDe
            // 
            this.cb_ChonChuDe.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ChonChuDe.FormattingEnabled = true;
            this.cb_ChonChuDe.Location = new System.Drawing.Point(462, 257);
            this.cb_ChonChuDe.Name = "cb_ChonChuDe";
            this.cb_ChonChuDe.Size = new System.Drawing.Size(566, 50);
            this.cb_ChonChuDe.TabIndex = 3;
            // 
            // bt_DongY
            // 
            this.bt_DongY.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_DongY.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DongY.ForeColor = System.Drawing.Color.Yellow;
            this.bt_DongY.ImageKey = "(none)";
            this.bt_DongY.Location = new System.Drawing.Point(620, 358);
            this.bt_DongY.Name = "bt_DongY";
            this.bt_DongY.Size = new System.Drawing.Size(250, 69);
            this.bt_DongY.TabIndex = 9;
            this.bt_DongY.Text = "Đồng Ý";
            this.bt_DongY.UseVisualStyleBackColor = false;
            // 
            // bt_VeMenu
            // 
            this.bt_VeMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_VeMenu.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_VeMenu.ForeColor = System.Drawing.Color.Yellow;
            this.bt_VeMenu.ImageKey = "(none)";
            this.bt_VeMenu.Location = new System.Drawing.Point(53, 605);
            this.bt_VeMenu.Name = "bt_VeMenu";
            this.bt_VeMenu.Size = new System.Drawing.Size(250, 69);
            this.bt_VeMenu.TabIndex = 10;
            this.bt_VeMenu.Text = "Về Menu";
            this.bt_VeMenu.UseVisualStyleBackColor = false;
            // 
            // frm_ChonChuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 770);
            this.Controls.Add(this.bt_VeMenu);
            this.Controls.Add(this.bt_DongY);
            this.Controls.Add(this.cb_ChonChuDe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_ChonChuDe);
            this.Name = "frm_ChonChuDe";
            this.Text = "frm_ChonChuDe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ChonChuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ChonChuDe;
        private System.Windows.Forms.Button bt_DongY;
        private System.Windows.Forms.Button bt_VeMenu;
    }
}