using CCYMovimientos.Modelos.Clientes;
using CCYMovimientos.Reportes;
using CCYMovimientos.Vistas.Creditos;
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

            DestacarMora();
        }

        private void DestacarMora()
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
        }
        private void ChEmpresas_OnChange(object sender, EventArgs e)
        {
            CargarClientes();
            TxtBuscar_OnTextChange();
        }

        private void TxtBuscar_OnTextChange(object sender = null, EventArgs e = null)
        {
            DGClientes.CurrentCell = null;
            foreach (DataGridViewRow row in DGClientes.Rows)
            {
                string mayus = row.Cells[0].Value.ToString().ToUpper();
                string mayus1 = row.Cells[1].Value.ToString().ToUpper();
                string mayus2 = row.Cells[2].Value.ToString().ToUpper();
                string mayus3 = row.Cells[3].Value.ToString().ToUpper();
                string mayus4 = row.Cells[4].Value.ToString().ToUpper();
                string mayus5 = row.Cells[5].Value.ToString().ToUpper();
                string mayus6 = row.Cells[6].Value.ToString().ToUpper();
                string mayus7 = row.Cells[7].Value.ToString().ToUpper();
                string mayus8 = row.Cells[8].Value.ToString().ToUpper();
                string mayus9 = row.Cells[9].Value.ToString().ToUpper();
                if (mayus.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1 ||
                    mayus1.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1 ||
                    mayus2.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1 ||
                    mayus3.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1 ||
                    mayus4.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1 ||
                    mayus5.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1 ||
                    mayus6.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1 ||
                    mayus7.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1 ||
                    mayus8.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1 ||
                    mayus9.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }

            }
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
                        bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                        bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                        bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                    }
                        
                    return;
                }
            }
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            ClienteNewEdit ClienteNewEditForm = new ClienteNewEdit(codCliente, ChEmpresas.Checked);
            ClienteNewEditForm.ShowDialog();
            CargarClientes();
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
    }
}
