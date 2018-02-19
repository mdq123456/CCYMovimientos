using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCYMovimientos.Modelos.Contactos
{
    class DBContactos
    {

        private string codigo { set; get; }
        private string entidad { set; get; }

        public DBContactos(string pcodigo, string pentidad)
        {
            codigo = pcodigo;
            entidad = pentidad;
        }

        public object TraerTelefonos()
        {
            try
            {
                DataCenter objDC = new DataCenter();
                DataTable tabla = objDC.TraerTelefonos(codigo,entidad);
                objDC.cerrarConexion();

                return tabla;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public string GuardarEmail(string pemail)
        {
            string retorno = "";

            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.GuardarEmail(codigo,entidad,pemail);
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

        public string GuardarTelefonos(string pcelular, string pTelFijo)
        {
            string retorno = "";

            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.GuardarTelefonos(codigo, entidad, pcelular,pTelFijo);
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

        public object TraerEmails()
        {
            try
            {
                DataCenter objDC = new DataCenter();
                DataTable tabla = objDC.TraerEmails(codigo, entidad);
                objDC.cerrarConexion();

                return tabla;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
