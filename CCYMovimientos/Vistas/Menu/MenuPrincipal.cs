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
using CCYMovimientos.Vistas.Ventas;
using CCYMovimientos.Vistas.Notificaciones;

namespace CCYMovimientos.Vistas.Menu
{
    public partial class MenuPrincipal : Form
    {
        private ClienteABM clienteForm;
        private FondosCaja fondosForm;
        private VentasABM ventasForm;

        public MenuPrincipal()
        {
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
            if (this.ventasForm != null)
            {
                this.ventasForm.Hide();
            }


        }

        //EVENTOS
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.panelMenu.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            if (Sesion.codRol == 2)
            {
                btnFondos.Visible = false;
                btnCreditos.Visible = false;
                btnFondos.Visible = false;
                btnHVentas.Visible = false;
            }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
                this.menuLeft.Width = 80;
                this.btnMenu.Location = new Point(-8, 5);
                this.menuLeftAnimator.ShowSync(menuLeft);
                
            }
            else
            {
                this.menuLeft.Visible = false;
                this.menuLeft.Width = 234;
                this.btnMenu.Location = new Point(150, 5);
                this.menuLeftAnimator.ShowSync(menuLeft);
            }
        }

        private void MenuPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "MenuPrincipal")
                    {
                        frm.WindowState = FormWindowState.Minimized;
                    }
                }
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "MenuPrincipal")
                    {
                        frm.FormBorderStyle = FormBorderStyle.None;
                    }
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
            btnTitulo.Iconimage = btnClientes.Iconimage;
            lblTitulo.Text = "CLIENTES";
            clienteForm.Show();
            clienteForm.CargarClientes();
            clienteForm.DestacarMora();
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
            else
            {
                fondosForm.CargarMovimientos();
            }
            btnTitulo.Iconimage = btnFondos.Iconimage;
            lblTitulo.Text = "FONDOS";
            fondosForm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.EsconderPaneles();

            if (ventasForm == null)
            {
                ventasForm = new VentasABM(this.panelMenu.Location,
                                               this.panelMenu.Size);
                ventasForm.MdiParent = this;
                this.panelMenu.Controls.Add(ventasForm);
                ventasForm.Dock = DockStyle.Fill;
                
            }
            btnTitulo.Iconimage = btnVentas.Iconimage;
            lblTitulo.Text = "VENTAS";
            ventasForm.Show();
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            string pregunta;
            pregunta = "Desea cerrar la sesion del usuario '" + Sesion.usuario  + "' ?";
            IngresoDatos objMsj = new IngresoDatos("Cerrar Sesion", pregunta,
                                                   "No","Si");
            objMsj.ShowDialog();

            if (objMsj.getTexto1() == "S")
            {
                Application.Restart();
            }
        }

        private void btnHVentas_Click(object sender, EventArgs e)
        {
            HistorialVentas HVentasForm = new HistorialVentas();
            HVentasForm.ShowDialog();
        }

        private void btnTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
