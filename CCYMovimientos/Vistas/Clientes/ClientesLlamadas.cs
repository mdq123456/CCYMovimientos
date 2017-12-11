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
    public partial class ClientesLlamadas : Form
    {
        private string codCliente;
        public ClientesLlamadas(string pcodCliente,
                                string pNombre)
        {
            InitializeComponent();

            this.codCliente = pcodCliente;
            TxtCliente.Text = pNombre;
        }

        private void ClientesLlamadas_Load(object sender, EventArgs e)
        {
            cboFecha2.Value = DateTime.Today;
            CargarLlamadas();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TxtConcepto.Text = "";
            cboFecha2.Value = DateTime.Today;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ControlarDatos())
            {
                GuardarLlamada();
                CargarLlamadas();
            }
        }

        private void CargarLlamadas()
        {
            DBClientes objCliente = new DBClientes();
            DGLlamadas.DataSource = objCliente.TraerLlamadas(this.codCliente);
        }

        private void GuardarLlamada()
        {
            DBClientes objCliente = new DBClientes();

            Alertas alert = new Alertas(objCliente.GuardarLlamada(this.codCliente,
                                                               cboFecha2.Value,
                                                               TxtConcepto.Text.Trim()), "");
            alert.Show();

            TxtConcepto.Text = "";
            cboFecha2.Value = DateTime.Today;
        }

        private bool ControlarDatos()
        {
            if (TxtConcepto.Text.Trim() == "")
            {
                Alertas alert = new Alertas("Debe completar los datos para guardar la llamada.", "");
                alert.Show();
                return false;
            }
            return true;
        }

        private void DGLlamadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGLlamadas.CurrentCell = null;
            foreach (DataGridViewRow row in DGLlamadas.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    TxtConcepto.Text = row.Cells["Conversacion"].Value.ToString();
                    cboFecha2.Value = Convert.ToDateTime(row.Cells["FechaLlamada"].Value.ToString());

                    return;
                }
            }
        }
    }
}
