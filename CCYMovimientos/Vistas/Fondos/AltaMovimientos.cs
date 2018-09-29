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
        public string sena;
        public int CodCliente;
        public string CodMovimiento;
        public bool CHKCheque;
        public string getMsj() { return this.Msj; }

        public AltaMovimientos(string pTipo)
        {
            this.TipoMov = pTipo;
            sena = "";
            InitializeComponent();
        }

        public AltaMovimientos(string pTipo, string pConcepto,int pCodCliente)
        {
            InitializeComponent();
            this.TipoMov = pTipo;
            string concep = "Seña de " + pConcepto;
            TxtConcepto.Text = concep;
            TxtConcepto.Enabled = false;
            sena = "1";
            CodCliente = pCodCliente;
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

            DGCheques.DataSource = objFondos.TraerCheques();

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

        private bool ControlarDatosGuardar()
        {
            CHKCheque = true;
            //Egreso de cheques
            if (Convert.ToInt32(cboTipoMov.SelectedValue) == 6)
            {
                DGCheques.CurrentCell = null;
                foreach (DataGridViewRow row in DGCheques.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        CHKCheque = false;
                        break;
                    }
                }
            }

            Alertas alert;
            if (TxtImporte.Text.Trim() == "" && CHKCheque)
            {
                alert = new Alertas("Ingrese un Importe para continuar.", "");
                alert.Show();
                return false;
            }
            else if (CHKCheque)
            {
                if (Convert.ToDecimal(TxtImporte.Text.Trim()) <= 0 && CHKCheque)
                {
                    alert = new Alertas("Ingrese un Importe para continuar.", "");
                    alert.Show();
                    return false;
                }
            }
            
            if (TxtConcepto.Text.Trim() == "")
            {
                alert = new Alertas("Ingrese un Concepto para continuar.", "");
                alert.Show();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ControlarDatosGuardar() == false)
            {
                return;
            }

            string strCodCheques = GenerarstrCodCheques();

            InsertarMovimientos(TxtConcepto.Text,
                            cboTipoMov.SelectedValue.ToString(),
                            TxtImporte.Text,
                            cboFecha1.Value,
                            cboFecha2.Value,
                            TxtNroCheque.Text,
                            Txt1.Text,
                            Txt2.Text,
                            Txt4.Text,
                            strCodCheques);

            this.Close();
        }

        private string GenerarstrCodCheques()
        {
            string strCodCheques = "";
            DGCheques.CurrentCell = null;
            foreach (DataGridViewRow row in DGCheques.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    strCodCheques = strCodCheques + "|" + row.Cells["Cod"].Value.ToString();
                }
            }

            return strCodCheques;
        }

        private void InsertarMovimientos(string pConcepto, string ptipoMov, 
                                        string pimporte,
                                        DateTime pfechaEmision, DateTime pfechaCobro,
                                        string pnroCheque, string pbanco, string pcuenta,
                                        string pbeneficiario, string strCodCheques)
        {
            DBFondos objFondo = new DBFondos(pConcepto,
                                             ptipoMov,
                                             pimporte,
                                             pfechaEmision,
                                             pfechaCobro,
                                             pnroCheque,
                                             pbanco,
                                             pcuenta,
                                             pbeneficiario);
            if (sena == "1")
            {
                objFondo.setSena(sena,CodCliente);
            }

            this.Msj = objFondo.InsertarMov(strCodCheques);
            this.CodMovimiento = objFondo.CodMovimiento;

        }

        private void cboTipoMov_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTipoMov.ValueMember != "")
            {
                switch (Convert.ToInt32(cboTipoMov.SelectedValue))
                {
                    //Efectivo
                    case 1:
                        OcultarControles();
                        break;
                    case 2:
                        OcultarControles();
                        break;
                    //Cheque
                    case 5:
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
                        panelSombra.Visible = true;
                        panelCheques.Visible = true;
                        break;
                    //Transferencia Bancaria
                    case 7:
                        OcultarControles();
                        lbl1.Visible = true;
                        Txt1.Visible = true;
                        lbl2.Text = "Nro Cuenta :";
                        lbl2.Visible = true;
                        Txt2.Visible = true;
                        break;
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

            panelSombra.Visible = false;
            panelCheques.Visible = false;
        }

        private void DGCheques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }

            DGCheques.CurrentCell = null;
            foreach (DataGridViewRow row in DGCheques.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    row.Cells[0].Value = !Convert.ToBoolean(row.Cells[0].Value);
                    break;   
                }
            }
        }
    }
}
