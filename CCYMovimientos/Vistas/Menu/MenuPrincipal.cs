using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Vistas.Menu
{
    public partial class MenuPrincipal : Form
    {
        
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.controlDeUsuarios.Dock = DockStyle.Fill;
            this.caja.Dock = DockStyle.Fill;
            this.controlDeCreditos.Dock = DockStyle.Fill;
            this.ventas.Dock = DockStyle.Fill;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuLeft.Width == 234)
            {
                menuLeft.Visible = false;
                menuLeft.Width = 54;
                btnMenu.Location = new Point(16, 16);
                menuLeftAnimator.ShowSync(menuLeft);
                
            }
            else
            {
                menuLeft.Visible = false;
                menuLeft.Width = 234;
                btnMenu.Location = new Point(192, 16);
                menuLeftAnimator.ShowSync(menuLeft);
            }
        }

        private void MenuPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {

                foreach (Form frm in Application.OpenForms)
                {
                    frm.WindowState = FormWindowState.Minimized;
                }

            }
        }
        private void EsconderPaneles()
        {
            this.menuFondo.Visible = true;
            this.controlDeUsuarios.Hide();
            this.caja.Hide();
            this.controlDeCreditos.Hide();
            this.ventas.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.EsconderPaneles();
            this.controlDeUsuarios.Visible = true;
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            this.EsconderPaneles();
            caja.Visible = true;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.EsconderPaneles();
            this.ventas.Visible = true;
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            this.EsconderPaneles();
            this.controlDeCreditos.Visible = true;
        }
    }
}
