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



        //Clientes***********************************************
        public  DataTable TraerClientes(bool tipoCliente,string codCliente = "0")
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

        public  DataTable TraerClientesTipos()
        {
            abrirConexion();
            cmd = new SqlCommand("SP_CLIENTE_Traer_Tipos", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ClientesTipos");
            adapter.Fill(dt);

            return dt;

        }

        public  DataTable TraerClientesLocalidades(int codProvincia)
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

        public  DataTable TraerClientesProvincias()
        {
            abrirConexion();
            cmd = new SqlCommand("SP_CLIENTE_Traer_Provincias", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ClientesProvincias");
            adapter.Fill(dt);

            return dt;
        }

        public  SqlDataReader CrearCliente(string pApellidos, string pNombres,
                                              string pCUIL, string pDNI, string pcodTipoCliente,
                                              string pTelefono, string pEmail, string pcodProvincia,
                                              string pCodLocalidad, string pDomicilio)
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
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 150).Value = pEmail;
            cmd.Parameters.Add("@CodProvincia", SqlDbType.VarChar, 20).Value = pcodProvincia;
            cmd.Parameters.Add("@CodLocalidad", SqlDbType.VarChar, 20).Value = pCodLocalidad;
            cmd.Parameters.Add("@Domicilio", SqlDbType.VarChar, 20).Value = pDomicilio;

            unDataReader = cmd.ExecuteReader();
            return unDataReader;
        }

        //Clientes***********************************************


        //Fondos*************************************************
        public SqlDataReader AbrirCaja()
        {
            abrirConexion();
            cmd = new SqlCommand("SP_FONDOS_Abrir_Caja", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader unDataReader = cmd.ExecuteReader();

            return unDataReader;

        }

        public SqlDataReader CerrarCaja(decimal pImporte)
        {
            abrirConexion();
            cmd = new SqlCommand("SP_FONDOS_Cerrar_Caja", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@importe", SqlDbType.Decimal).Value = pImporte;

            SqlDataReader unDataReader = cmd.ExecuteReader();

            return unDataReader;

        }

        public DataTable TraerMovmientos(DateTime fechaMov)
        {
            abrirConexion();
            cmd = new SqlCommand("SP_FONDOS_Traer_Movimientos", con);
            cmd.Parameters.Add("@fechaMov", SqlDbType.SmallDateTime).Value = fechaMov;

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("FondosMovimientos");
            adapter.Fill(dt);

            return dt;
        }
        //Fondos*************************************************
    }
}
