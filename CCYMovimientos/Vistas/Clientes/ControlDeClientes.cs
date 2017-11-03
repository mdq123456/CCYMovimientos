using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCYMovimientos.Modelos.Clientes;

namespace CCYMovimientos.Vistas.Clientes
{
    public partial class ControlDeClientes : UserControl
    {

        private string status { set; get; }
        public string getStatus() { return this.status; }
        public void cambiarStatus(string p_status)
        {
            this.status = p_status;
        }

        public ControlDeClientes()
        {
            InitializeComponent();
            this.status = "V";
        }
        //METODOS
        private void OcultarFormulario(string p_status)
        {
            this.status = p_status;
            this.Hide();
        }
        //EVENTOS
        private void ControlDeClientes_Load(object sender, EventArgs e)
        {
            this.CargarClientes();
        }

        public void CargarClientes()
        {
            DBClientes objCliente = new DBClientes();
            DGClientes.DataSource = objCliente.TraerClientes(ChEmpresas.Checked);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            OcultarFormulario("N");
        }

        private void ChEmpresas_OnChange(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
