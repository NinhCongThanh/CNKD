using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ChiecNonKyDIeu.Giaodien
{
    public partial class frm_Intro : Form
    {
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();
        Form menu = new Form_start();
        public frm_Intro()
        {
                InitializeComponent();
                timer3.Interval = 20;
                timer3.Tick += new EventHandler(fadeOut);
                timer2.Interval = 500;
                timer2.Tick += new EventHandler(keeping);
        }

        private void frm_Intro_Activated(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frm_Intro_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            timer1.Interval = 20;  //tang mo moi 10s
            timer1.Tick += new EventHandler(fadeIn);  //ham thay doi do mo
            timer1.Start();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                timer1.Stop();   //this stops the timer if the form is completely displayed
                timer2.Start();
            }
            else
                Opacity += 0.04;
        }

        int start = 0;
        int stop = 1500;
        void keeping(object sender, EventArgs e)
        {
            if (start < stop)
            {
                start += timer2.Interval;
            }
            else
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                timer3.Stop();
                this.Hide();
                menu.Show();
            }
            else
                Opacity -= 0.04;
        }
    }
}
