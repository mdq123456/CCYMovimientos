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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DBVentas objVentas = new DBVentas();

            string Concepto = TxtConcepto.Text.Trim();
            Concepto = Concepto.Replace("\n", " | ");

            Alertas alert = new Alertas(objVentas.GuardarVenta(this.codCliente,
                                                               TxtTotal.Text.Trim(),
                                                               TxtCuotas.Text.Trim(),
                                                               TxtCuotaPrecio.Text.Trim(),
                                                               TxtAnticipo.Text.Trim(),
                                                               cboFormaPago.SelectedValue.ToString(),
                                                               TxtConcepto.Text.Trim()), "");
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
            TxtCuotaPrecio.Text = "";
            TxtCuotas.Text = "1";
            TxtImporte.Text = "";
            TxtTotal.Text = "";
        }

        private void TxtImporte_OnValueChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if (TxtCuotas.Text != "1" &&
                TxtCuotas.Text != "" &&
                TxtImporte.Text != "")
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
    }
}
