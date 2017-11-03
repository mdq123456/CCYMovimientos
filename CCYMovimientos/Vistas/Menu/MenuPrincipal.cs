using CCYMovimientos.Modelos.Sessiones;
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
        private Sesion objSesion;
        public MenuPrincipal(Sesion pobjSesion)
        {
            this.objSesion = pobjSesion;
            InitializeComponent();
        }

        //METODOS
        private void EsconderPaneles()
        {
            this.menuFondo.Visible = true;
            this.controlDeClientes.Hide();
            this.caja.Hide();
            this.controlDeCreditos.Hide();
            this.ventas.Hide();
            this.Cliente.Hide();
        }

        //EVENTOS
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.menuFondo.Dock = DockStyle.Fill;
            this.controlDeClientes.Dock = DockStyle.Fill;
            this.caja.Dock = DockStyle.Fill;
            this.controlDeCreditos.Dock = DockStyle.Fill;
            this.ventas.Dock = DockStyle.Fill;
            this.Cliente.Dock = DockStyle.Fill;
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
            if (this.menuLeft.Width == 234)
            {
                this.menuLeft.Visible = false;
                this.menuLeft.Width = 54;
                this.btnMenu.Location = new Point(16, 16);
                this.menuLeftAnimator.ShowSync(menuLeft);
                
            }
            else
            {
                this.menuLeft.Visible = false;
                this.menuLeft.Width = 234;
                this.btnMenu.Location = new Point(192, 16);
                this.menuLeftAnimator.ShowSync(menuLeft);
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

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.EsconderPaneles();
            this.controlDeClientes.Visible = true;
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            this.EsconderPaneles();
            this.caja.Visible = true;
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

        private void controlDeClientes_VisibleChanged(object sender, EventArgs e)
        {
            if (this.controlDeClientes.getStatus() != "V")
            {
                this.Cliente.cambiarStatus(this.controlDeClientes.getStatus());
                this.panelesAnimator.ShowSync(this.Cliente);
            }
        }

        private void Cliente_VisibleChanged(object sender, EventArgs e)
        {
            if (this.controlDeClientes.getStatus() == "N"
                && !this.Cliente.Visible)
            {
                this.controlDeClientes.cambiarStatus("V");
                if (this.Cliente.getStatus() == "P")
                {
                    this.panelesAnimator.ShowSync(this.controlDeClientes);
                }
                else if (this.Cliente.getStatus() == "G")
                {
                    controlDeClientes.CargarClientes();
                    this.panelesAnimator.ShowSync(this.controlDeClientes);
                }
            }
        }

    }
}
