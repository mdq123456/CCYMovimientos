using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCYMovimientos.Modelos.Contratos
{
    class DBContratos
    {
        private string codContrato { set; get; }

        public DBContratos()
        {

        }

        public DataTable TraerContratosTipos()
        {
            try
            {
                DataCenter objDC = new DataCenter();
                DataTable tabla = objDC.TraerContratosTipos();
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
