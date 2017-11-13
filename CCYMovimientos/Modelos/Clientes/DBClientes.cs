using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCYMovimientos.Modelos.Clientes
{
    class DBClientes
    {
        private int codCliente { set; get; }
        private string Apellidos { set; get; }
        private string Nombres { set; get; }
        private string CUIL { set; get; }
        private string DNI { set; get; }
        private string codTipoCliente { set; get; }
        private string Telefono { set; get; }
        private string Email { set; get; }
        private string codProvincia { set; get; }
        private string codLocalidad { set; get; }
        private string Domicilio { set; get; }
        

        public DBClientes()
        {
            
        }
        public DBClientes(string pApellidos, string pNombres,
                          string pCUIL, string pDNI, string pcodTipoCliente,
                          string pTelefono, string pEmail, string pcodProvincia,
                          string pCodLocalidad, string pDomicilio)
        {
            Apellidos = pApellidos;
            Nombres = pNombres;
            CUIL = pCUIL;
            DNI = pDNI;
            codTipoCliente = pcodTipoCliente;
            Telefono = pTelefono;
            Email = pEmail;
            codProvincia = pcodProvincia;
            codLocalidad = pCodLocalidad;
            Domicilio = pDomicilio; 
        }

        public DataTable TraerClientes(bool tipoCliente)
        {
            try
            {
                DataCenter objDC = new DataCenter();
                DataTable tabla = objDC.TraerClientes(tipoCliente);
                objDC.cerrarConexion();

                return tabla;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        public DataTable TraerClientesTipos()
        {
            try { 
            DataCenter objDC = new DataCenter();
            DataTable tabla = objDC.TraerClientesTipos();
            objDC.cerrarConexion();

            return tabla;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable TraerClientesProvincias()
        {
            try { 
            DataCenter objDC = new DataCenter();
            DataTable tabla = objDC.TraerClientesProvincias();
            objDC.cerrarConexion();

            return tabla;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public DataTable TraerClientesLocalidades(int codProvincia)
        {
            try { 
            DataCenter objDC = new DataCenter();
            DataTable tabla = objDC.TraerClientesLocalidades(codProvincia);
            objDC.cerrarConexion();

            return tabla;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public bool CrearCliente()
        {
            bool varResultado;
            try { 
                DataCenter objDC = new DataCenter();

                SqlDataReader resultado = objDC.CrearCliente(Apellidos,
                                                                  Nombres,
                                                                  CUIL,
                                                                  DNI,
                                                                  codTipoCliente,
                                                                  Telefono,
                                                                  Email,
                                                                  codProvincia,
                                                                  codLocalidad,
                                                                  Domicilio);
            
                if (resultado.HasRows)
                {
                    resultado.Read();

                    if (resultado[0].ToString() == "1")
                    {
                        varResultado = true;
                    }
                    else
                    {
                        varResultado = false;
                    }
                }
                else
                {
                    varResultado = false;
                }

                objDC.cerrarConexion();

                return varResultado;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
