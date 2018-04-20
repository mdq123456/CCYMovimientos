using CCYMovimientos.Modelos.Fondos;
using CCYMovimientos.Modelos.Registros;
using CCYMovimientos.Modelos.Sessiones;
using CCYMovimientos.Reportes;
using CCYMovimientos.Vistas.Notificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Vistas.Fondos
{
    public partial class FondosCaja : Form
    {
        Point posicion;
        Size dimension;
        string codFondosMov;
        DataTable rsMov;

        public FondosCaja(Point pPosicion, Size pDimension)
        {
            this.dimension = pDimension;
            this.posicion = pPosicion;
            InitializeComponent();
        }

        private void FondosCaja_Load(object sender, EventArgs e)
        {
            this.Size = this.dimension;
            this.Location = this.posicion;

            cboFechaMov.Value = DateTime.Today;

            CargarMovimientos();
        }

        public void CargarMovimientos()
        {
            DBFondos objFondo = new DBFondos();
            rsMov = objFondo.TraerMovimientos(cboFechaMov.Value,
                                            chEfectivo.Checked,
                                            chTrans.Checked,
                                            ChCheques.Checked);
            DGMovimientos.DataSource = rsMov;

            decimal ingresos = 0;
            decimal egresos = 0;
            decimal apertura = 0;
            decimal total = 0;
            foreach (DataGridViewRow row in DGMovimientos.Rows)
            {
                if (row.Cells["Tipo_Movimiento"].Value.ToString().Substring(0,6).Trim() == "Ingres")
                {
                    ingresos = ingresos + Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                }
                if (row.Cells["Tipo_Movimiento"].Value.ToString().Substring(0, 6).Trim() == "Egreso")
                {
                    egresos = egresos + Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                }
                if (row.Cells["Tipo_Movimiento"].Value.ToString().Substring(0, 6).Trim() == "Apertu")
                {
                    apertura = Convert.ToDecimal(row.Cells["Importe"].Value.ToString());
                }
            }
            
            lblApertura.Text = apertura.ToString("C1", CultureInfo.CurrentCulture);
            lblIngresos.Text = ingresos.ToString("C1", CultureInfo.CurrentCulture);
            lblEgresos.Text = egresos.ToString("C1", CultureInfo.CurrentCulture);
            total = (ingresos - egresos + apertura);
            lblTotal.Text = total.ToString("C1", CultureInfo.CurrentCulture);

        }

        private void cboFechaMov_onValueChanged(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            DBFondos objFondo = new DBFondos();
            Alertas alert = new Alertas(objFondo.AbrirCaja(),"");
            alert.Show();
            CargarMovimientos();
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            IngresoDatos objMsj = new IngresoDatos("Cierre de Caja", "Importe Cierre");
            objMsj.ShowDialog();

            if (objMsj.getTexto1() != "")
            {
                DBFondos objFondo = new DBFondos();
                Alertas alert = new Alertas(objFondo.CerrarCaja(Convert.ToDecimal(objMsj.getTexto1().Trim())), "");
                alert.Show();
                CargarMovimientos();
            }
            
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            FormAltaMov("Ingreso");
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            FormAltaMov("Egreso");
        }

        private void FormAltaMov(string tipoMov)
        {
            AltaMovimientos AltaMovForm = new AltaMovimientos(tipoMov);
            AltaMovForm.ShowDialog();

            if (AltaMovForm.CodMovimiento != "")
            {
                PrevisualizarReportes ViewReport = new PrevisualizarReportes();
                ViewReport.Codigo = AltaMovForm.CodMovimiento;
                ViewReport.Reporte = "ReporteMovCaja";
                ViewReport.Show();
            }

            CargarMovimientos();

            if (AltaMovForm.getMsj() != "")
            {
                Alertas alert = new Alertas(AltaMovForm.getMsj(), "");
                alert.Show();
            }
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            cboFechaMov.Value = cboFechaMov.Value.AddDays(-1);
        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            cboFechaMov.Value = cboFechaMov.Value.AddDays(1);
        }

        private void chEfectivo_OnChange(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

        private void chTrans_OnChange(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

        private void ChCheques_OnChange(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

        private void DGMovimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1) || Sesion.codRol == 2)
            {
                return;
            }

            DGMovimientos.CurrentCell = null;
            foreach (DataGridViewRow row in DGMovimientos.Rows)
            {
                if (row.Index == e.RowIndex)
                {

                    if (row.Cells["Tipo_Movimiento"].Value.ToString().Substring(0, 6).Trim() == "Apertu")
                    {
                        return;
                    }

                    codFondosMov = row.Cells["Codigo"].Value.ToString();
                    string pInfo = row.Cells["Concepto"].Value.ToString();
                    string pregunta;
                    pregunta = "¿Desea anular el movimiento de caja numero " + codFondosMov + "?";

                    PreguntaRespuesta pForm = new PreguntaRespuesta("Anular Movimiento",
                                                                    pregunta,
                                                                    pInfo,
                                                                    "NO",
                                                                    "SI");

                    pForm.ShowDialog();

                    if (pForm.SIoNO == "1")
                    {
                        DBRegistros objRegistro = new DBRegistros(codFondosMov,
                                                                  "Fondos_Mov",
                                                                  pForm.concepto,
                                                                  "CodFondoMov");

                        Alertas alert = new Alertas(objRegistro.AnularRegistro(), "");
                        alert.Show();

                        if (objRegistro.getCodigo() != "")
                        {
                            PrevisualizarReportes ViewReport = new PrevisualizarReportes();
                            ViewReport.Codigo = objRegistro.getCodigo();
                            ViewReport.Reporte = "ReporteAnulacion";
                            ViewReport.Show();
                        }

                        CargarMovimientos();
                    }

                    this.codFondosMov = "";
                    return;
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

            (DGMovimientos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Concepto Like '%{0}%' or Tipo_Movimiento Like '%{0}%'", TxtBuscar.Text.Trim().ToUpper());

        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {
            TxtBuscar.SelectionStart = 0;
            TxtBuscar.SelectionLength = TxtBuscar.Text.Length;
        }
    }
}
