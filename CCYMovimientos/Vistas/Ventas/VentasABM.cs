using CCYMovimientos.Modelos.Ventas;
using CCYMovimientos.Vistas.Clientes;
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

namespace CCYMovimientos.Vistas.Ventas
{
    public partial class VentasABM : Form
    {
        Point posicion;
        Size dimension;

        private string codCliente;
        public VentasABM(Point pPosicion, Size pDimension)
        {
            this.dimension = pDimension;
            this.posicion = pPosicion;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteBusqueda ClienteBusquedaForm = new ClienteBusqueda();
            ClienteBusquedaForm.ShowDialog();

            this.codCliente = ClienteBusquedaForm.getCodCliente();
            TxtCliente.Text = ClienteBusquedaForm.getNombre();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            ClienteNewEdit ClienteNewEditForm = new ClienteNewEdit();
            ClienteNewEditForm.ShowDialog();
        }

        private void VentasABM_Load(object sender, EventArgs e)
        {
            this.Size = this.dimension;
            this.Location = this.posicion;

            CargarComponentes();
        }

        private void CargarComponentes()
        {
            //Cargo combo Metodos de Pago
            DBVentas objVenta = new DBVentas();
            this.cboFormaPago.DisplayMember = "FormaPago";
            this.cboFormaPago.ValueMember = "CodFormaPago";
            this.cboFormaPago.DataSource = objVenta.TraerMetPagos();

            cboFecha1.Value = DateTime.Today;
            cboFecha2.Value = cboFecha1.Value.AddDays(30);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DBVentas objVentas = new DBVentas();

            Alertas alert = new Alertas(objVentas.GuardarVenta(this.codCliente,
                                                               TxtTotal.Text.Trim(),
                                                               TxtCuotas.Text.Trim(),
                                                               TxtCuotaPrecio.Text.Trim(),
                                                               TxtAnticipo.Text.Trim(),
                                                               cboFormaPago.SelectedValue.ToString(),
                                                               TxtConcepto.Text.Trim(),
                                                               cboFecha1.Value,
                                                               cboFecha2.Value,
                                                               TxtNroCheque.Text,
                                                               Txt1.Text,
                                                               Txt2.Text,
                                                               Txt4.Text), "");
            alert.Show();

            LimpiarDatos();

        }

        private void TxtCuotas_OnValueChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            this.codCliente = "";
            TxtCliente.Text = "";
            TxtConcepto.Text = "";
            TxtAnticipo.Text = "";

            Txt1.Text = "";
            Txt2.Text = "";
            Txt4.Text = "";

            TxtCuotaPrecio.Text = "0";
            TxtCuotas.Text = "1";
            TxtImporte.Text = "";
            TxtTotal.Text = "";

            cboFecha1.Value = DateTime.Today;
            cboFecha2.Value = cboFecha1.Value.AddDays(30);

        }

        private void TxtImporte_OnValueChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            decimal n;

            if (TxtCuotas.Text != "0" &&
                decimal.TryParse(TxtCuotas.Text, out n) &&
                decimal.TryParse(TxtImporte.Text, out n) &&
                TxtImporte.Text != "0" &&
                decimal.TryParse(TxtCuotaPrecio.Text, out n) &&
                TxtCuotaPrecio.Text != "")
            {
                decimal importe = Convert.ToDecimal(TxtImporte.Text.Trim());
                decimal cuotas = Convert.ToDecimal(TxtCuotas.Text.Trim());
                
                if (TxtAnticipo.Text != "")
                {
                    decimal anticipo = Convert.ToDecimal(TxtAnticipo.Text.Trim());
                    importe = importe - anticipo;
                }

                TxtCuotaPrecio.Text = Convert.ToString(importe / cuotas);

                TxtTotal.Text = TxtImporte.Text;
            }
        }

        private void TxtAnticipo_OnValueChanged(object sender, EventArgs e)
        {
            Calcular();
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

        private void TxtCuotaPrecio_OnValueChanged(object sender, EventArgs e)
        {
            decimal n;

            if (TxtAnticipo.Text.Trim() == "")
            {
                TxtAnticipo.Text = "0";
            }

            if (TxtCuotas.Text != "0" &&
                decimal.TryParse(TxtCuotas.Text, out n) &&
                decimal.TryParse(TxtImporte.Text, out n) &&
                TxtImporte.Text != "0" &&
                decimal.TryParse(TxtCuotaPrecio.Text, out n) &&
                TxtCuotaPrecio.Text != "")
            {

                TxtTotal.Text = Convert.ToString((Convert.ToDecimal(TxtCuotaPrecio.Text) * Convert.ToDecimal(TxtCuotas.Text))+ Convert.ToDecimal(TxtAnticipo.Text));

            }

        }

    }
}
