using CCYMovimientos.Modelos.Clientes;
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
    public partial class ClientesDirecciones : Form
    {
        string codCliente;
        public ClientesDirecciones(string pcodCliente,
                                string pNombre)
        {
            InitializeComponent();
            this.codCliente = pcodCliente;
            TxtCliente.Text = pNombre;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientesDirecciones_Load(object sender, EventArgs e)
        {
            cargarComponentes();
            CargarDirecciones();
        }

        private void cargarComponentes()
        {
            DBClientes objCliente = new DBClientes();
            //Cargo combo Provincias
            this.cboProvincia.DisplayMember = "Provincia";
            this.cboProvincia.ValueMember = "CodProvincia";
            this.cboProvincia.DataSource = objCliente.TraerClientesProvincias();
            this.cboProvincia.SelectedIndex = 7;

            //Cargo combo Localidades
            this.cboLocalidad.DisplayMember = "Localidad";
            this.cboLocalidad.ValueMember = "CodLocalidad";
            this.cboLocalidad.DataSource = objCliente.TraerClientesLocalidades(Convert.ToInt32(this.cboProvincia.SelectedValue));
            this.cboLocalidad.SelectedIndex = 5;

        }

        private void CargarLocalidades()
        {
            try
            {

                if (Convert.ToInt32(this.cboProvincia.SelectedValue) > 0)
                {
                    DBClientes objCliente = new DBClientes();
                    this.cboLocalidad.DisplayMember = "Localidad";
                    this.cboLocalidad.ValueMember = "CodLocalidad";
                    DataTable dt = objCliente.TraerClientesLocalidades(Convert.ToInt32(this.cboProvincia.SelectedValue));

                    this.cboLocalidad.DataSource = dt;

                    this.cboLocalidad.SelectedIndex = -1;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarLocalidades();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ControlarDatos())
            {
                GuardarDireccion();
                CargarDirecciones();
            }
            else
            {
                Alertas alert = new Alertas("Debe completar los datos para guardar la direccion.", "");
                alert.Show();
            }
        }

        private void CargarDirecciones()
        {
            DBClientes objCliente = new DBClientes();
            DGDirecciones.DataSource = objCliente.TraerDirecciones(this.codCliente);
            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            TxtDireccion.Text = "";
            this.cboProvincia.SelectedIndex = 7;
            this.cboLocalidad.SelectedIndex = 5;
        }

        private void GuardarDireccion()
        {
            DBClientes objCliente = new DBClientes();

            Alertas alert = new Alertas(objCliente.GuardarDireccion(this.codCliente,
                                                               cboProvincia.SelectedValue.ToString(),
                                                               cboLocalidad.SelectedValue.ToString(),
                                                               TxtDireccion.Text.Trim()), "");
            alert.Show();
        }

        private bool ControlarDatos()
        {
            if (cboProvincia.Text == "" &&
                cboLocalidad.Text == "")
            {
                return false;
            }

            return true;

        }

    }
}
