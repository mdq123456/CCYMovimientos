using CCYMovimientos.Modelos.Fondos;
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

namespace CCYMovimientos.Vistas.Fondos
{
    public partial class FondosCaja : Form
    {
        Point posicion;
        Size dimension;
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
            DGMovimientos.DataSource = objFondo.TraerMovimientos(cboFechaMov.Value);
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
    }
}
