using CCYMovimientos.Modelos.Sessiones;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCYMovimientos.Modelos
{
    public class DataCenter
    {
        private SqlDataReader unDataReader;
        private SqlConnection con;
        private SqlCommand cmd;

        public DataCenter()
        {
            this.con = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString());
        }

        public  void abrirConexion()
        {
            try
            {
                this.con.Open();
                return;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        

        public  System.Data.ConnectionState abrirConexion(int bandera)
        {
            try
            {
                this.con.Open();
                return con.State;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
              
        }

        

        public  void cerrarConexion()
        {
            try
            {
                this.con.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public  SqlDataReader Ingresar(string pUsuario, string pPass)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_SESIONES_Ingresar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = pUsuario;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20).Value = pPass;

                //Parametro de retorno
                //SqlParameter paramCodRetorno = new SqlParameter("@codRetorno", SqlDbType.VarChar, 150);
                //paramCodRetorno.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(paramCodRetorno);

                //ejecucion del comando.
                //cmd.ExecuteNonQuery();

                //return paramCodRetorno.Value.ToString();
                unDataReader = cmd.ExecuteReader();
                return unDataReader;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        //Clientes***********************************************
        public SqlDataReader GuardarLlamada(string pcodCliente, DateTime pFechaLlamada, string pConcepto)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CLIENTES_Nueva_Llamada", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@codCliente", SqlDbType.Int).Value = Convert.ToInt32(pcodCliente);
                cmd.Parameters.Add("@fechaLlamada", SqlDbType.SmallDateTime).Value = pFechaLlamada;
                cmd.Parameters.Add("@Concepto", SqlDbType.VarChar).Value = pConcepto;
                

                unDataReader = cmd.ExecuteReader();
                return unDataReader;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public SqlDataReader GuardarDireccion(string pcodCliente, 
                                                string pcodProvincia, 
                                                string pCodLocalidad, 
                                                string pDomicilio, 
                                                string pentidad)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_DOMICILIOS_Nuevo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = Convert.ToInt32(pcodCliente);
                cmd.Parameters.Add("@entidad", SqlDbType.VarChar,100).Value = pentidad;
                cmd.Parameters.Add("@CodLocalidad", SqlDbType.VarChar, 20).Value = pCodLocalidad;
                cmd.Parameters.Add("@Domicilio", SqlDbType.VarChar, 20).Value = pDomicilio;

                unDataReader = cmd.ExecuteReader();
                return unDataReader;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable TraerDirecciones(string pcodigo, string pentidad)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_DOMICILIOS_Traer", con);
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = Convert.ToInt32(pcodigo);
                cmd.Parameters.Add("@entidad", SqlDbType.VarChar,100).Value = pentidad;

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ClientesDirecciones");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable TraerLlamadas(string pcodCliente)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CLIENTE_Traer_Llamadas", con);
                cmd.Parameters.Add("@codCliente", SqlDbType.Int).Value = Convert.ToInt32(pcodCliente);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ClientesLlamadas");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }


        }

        public  DataTable TraerClientes(bool tipoCliente,string codCliente = "0")
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CLIENTE_Traer", con);
                cmd.Parameters.Add("@codCliente", SqlDbType.Int).Value = Convert.ToInt32(codCliente);
                cmd.Parameters.Add("@tipoCliente", SqlDbType.Bit).Value = tipoCliente;

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ClientesLocalidades");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            

        }

        public  DataTable TraerClientesTipos()
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CLIENTE_Traer_Tipos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ClientesTipos");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            

        }

        public  DataTable TraerClientesLocalidades(int codProvincia)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CLIENTE_Traer_Localidades", con);
                cmd.Parameters.Add("@CodProvincia", SqlDbType.Int).Value = codProvincia;

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ClientesLocalidades");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        public  DataTable TraerClientesProvincias()
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CLIENTE_Traer_Provincias", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ClientesProvincias");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        public  SqlDataReader GuardarCliente(string pApellidos, string pNombres,
                                              string pCUIL, string pDNI, string pcodTipoCliente,
                                              string pTelefono, string pTelFijo, 
                                              string pEmail, string pcodProvincia,
                                              string pCodLocalidad, string pDomicilio,
                                              string pcodCliente)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CLIENTE_Nuevo_Editar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar, 150).Value = pApellidos;
                cmd.Parameters.Add("@Nombres", SqlDbType.VarChar, 150).Value = pNombres;
                cmd.Parameters.Add("@CUIT", SqlDbType.NVarChar, 15).Value = pCUIL;
                cmd.Parameters.Add("@DNI", SqlDbType.NVarChar, 13).Value = pDNI;
                cmd.Parameters.Add("@CodTipoCliente", SqlDbType.Int).Value = Convert.ToInt32(pcodTipoCliente);
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 20).Value = pTelefono;
                cmd.Parameters.Add("@TelFijo", SqlDbType.VarChar, 20).Value = pTelFijo;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 150).Value = pEmail;
                cmd.Parameters.Add("@CodProvincia", SqlDbType.VarChar, 20).Value = pcodProvincia;
                cmd.Parameters.Add("@CodLocalidad", SqlDbType.VarChar, 20).Value = pCodLocalidad;
                cmd.Parameters.Add("@Domicilio", SqlDbType.VarChar, 20).Value = pDomicilio;
                cmd.Parameters.Add("@CodCliente", SqlDbType.Int).Value = Convert.ToInt32(pcodCliente);
                cmd.Parameters.Add("@codLogin", SqlDbType.Int).Value = Sesion.codUsuario;

                unDataReader = cmd.ExecuteReader();
                return unDataReader;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        //Clientes***********************************************


        //Fondos*************************************************
        public SqlDataReader AbrirCaja()
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_FONDOS_Abrir_Caja", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@codLogin", SqlDbType.Int).Value = Sesion.codUsuario;

                SqlDataReader unDataReader = cmd.ExecuteReader();

                return unDataReader;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            

        }

        public SqlDataReader CerrarCaja(decimal pImporte)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_FONDOS_Cerrar_Caja", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@importe", SqlDbType.Decimal).Value = pImporte;
                cmd.Parameters.Add("@codLogin", SqlDbType.Int).Value = Sesion.codUsuario;

                SqlDataReader unDataReader = cmd.ExecuteReader();

                return unDataReader;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            

        }
        public DataTable TraerFondosMov(string pTipo)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_FONDOS_Traer_TiposMov", con);
                cmd.Parameters.Add("@tipoMov", SqlDbType.VarChar, 10).Value = pTipo;

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("TiposMov");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            
        }
        
        public DataTable TraerMovmientos(DateTime fechaMov,bool efectivo,
                                         bool transferencia, bool cheques)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_FONDOS_Traer_Movimientos", con);
                cmd.Parameters.Add("@fechaMov", SqlDbType.SmallDateTime).Value = fechaMov;
                cmd.Parameters.Add("@efectivo", SqlDbType.Bit).Value = efectivo;
                cmd.Parameters.Add("@transferencia", SqlDbType.Bit).Value = transferencia;
                cmd.Parameters.Add("@cheques", SqlDbType.Bit).Value = cheques;

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("FondosMovimientos");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        public SqlDataReader InsertarMov(string pConcepto, string ptipoMov, string pimporte,
                        DateTime pfechaEmision, DateTime pfechaCobro,
                        string pnroCheque, string pbanco, string pcuenta,
                        int pcodVenta, int pcodAnticipo, string pbeneficiario)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_FONDOS_Insertar_Mov", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@concepto", SqlDbType.VarChar, 300).Value = pConcepto;
                cmd.Parameters.Add("@codTipoMov", SqlDbType.Int).Value = Convert.ToInt32(ptipoMov);
                cmd.Parameters.Add("@importe", SqlDbType.Decimal).Value = Convert.ToDecimal(pimporte);
                cmd.Parameters.Add("@fechaEmision", SqlDbType.SmallDateTime).Value = pfechaEmision;
                cmd.Parameters.Add("@fechaCobro", SqlDbType.SmallDateTime).Value = pfechaCobro;
                cmd.Parameters.Add("@nroCheque", SqlDbType.VarChar, 30).Value = pnroCheque;
                cmd.Parameters.Add("@banco", SqlDbType.VarChar, 200).Value = pbanco;
                cmd.Parameters.Add("@cuenta", SqlDbType.VarChar, 100).Value = pcuenta;
                cmd.Parameters.Add("@beneficiario", SqlDbType.VarChar, 200).Value = pbeneficiario;

                if (pcodVenta != 0)
                {
                    cmd.Parameters.Add("@codVenta", SqlDbType.Int).Value = pcodVenta;
                }
                if (pcodAnticipo != 0)
                {
                    cmd.Parameters.Add("@codAnticipo", SqlDbType.Int).Value = pcodAnticipo;
                }
                cmd.Parameters.Add("@codLogin", SqlDbType.Int).Value = Sesion.codUsuario;

                SqlDataReader unDataReader = cmd.ExecuteReader();

                return unDataReader;
            }
            catch (Exception ex)
            {
                cerrarConexion();
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return unDataReader;
                throw;
            }
            
        }
        //Fondos*************************************************

        //Ventas*************************************************
        public DataTable TraerMetPagos()
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_VENTAS_Traer_MetPagos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("MetPagos");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public SqlDataReader GuardarVenta(string pCodCliente, string pTotal,
                                        string pCuotas, string pCuota, string pAnticipo,
                                        string pContratoTipo, string pConcepto,
                                        string pMT2, string pMT2Precio)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_VENTAS_Nuevo_Editar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@codCliente", SqlDbType.Int).Value = Convert.ToInt32(pCodCliente);
                cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(pTotal);
                cmd.Parameters.Add("@cuotas", SqlDbType.Int).Value = Convert.ToInt32(pCuotas);
                cmd.Parameters.Add("@cuota", SqlDbType.Decimal).Value = Convert.ToDecimal(pCuota);
                if (pAnticipo == "")
                {
                    pAnticipo = "0";
                }
                cmd.Parameters.Add("@anticipo", SqlDbType.Decimal).Value = Convert.ToDecimal(pAnticipo);

                cmd.Parameters.Add("@Contrato", SqlDbType.VarChar, 200).Value = pContratoTipo; 
                cmd.Parameters.Add("@Concepto", SqlDbType.VarChar, 300).Value = pConcepto;

                cmd.Parameters.Add("@MT2", SqlDbType.Decimal).Value = Convert.ToDecimal(pMT2);
                cmd.Parameters.Add("@MT2Precio", SqlDbType.Decimal).Value = Convert.ToDecimal(pMT2Precio);

                cmd.Parameters.Add("@codLogin", SqlDbType.Int).Value = Sesion.codUsuario;

                unDataReader = cmd.ExecuteReader();
                return unDataReader;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());

                throw;
            }
        }
        //Ventas*************************************************

        //Creditos***********************************************
        public DataTable TraerCreditos(string codCliente)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CREDITOS_Traer", con);
                cmd.Parameters.Add("@codCliente", SqlDbType.Int).Value = Convert.ToInt32(codCliente);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Creditos");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public SqlDataReader InsertarPago(string pcodCliente, string pcodFormaPago, 
                                          string pimporte, string pstrCodPago,
                                          string pNombreCliente,
                                          DateTime pfechaEmision, DateTime pfechaCobro,
                                        string pnroCheque, string pbanco, string pcuenta,
                                        string pbeneficiario,
                                        string pConcepto, DateTime pfechaPago)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CREDITOS_Insertar_Pago", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@codCliente", SqlDbType.Int).Value = Convert.ToInt32(pcodCliente);
                cmd.Parameters.Add("@codFormaPago", SqlDbType.Int).Value = Convert.ToInt32(pcodFormaPago);
                cmd.Parameters.Add("@importe", SqlDbType.Decimal).Value = Convert.ToDecimal(pimporte);
                cmd.Parameters.Add("@strCodPago", SqlDbType.VarChar, 2000).Value = pstrCodPago;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 300).Value = pNombreCliente;

                cmd.Parameters.Add("@fechaEmision", SqlDbType.SmallDateTime).Value = pfechaEmision;
                cmd.Parameters.Add("@fechaCobro", SqlDbType.SmallDateTime).Value = pfechaCobro;
                cmd.Parameters.Add("@nroCheque", SqlDbType.VarChar, 30).Value = pnroCheque;
                cmd.Parameters.Add("@banco", SqlDbType.VarChar, 200).Value = pbanco;
                cmd.Parameters.Add("@cuenta", SqlDbType.VarChar, 100).Value = pcuenta;
                cmd.Parameters.Add("@beneficiario", SqlDbType.VarChar, 200).Value = pbeneficiario;
                cmd.Parameters.Add("@codLogin", SqlDbType.Int).Value = Sesion.codUsuario;
                cmd.Parameters.Add("@Concepto", SqlDbType.VarChar, 300).Value = pConcepto;
                cmd.Parameters.Add("@fechaPago", SqlDbType.SmallDateTime).Value = pfechaPago;

                SqlDataReader unDataReader = cmd.ExecuteReader();

                return unDataReader;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }
        //Creditos***********************************************

        //Contactos**********************************************
        public DataTable TraerTelefonos(string pcodigo, string pentidad)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CONTACTO_Traer_Telefonos", con);
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = Convert.ToInt32(pcodigo);
                cmd.Parameters.Add("@entidad", SqlDbType.VarChar, 100).Value = pentidad;

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Contactos");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable TraerEmails(string pcodigo, string pentidad)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CONTACTO_Traer_Emails", con);
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = Convert.ToInt32(pcodigo);
                cmd.Parameters.Add("@entidad", SqlDbType.VarChar, 100).Value = pentidad;

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Emails");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public SqlDataReader GuardarEmail(string pcodigo, string pentidad, string pemail)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CONTACTO_Nuevo_Email", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = Convert.ToInt32(pcodigo);
                cmd.Parameters.Add("@entidad", SqlDbType.VarChar, 100).Value = pentidad;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 150).Value = pemail;


                unDataReader = cmd.ExecuteReader();
                return unDataReader;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public SqlDataReader GuardarTelefonos(string pcodigo, string pentidad, 
                                              string pcelular, string pTelFijo)
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CONTACTO_Nuevo_Telefono", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = Convert.ToInt32(pcodigo);
                cmd.Parameters.Add("@entidad", SqlDbType.VarChar, 100).Value = pentidad;
                cmd.Parameters.Add("@celular", SqlDbType.VarChar, 20).Value = pcelular;
                cmd.Parameters.Add("@telfijo", SqlDbType.VarChar, 20).Value = pTelFijo;


                unDataReader = cmd.ExecuteReader();
                return unDataReader;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }
        //Contactos**********************************************

        //Contratos**********************************************
        public DataTable TraerContratosTipos()
        {
            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_CONTRATOS_Traer_Tipos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("ContratosTipos");
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
        }
        //Contratos**********************************************

    }
}
