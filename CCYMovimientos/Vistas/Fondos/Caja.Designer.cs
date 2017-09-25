namespace CCYMovimientos.Vistas.Fondos
{
    partial class Caja
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnIngresos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEgresos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DGClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAbrirCaja = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrarCaja = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.TxtConcepto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtImporte = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresos
            // 
            this.btnIngresos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.btnIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnIngresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresos.BorderRadius = 0;
            this.btnIngresos.ButtonText = "              INGRESOS";
            this.btnIngresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresos.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngresos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngresos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIngresos.Iconimage")));
            this.btnIngresos.Iconimage_right = null;
            this.btnIngresos.Iconimage_right_Selected = null;
            this.btnIngresos.Iconimage_Selected = null;
            this.btnIngresos.IconMarginLeft = 0;
            this.btnIngresos.IconMarginRight = 0;
            this.btnIngresos.IconRightVisible = true;
            this.btnIngresos.IconRightZoom = 0D;
            this.btnIngresos.IconVisible = true;
            this.btnIngresos.IconZoom = 80D;
            this.btnIngresos.IsTab = true;
            this.btnIngresos.Location = new System.Drawing.Point(24, 182);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnIngresos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnIngresos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIngresos.selected = false;
            this.btnIngresos.Size = new System.Drawing.Size(187, 51);
            this.btnIngresos.TabIndex = 2;
            this.btnIngresos.Text = "              INGRESOS";
            this.btnIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresos.Textcolor = System.Drawing.Color.Silver;
            this.btnIngresos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnEgresos
            // 
            this.btnEgresos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.btnEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnEgresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEgresos.BorderRadius = 0;
            this.btnEgresos.ButtonText = "              EGRESOS";
            this.btnEgresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEgresos.DisabledColor = System.Drawing.Color.Gray;
            this.btnEgresos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEgresos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEgresos.Iconimage")));
            this.btnEgresos.Iconimage_right = null;
            this.btnEgresos.Iconimage_right_Selected = null;
            this.btnEgresos.Iconimage_Selected = null;
            this.btnEgresos.IconMarginLeft = 0;
            this.btnEgresos.IconMarginRight = 0;
            this.btnEgresos.IconRightVisible = true;
            this.btnEgresos.IconRightZoom = 0D;
            this.btnEgresos.IconVisible = true;
            this.btnEgresos.IconZoom = 80D;
            this.btnEgresos.IsTab = true;
            this.btnEgresos.Location = new System.Drawing.Point(24, 239);
            this.btnEgresos.Name = "btnEgresos";
            this.btnEgresos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnEgresos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnEgresos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEgresos.selected = false;
            this.btnEgresos.Size = new System.Drawing.Size(187, 51);
            this.btnEgresos.TabIndex = 3;
            this.btnEgresos.Text = "              EGRESOS";
            this.btnEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEgresos.Textcolor = System.Drawing.Color.Silver;
            this.btnEgresos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DGClientes
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DGClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4});
            this.DGClientes.DoubleBuffered = true;
            this.DGClientes.EnableHeadersVisualStyles = false;
            this.DGClientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.DGClientes.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.DGClientes.Location = new System.Drawing.Point(24, 342);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGClientes.Size = new System.Drawing.Size(837, 313);
            this.DGClientes.TabIndex = 4;
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnAbrirCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnAbrirCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirCaja.BorderRadius = 0;
            this.btnAbrirCaja.ButtonText = "              ABRIR CAJA";
            this.btnAbrirCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCaja.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbrirCaja.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaja.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbrirCaja.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAbrirCaja.Iconimage")));
            this.btnAbrirCaja.Iconimage_right = null;
            this.btnAbrirCaja.Iconimage_right_Selected = null;
            this.btnAbrirCaja.Iconimage_Selected = null;
            this.btnAbrirCaja.IconMarginLeft = 0;
            this.btnAbrirCaja.IconMarginRight = 0;
            this.btnAbrirCaja.IconRightVisible = true;
            this.btnAbrirCaja.IconRightZoom = 0D;
            this.btnAbrirCaja.IconVisible = true;
            this.btnAbrirCaja.IconZoom = 80D;
            this.btnAbrirCaja.IsTab = true;
            this.btnAbrirCaja.Location = new System.Drawing.Point(661, 23);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnAbrirCaja.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnAbrirCaja.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAbrirCaja.selected = false;
            this.btnAbrirCaja.Size = new System.Drawing.Size(200, 51);
            this.btnAbrirCaja.TabIndex = 5;
            this.btnAbrirCaja.Text = "              ABRIR CAJA";
            this.btnAbrirCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirCaja.Textcolor = System.Drawing.Color.Silver;
            this.btnAbrirCaja.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnCerrarCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnCerrarCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarCaja.BorderRadius = 0;
            this.btnCerrarCaja.ButtonText = "              CERRAR CAJA";
            this.btnCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarCaja.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrarCaja.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrarCaja.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCerrarCaja.Iconimage")));
            this.btnCerrarCaja.Iconimage_right = null;
            this.btnCerrarCaja.Iconimage_right_Selected = null;
            this.btnCerrarCaja.Iconimage_Selected = null;
            this.btnCerrarCaja.IconMarginLeft = 0;
            this.btnCerrarCaja.IconMarginRight = 0;
            this.btnCerrarCaja.IconRightVisible = true;
            this.btnCerrarCaja.IconRightZoom = 0D;
            this.btnCerrarCaja.IconVisible = true;
            this.btnCerrarCaja.IconZoom = 80D;
            this.btnCerrarCaja.IsTab = true;
            this.btnCerrarCaja.Location = new System.Drawing.Point(661, 80);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnCerrarCaja.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnCerrarCaja.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrarCaja.selected = false;
            this.btnCerrarCaja.Size = new System.Drawing.Size(200, 51);
            this.btnCerrarCaja.TabIndex = 6;
            this.btnCerrarCaja.Text = "              CERRAR CAJA";
            this.btnCerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarCaja.Textcolor = System.Drawing.Color.Silver;
            this.btnCerrarCaja.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(237, 266);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(85, 21);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "Importe $ :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(237, 226);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(47, 21);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Tipo :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(237, 182);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(83, 21);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Concepto :";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha de Movimiento";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CodMovimiento";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ingresos";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Egresos";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Concepto del Movimiento";
            this.Column4.Name = "Column4";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(329, 218);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(532, 35);
            this.bunifuDropdown1.TabIndex = 12;
            // 
            // TxtConcepto
            // 
            this.TxtConcepto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtConcepto.HintForeColor = System.Drawing.Color.Empty;
            this.TxtConcepto.HintText = "";
            this.TxtConcepto.isPassword = false;
            this.TxtConcepto.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtConcepto.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtConcepto.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtConcepto.LineThickness = 3;
            this.TxtConcepto.Location = new System.Drawing.Point(329, 180);
            this.TxtConcepto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConcepto.Name = "TxtConcepto";
            this.TxtConcepto.Size = new System.Drawing.Size(532, 33);
            this.TxtConcepto.TabIndex = 13;
            this.TxtConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtImporte.HintForeColor = System.Drawing.Color.Empty;
            this.TxtImporte.HintText = "";
            this.TxtImporte.isPassword = false;
            this.TxtImporte.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtImporte.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtImporte.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtImporte.LineThickness = 3;
            this.TxtImporte.Location = new System.Drawing.Point(329, 257);
            this.TxtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(261, 33);
            this.TxtImporte.TabIndex = 14;
            this.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Guardar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(680, 292);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 15;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.TxtImporte);
            this.Controls.Add(this.TxtConcepto);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.btnAbrirCaja);
            this.Controls.Add(this.DGClientes);
            this.Controls.Add(this.btnEgresos);
            this.Controls.Add(this.btnIngresos);
            this.Name = "Caja";
            this.Size = new System.Drawing.Size(890, 680);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnIngresos;
        private Bunifu.Framework.UI.BunifuFlatButton btnEgresos;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbrirCaja;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrarCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtConcepto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtImporte;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
