using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCYMovimientos.Modelos.Registros
{
    class DBRegistros
    {
        private string codigo { set; get; }
        private string tabla { set; get; }
        private string concepto { set; get; }
        private string codigoReferencia { set; get; }

        public DBRegistros()
        {

        }

        public DBRegistros(string pCodigo, string pTabla, string pConcepto, string pcodigoReferencia)
        {
            codigo = pCodigo;
            tabla = pTabla;
            concepto = pConcepto;
            codigoReferencia = pcodigoReferencia;
        }

        public string getCodigo()
        {
            return codigo;
        }

        public string AnularRegistro()
        {
            string retorno;
            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.AnularRegistro(codigo,tabla,concepto,codigoReferencia);
            retorno = "No se pudo realizar la operacion, comuniquese con su administrador.";
            codigo = "";

            if (unDato != null)
            {
                if (unDato.HasRows)
                {
                    unDato.Read();

                    retorno = unDato["Msj"].ToString();

                    if (unDato["Codigo"].ToString() != "")
                    {
                        codigo = unDato["Codigo"].ToString();
                    }
                }
            }
            
            objDC.cerrarConexion();
            return retorno;

        }

    }
}
