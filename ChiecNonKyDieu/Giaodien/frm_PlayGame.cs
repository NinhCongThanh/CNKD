using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ChiecNonKyDIeu.xuly;
using System.Threading;

namespace ChiecNonKyDIeu.Giaodien
{
    public partial class frm_PlayGame : Form
    {
      
        Bitmap ChiecNonbitmap = new Bitmap(ChiecNonKyDIeu.Properties.Resources.HinhChiecNon);
        Image HinhChiecNon;
        Thread th;
        public frm_PlayGame()
        {
            InitializeComponent();
            ptb_VongQuay.Enabled = false;  
        }

        private void ptb_MC_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void frm_PlayGame_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ptb_VongQuay_Click(object sender, EventArgs e)
        {
            HinhChiecNon = ChiecNonbitmap;
            int tocdo = new Random().Next(30, 80);
            while (tocdo > 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    int gocCong = new Random().Next(0,360);
                    ptb_VongQuay.Image.Clone();
                    ptb_VongQuay.Image = cls_VongQuay.xoayvong(HinhChiecNon, new PointF((float)(HinhChiecNon.Width / 2), (float)(HinhChiecNon.Height / 2)), gocCong + tocdo);
                    int goc = (gocCong + tocdo) % 360;
                    ptb_VongQuay.Tag = goc.ToString();
                    ptb_VongQuay.Refresh();
                }
                tocdo = tocdo - 3;
                ptb_VongQuay.Enabled = false;
            }
            
        }

        private void ptb_VongQuay_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(MoForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void MoForm()
        {
            Application.Run(new frm_Start());
        }

        private void bt_DoanChuCai_Click(object sender, EventArgs e)
        {
            ptb_VongQuay.Enabled = true;
        }
    }
}
