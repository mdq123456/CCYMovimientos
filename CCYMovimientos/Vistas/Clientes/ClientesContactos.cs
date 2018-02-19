using CCYMovimientos.Modelos.Clientes;
using CCYMovimientos.Modelos.Contactos;
using CCYMovimientos.Vistas.Notificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Vistas.Clientes
{

    public partial class ClientesContactos : Form
    {
        string codCliente;
        public ClientesContactos(string pcodCliente, string pNombre)
        {
            InitializeComponent();
            codCliente = pcodCliente;
            TxtCliente.Text = pNombre;
        }

        private void btnGuardarTel_Click(object sender, EventArgs e)
        {
            if (ControlarDatosTel())
            {
                GuardarTelefonos();
                CargarTelefonos();
            }
        }

        private void GuardarTelefonos()
        {
            DBContactos objContacto = new DBContactos(codCliente, "Cliente");

            Alertas alert = new Alertas(objContacto.GuardarTelefonos(TxtCel.Text.Trim(),
                                                                     TxtFijo.Text.Trim()), "");
            alert.Show();

            TxtEmail.Text = "";
        }

        private bool ControlarDatosTel()
        {
            if (TxtCel.Text.Trim() == "" ||
                TxtFijo.Text.Trim() == "")
            {
                Alertas alert = new Alertas("Debe completar los datos para guardar el contacto.", "");
                alert.Show();
                return false;
            }
            return true;
        }

        private void ClientesContactos_Load(object sender, EventArgs e)
        {
            CargarContactos();
        }

        private void CargarContactos()
        {
            CargarTelefonos();
            CargarEmails();
        }

        private void CargarEmails()
        {
            DBContactos objContacto = new DBContactos(this.codCliente, "Cliente");
            DGEmail.DataSource = objContacto.TraerEmails();
            LimpiarDatos();
        }

        private void CargarTelefonos()
        {
            DBContactos objContacto = new DBContactos(this.codCliente, "Cliente");
            DGTelefonos.DataSource = objContacto.TraerTelefonos();
            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            TxtCel.Text = "";
            TxtFijo.Text = "";
            TxtEmail.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarEmail_Click(object sender, EventArgs e)
        {
            if (ControlarDatosEmail())
            {
                GuardarEmail();
                CargarContactos();
            }
        }

        private void GuardarEmail()
        {
            DBContactos objContacto = new DBContactos(codCliente, "Cliente");

            Alertas alert = new Alertas(objContacto.GuardarEmail(TxtEmail.Text.Trim()), "");
            alert.Show();

            TxtEmail.Text = "";
        }

        private bool ControlarDatosEmail()
        {
            if (TxtEmail.Text.Trim() == "")
            {
                Alertas alert = new Alertas("Debe completar los datos para guardar el contacto.", "");
                alert.Show();
                return false;
            }
            return true;
        }
    }
}
