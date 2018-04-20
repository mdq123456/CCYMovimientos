using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCYMovimientos.Modelos.Creditos
{
    class DBCreditos
    {
        private string codCliente { set; get; }
        private string NombreCliente { set; get; }
        private string strCodPago { set; get; }
        private string importe { set; get; }
        private string codFormaPago { set; get; }
        private DateTime fechaEmision { set; get; }
        private DateTime fechaCobro { set; get; }
        private string nroCheque { set; get; }
        private string banco { set; get; }
        private string cuenta { set; get; }
        private string beneficiario { set; get; }

        public string NroRecibo;

        public DBCreditos(string pCodCliente)
        {
            this.codCliente = pCodCliente;
        }

        public DataTable TraerPagos()
        {
            try
            {
                DataCenter objDC = new DataCenter();
                DataTable tabla = objDC.TraerPagos(this.codCliente);
                objDC.cerrarConexion();

                return tabla;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public DBCreditos(string pCodCliente, string pstrCodPago,string pimporte,
                            string pcodFormaPago, string pNombreCliente,
                            DateTime pfechaEmision, DateTime pfechaCobro,
                            string pnroCheque, string pbanco, string pcuenta,
                            string pbeneficiario)
        {
            this.codCliente = pCodCliente;
            this.strCodPago = pstrCodPago;
            this.importe = pimporte;
            this.codFormaPago = pcodFormaPago;
            this.NombreCliente = pNombreCliente;
            this.fechaEmision = pfechaEmision;
            this.fechaCobro = pfechaCobro;
            this.nroCheque = pnroCheque;
            this.banco = pbanco;
            this.cuenta = pcuenta;
            this.beneficiario = pbeneficiario;
        }

        public DataTable TraerVentas()
        {
            try
            {
                DataCenter objDC = new DataCenter();
                DataTable tabla = objDC.TraerVentas(this.codCliente);
                objDC.cerrarConexion();

                return tabla;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable TraerCreditos()
        {
            try
            {
                DataCenter objDC = new DataCenter();
                DataTable tabla = objDC.TraerCreditos(this.codCliente);
                objDC.cerrarConexion();

                return tabla;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public string InsertarPago(string pConcepto, DateTime pfechaPago,
                                   string pCodCredito)
        {
            string retorno;
            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.InsertarPago(this.codCliente,
                                                      this.codFormaPago,
                                                      this.importe,
                                                      this.strCodPago,
                                                      this.NombreCliente,
                                                      this.fechaEmision,
                                                        this.fechaCobro,
                                                        this.nroCheque,
                                                        this.banco,
                                                        this.cuenta,
                                                        this.beneficiario,
                                                        pConcepto,
                                                        pfechaPago,
                                                        pCodCredito);
            if (unDato.HasRows)
            {
                unDato.Read();

                retorno = unDato["Msj"].ToString();
                NroRecibo = unDato["NroRecibo"].ToString();
            }
            else
            {
                retorno = "No se pudo realizar la operacion, comuniquese con su administrador.";
            }
            objDC.cerrarConexion();
            return retorno;
        }
    }
}
