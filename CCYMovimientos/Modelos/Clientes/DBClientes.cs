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
            DataCenter.abrirConexion();
            DataTable tabla = DataCenter.TraerClientes(tipoCliente);
            DataCenter.cerrarConexion();

            return tabla;
        }

        public DataTable TraerClientesTipos()
        {
            DataCenter.abrirConexion();
            DataTable tabla = DataCenter.TraerClientesTipos();
            DataCenter.cerrarConexion();

            return tabla;

        }

        public DataTable TraerClientesProvincias()
        {
            DataCenter.abrirConexion();
            DataTable tabla = DataCenter.TraerClientesProvincias();
            DataCenter.cerrarConexion();

            return tabla;
        }
        public DataTable TraerClientesLocalidades(int codProvincia)
        {
            DataCenter.abrirConexion();
            DataTable tabla = DataCenter.TraerClientesLocalidades(codProvincia);
            DataCenter.cerrarConexion();

            return tabla;
        }

        public bool CrearCliente()
        {
            bool varResultado;
            DataCenter.abrirConexion();

            SqlDataReader resultado = DataCenter.CrearCliente(Apellidos,
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

            DataCenter.cerrarConexion();

            return varResultado;
        }
    }
}
