using CCYMovimientos.Modelos.Creditos;
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

namespace CCYMovimientos.Vistas.Creditos
{
    public partial class PagosClientesCreditos : Form
    {
        private string codCliente;
        private string Msj;
        private string strCodPago;

        public PagosClientesCreditos(string pCodCliente, string Nombre)
        {
            InitializeComponent();
            this.codCliente = pCodCliente;
            TxtCliente.Text = Nombre;
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGCreditos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal totalAPagar = 0;
            this.strCodPago = "";

            DGCreditos.CurrentCell = null;
            foreach (DataGridViewRow row in DGCreditos.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    this.strCodPago = this.strCodPago + "|" + row.Cells["CodPago"].Value.ToString();
                    totalAPagar = totalAPagar + Convert.ToDecimal(row.Cells["Saldo_Cuota"].Value.ToString());
                }
            }

            this.strCodPago = this.strCodPago.Substring(1);
            TxtSaldoTotal.Text = Convert.ToString(totalAPagar);
            TxtImporte.Text = TxtSaldoTotal.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DBCreditos objCredito = new DBCreditos(this.codCliente,
                                                   this.strCodPago,
                                                   TxtImporte.Text.Trim(),
                                                   cboFormaPago.SelectedValue.ToString(),
                                                   TxtCliente.Text);

            this.Msj = objCredito.InsertarPago();
            this.Close();
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
            Txt4.Visible = false;
            TxtNroCheque.Visible = false;

            cboFecha1.Visible = false;
            cboFecha2.Visible = false;
        }

    }
}
