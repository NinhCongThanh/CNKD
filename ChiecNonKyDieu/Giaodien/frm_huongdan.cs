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
    public partial class frm_HuongDan : Form
    {
        Thread th;
        public frm_HuongDan()
        {
            InitializeComponent();
        }

        private void bt_VeMenu_Click(object sender, EventArgs e)
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
    }
}
