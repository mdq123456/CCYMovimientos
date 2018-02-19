using CCYMovimientos.Modelos;
using CCYMovimientos.Modelos.Sessiones;
using CCYMovimientos.Vistas.Menu;
using CCYMovimientos.Vistas.Notificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos.Vistas.Sesiones
{
    public partial class Login : Form
    {
        private bool status { set; get; }
        private DBSesion objSesion { set; get; }

        public Login()
        {
            InitializeComponent();
            this.status = false;
            
        }
        public bool getStatus(){return this.status;}
        private void setSesion(DBSesion pobjSesion) { this.objSesion = pobjSesion; }
        public DBSesion getSesion() { return this.objSesion; }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_OnValueChanged(object sender, EventArgs e)
        {
            this.txtPass.isPassword = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            this.Ingresar();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //Alertas alert = new Alertas("Gato","");
            //alert.Show();
        }

        private void txtUsuario_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Ingresar();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Ingresar();
            }
        }

        private void Ingresar()
        {
            if (this.txtUsuario.Text.Trim() != "" &&
                this.txtPass.Text.Trim() != "" &&
                this.txtUsuario.Text.Trim().Length <= 20 &&
                this.txtPass.Text.Trim().Length <= 20)
            {
                DataCenter objDC = new DataCenter();
                if (objDC.abrirConexion(1) != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("No se logró conectar a la base de datos, consulte con su administrador.", "CCYMovimientos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    DBSesion pobjSesion = new DBSesion(txtUsuario.Text.Trim(), txtPass.Text.Trim());
                    string msj = pobjSesion.Ingresar();

                    if (msj == "1")
                    {
                        this.status = true;
                        this.objSesion = pobjSesion;
                        this.Close();
                    }
                    else
                    {
                        this.txtUsuario.Focus();
                        Alertas alert = new Alertas(msj, "");
                        alert.Show();

                    }

                }
            }
            else
            {
                this.txtUsuario.Focus();
                Alertas alert = new Alertas("No se admiten valores vacios o mayores a 20 caracteres.", "");
                alert.Show();
                
            }
        }

    }
}
