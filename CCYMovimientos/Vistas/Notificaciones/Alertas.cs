using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Vistas.Notificaciones
{
    public partial class Alertas : Form
    {
        int interval = 0;
        string msj { set; get; }
        public Alertas(string pmsj, string tipo)
        {
            InitializeComponent();

            this.msj = pmsj;
            this.lblMsj.Text = this.msj;

            switch (tipo)
            {
                case "Info":

                    break;
                default:
                    break;
            }
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;

            this.timeShow.Start();
        }

        private void timeOut_Tick(object sender, EventArgs e)
        {
            this.timeClose.Start();
        }

        private void timeShow_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                this.interval += 2;
            }
            else
            {
                this.timeShow.Stop();
            }
        }

        private void timeClose_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.timeClose.Start();
        }
    }
}
