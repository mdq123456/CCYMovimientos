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
        }

        private void ClienteBusqueda_Load(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            CargarClientes();
            DestacarMora();
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
