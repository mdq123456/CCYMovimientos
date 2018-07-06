using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCYMovimientos.Modelos.Configuracion
{
    class DBConfiguracion
    {
        private string config { set; get; }

        public DBConfiguracion(string pconfig)
        {
            config = pconfig;
        }
        
        public string TraerConfig()
        {
            string retorno = "";

            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.TraerConfig(config);
            if (unDato.HasRows)
            {
                unDato.Read();

                retorno = unDato["Valor"].ToString();

            }
            else
            {
                retorno = "";
            }

            objDC.cerrarConexion();
            return retorno;
        }

        
    }
}
