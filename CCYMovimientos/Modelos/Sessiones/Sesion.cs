using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCYMovimientos.Modelos.Sessiones
{
    public class Sesion
    {
        private int codUsuario { set; get; }
        private string usuario { set; get; }
        private string pass { set; get; }
        private int codRol { set; get; }
        private string rol { set; get; }
        private string msj { set; get; }

        public Sesion(string pUsuario, string pPass)
        {
            this.usuario = pUsuario;
            this.pass = pPass;
        }
        private void setMsj(string pMsj){this.msj = pMsj;}
        private void setPass(string pPass) { this.pass = pPass; }
        private void setCodRol(int pCodRol) { this.codRol = pCodRol; }
        private void setUsuario(string pUsuario) { this.usuario = pUsuario; }
        private void setCodUsuario(int pCodUsuario) { this.codUsuario = pCodUsuario; }
        
        public string Ingresar()
        {
            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.Ingresar(this.usuario, this.pass);
            if (unDato.HasRows)
            {
                unDato.Read();

                this.setMsj(unDato["msj"].ToString());
                this.setCodUsuario(Convert.ToInt32(unDato["codUsuario"].ToString()));
                this.setUsuario(unDato["Usuario"].ToString());
                this.setCodRol(Convert.ToInt32(unDato["codRol"].ToString()));
                this.setPass("");
                objDC.cerrarConexion();
                return this.msj;

            }
            objDC.cerrarConexion();
            return "Usuario y/o contraseña NO válidos !";
            
        }

        
    }
}
