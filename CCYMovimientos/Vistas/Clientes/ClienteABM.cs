using CCYMovimientos.Modelos.Clientes;
using CCYMovimientos.Vistas.Creditos;
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

        public ClienteABM(Point pPosicion, Size pDimension)
        {
            this.dimension = pDimension;
            this.posicion = pPosicion;
            InitializeComponent();
        }

        private void ClienteABM_Load(object sender, EventArgs e)
        {
            this.Size = this.dimension;
            this.Location = this.posicion;
            CargarClientes();
        }

        public void CargarClientes()
        {
            DBClientes objCliente = new DBClientes();
            DGClientes.DataSource = objCliente.TraerClientes(ChEmpresas.Checked);
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
                string mayus = row.Cells[1].Value.ToString().ToUpper();
                if (mayus.IndexOf(TxtBuscar.Text.Trim().ToUpper()) != -1)
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
                btnContacto.Visible = false;
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

                    btnEditCliente.Visible = true;
                    btnHistorialPago.Visible = true;
                    btnContacto.Visible = true;
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
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            ClientesLlamadas ClientesLlamadasForm = new ClientesLlamadas(codCliente, lblNombre.Text);
            ClientesLlamadasForm.ShowDialog();
        }
    }
}
