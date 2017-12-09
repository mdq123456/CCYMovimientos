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

        public DBCreditos(string pCodCliente)
        {
            this.codCliente = pCodCliente;
        }
        public DBCreditos(string pCodCliente, string pstrCodPago,string pimporte,
                            string pcodFormaPago, string pNombreCliente)
        {
            this.codCliente = pCodCliente;
            this.strCodPago = pstrCodPago;
            this.importe = pimporte;
            this.codFormaPago = pcodFormaPago;
            this.NombreCliente = pNombreCliente;
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

        public string InsertarPago()
        {
            string retorno;
            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.InsertarPago(this.codCliente,
                                                      this.codFormaPago,
                                                      this.importe,
                                                      this.strCodPago,
                                                      this.NombreCliente);
            if (unDato.HasRows)
            {
                unDato.Read();

                retorno = unDato["Msj"].ToString();

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
