using CCYMovimientos.Modelos.Fondos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Vistas.Fondos
{
    public partial class CierreCaja : Form
    {
        private string strCierre { set; get; }

        public CierreCaja()
        {
            InitializeComponent();
            strCierre = "";
        }

        private void CierreCaja_Load(object sender, EventArgs e)
        {
            DBFondos objFondo = new DBFondos();
            DGFondos.DataSource = objFondo.TraerFondosCierre();

            foreach (DataGridViewColumn celda in DGFondos.Columns)
            {
                if (celda.Name != "ImportedeCaja")
                {
                    celda.ReadOnly = true;
                }
                if (celda.Name == "CodTipoMov")
                {
                    celda.Visible = false;
                }

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GenerarStrCierre();
            this.Close();
        }

        private void DGFondos_SelectionChanged(object sender, EventArgs e)
        {
            //DGFondos.CurrentCell = DGFondos.CurrentRow.Cells["ImporteCaja"];
            //DGFondos.BeginEdit(true);
        }

        private void GenerarStrCierre() //tomamos todos los productos de la grilla que estan seleccionamos y hacemos una cadena
        {
            strCierre = "";
            foreach (DataGridViewRow row in DGFondos.Rows)
            {
                if (row.Cells["ImportedeCaja"].Value.ToString().Trim() == "") //si tiene datos agrega al string
                {
                    strCierre += "|";
                    strCierre += row.Cells["ImportedeCaja"].Value.ToString();
                    strCierre += ";";
                    strCierre += row.Cells["CodTipoMov"].Value.ToString();
                    strCierre += "#";
                    strCierre += row.Cells["Importe"].Value.ToString();
                }
            }
        }

        public string getStrCierre()
        {
            return strCierre;
        }
    }
}
