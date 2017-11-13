using CCYMovimientos.Modelos.Sessiones;
using CCYMovimientos.Vistas.Fondos;
using CCYMovimientos.Vistas.Clientes;
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
        private ClienteABM clienteForm;
        private FondosCaja fondosForm;
        public MenuPrincipal(Sesion pobjSesion)
        {
            this.objSesion = pobjSesion;
            InitializeComponent();
        }

        //METODOS
        private void EsconderPaneles()
        {
            this.panelMenu.Visible = true;
            if (this.clienteForm != null)
            {
                this.clienteForm.Hide();
            }
            if (this.fondosForm != null)
            {
                this.fondosForm.Hide();
            }


        }

        //EVENTOS
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.panelMenu.Dock = DockStyle.Fill;
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
            if (clienteForm == null)
            {
                this.clienteForm = new ClienteABM(this.panelMenu.Location,
                                               this.panelMenu.Size);
                clienteForm.MdiParent = this;
                this.panelMenu.Controls.Add(clienteForm);
                clienteForm.Dock = DockStyle.Fill;
            }
            clienteForm.Show();
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            this.EsconderPaneles();
            if (fondosForm == null)
            {
                fondosForm = new FondosCaja(this.panelMenu.Location,
                                               this.panelMenu.Size);
                fondosForm.MdiParent = this;
                this.panelMenu.Controls.Add(fondosForm);
                fondosForm.Dock = DockStyle.Fill;
            }
            fondosForm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.EsconderPaneles();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            this.EsconderPaneles();
        }

        private void controlDeClientes_VisibleChanged(object sender, EventArgs e)
        {
            //if (this.controlDeClientes.getStatus() != "V")
            //{
            //    this.Cliente.cambiarStatus(this.controlDeClientes.getStatus());
            //    this.panelesAnimator.ShowSync(this.Cliente);
            //}
        }

        private void Cliente_VisibleChanged(object sender, EventArgs e)
        {
            //if (this.controlDeClientes.getStatus() == "N"
            //    && !this.Cliente.Visible)
            //{
            //    this.controlDeClientes.cambiarStatus("V");
            //    if (this.Cliente.getStatus() == "P")
            //    {
            //        this.panelesAnimator.ShowSync(this.controlDeClientes);
            //    }
            //    else if (this.Cliente.getStatus() == "G")
            //    {
            //        //controlDeClientes.CargarClientes();
            //        this.panelesAnimator.ShowSync(this.controlDeClientes);
            //    }
            //}
        }

    }
}
