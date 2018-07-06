using CCYMovimientos.Modelos.Configuracion;
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
        private string strCodCuota;
        private bool bloquearCuota;
        decimal valorSena = 0;

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
            SetearConfiguracion();
            CargarCreditos();
            CargarFormasPago();
        }

        private void SetearConfiguracion()
        {
            bloquearCuota = false;

            DBConfiguracion objConfig = new DBConfiguracion("Bloquear_Cuotas");

            if (objConfig.TraerConfig() == "1")
            {
                bloquearCuota = true;
            }
            
        }

        private void CargarFormasPago()
        {
            //Cargo combo Metodos de Pago
            DBVentas objVenta = new DBVentas();
            this.cboFormaPago.DisplayMember = "FormaPago";
            this.cboFormaPago.ValueMember = "CodFormaPago";
            this.cboFormaPago.DataSource = objVenta.TraerMetPagos(valorSena);

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

            //return;

            DataTable sena = objCredito.TraerSena();
            
            if (sena.Rows.Count > 0)
            {
                foreach (DataRow fila in sena.Rows)
                {
                    valorSena = valorSena + Convert.ToDecimal(fila["Saldo"].ToString());
                }
                
                if (valorSena > 0)
                {
                    lblSena.Visible = true;
                    lblValorSena.Visible = true;
                    lblValorSena.Text = valorSena.ToString();
                }

            }


        }

        private void DestacarAnticipos()
        {

            DGCreditos.CurrentCell = null;

            string pcodCredito = "";

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
                    pcodCredito = row.Cells["CodCredito"].Value.ToString();
                    row.ReadOnly = false;
                }
                else if (pcodCredito == row.Cells["CodCredito"].Value.ToString() &&
                         bloquearCuota)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
                    row.ReadOnly = true;
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
            if (ControlarDatosGuardar() == false)
            {
                return;
            }

            string strFormasPago = GenerarstrFormasPago(); 

            DBCreditos objCredito = new DBCreditos(this.codCliente,
                                                   this.strCodCuota,
                                                   //TxtImporte.Text.Trim(),
                                                   txtPagos.Text.Trim(),
                                                   TxtSaldoTotal.Text.Trim(),
                                                   //cboFormaPago.SelectedValue.ToString(),
                                                   strFormasPago,
                                                   TxtCliente.Text,
                                                   cboFecha1.Value,
                                                    cboFecha2.Value,
                                                    TxtNroCheque.Text,
                                                    Txt1.Text,
                                                    Txt2.Text,
                                                    Txt4.Text);
            
            ////Sobrecargo el metodo para hacer pagos con señas
            //if (ChSena.Checked)
            //{
            //    sena = TxtSena.Text;
            //}

            Msj = objCredito.InsertarPago(TxtConcepto.Text,
                                          cboFechaPago.Value,
                                          cboVentas.SelectedValue.ToString());

            NroRecibo = objCredito.NroRecibo;

            this.Close();
        }

        private string GenerarstrFormasPago()
        {
            string strFormasPago = "";

            if (DGPagos.Rows.Count > 0)
            {
                DGPagos.CurrentCell = null;
                foreach (DataGridViewRow row in DGPagos.Rows)
                {
                    strFormasPago = strFormasPago + "|" + row.Cells["CodFormaPago"].Value.ToString() 
                                  + ";" + row.Cells["ImportePago"].Value.ToString() 
                                  + "$" + row.Cells["Banco"].Value.ToString() 
                                  + "@" + row.Cells["Beneficiario"].Value.ToString() 
                                  + "%" + row.Cells["FechaEmision"].Value.ToString() 
                                  + "#" + row.Cells["FechaCobro"].Value.ToString() 
                                  + "*" + row.Cells["NroCuenta"].Value.ToString() 
                                  + "?" + row.Cells["NroCheque"].Value.ToString();
                }
            }

            return strFormasPago;
        }

        private bool ControlarDatosGuardar()
        {
            Alertas alert;
            if (Convert.ToDecimal(txtPagos.Text.Trim()) <= 0 &&
                DGPagos.Rows.Count == 0)
            {
                alert = new Alertas("Ingrese una Forma de Pago para continuar.", "");
                alert.Show();
                return false;
            }

            return true;
        }

        private bool ControlarDatos()
        {
            Alertas alert;
            if (TxtImporte.Text.Trim() == "")
            {
                return false;
            }
            switch (Convert.ToInt32(cboFormaPago.SelectedValue))
            {
                //Efectivo
                case 1:
                    if (Convert.ToDecimal(TxtImporte.Text.Trim()) <= 0)
                    {
                        alert = new Alertas("Ingrese un importe mayor a 0.", "");
                        alert.Show();
                        return false;
                    }
                    break;
                //Tarjeta
                case 4:
                    //if (Convert.ToDecimal(TxtImporte.Text.Trim()) <= 0 )
                    //{
                    //    alert = new Alertas("Ingrese un importe mayor a 0.", "");
                    //    alert.Show();
                    //    return false;
                    //}
                    break;
                //Cheque
                case 5:
                    if (Convert.ToDecimal(TxtImporte.Text.Trim()) <= 0 ||
                        Txt1.Text.Trim() == "" ||
                        Txt4.Text.Trim() == "" ||
                        TxtNroCheque.Text.Trim() == "")
                    {
                        alert = new Alertas("Complete los datos para continuar.", "");
                        alert.Show();
                        return false;
                    }
                    break;
                //Cuenta Corriente
                case 6:

                    return false;
                    //break;
                //Transferencia Bancaria
                case 7:
                    if (Convert.ToDecimal(TxtImporte.Text.Trim()) <= 0 ||
                        Txt1.Text.Trim() == "" ||
                        Txt2.Text.Trim() == "" )
                    {
                        alert = new Alertas("Complete los datos para continuar.", "");
                        alert.Show();
                        return false;
                    }
                    break;
                //Seña
                case 10:
                    if (Convert.ToDecimal(TxtImporte.Text.Trim()) <= 0)
                    {
                        alert = new Alertas("Ingrese un importe mayor a 0.", "");
                        alert.Show();
                        return false;
                    }
                    else if (valorSena < Convert.ToDecimal(TxtImporte.Text.Trim()))
                    {
                        alert = new Alertas("El importe excede el saldo a favor.", "");
                        alert.Show();
                        return false;
                    }
                    break;
                //Bonificacion
                case 9:
                    if (Convert.ToDecimal(TxtImporte.Text.Trim()) <= 0)
                    {
                        alert = new Alertas("Ingrese un importe mayor a 0.", "");
                        alert.Show();
                        return false;
                    }
                    break;
                default:
                    break;
            }

            if (Convert.ToDecimal(TxtImporte.Text.Trim()) + Convert.ToDecimal(txtPagos.Text.Trim())
                > Convert.ToDecimal(TxtSaldoTotal.Text.Trim()))
            {
                alert = new Alertas("El importe excede el total del pago.", "");
                alert.Show();
                //return false;
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
                        //Efectivo
                        OcultarControles();
                        break;

                    case 4:
                        //Tarjeta
                        break;
                    case 5:
                        //Cheque
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
                        //Cuenta Corriente
                        break;
                    case 7:
                        //Transferencia Bancaria
                        OcultarControles();
                        lbl1.Visible = true;
                        Txt1.Visible = true;
                        lbl2.Text = "Nro Cuenta :";
                        lbl2.Visible = true;
                        Txt2.Visible = true;
                        break;
                    case 10:
                        //Seña
                        OcultarControles();
                        break;
                    case 9:
                        //Bonificacion
                        OcultarControles();
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

        private void DGCreditos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal totalAPagar = 0;
            
            DateTime fechaVencimiento = DateTime.Today;

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
                    if (row.DefaultCellStyle.BackColor != Color.Gray)
                    {
                        row.Cells[0].Value = !Convert.ToBoolean(row.Cells[0].Value);
                        
                    }
                }
            }

            this.strCodCuota = "";
            DGCreditos.CurrentCell = null;
            foreach (DataGridViewRow row in DGCreditos.Rows)
            {

                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    this.strCodCuota = this.strCodCuota + "|" + row.Cells["CodCuota"].Value.ToString();
                    totalAPagar = totalAPagar + Convert.ToDecimal(row.Cells["Saldo_Cuota"].Value.ToString());
                }

                
            }

            TxtSaldoTotal.Text = Convert.ToString(totalAPagar);
            TxtImporte.Text = TxtSaldoTotal.Text;
        }

        private void TraerSaldos()
        {
            decimal totalAPagar = 0;
            DGCreditos.CurrentCell = null;
            foreach (DataGridViewRow row in DGCreditos.Rows)
            {
                if (row.Cells[0].Value.ToString() == "1")
                {
                    totalAPagar = totalAPagar + Convert.ToDecimal(row.Cells["Saldo_Cuota"].Value.ToString());
                }
            }

            TxtSaldoTotal.Text = totalAPagar.ToString();

        }

        private void ChCostoAdicional_OnChange(object sender, EventArgs e)
        {
            CostoAdicional();
        }

        private void CostoAdicional()
        {
            TxtImporte.Text = "0";
            TxtSaldoTotal.Text = "0";

            if (ChCostoAdicional.Checked)
            {
                cboVentas.Visible = true;
                lblVenta.Visible = true;
                TxtImporte.Enabled = true;
                cboVentas.Enabled = true;
                TxtSaldoTotal.Enabled = true;

                DGCreditos.CurrentCell = null;
                foreach (DataGridViewRow row in DGCreditos.Rows)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                    if (row.Selected)
                    {
                        row.Cells[0].Value = 0;
                    }
                    this.strCodCuota = "";
                }
                DGCreditos.Enabled = false;

                TxtSaldoTotal.Focus();

                return;

            }
            else
            {
                DGCreditos.Enabled = true;
                cboVentas.Enabled = false;
                cboVentas.Visible = false;
                lblVenta.Visible = false;
                DestacarAnticipos();
                TxtSaldoTotal.Enabled = false;
            }
        }

        private void TxtImporte_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {

            if (!ControlarDatos())
            {
                return;
            }

            AgregarPago();

            SumarSaldos();

            MostrarTipoPago();

            LimpiarDatos();
            
        }

        private void LimpiarDatos()
        {
            decimal importeRestante = 0;

            importeRestante = Convert.ToDecimal(TxtSaldoTotal.Text.Trim())
                                - Convert.ToDecimal(txtPagos.Text.Trim());

            TxtImporte.Text = importeRestante.ToString();
            cboFormaPago.SelectedValue = 1;
            cboFecha1.Value = DateTime.Today;
            cboFecha2.Value = cboFecha1.Value.AddDays(30);
            TxtNroCheque.Text = "";
            Txt1.Text = "";
            Txt2.Text = "";
            Txt4.Text = "Construcciones NEA";
        }

        private void SumarSaldos()
        {
            decimal saldoPagos = 0;

            if (DGPagos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGPagos.Rows)
                {
                    saldoPagos = saldoPagos + Convert.ToDecimal(row.Cells["ImportePago"].Value.ToString());
                }
            }

            txtPagos.Text = saldoPagos.ToString();

        }

        private void AgregarPago()
        {
            switch (Convert.ToInt32(cboFormaPago.SelectedValue))
            {
                //Efectivo
                case 1:
                    
                    if (DGPagos.Rows.Count >0)
                    {
                        foreach (DataGridViewRow row in DGPagos.Rows)
                        {
                            if (row.Cells["CodFormaPago"].Value.ToString() == cboFormaPago.SelectedValue.ToString())
                            {
                                DGPagos.Rows.RemoveAt(row.Index);
                            }
                        }
                    }

                    DGPagos.Rows.Add("1", cboFormaPago.SelectedValue.ToString(), "Efectivo",TxtImporte.Text.Trim(),"","","","","","");

                    break;
                //Tarjeta
                case 4:
                    //OcultarControles();
                    break;
                //Cheque
                case 5:
                    //if (DGPagos.Rows.Count > 0)
                    //{
                    //    foreach (DataGridViewRow row in DGPagos.Rows)
                    //    {
                    //        if (row.Cells["CodFormaPago"].Value.ToString() == cboFormaPago.SelectedValue.ToString())
                    //        {
                    //            DGPagos.Rows.RemoveAt(row.Index);
                    //        }
                    //    }
                    //}

                    DGPagos.Rows.Add("1", cboFormaPago.SelectedValue.ToString(), "Cheque", TxtImporte.Text.Trim(), Txt1.Text.Trim(), Txt4.Text.Trim(), cboFecha1.Value, cboFecha2.Value, "", TxtNroCheque.Text.Trim());
                    
                    break;
                //Cuenta Corriente
                case 6:

                    break;
                //Transferencia Bancaria
                case 7:
                    //if (DGPagos.Rows.Count > 0)
                    //{
                    //    foreach (DataGridViewRow row in DGPagos.Rows)
                    //    {
                    //        if (row.Cells["CodFormaPago"].Value.ToString() == cboFormaPago.SelectedValue.ToString())
                    //        {
                    //            DGPagos.Rows.RemoveAt(row.Index);
                    //        }
                    //    }
                    //}

                    DGPagos.Rows.Add("1", cboFormaPago.SelectedValue.ToString(), "Transferencia Bancaria", TxtImporte.Text.Trim(), Txt1.Text.Trim(), "", "", "", Txt2.Text.Trim(), "");
                    break;
                //Seña
                case 10:
                    
                    if (DGPagos.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in DGPagos.Rows)
                        {
                            if (row.Cells["CodFormaPago"].Value.ToString() == cboFormaPago.SelectedValue.ToString())
                            {
                                DGPagos.Rows.RemoveAt(row.Index);
                            }
                        }
                    }

                    DGPagos.Rows.Add("1", cboFormaPago.SelectedValue.ToString(), "Seña", TxtImporte.Text.Trim(), "", "", "", "", "", "");
                    break;
                //Bonificacion
                case 9:
                    if (DGPagos.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in DGPagos.Rows)
                        {
                            if (row.Cells["CodFormaPago"].Value.ToString() == cboFormaPago.SelectedValue.ToString())
                            {
                                DGPagos.Rows.RemoveAt(row.Index);
                            }
                        }
                    }

                    DGPagos.Rows.Add("1", cboFormaPago.SelectedValue.ToString(), "Bonificacion", TxtImporte.Text.Trim(), "", "", "", "", "", "");
                    break;
                default:
                    break;
            }



        }

        private void MostrarTipoPago()
        {
            lbPagos.Visible = true;

            if (Convert.ToDecimal(TxtSaldoTotal.Text) == Convert.ToDecimal(txtPagos.Text))
            {
                lbPagos.Text = "Pagos Completados";
            }
            else if (Convert.ToDecimal(TxtSaldoTotal.Text) > Convert.ToDecimal(txtPagos.Text))
            {
                lbPagos.Text = "Pago Parcial";
            }
            else
            {
                lbPagos.Text = "";
            }
        }

        private void TxtSaldoTotal_OnValueChanged(object sender, EventArgs e)
        {
            if (ChCostoAdicional.Checked)
            {
                TxtImporte.Text = TxtSaldoTotal.Text  ;
            }
        }

        private void DGPagos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            SumarSaldos();

            MostrarTipoPago();

        }

        private void DGPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
