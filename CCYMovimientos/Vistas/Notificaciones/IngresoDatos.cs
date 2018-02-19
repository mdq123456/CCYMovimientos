using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Vistas.Notificaciones
{
    public partial class IngresoDatos : Form
    {
        private string texto1;
        private bool SiNo;
        public IngresoDatos(string pTitulo, string pLbl)
        {
            InitializeComponent();
            lblTitulo.Text = pTitulo;
            lblTexto1.Text = pLbl;
        }

        public IngresoDatos(string pTitulo, string pPregunta,
                            string pNO = "No",
                            string pSI = "Si")
        {
            InitializeComponent();

            lblTexto1.Visible = false;
            TxtTexto1.Visible = false;
            lblPregunta.Visible = true;
            this.SiNo = true;

            lblTitulo.Text = pTitulo;
            lblPregunta.Text = pPregunta;
            btnCancelar.ButtonText = pNO;
            btnGuardar.ButtonText = pSI;
        }

        public string getTexto1()
        {
            return this.texto1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cerrarForm("S", TxtTexto1.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrarForm("N", "");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            cerrarForm("N", "");
        }

        private void cerrarForm(string pVar = "",
                                string pVar2 = "")
        {
            if (this.SiNo)
            {
                this.texto1 = pVar;
                this.Close();
            }
            else
            {
                this.texto1 = pVar2;
                this.Close();
            }
        }

    }
}
