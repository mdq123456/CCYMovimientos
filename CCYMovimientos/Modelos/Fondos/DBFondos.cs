﻿using System;
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
        private string concepto { set; get; }
        private string tipoMov { set; get; }
        private string importe { set; get; }
        private DateTime fechaEmision { set; get; }
        private DateTime fechaCobro { set; get; }
        private string nroCheque { set; get; }
        private string banco { set; get; }
        private string cuenta { set; get; }

        private int codVenta { set; get; }
        private int codAnticipo { set; get; }
        private string beneficiario { set; get; }
        public string CodMovimiento;
        private string sena { set; get; }
        private int codCliente { set; get; }

        private int codFondo { set; get; }


        public DBFondos()
        {

        }

        public DBFondos(string pConcepto, string ptipoMov, string pimporte,
                        DateTime pfechaEmision, DateTime pfechaCobro,
                        string pnroCheque, string pbanco, string pcuenta,
                        string pbeneficiario)
        {
            this.concepto = pConcepto;
            this.tipoMov = ptipoMov;
            this.importe = pimporte;
            this.fechaEmision = pfechaEmision;
            this.fechaCobro = pfechaCobro;
            this.nroCheque = pnroCheque;
            this.banco = pbanco;
            this.cuenta = pcuenta;
            this.beneficiario = pbeneficiario;
            sena = "";
            codCliente = 0;
        }

        public void setSena(string psena, int pCodCliente)
        {
            sena = psena;
            codCliente = pCodCliente;
        }

        public DataTable TraerCheques()
        {
            DataCenter objDC = new DataCenter();
            DataTable tabla = objDC.TraerCheques();
            objDC.cerrarConexion();
            return tabla;
        }

        public DataTable TraerFondosCierre()
        {
            DataCenter objDC = new DataCenter();
            DataTable tabla = objDC.TraerFondosCierre();
            objDC.cerrarConexion();
            return tabla;
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

        public DataTable TraerTiposMov(string pTipo)
        {
            DataCenter objDC = new DataCenter();
            DataTable tabla = objDC.TraerFondosMov(pTipo);
            objDC.cerrarConexion();
            return tabla;
        }

        public DataTable TraerMovimientos(DateTime fechaMov, bool efectivo,
                                          bool transferencia, bool cheques)
        {
            DataCenter objDC = new DataCenter();
            DataTable tabla = objDC.TraerMovmientos(fechaMov, efectivo,transferencia
                                                    ,cheques);
            objDC.cerrarConexion();
            return tabla;
        }
        public string InsertarMov(string pstrCodCheques)
        {
            string retorno;
            CodMovimiento = "";
            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.InsertarMov(this.concepto,
                                                     this.tipoMov,
                                                     this.importe,
                                                     this.fechaEmision,
                                                     this.fechaCobro,
                                                     this.nroCheque,
                                                     this.banco,
                                                     this.cuenta,
                                                     this.codVenta,
                                                     this.codAnticipo,
                                                     this.beneficiario,
                                                     sena,
                                                     codCliente,
                                                     pstrCodCheques);
            retorno = "No se pudo realizar la operacion, comuniquese con su administrador.";
            if (unDato != null)
            {
                if (unDato.HasRows)
                {
                    unDato.Read();

                    retorno = unDato["Msj"].ToString();
                    
                    if (unDato["CodMovimiento"].ToString() != "")
                    {
                        CodMovimiento = unDato["CodMovimiento"].ToString();
                    }
                }
            }
            
            objDC.cerrarConexion();
            return retorno;

        }

        public string CerrarCajaMontos(string strCierre)
        {
            string retorno = "";

            DataCenter objDC = new DataCenter();
            SqlDataReader unDato = objDC.CerrarCajaMontos(strCierre);
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
