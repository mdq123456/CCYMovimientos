using CCYMovimientos.Modelos.Clientes;
using CCYMovimientos.Reportes;
using CCYMovimientos.Vistas.Creditos;
using CCYMovimientos.Vistas.Fondos;
using CCYMovimientos.Vistas.Notificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Vistas.Clientes
{
    public partial class ClienteABM : Form
    {
        Point posicion;
        Size dimension;
        private string codCliente;
        private string estado;

        public ClienteABM(Point pPosicion, Size pDimension)
        {
            this.dimension = pDimension;
            this.posicion = pPosicion;
            InitializeComponent();
        }

        private void ClienteABM_Load(object sender, EventArgs e)
        {
            Posicionar();
            //CargarClientes();
        }

        private void Posicionar()
        {
            this.Size = this.dimension;
            this.Location = this.posicion;
        }

        public void CargarClientes()
        {
            DBClientes objCliente = new DBClientes();
            DGClientes.DataSource = objCliente.TraerClientes(ChEmpresas.Checked);
        }

        public void DestacarMora()
        {
            DGClientes.CurrentCell = null;
            foreach (DataGridViewRow row in DGClientes.Rows)
            {
                if (row.Cells["Estado"].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                }
                
            }

            if (estado == "False")
            {
                bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            ClienteNewEdit ClienteNewEditForm = new ClienteNewEdit();
            ClienteNewEditForm.ShowDialog();
            CargarClientes();
            DestacarMora();
        }
        private void ChEmpresas_OnChange(object sender, EventArgs e)
        {
            CargarClientes();
            TxtBuscar_OnTextChange();
        }

        private void TxtBuscar_OnTextChange(object sender = null, EventArgs e = null)
        {
            if (ChEmpresas.Checked == true)
            {
                (DGClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("RazonSocial Like '%{0}%' or Nombre Like '%{0}%' or Identificacion Like '%{0}%' or TelCelular Like '%{0}%' or TelFijo Like '%{0}%' or Domicilio Like '%{0}%' or Localidad Like '%{0}%' or email Like '%{0}%'", TxtBuscar.Text.Trim().ToUpper());
            }
            else
            {
                (DGClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre Like '%{0}%' or Identificacion Like '%{0}%' or CUIL Like '%{0}%' or TelCelular Like '%{0}%' or TelFijo Like '%{0}%' or Domicilio Like '%{0}%' or Localidad Like '%{0}%' or email Like '%{0}%'", TxtBuscar.Text.Trim().ToUpper());
            }
            DestacarMora();
        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {
            TxtBuscar.SelectionStart = 0;
            TxtBuscar.SelectionLength = TxtBuscar.Text.Length;
        }

        private void DGClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se pulsa e el header el RowIndex sera menos a menos
            if (!(e.RowIndex > -1))
            {
                btnEditCliente.Visible = false;
                btnHistorialPago.Visible = false;
                btnLlamadas.Visible = false;
                btnContactos.Visible = false;
                btnDirecciones.Visible = false;
                btnSena.Visible = false;
                btnHistorialPagos.Visible = false;
                return;
            }
            DGClientes.CurrentCell = null;
            foreach (DataGridViewRow row in DGClientes.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    codCliente = row.Cells["Codigo"].Value.ToString();
                    lblNombre.Text = row.Cells["Nombre"].Value.ToString();
                    lblDoc.Text = row.Cells["Identificacion"].Value.ToString();
                    lblEmail.Text = row.Cells["Email"].Value.ToString();
                    lblDireccion.Text = row.Cells["Domicilio"].Value.ToString();
                    lblTel.Text = row.Cells["TelCelular"].Value.ToString();
                    lblFijo.Text = row.Cells["TelFijo"].Value.ToString();
                    estado = row.Cells["Estado"].Value.ToString();

                    if (estado == "True")
                    {
                        btnEditCliente.Visible = true;
                        btnHistorialPago.Visible = true;
                        btnLlamadas.Visible = true;
                        btnContactos.Visible = true;
                        btnDirecciones.Visible = true;
                        btnSena.Visible = true;
                        bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
                        bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
                        bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
                        
                    }
                    else
                    {
                        btnEditCliente.Visible = true;
                        btnHistorialPago.Visible = false;
                        btnLlamadas.Visible = false;
                        btnContactos.Visible = false;
                        btnDirecciones.Visible = false;
                        btnSena.Visible = false;
                        bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                        bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                        bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                    }
                    btnHistorialPagos.Visible = true;
                    row.Selected = true; 
                    break;
                }
            }

            

        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            ClienteNewEdit ClienteNewEditForm = new ClienteNewEdit(codCliente, ChEmpresas.Checked);
            ClienteNewEditForm.ShowDialog();
            CargarClientes();
            DestacarMora();
        }

        private void btnHistorialPago_Click(object sender, EventArgs e)
        {
            PagosClientesCreditos PagosCreditosForm = new PagosClientesCreditos(codCliente, lblNombre.Text);
            PagosCreditosForm.ShowDialog();

            if (PagosCreditosForm.Msj != "")
            {
                Alertas alert;
                alert = new Alertas(PagosCreditosForm.Msj, "");
                alert.Show();

                if (PagosCreditosForm.NroRecibo != "")
                {
                    PrevisualizarReportes ViewReport = new PrevisualizarReportes();
                    ViewReport.Codigo = PagosCreditosForm.NroRecibo;
                    ViewReport.Reporte = "ReciboDePagoCuota";
                    ViewReport.Show();
                }

            }
            
            
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            ClientesLlamadas ClientesLlamadasForm = new ClientesLlamadas(codCliente, lblNombre.Text);
            ClientesLlamadasForm.ShowDialog();
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            ClientesContactos ClientesContactosForm = new ClientesContactos(codCliente, lblNombre.Text);
            ClientesContactosForm.ShowDialog();
        }

        private void btnDirecciones_Click(object sender, EventArgs e)
        {
            ClientesDirecciones ClientesDireccionesForm = new ClientesDirecciones(codCliente, lblNombre.Text);
            ClientesDireccionesForm.ShowDialog();
        }

        private void DGClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HistorialPagos PagosCreditosForm = new HistorialPagos(codCliente, lblNombre.Text);
            PagosCreditosForm.ShowDialog();
        }

        private void btnSena_Click(object sender, EventArgs e)
        {
            AltaMovimientos movForm = new AltaMovimientos("Ingreso", lblNombre.Text,Convert.ToInt32(codCliente));

            movForm.ShowDialog();
        }

        private void btnHistorialPagos_Click(object sender, EventArgs e)
        {
            if (lblNombre.Text == "Cliente X")
            {
                return;
            }

            HistorialPagos PagosCreditosForm = new HistorialPagos(codCliente, lblNombre.Text);
            PagosCreditosForm.ShowDialog();
        }
    }
}
