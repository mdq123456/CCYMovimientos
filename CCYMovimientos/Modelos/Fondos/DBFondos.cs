using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCYMovimientos.Modelos.Fondos
{
    public class DBFondos
    {
        private int codFondo { set; get; }

        public DBFondos()
        {
            
        }
        
        public string AbrirCaja()
        {
            string retorno ="";

            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.AbrirCaja();
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

        public DataTable TraerMovimientos(DateTime fechaMov)
        {
            DataCenter objDC = new DataCenter();
            DataTable tabla = objDC.TraerMovmientos(fechaMov);
            objDC.cerrarConexion();
            return tabla;
        }

        public string CerrarCaja(decimal pImporte)
        {
            string retorno = "";

            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.CerrarCaja(pImporte);
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
