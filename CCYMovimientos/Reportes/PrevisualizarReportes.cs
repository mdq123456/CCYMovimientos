using CCYMovimientos.Reportes.Creditos;
using CCYMovimientos.Reportes.Fondos;
using CCYMovimientos.Reportes.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Reportes
{
    public partial class PrevisualizarReportes : Form
    {
        public string Codigo;
        public string Reporte;
        public PrevisualizarReportes()
        {
            InitializeComponent();
        }

        private void PrevisualizarReportes_Load(object sender, EventArgs e)
        {
            Previsualizar();
        }

        private void Previsualizar()
        {
            switch (Reporte)
            {
                case "ReciboDePagoCuota":
                    ReciboDePagoCuota objReporte = new ReciboDePagoCuota();
                    objReporte.SetParameterValue("@NroRecibo",Convert.ToInt32(Codigo));
                    crystalReportViewer1.ReportSource = objReporte;
                        break;
                case "ReporteMovCaja":
                    ReporteMovCaja objReport = new ReporteMovCaja();
                    objReport.SetParameterValue("@CodFondosMov", Convert.ToInt32(Codigo));
                    crystalReportViewer1.ReportSource = objReport;
                    break;
                case "ReporteAnulacion":
                    ReporteAnulacion objRepor = new ReporteAnulacion();
                    objRepor.SetParameterValue("@NroRecibo", Convert.ToInt32(Codigo));
                    crystalReportViewer1.ReportSource = objRepor;
                    break;
                default:
                    break;
            }
        }
    }
}
