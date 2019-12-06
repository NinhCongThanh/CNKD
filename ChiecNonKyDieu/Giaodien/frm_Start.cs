using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChiecNonKyDIeu.Giaodien
{
    public partial class frm_Start : Form
    {
        string hanhdong;
        Thread th;
        public frm_Start()
        {
            InitializeComponent();
        }

        private void bt_HuongDan_Click(object sender, EventArgs e)
        {
            hanhdong = "huongdan";
            this.Close();
            th = new Thread(MoForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            hanhdong = "start";
            this.Close();
            th = new Thread(MoForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void MoForm()
        {
            switch(hanhdong)
            {
                case "start":
                    {
                        Application.Run(new frm_PlayGame());
                        break;
                    }
                case "bangxephang":
                    {
                        Application.Run(new frm_BangXepHang());
                        break;
                    }
                case "CaiDat":
                    {
                        Application.Run(new frm_CaiDat());
                        break;
                    }
                case "huongdan":
                    {
                        Application.Run(new frm_HuongDan());
                        break;
                    }
            }
            
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_bangxephang_Click(object sender, EventArgs e)
        {
            hanhdong = "bangxephang";
            this.Close();
            th = new Thread(MoForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void button_CaiDat_Click(object sender, EventArgs e)
        {
            hanhdong = "CaiDat";
            this.Close();
            th = new Thread(MoForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
