namespace CCYMovimientos.Vistas.Clientes
{
    partial class ClientesContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesContactos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.DGTelefonos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DGEmail = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lbl3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtCel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtFijo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnGuardarTel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGuardarEmail = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TxtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.bunifuCustomLabel12);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 60);
            this.panel2.TabIndex = 17;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(28, 7);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(350, 47);
            this.bunifuCustomLabel12.TabIndex = 76;
            this.bunifuCustomLabel12.Text = "Contactos del Cliente";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(901, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(44, 60);
            this.panel3.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(9, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DGTelefonos
            // 
            this.DGTelefonos.AllowUserToAddRows = false;
            this.DGTelefonos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGTelefonos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGTelefonos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGTelefonos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGTelefonos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTelefonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTelefonos.DoubleBuffered = true;
            this.DGTelefonos.EnableHeadersVisualStyles = false;
            this.DGTelefonos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.DGTelefonos.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.DGTelefonos.Location = new System.Drawing.Point(31, 162);
            this.DGTelefonos.Name = "DGTelefonos";
            this.DGTelefonos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGTelefonos.Size = new System.Drawing.Size(884, 182);
            this.DGTelefonos.TabIndex = 92;
            // 
            // DGEmail
            // 
            this.DGEmail.AllowUserToAddRows = false;
            this.DGEmail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGEmail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DGEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGEmail.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGEmail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGEmail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGEmail.DoubleBuffered = true;
            this.DGEmail.EnableHeadersVisualStyles = false;
            this.DGEmail.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.DGEmail.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.DGEmail.Location = new System.Drawing.Point(31, 421);
            this.DGEmail.Name = "DGEmail";
            this.DGEmail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGEmail.Size = new System.Drawing.Size(884, 182);
            this.DGEmail.TabIndex = 94;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(27, 117);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(128, 21);
            this.lbl3.TabIndex = 95;
            this.lbl3.Text = "Teléfono Celular :";
            // 
            // TxtCel
            // 
            this.TxtCel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCel.HintForeColor = System.Drawing.Color.Empty;
            this.TxtCel.HintText = "";
            this.TxtCel.isPassword = false;
            this.TxtCel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtCel.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtCel.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtCel.LineThickness = 4;
            this.TxtCel.Location = new System.Drawing.Point(162, 104);
            this.TxtCel.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCel.Name = "TxtCel";
            this.TxtCel.Size = new System.Drawing.Size(161, 41);
            this.TxtCel.TabIndex = 96;
            this.TxtCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtFijo
            // 
            this.TxtFijo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtFijo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFijo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtFijo.HintForeColor = System.Drawing.Color.Empty;
            this.TxtFijo.HintText = "";
            this.TxtFijo.isPassword = false;
            this.TxtFijo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtFijo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtFijo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtFijo.LineThickness = 4;
            this.TxtFijo.Location = new System.Drawing.Point(484, 104);
            this.TxtFijo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFijo.Name = "TxtFijo";
            this.TxtFijo.Size = new System.Drawing.Size(161, 41);
            this.TxtFijo.TabIndex = 98;
            this.TxtFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(373, 117);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 21);
            this.bunifuCustomLabel1.TabIndex = 97;
            this.bunifuCustomLabel1.Text = "Teléfono Fijo :";
            // 
            // btnGuardarTel
            // 
            this.btnGuardarTel.ActiveBorderThickness = 1;
            this.btnGuardarTel.ActiveCornerRadius = 20;
            this.btnGuardarTel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardarTel.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardarTel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardarTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.btnGuardarTel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarTel.BackgroundImage")));
            this.btnGuardarTel.ButtonText = "Guardar";
            this.btnGuardarTel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardarTel.IdleBorderThickness = 1;
            this.btnGuardarTel.IdleCornerRadius = 20;
            this.btnGuardarTel.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardarTel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardarTel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardarTel.Location = new System.Drawing.Point(734, 112);
            this.btnGuardarTel.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarTel.Name = "btnGuardarTel";
            this.btnGuardarTel.Size = new System.Drawing.Size(181, 41);
            this.btnGuardarTel.TabIndex = 99;
            this.btnGuardarTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarTel.Click += new System.EventHandler(this.btnGuardarTel_Click);
            // 
            // btnGuardarEmail
            // 
            this.btnGuardarEmail.ActiveBorderThickness = 1;
            this.btnGuardarEmail.ActiveCornerRadius = 20;
            this.btnGuardarEmail.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardarEmail.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardarEmail.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardarEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.btnGuardarEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEmail.BackgroundImage")));
            this.btnGuardarEmail.ButtonText = "Guardar";
            this.btnGuardarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardarEmail.IdleBorderThickness = 1;
            this.btnGuardarEmail.IdleCornerRadius = 20;
            this.btnGuardarEmail.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardarEmail.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardarEmail.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardarEmail.Location = new System.Drawing.Point(734, 372);
            this.btnGuardarEmail.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarEmail.Name = "btnGuardarEmail";
            this.btnGuardarEmail.Size = new System.Drawing.Size(181, 41);
            this.btnGuardarEmail.TabIndex = 100;
            this.btnGuardarEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarEmail.Click += new System.EventHandler(this.btnGuardarEmail_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.TxtEmail.HintText = "";
            this.TxtEmail.isPassword = false;
            this.TxtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtEmail.LineThickness = 4;
            this.TxtEmail.Location = new System.Drawing.Point(94, 366);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(551, 41);
            this.TxtEmail.TabIndex = 102;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 377);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(55, 21);
            this.bunifuCustomLabel2.TabIndex = 101;
            this.bunifuCustomLabel2.Text = "Email :";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCliente.Enabled = false;
            this.TxtCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCliente.HintForeColor = System.Drawing.Color.Black;
            this.TxtCliente.HintText = "";
            this.TxtCliente.isPassword = false;
            this.TxtCliente.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtCliente.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtCliente.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtCliente.LineThickness = 4;
            this.TxtCliente.Location = new System.Drawing.Point(162, 62);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(483, 41);
            this.TxtCliente.TabIndex = 103;
            this.TxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(27, 76);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel3.TabIndex = 104;
            this.bunifuCustomLabel3.Text = "Cliente :";
            // 
            // ClientesContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(945, 633);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btnGuardarEmail);
            this.Controls.Add(this.btnGuardarTel);
            this.Controls.Add(this.TxtFijo);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.TxtCel);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.DGEmail);
            this.Controls.Add(this.DGTelefonos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesContactos";
            this.Load += new System.EventHandler(this.ClientesContactos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGTelefonos;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtFijo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardarTel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardarEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}