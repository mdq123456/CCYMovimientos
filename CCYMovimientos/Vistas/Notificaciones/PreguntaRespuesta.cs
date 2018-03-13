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
    public partial class PreguntaRespuesta : Form
    {
        public string SIoNO;
        public string concepto;
        public PreguntaRespuesta(string pTitulo,
                                 string pPregunta,
                                 string pInfo,
                                 string pBtnCancel,
                                 string pBtnAceptar)
        {
            InitializeComponent();
            lblTitulo.Text = pTitulo;
            lblPregunta.Text = pPregunta;
            lblInfo.Text = pInfo;
            btnCancelar.ButtonText = pBtnCancel;
            btnGuardar.ButtonText = pBtnAceptar;
        }

        private void PreguntaRespuesta_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtConcepto.Text.Trim() == "")
            {
                Alertas alert = new Alertas("Debe agregar un concepto para completar la operacion !", "");
                alert.Show();

                return;
            }
            SIoNO = "1";
            concepto = TxtConcepto.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SIoNO = "0";
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SIoNO = "0";
            this.Close();
        }
    }
}
