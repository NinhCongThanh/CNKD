namespace ChiecNonKyDIeu.Giaodien
{
    partial class frm_Start
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
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_HuongDan = new System.Windows.Forms.Button();
            this.bt_bangxephang = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_CaiDat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_Thoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.ImageKey = "(none)";
            this.bt_Thoat.Location = new System.Drawing.Point(486, 651);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(289, 57);
            this.bt_Thoat.TabIndex = 9;
            this.bt_Thoat.Text = "THOÁT";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_HuongDan
            // 
            this.bt_HuongDan.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_HuongDan.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HuongDan.ImageKey = "(none)";
            this.bt_HuongDan.Location = new System.Drawing.Point(486, 501);
            this.bt_HuongDan.Name = "bt_HuongDan";
            this.bt_HuongDan.Size = new System.Drawing.Size(289, 57);
            this.bt_HuongDan.TabIndex = 8;
            this.bt_HuongDan.Text = "HƯỚNG DẪN";
            this.bt_HuongDan.UseVisualStyleBackColor = false;
            this.bt_HuongDan.Click += new System.EventHandler(this.bt_HuongDan_Click);
            // 
            // bt_bangxephang
            // 
            this.bt_bangxephang.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_bangxephang.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bangxephang.ImageKey = "(none)";
            this.bt_bangxephang.Location = new System.Drawing.Point(486, 426);
            this.bt_bangxephang.Name = "bt_bangxephang";
            this.bt_bangxephang.Size = new System.Drawing.Size(289, 57);
            this.bt_bangxephang.TabIndex = 7;
            this.bt_bangxephang.Text = "BẢNG XẾP HẠNG";
            this.bt_bangxephang.UseVisualStyleBackColor = false;
            this.bt_bangxephang.Click += new System.EventHandler(this.bt_bangxephang_Click);
            // 
            // bt_start
            // 
            this.bt_start.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_start.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.ImageKey = "(none)";
            this.bt_start.Location = new System.Drawing.Point(486, 351);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(289, 57);
            this.bt_start.TabIndex = 6;
            this.bt_start.Text = "CHƠI GAME";
            this.bt_start.UseVisualStyleBackColor = false;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-41, -130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_CaiDat
            // 
            this.button_CaiDat.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_CaiDat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CaiDat.ImageKey = "(none)";
            this.button_CaiDat.Location = new System.Drawing.Point(486, 576);
            this.button_CaiDat.Name = "button_CaiDat";
            this.button_CaiDat.Size = new System.Drawing.Size(289, 57);
            this.button_CaiDat.TabIndex = 10;
            this.button_CaiDat.Text = "CÀI ĐẶT";
            this.button_CaiDat.UseVisualStyleBackColor = false;
            this.button_CaiDat.Click += new System.EventHandler(this.button_CaiDat_Click);
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChiecNonKyDIeu.Properties.Resources.menuCNKD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.button_CaiDat);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_HuongDan);
            this.Controls.Add(this.bt_bangxephang);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.button1);
            this.Name = "frm_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_start";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_HuongDan;
        private System.Windows.Forms.Button bt_bangxephang;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_CaiDat;
    }
}