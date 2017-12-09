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
    public partial class ClienteNewEdit : Form
    {
        string codCliente;
        bool tipoCliente;
        public ClienteNewEdit()
        {
            InitializeComponent();
            codCliente = "0";
        }

        public ClienteNewEdit(string pCodCliente, bool ptipoCliente)
        {
            InitializeComponent();
            codCliente = pCodCliente;
            tipoCliente = ptipoCliente;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClienteNewEdit_Load(object sender, EventArgs e)
        {
            cargarComponentes();

            panel4.Dock = DockStyle.Fill;

            if (codCliente != "0")
            {

                cargarCliente();
            }
            
        }

        private void cargarCliente()
        {
            panel4.Visible = false;
            panel5.Dock = DockStyle.Fill;
            panel5.Visible = true;

            DBClientes objCliente = new DBClientes();
            DataTable tabla = objCliente.TraerClientes(tipoCliente,codCliente);

            DataRow row = tabla.Rows[0];
            cboTipoCliente.SelectedValue = Convert.ToInt32( row["CodClienteTipo"].ToString());
            if (row["CodProvincia"].ToString() != "")
            {
                cboProvincia.SelectedValue = Convert.ToInt32(row["CodProvincia"].ToString());
            }
            if (row["CodLocalidad"].ToString() != "")
            {
                cboLocalidad.SelectedValue = Convert.ToInt32(row["CodLocalidad"].ToString());
            }
            
            TxtNombres.Text = row["Nombres"].ToString();
            TxtApellidos.Text = row["Apellidos"].ToString();
            TxtDNI.Text = row["DNI"].ToString();
            if (row["CUIL"].ToString() != "")
            {
                String value = row["CUIL"].ToString();
                Char delimiter = '-';
                String[] substrings = value.Split(delimiter);
                int contar = 1;
                foreach (var substring in substrings)
                {
                    switch (contar)
                    {
                        case 1:
                            TxtCUILIzq.Text = substring;
                            break;
                        case 2:
                            TxtCUIL.Text = substring;
                            break;
                        case 3:
                            TxtCUILDer.Text = substring;
                            break;
                        default:
                            break;
                    }
                    contar = contar + 1;
                }
                
            }
            
            TxtTel.Text = row["TelCelular"].ToString();
            TxtDireccion.Text = row["Domicilio"].ToString();
            TxtEmail.Text = row["Email"].ToString();

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

        private void cargarComponentes()
        {
            //Cargo combo Tipo Clientes
            DBClientes objCliente = new DBClientes();
            this.cboTipoCliente.DisplayMember = "TipoCliente";
            this.cboTipoCliente.ValueMember = "CodClienteTipo";
            this.cboTipoCliente.DataSource = objCliente.TraerClientesTipos();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ControlarDatos())
            {
                GuardarCliente();
                this.Close();
            }
            else
            {
                Alertas alert = new Alertas("Debe completar los datos para guardar el cliente.", "");
                alert.Show();
            }
        }

        private void GuardarCliente()
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
                                                   TxtDireccion.Text,
                                                   codCliente.ToString());
            if (objCliente.GuardarCliente())
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
    }
}
