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
        public IngresoDatos(string pTitulo, string pLbl)
        {
            InitializeComponent();
            lblTitulo.Text = pTitulo;
            lblTexto1.Text = pLbl;
        }

        public string getTexto1()
        {
            return this.texto1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.texto1 = TxtTexto1.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.texto1 = "";
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.texto1 = "";
            this.Close();
        }
    }
}
