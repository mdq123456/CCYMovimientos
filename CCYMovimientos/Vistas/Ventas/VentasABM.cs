using CCYMovimientos.Modelos.Contratos;
using CCYMovimientos.Modelos.Fondos;
using CCYMovimientos.Modelos.Ventas;
using CCYMovimientos.Vistas.Clientes;
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
            DBContratos objVenta = new DBContratos();
            this.cboContratoTipo.DisplayMember = "Contrato";
            this.cboContratoTipo.ValueMember = "CodContrato";
            this.cboContratoTipo.DataSource = objVenta.TraerContratosTipos();

        }

        private bool ControlarDatos()
        {
            if (this.codCliente == "" ||
                TxtCliente.Text == "" ||
                TxtTotal.Text == "" ||
                TxtAnticipo.Text == "" ||
                TxtCuotas.Text == "" ||
                TxtCuotaPrecio.Text == "" ||
                TxtMT2.Text == "" ||
                TxtMT2Precio.Text == "" ||
                TxtSaldo.Text == "" ||
                TxtContratoTipo.Text == "" ||
                TxtConcepto.Text == "")
            {
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DBFondos objFondo = new DBFondos();
            Alertas alert;

            string msj = objFondo.AbrirCaja();
            
            if (msj != "La operación se completó con éxito !" &&
                msj != "La caja ya se encuentra abierta.")
            {
                alert = new Alertas("Abra la caja para poder realizar la venta.", "");
                alert.Show();
                return;
            }

            if (ControlarDatos() == false)
            {
                alert = new Alertas("Complete todos los datos para realizar la venta.", "");
                alert.Show();
                return;
            }

            DBVentas objVentas = new DBVentas();

            alert = new Alertas(objVentas.GuardarVenta(this.codCliente,
                                                        TxtTotal.Text.Trim(),
                                                        TxtCuotas.Text.Trim(),
                                                        TxtCuotaPrecio.Text.Trim(),
                                                        TxtAnticipo.Text.Trim(),
                                                        TxtContratoTipo.Text.Trim(),
                                                        TxtConcepto.Text.Trim(),
                                                        TxtMT2.Text,
                                                        TxtMT2Precio.Text), "");
            alert.Show();

            LimpiarDatos();

        }

        private void TxtCuotas_OnValueChanged(object sender, EventArgs e)
        {
            //Calcular();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            this.codCliente = "";
            TxtCliente.Text = "";

            TxtTotal.Text = "";
            TxtAnticipo.Text = "0";
            
            TxtCuotas.Text = "1";
            TxtCuotaPrecio.Text = "";

            TxtMT2.Text = "";
            TxtMT2Precio.Text = "";
            TxtSaldo.Text = "";

            TxtConcepto.Text = "";

            TxtContratoTipo.Text = "";
        }

        private void TxtImporte_OnValueChanged(object sender, EventArgs e)
        {
            //Calcular();
        }

        private void Calcular()
        {
            decimal n;

            if (TxtCuotas.Text != "0" &&
                decimal.TryParse(TxtCuotas.Text, out n) &&
                decimal.TryParse(TxtSaldo.Text, out n) &&
                TxtSaldo.Text != "0" &&
                decimal.TryParse(TxtCuotaPrecio.Text, out n) &&
                TxtCuotaPrecio.Text != "")
            {
                decimal importe = Convert.ToDecimal(TxtSaldo.Text.Trim());
                decimal cuotas = Convert.ToDecimal(TxtCuotas.Text.Trim());
                
                if (TxtAnticipo.Text != "")
                {
                    decimal anticipo = Convert.ToDecimal(TxtAnticipo.Text.Trim());
                    importe = importe - anticipo;
                }

                n = (importe / cuotas);
                
                TxtCuotaPrecio.Text = n.ToString("N1");

                TxtTotal.Text = TxtSaldo.Text;
            }
        }

        private void cboFormaPago_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void OcultarControles()
        {
            
        }

        private void TxtCuotaPrecio_OnValueChanged(object sender, EventArgs e)
        {
            

        }

        private void CalcularSaldo()
        {
            decimal n;
            bool isNumeric = decimal.TryParse(TxtTotal.Text, out n);

            n = 0;

            if (TxtTotal.Text != "" &&
                TxtAnticipo.Text != "" &&
                isNumeric)
            {
                n = Convert.ToDecimal(TxtTotal.Text) - Convert.ToDecimal(TxtAnticipo.Text);
            }

            TxtSaldo.Text = n.ToString("N1", CultureInfo.CurrentCulture);
        }

        private void TxtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) 
                && (e.KeyChar != (char)Keys.Back)
                && (e.KeyChar != 46)
                && (e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

        }

        private void TxtAnticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar))
                && (e.KeyChar != (char)Keys.Back)
                && (e.KeyChar != 46)
                && (e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtTotal_OnValueChanged(object sender, EventArgs e)
        {
            CalcularSaldo();
        }

        private void TxtAnticipo_OnValueChanged(object sender, EventArgs e)
        {
            CalcularSaldo();
        }
    }
}
