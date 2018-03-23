using CCYMovimientos.Modelos.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Vistas.Ventas
{
    public partial class HistorialVentas : Form
    {
        public HistorialVentas()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboFechaHasta_onValueChanged(object sender, EventArgs e)
        {
            CargarHVentas();
        }

        public void CargarHVentas()
        {
            DBVentas objVentas = new DBVentas();
            DGHVentas.DataSource = objVentas.TraerHVentas(cboFechaDesde.Value,
                                                          cboFechaHasta.Value);
        }

        private void cboFechaDesde_onValueChanged(object sender, EventArgs e)
        {
            CargarHVentas();
        }

        private void HistorialVentas_Load(object sender, EventArgs e)
        {
            cboFechaDesde.Value = DateTime.Today;
            cboFechaHasta.Value = DateTime.Today;
        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {
            TxtBuscar.SelectionStart = 0;
            TxtBuscar.SelectionLength = TxtBuscar.Text.Length;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DGHVentas.CurrentCell = null;
            foreach (DataGridViewRow row in DGHVentas.Rows)
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
    }
}
