using CCYMovimientos.Modelos.Creditos;
using CCYMovimientos.Modelos.Sessiones;
using CCYMovimientos.Modelos.Ventas;
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

namespace CCYMovimientos.Vistas.Creditos
{
    public partial class PagosClientesCreditos : Form
    {
        private string codCliente;
        public string Msj;
        public string NroRecibo;
        private string strCodPago;

        public PagosClientesCreditos(string pCodCliente, string Nombre)
        {
            InitializeComponent();
            this.codCliente = pCodCliente;
            TxtCliente.Text = Nombre;
            Msj = "";
            NroRecibo = "";
        }

        private void PagosClientesCreditos_Load(object sender, EventArgs e)
        {
            CargarFormasPago();
            CargarCreditos();
        }

        private void CargarFormasPago()
        {
            //Cargo combo Metodos de Pago
            DBVentas objVenta = new DBVentas();
            this.cboFormaPago.DisplayMember = "FormaPago";
            this.cboFormaPago.ValueMember = "CodFormaPago";
            this.cboFormaPago.DataSource = objVenta.TraerMetPagos();

        }

        private void CargarCreditos()
        {
            DBCreditos objCredito = new DBCreditos(this.codCliente);
            DGCreditos.DataSource = objCredito.TraerCreditos();

            DestacarAnticipos();

            cboFecha1.Value = DateTime.Today;
            cboFecha2.Value = cboFecha1.Value.AddDays(30);
            cboFechaPago.Value = DateTime.Today;

            this.cboVentas.DisplayMember = "Venta";
            this.cboVentas.ValueMember = "CodCredito";
            this.cboVentas.DataSource = objCredito.TraerVentas();

        }

        private void DestacarAnticipos()
        {

            DGCreditos.CurrentCell = null;

            if (ChCostoAdicional.Checked)
            {
                foreach (DataGridViewRow row in DGCreditos.Rows)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                }

                return;
            }

            DateTime fechaVencimiento;

            foreach (DataGridViewRow row in DGCreditos.Rows)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

                if (row.Cells["TipoCuota"].Value.ToString() == "Anticipo")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(106)))), ((int)(((byte)(27)))));
                }
                if (row.Cells["FechaVencimiento"].Value.ToString().Trim() != "")
                {
                    fechaVencimiento = Convert.ToDateTime(row.Cells["FechaVencimiento"].Value.ToString().Trim());
                    if (fechaVencimiento < DateTime.Today)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen;
                    }
                    fechaVencimiento = fechaVencimiento.AddDays(30);
                    if (fechaVencimiento < DateTime.Today)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ControlarDatos() == false)
            {
                return;
            }

            DBCreditos objCredito = new DBCreditos(this.codCliente,
                                                   this.strCodPago,
                                                   TxtImporte.Text.Trim(),
                                                   cboFormaPago.SelectedValue.ToString(),
                                                   TxtCliente.Text,
                                                   cboFecha1.Value,
                                                    cboFecha2.Value,
                                                    TxtNroCheque.Text,
                                                    Txt1.Text,
                                                    Txt2.Text,
                                                    Txt4.Text);

            Msj = objCredito.InsertarPago(TxtConcepto.Text,
                                          cboFechaPago.Value,
                                          cboVentas.SelectedValue.ToString());
            NroRecibo = objCredito.NroRecibo;

            this.Close();
        }

        private bool ControlarDatos()
        {
            Alertas alert;

            if (TxtImporte.Text.Trim() == "0" && ChCostoAdicional.Checked == false)
            {
                alert = new Alertas("Ingrese un importe mayor a 0.", "");
                alert.Show();
                return false;
            }

            if (ChCostoAdicional.Checked == false)
            {
                DGCreditos.CurrentCell = null;
                foreach (DataGridViewRow row in DGCreditos.Rows)
                {

                    //Si es cuota normal
                    if (row.Cells[0].Value.ToString() == "1" &&
                        row.Cells["NroCuota"].Value.ToString() != "0" &&
                        (Convert.ToDecimal(TxtImporte.Text.Trim()) <
                        Convert.ToDecimal(TxtSaldoTotal.Text.Trim())))
                    {
                        alert = new Alertas("No puede realizar un pago parcial de una cuota vencida.", "");
                        alert.Show();
                        return false;
                    }

                }
            }            

            return true;
        }

        private void cboFormaPago_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboFormaPago.ValueMember != "")
            {
                switch (Convert.ToInt32(cboFormaPago.SelectedValue))
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
            Txt4.Visible = false;
            TxtNroCheque.Visible = false;

            cboFecha1.Visible = false;
            cboFecha2.Visible = false;
        }

        private void ChActivo_OnChange(object sender, EventArgs e)
        {
            if (Sesion.codRol == 1)
            {
                if (ChActivo.Checked)
                {
                    TxtImporte.Enabled = true;
                }
                else
                {
                    TxtImporte.Enabled = false;
                }
            }
        }

        private void DGCreditos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal totalAPagar = 0;
            string NroCuota = "";
            string CodCredito = "";
            this.strCodPago = "";
            DateTime fechaVencimiento = DateTime.Today;
            TxtImporte.Enabled = false;

            DestacarAnticipos();

            if (!(e.RowIndex > -1))
            {
                CargarCreditos();
                TxtSaldoTotal.Text = Convert.ToString(totalAPagar);
                TxtImporte.Text = TxtSaldoTotal.Text;
                return;
            }

            DGCreditos.CurrentCell = null;
            foreach (DataGridViewRow row in DGCreditos.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    CodCredito = row.Cells["CodCredito"].Value.ToString();

                }
            }

            DGCreditos.CurrentCell = null;
            foreach (DataGridViewRow row in DGCreditos.Rows)
            {
                row.Cells[0].Value = 0;
                if (row.DefaultCellStyle.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(118)))), ((int)(((byte)(13))))))
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                }
                
                if (row.Cells["CodCredito"].Value.ToString() == CodCredito)
                {
                    this.strCodPago = this.strCodPago + "|" + row.Cells["CodCuota"].Value.ToString();
                    totalAPagar = totalAPagar + Convert.ToDecimal(row.Cells["Saldo_Cuota"].Value.ToString());
                    row.Cells[0].Value = 1;
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(118)))), ((int)(((byte)(13)))));

                    NroCuota = row.Cells["NroCuota"].Value.ToString();

                    if (row.Cells["FechaVencimiento"].Value.ToString().Trim() != "")
                    {
                        fechaVencimiento = Convert.ToDateTime(row.Cells["FechaVencimiento"].Value.ToString());
                    }
                    row.Selected = true;
                    CodCredito = "0";
                }
            }

            if (this.strCodPago != "")
            {
                this.strCodPago = this.strCodPago.Substring(1);

                if (NroCuota == "0")
                {
                    TxtImporte.Enabled = true;
                    TxtImporte.Focus();
                }

                if (fechaVencimiento < DateTime.Today)
                {
                    TxtImporte.Enabled = true;
                    TxtImporte.Focus();
                }

            }

            TxtSaldoTotal.Text = Convert.ToString(totalAPagar);
            TxtImporte.Text = TxtSaldoTotal.Text;
        }

        private void ChCostoAdicional_OnChange(object sender, EventArgs e)
        {
            CostoAdicional();
        }

        private void CostoAdicional()
        {
            TxtImporte.Text = "0";
            if (ChCostoAdicional.Checked)
            {
                cboVentas.Visible = true;
                lblAdicional.Visible = true;
                ChActivo.Checked = true;
                TxtImporte.Enabled = true;
                cboVentas.Enabled = true;
                
                DGCreditos.CurrentCell = null;
                foreach (DataGridViewRow row in DGCreditos.Rows)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                    if (row.Selected)
                    {
                        row.Cells[0].Value = 0;
                    }
                    this.strCodPago = "";
                }
                DGCreditos.Enabled = false;
                
                return;

            }
            else
            {
                ChActivo.Checked = false;
                DGCreditos.Enabled = true;
                cboVentas.Enabled = false;
                cboVentas.Visible = false;
                lblAdicional.Visible = false;
                DestacarAnticipos();
            }
        }

        private void TxtImporte_OnValueChanged(object sender, EventArgs e)
        {
            if (ChCostoAdicional.Checked)
            {
                TxtSaldoTotal.Text = TxtImporte.Text;
            }
        }
    }
}
