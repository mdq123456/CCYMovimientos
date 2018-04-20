using CCYMovimientos.Modelos.Creditos;
using CCYMovimientos.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Vistas.Creditos
{
    public partial class HistorialPagos : Form
    {
        private string codCliente { set; get; }
        private string codRecibo { set; get; }
        public HistorialPagos(string pCodCliente, string Nombre)
        {
            InitializeComponent();
            this.codCliente = pCodCliente;
            TxtCliente.Text = Nombre;
        }

        private void HistorialPagos_Load(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void CargarPagos()
        {
            DBCreditos objCredito = new DBCreditos(this.codCliente);
            DGPagos.DataSource = objCredito.TraerPagos();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReImprimir_Click(object sender, EventArgs e)
        {
            if (codRecibo != "")
            {
                PrevisualizarReportes ViewReport = new PrevisualizarReportes();
                ViewReport.Codigo = codRecibo;
                ViewReport.Reporte = "ReciboDePagoCuota";
                ViewReport.Show();
            }
        }

        private void DGPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se pulsa e el header el RowIndex sera menos a menos
            if (!(e.RowIndex > -1))
            {
                btnReImprimir.Enabled = false;
                codRecibo = "";
                return;
            }
            DGPagos.CurrentCell = null;
            foreach (DataGridViewRow row in DGPagos.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    btnReImprimir.Enabled = true;
                    codRecibo = row.Cells["NroRecibo"].Value.ToString();
                    
                    row.Selected = true;
                    break;
                }
            }
        }


    }
}
