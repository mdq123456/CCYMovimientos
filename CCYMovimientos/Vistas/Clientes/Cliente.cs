using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCYMovimientos.Modelos;
using System.Data.SqlClient;
using CCYMovimientos.Modelos.Clientes;
using CCYMovimientos.Vistas.Notificaciones;

namespace CCYMovimientos.Vistas.Clientes
{
    public partial class Cliente : UserControl
    {
        // Status:
        // P: pendiente; N: Nuevo; E: Edicion
        private string status { set; get; }
        public string getStatus() { return this.status; }
        public void cambiarStatus(string p_status)
        {
            this.status = p_status;
        }

        public Cliente()
        {
            InitializeComponent();
            this.status = "N";
        }

        //METODOS
        private void OcultarFormulario(string p_status)
        {
            this.status = p_status;
            this.Hide();
        }

        //EVENTOS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ControlarDatos())
            {
                CrearCliente();
                OcultarFormulario("G");
            }
            else
            {
                Alertas alert = new Alertas("Debe completar los datos para ingresar al nuevo cliente.", "");
                alert.Show();
            } 
        }

        private void CrearCliente()
        {
            string CUIL = TxtCUILIzq.Text + "-" + TxtCUIL.Text + "-" + TxtCUILDer.Text;
            DBClientes objCliente = new DBClientes(TxtApellidos.Text,
                                                   TxtNombres.Text,
                                                   CUIL,
                                                   TxtDNI.Text,
                                                   cboTipoCliente.SelectedValue.ToString(),
                                                   TxtTel.Text,
                                                   TxtEmail.Text,
                                                   cboProvincia.SelectedValue.ToString(),
                                                   cboLocalidad.SelectedValue.ToString(),
                                                   TxtDireccion.Text);
            if (objCliente.CrearCliente())
            {
                Alertas alert = new Alertas("Operacion finalizada con éxito !", "");
                alert.Show();
            }
            else
            {
                Alertas alert = new Alertas("No pudo realizarse la operacion, comuniquese con su administrador.", "");
                alert.Show();
            }
            

        }

        private bool ControlarDatos()
        {
            if (cboTipoCliente.Text == "" &&
                cboProvincia.Text == "" &&
                cboLocalidad.Text == "")
            {
                return false;
            }

            return true;
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            OcultarFormulario("P");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OcultarFormulario("P");
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            cargarComponentes();
        }

        private void cargarComponentes()
        {
            //Cargo combo Tipo Clientes
            DBClientes objCliente = new DBClientes();
            this.cboTipoCliente.DataSource = objCliente.TraerClientesTipos();
            this.cboTipoCliente.DisplayMember = "TipoCliente";
            this.cboTipoCliente.ValueMember = "CodClienteTipo";

            //Cargo combo Provincias
            this.cboProvincia.DataSource = objCliente.TraerClientesProvincias();
            this.cboProvincia.DisplayMember = "Provincia";
            this.cboProvincia.ValueMember = "CodProvincia";
            this.cboProvincia.SelectedIndex = 7;

            //Cargo combo Localidades
            this.cboLocalidad.DataSource = objCliente.TraerClientesLocalidades(Convert.ToInt32(this.cboProvincia.SelectedValue));
            this.cboLocalidad.DisplayMember = "Localidad";
            this.cboLocalidad.ValueMember = "CodLocalidad";
            this.cboLocalidad.SelectedIndex = 5;

        }

        private void CargarLocalidades()
        {
            try
            {
                if (Convert.ToInt32(this.cboProvincia.SelectedValue) > -1)
                {
                    DBClientes objCliente = new DBClientes();
                    this.cboLocalidad.DataSource = objCliente.TraerClientesLocalidades(Convert.ToInt32(this.cboProvincia.SelectedValue));
                    this.cboLocalidad.DisplayMember = "Localidad";
                    this.cboLocalidad.ValueMember = "CodLocalidad";
                    this.cboLocalidad.SelectedIndex = -1;
                }
            }
            catch (Exception e)
            {
                //throw ;
            }
            
            
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarLocalidades();
        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboTipoCliente.Text == "Persona Juridica")
            {
                lblNombre.Text = "Nombre Fantasia :";
                lblApellido.Text = "Razon Social :";
                lblDNI.Enabled = false;
                TxtDNI.Enabled = false;
                TxtDNI.LineIdleColor = Color.FromArgb(64, 64, 64);
                TxtDNI.LineMouseHoverColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                lblNombre.Text = "Nombres :";
                lblApellido.Text = "Apellidos :";
                lblDNI.Enabled = true;
                TxtDNI.Enabled = true;
                TxtDNI.LineIdleColor = Color.FromArgb(8, 37, 67);
                TxtDNI.LineMouseHoverColor = Color.FromArgb(0, 7, 67);
            }
        }
    }
}
