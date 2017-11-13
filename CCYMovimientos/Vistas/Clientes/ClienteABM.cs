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
    public partial class ClienteABM : Form
    {
        Point posicion;
        Size dimension;
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
        }
        private void ChEmpresas_OnChange(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
