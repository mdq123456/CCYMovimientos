using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCYMovimientos.Modelos.Ventas
{
    class DBVentas
    {


        public DataTable TraerMetPagos()
        {
            try
            {
                DataCenter objDC = new DataCenter();
                DataTable tabla = objDC.TraerMetPagos();
                objDC.cerrarConexion();

                return tabla;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public string GuardarVenta(string pCodCliente, string pTotal,
                                    string pCuotas, string pCuota, string pAnticipo,
                                    string pCodFormaPago, string pConcepto)
        {
            string retorno = "";

            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.GuardarVenta(pCodCliente,pTotal,
                                                      pCuotas,pCuota,pAnticipo,
                                                      pCodFormaPago,pConcepto);
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
