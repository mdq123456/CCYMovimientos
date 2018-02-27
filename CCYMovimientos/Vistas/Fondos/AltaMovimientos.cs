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
    public partial class AltaMovimientos : Form
    {
        private string TipoMov;
        private string Msj;
        public string CodMovimiento;
        public string getMsj() { return this.Msj; }

        public AltaMovimientos(string pTipo)
        {
            this.TipoMov = pTipo;
            InitializeComponent();
        }

        private void AltaMovimientos_Load(object sender, EventArgs e)
        {
            cargarComponentes();
        }

        private void cargarComponentes()
        {
            //Cargo combo Tipo Clientes
            DBFondos objFondos = new DBFondos();
            cboTipoMov.DataSource = objFondos.TraerTiposMov(this.TipoMov);
            cboTipoMov.DisplayMember = "TipoMov";
            cboTipoMov.ValueMember = "CodTipoMov";

            cboFecha1.Value = DateTime.Today;
            cboFecha2.Value = cboFecha1.Value.AddDays(30);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Msj = "";
            this.CodMovimiento = "";
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Msj = "";
            this.CodMovimiento = "";
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DBFondos objFondo = new DBFondos(TxtConcepto.Text,
                                             cboTipoMov.SelectedValue.ToString(),
                                             TxtImporte.Text,
                                             cboFecha1.Value,
                                             cboFecha2.Value,
                                             TxtNroCheque.Text,
                                             Txt1.Text,
                                             Txt2.Text,
                                             Txt4.Text);

            this.Msj = objFondo.InsertarMov();
            this.CodMovimiento = objFondo.CodMovimiento;
            this.Close();

        }

        private void cboTipoMov_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTipoMov.ValueMember != "")
            {
                switch (Convert.ToInt32(cboTipoMov.SelectedValue))
                {
                    case 1:
                    case 2:
                        OcultarControles();
                        break;
                    case 5:
                    case 6:
                        OcultarControles();
                        lbl1.Visible = true;
                        lbl2.Text = "Fecha de Emision :";
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        Txt1.Visible = true;
                        Txt4.Visible = true;
                        cboFecha1.Visible = true;
                        cboFecha2.Visible = true;
                        lbl5.Visible = true;
                        TxtNroCheque.Visible = true;
                        break;
                    case 7:
                    case 8:
                        OcultarControles();
                        lbl1.Visible = true;
                        Txt1.Visible = true;
                        lbl2.Text = "Nro Cuenta :";
                        lbl2.Visible = true;
                        Txt2.Visible = true;
                        break;
                    default:
                        break;
                }
            }
            
        }

        private void OcultarControles()
        {
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            Txt1.Visible = false;
            Txt2.Visible = false;
            Txt3.Visible = false;
            Txt4.Visible = false;
            TxtNroCheque.Visible = false;

            cboFecha1.Visible = false;
            cboFecha2.Visible = false;
        }

    }
}
