using CCYMovimientos.Modelos.Clientes;
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
    public partial class ClienteBusqueda : Form
    {
        private string codCliente;
        private string Nombre;
        public ClienteBusqueda()
        {
            InitializeComponent();
        }

        public string getCodCliente() {return this.codCliente;}
        public string getNombre() { return this.Nombre; }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {
            TxtBuscar.SelectionStart = 0;
            TxtBuscar.SelectionLength = TxtBuscar.Text.Length;
        }

        private void TxtBuscar_TextChanged(object sender = null, EventArgs e = null)
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

        private void ChEmpresas_OnChange(object sender, EventArgs e)
        {
            CargarClientes();
            TxtBuscar_TextChanged();
        }

        public void CargarClientes()
        {
            DBClientes objCliente = new DBClientes();
            DGClientes.DataSource = objCliente.TraerClientes(ChEmpresas.Checked);
        }

        private void ClienteBusqueda_Load(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            CargarClientes();
        }

        private void DGClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }

            DGClientes.CurrentCell = null;
            foreach (DataGridViewRow row in DGClientes.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    this.codCliente = row.Cells["Codigo"].Value.ToString();
                    this.Nombre = row.Cells["Nombre"].Value.ToString();
                    this.Close();
                    return;
                }
            }

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
