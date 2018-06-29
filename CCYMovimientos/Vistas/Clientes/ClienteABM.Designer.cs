namespace CCYMovimientos.Vistas.Clientes
{
    partial class ClienteABM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteABM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChEmpresas = new Bunifu.Framework.UI.BunifuCheckbox();
            this.DGClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbNombres = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDoc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDireccion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLlamadas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNuevoCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHistorialPago = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContactos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDirecciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFijo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSena = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHistorialPagos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.TxtBuscar);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.ChEmpresas);
            this.panel1.Controls.Add(this.DGClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 395);
            this.panel1.TabIndex = 14;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(35, 25);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(108, 21);
            this.bunifuCustomLabel6.TabIndex = 30;
            this.bunifuCustomLabel6.Text = "Buscar Cliente";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(39, 52);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(228, 29);
            this.TxtBuscar.TabIndex = 14;
            this.TxtBuscar.Click += new System.EventHandler(this.TxtBuscar_Click);
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_OnTextChange);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(336, 56);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(110, 21);
            this.bunifuCustomLabel5.TabIndex = 13;
            this.bunifuCustomLabel5.Text = "Solo Empresas";
            // 
            // ChEmpresas
            // 
            this.ChEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChEmpresas.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChEmpresas.Checked = false;
            this.ChEmpresas.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.ChEmpresas.ForeColor = System.Drawing.Color.White;
            this.ChEmpresas.Location = new System.Drawing.Point(310, 57);
            this.ChEmpresas.Name = "ChEmpresas";
            this.ChEmpresas.Size = new System.Drawing.Size(20, 20);
            this.ChEmpresas.TabIndex = 12;
            this.ChEmpresas.OnChange += new System.EventHandler(this.ChEmpresas_OnChange);
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DGClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.DoubleBuffered = true;
            this.DGClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGClientes.EnableHeadersVisualStyles = false;
            this.DGClientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.DGClientes.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.DGClientes.Location = new System.Drawing.Point(39, 106);
            this.DGClientes.MultiSelect = false;
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.ReadOnly = true;
            this.DGClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientes.Size = new System.Drawing.Size(714, 257);
            this.DGClientes.TabIndex = 11;
            this.DGClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientes_CellClick);
            this.DGClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientes_CellDoubleClick);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(197, 85);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(61, 21);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "E-Mail :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(197, 56);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(181, 21);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Número de Documento :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(197, 115);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(131, 21);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Teléfono Celular :";
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.Location = new System.Drawing.Point(197, 29);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(148, 21);
            this.lbNombres.TabIndex = 3;
            this.lbNombres.Text = "Nombre y Apellido :";
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(39, 29);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(149, 135);
            this.bunifuTileButton1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(197, 175);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(82, 21);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Dirección :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(378, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 21);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Cliente X";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.Location = new System.Drawing.Point(378, 56);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(72, 21);
            this.lblDoc.TabIndex = 9;
            this.lblDoc.Text = "xx.xxx.xxx";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(378, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 21);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "xxxxx@xxx.xxx";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(378, 115);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(86, 21);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "xxxx-xxxxxx";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(378, 175);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(104, 21);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Xxxxxx xxx xxx";
            // 
            // btnLlamadas
            // 
            this.btnLlamadas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnLlamadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLlamadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnLlamadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLlamadas.BorderRadius = 5;
            this.btnLlamadas.ButtonText = "              LLAMADAS";
            this.btnLlamadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLlamadas.DisabledColor = System.Drawing.Color.Gray;
            this.btnLlamadas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamadas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLlamadas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLlamadas.Iconimage")));
            this.btnLlamadas.Iconimage_right = null;
            this.btnLlamadas.Iconimage_right_Selected = null;
            this.btnLlamadas.Iconimage_Selected = null;
            this.btnLlamadas.IconMarginLeft = 0;
            this.btnLlamadas.IconMarginRight = 0;
            this.btnLlamadas.IconRightVisible = true;
            this.btnLlamadas.IconRightZoom = 0D;
            this.btnLlamadas.IconVisible = true;
            this.btnLlamadas.IconZoom = 70D;
            this.btnLlamadas.IsTab = true;
            this.btnLlamadas.Location = new System.Drawing.Point(541, 167);
            this.btnLlamadas.Name = "btnLlamadas";
            this.btnLlamadas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnLlamadas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnLlamadas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLlamadas.selected = false;
            this.btnLlamadas.Size = new System.Drawing.Size(212, 38);
            this.btnLlamadas.TabIndex = 15;
            this.btnLlamadas.Text = "              LLAMADAS";
            this.btnLlamadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLlamadas.Textcolor = System.Drawing.Color.Silver;
            this.btnLlamadas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamadas.Visible = false;
            this.btnLlamadas.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnNuevoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoCliente.BorderRadius = 5;
            this.btnNuevoCliente.ButtonText = "              NUEVO CLIENTE";
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.Iconimage")));
            this.btnNuevoCliente.Iconimage_right = null;
            this.btnNuevoCliente.Iconimage_right_Selected = null;
            this.btnNuevoCliente.Iconimage_Selected = null;
            this.btnNuevoCliente.IconMarginLeft = 0;
            this.btnNuevoCliente.IconMarginRight = 0;
            this.btnNuevoCliente.IconRightVisible = true;
            this.btnNuevoCliente.IconRightZoom = 0D;
            this.btnNuevoCliente.IconVisible = true;
            this.btnNuevoCliente.IconZoom = 70D;
            this.btnNuevoCliente.IsTab = true;
            this.btnNuevoCliente.Location = new System.Drawing.Point(541, 212);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnNuevoCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnNuevoCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoCliente.selected = false;
            this.btnNuevoCliente.Size = new System.Drawing.Size(212, 38);
            this.btnNuevoCliente.TabIndex = 7;
            this.btnNuevoCliente.Text = "              NUEVO CLIENTE";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.Textcolor = System.Drawing.Color.Silver;
            this.btnNuevoCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnHistorialPago
            // 
            this.btnHistorialPago.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHistorialPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorialPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHistorialPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistorialPago.BorderRadius = 5;
            this.btnHistorialPago.ButtonText = "              PAGOS";
            this.btnHistorialPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialPago.DisabledColor = System.Drawing.Color.Gray;
            this.btnHistorialPago.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPago.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHistorialPago.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHistorialPago.Iconimage")));
            this.btnHistorialPago.Iconimage_right = null;
            this.btnHistorialPago.Iconimage_right_Selected = null;
            this.btnHistorialPago.Iconimage_Selected = null;
            this.btnHistorialPago.IconMarginLeft = 0;
            this.btnHistorialPago.IconMarginRight = 0;
            this.btnHistorialPago.IconRightVisible = true;
            this.btnHistorialPago.IconRightZoom = 0D;
            this.btnHistorialPago.IconVisible = true;
            this.btnHistorialPago.IconZoom = 70D;
            this.btnHistorialPago.IsTab = true;
            this.btnHistorialPago.Location = new System.Drawing.Point(541, 122);
            this.btnHistorialPago.Name = "btnHistorialPago";
            this.btnHistorialPago.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHistorialPago.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnHistorialPago.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHistorialPago.selected = false;
            this.btnHistorialPago.Size = new System.Drawing.Size(167, 38);
            this.btnHistorialPago.TabIndex = 16;
            this.btnHistorialPago.Text = "              PAGOS";
            this.btnHistorialPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialPago.Textcolor = System.Drawing.Color.Silver;
            this.btnHistorialPago.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPago.Visible = false;
            this.btnHistorialPago.Click += new System.EventHandler(this.btnHistorialPago_Click);
            // 
            // btnContactos
            // 
            this.btnContactos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContactos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnContactos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContactos.BorderRadius = 5;
            this.btnContactos.ButtonText = "              CONTACTOS";
            this.btnContactos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContactos.DisabledColor = System.Drawing.Color.Gray;
            this.btnContactos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContactos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnContactos.Iconimage")));
            this.btnContactos.Iconimage_right = null;
            this.btnContactos.Iconimage_right_Selected = null;
            this.btnContactos.Iconimage_Selected = null;
            this.btnContactos.IconMarginLeft = 0;
            this.btnContactos.IconMarginRight = 0;
            this.btnContactos.IconRightVisible = true;
            this.btnContactos.IconRightZoom = 0D;
            this.btnContactos.IconVisible = true;
            this.btnContactos.IconZoom = 70D;
            this.btnContactos.IsTab = true;
            this.btnContactos.Location = new System.Drawing.Point(39, 228);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnContactos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnContactos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnContactos.selected = false;
            this.btnContactos.Size = new System.Drawing.Size(212, 38);
            this.btnContactos.TabIndex = 17;
            this.btnContactos.Text = "              CONTACTOS";
            this.btnContactos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactos.Textcolor = System.Drawing.Color.Silver;
            this.btnContactos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactos.Visible = false;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // btnEditCliente
            // 
            this.btnEditCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnEditCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnEditCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditCliente.BorderRadius = 5;
            this.btnEditCliente.ButtonText = "              EDITAR CLIENTE";
            this.btnEditCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditCliente.Iconimage")));
            this.btnEditCliente.Iconimage_right = null;
            this.btnEditCliente.Iconimage_right_Selected = null;
            this.btnEditCliente.Iconimage_Selected = null;
            this.btnEditCliente.IconMarginLeft = 0;
            this.btnEditCliente.IconMarginRight = 0;
            this.btnEditCliente.IconRightVisible = true;
            this.btnEditCliente.IconRightZoom = 0D;
            this.btnEditCliente.IconVisible = true;
            this.btnEditCliente.IconZoom = 70D;
            this.btnEditCliente.IsTab = true;
            this.btnEditCliente.Location = new System.Drawing.Point(541, 256);
            this.btnEditCliente.Name = "btnEditCliente";
            this.btnEditCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnEditCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnEditCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditCliente.selected = false;
            this.btnEditCliente.Size = new System.Drawing.Size(212, 38);
            this.btnEditCliente.TabIndex = 8;
            this.btnEditCliente.Text = "              EDITAR CLIENTE";
            this.btnEditCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCliente.Textcolor = System.Drawing.Color.Silver;
            this.btnEditCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCliente.Visible = false;
            this.btnEditCliente.Click += new System.EventHandler(this.btnEditCliente_Click);
            // 
            // btnDirecciones
            // 
            this.btnDirecciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnDirecciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDirecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnDirecciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirecciones.BorderRadius = 5;
            this.btnDirecciones.ButtonText = "              DIRECCIONES";
            this.btnDirecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDirecciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnDirecciones.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirecciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDirecciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDirecciones.Iconimage")));
            this.btnDirecciones.Iconimage_right = null;
            this.btnDirecciones.Iconimage_right_Selected = null;
            this.btnDirecciones.Iconimage_Selected = null;
            this.btnDirecciones.IconMarginLeft = 0;
            this.btnDirecciones.IconMarginRight = 0;
            this.btnDirecciones.IconRightVisible = true;
            this.btnDirecciones.IconRightZoom = 0D;
            this.btnDirecciones.IconVisible = true;
            this.btnDirecciones.IconZoom = 70D;
            this.btnDirecciones.IsTab = true;
            this.btnDirecciones.Location = new System.Drawing.Point(39, 273);
            this.btnDirecciones.Name = "btnDirecciones";
            this.btnDirecciones.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnDirecciones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnDirecciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDirecciones.selected = false;
            this.btnDirecciones.Size = new System.Drawing.Size(212, 38);
            this.btnDirecciones.TabIndex = 18;
            this.btnDirecciones.Text = "              DIRECCIONES";
            this.btnDirecciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirecciones.Textcolor = System.Drawing.Color.Silver;
            this.btnDirecciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirecciones.Visible = false;
            this.btnDirecciones.Click += new System.EventHandler(this.btnDirecciones_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(197, 143);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(106, 21);
            this.bunifuCustomLabel8.TabIndex = 19;
            this.bunifuCustomLabel8.Text = "Teléfono Fijo :";
            // 
            // lblFijo
            // 
            this.lblFijo.AutoSize = true;
            this.lblFijo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFijo.Location = new System.Drawing.Point(378, 143);
            this.lblFijo.Name = "lblFijo";
            this.lblFijo.Size = new System.Drawing.Size(86, 21);
            this.lblFijo.TabIndex = 20;
            this.lblFijo.Text = "xxxx-xxxxxx";
            // 
            // btnSena
            // 
            this.btnSena.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnSena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnSena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSena.BorderRadius = 5;
            this.btnSena.ButtonText = "              SEÑAR";
            this.btnSena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSena.DisabledColor = System.Drawing.Color.Gray;
            this.btnSena.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSena.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSena.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSena.Iconimage")));
            this.btnSena.Iconimage_right = null;
            this.btnSena.Iconimage_right_Selected = null;
            this.btnSena.Iconimage_Selected = null;
            this.btnSena.IconMarginLeft = 0;
            this.btnSena.IconMarginRight = 0;
            this.btnSena.IconRightVisible = true;
            this.btnSena.IconRightZoom = 0D;
            this.btnSena.IconVisible = true;
            this.btnSena.IconZoom = 70D;
            this.btnSena.IsTab = true;
            this.btnSena.Location = new System.Drawing.Point(541, 77);
            this.btnSena.Name = "btnSena";
            this.btnSena.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnSena.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnSena.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSena.selected = false;
            this.btnSena.Size = new System.Drawing.Size(212, 38);
            this.btnSena.TabIndex = 21;
            this.btnSena.Text = "              SEÑAR";
            this.btnSena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSena.Textcolor = System.Drawing.Color.Silver;
            this.btnSena.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSena.Visible = false;
            this.btnSena.Click += new System.EventHandler(this.btnSena_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnHistorialPagos);
            this.panel2.Controls.Add(this.btnSena);
            this.panel2.Controls.Add(this.lblFijo);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.btnDirecciones);
            this.panel2.Controls.Add(this.btnEditCliente);
            this.panel2.Controls.Add(this.btnContactos);
            this.panel2.Controls.Add(this.btnHistorialPago);
            this.panel2.Controls.Add(this.btnNuevoCliente);
            this.panel2.Controls.Add(this.btnLlamadas);
            this.panel2.Controls.Add(this.lblDireccion);
            this.panel2.Controls.Add(this.lblTel);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblDoc);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuTileButton1);
            this.panel2.Controls.Add(this.lbNombres);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 315);
            this.panel2.TabIndex = 13;
            // 
            // btnHistorialPagos
            // 
            this.btnHistorialPagos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHistorialPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorialPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHistorialPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistorialPagos.BorderRadius = 5;
            this.btnHistorialPagos.ButtonText = "";
            this.btnHistorialPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialPagos.DisabledColor = System.Drawing.Color.Gray;
            this.btnHistorialPagos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPagos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHistorialPagos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHistorialPagos.Iconimage")));
            this.btnHistorialPagos.Iconimage_right = null;
            this.btnHistorialPagos.Iconimage_right_Selected = null;
            this.btnHistorialPagos.Iconimage_Selected = null;
            this.btnHistorialPagos.IconMarginLeft = 0;
            this.btnHistorialPagos.IconMarginRight = 0;
            this.btnHistorialPagos.IconRightVisible = true;
            this.btnHistorialPagos.IconRightZoom = 0D;
            this.btnHistorialPagos.IconVisible = true;
            this.btnHistorialPagos.IconZoom = 70D;
            this.btnHistorialPagos.IsTab = true;
            this.btnHistorialPagos.Location = new System.Drawing.Point(712, 122);
            this.btnHistorialPagos.Name = "btnHistorialPagos";
            this.btnHistorialPagos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHistorialPagos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnHistorialPagos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHistorialPagos.selected = false;
            this.btnHistorialPagos.Size = new System.Drawing.Size(41, 38);
            this.btnHistorialPagos.TabIndex = 138;
            this.btnHistorialPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialPagos.Textcolor = System.Drawing.Color.Silver;
            this.btnHistorialPagos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPagos.Visible = false;
            this.btnHistorialPagos.Click += new System.EventHandler(this.btnHistorialPagos_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(34, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(466, 198);
            this.panel7.TabIndex = 136;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(169)))), ((int)(((byte)(184)))));
            this.panel3.Location = new System.Drawing.Point(42, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 198);
            this.panel3.TabIndex = 137;
            // 
            // ClienteABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(790, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClienteABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteABM";
            this.Load += new System.EventHandler(this.ClienteABM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox ChEmpresas;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGClientes;
        private System.Windows.Forms.TextBox TxtBuscar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNombres;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDoc;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDireccion;
        private Bunifu.Framework.UI.BunifuFlatButton btnLlamadas;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnHistorialPago;
        private Bunifu.Framework.UI.BunifuFlatButton btnContactos;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnDirecciones;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFijo;
        private Bunifu.Framework.UI.BunifuFlatButton btnSena;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnHistorialPagos;
    }
}