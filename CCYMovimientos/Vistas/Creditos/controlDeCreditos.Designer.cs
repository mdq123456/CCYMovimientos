namespace CCYMovimientos.Vistas.Creditos
{
    partial class controlDeCreditos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlDeCreditos));
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbNombres = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DGClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtClientes = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnHistorialPago = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContacto = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(192, 98);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(136, 21);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Status del Cliente :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(192, 63);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(181, 21);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "Número de Documento :";
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.Location = new System.Drawing.Point(192, 26);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(148, 21);
            this.lbNombres.TabIndex = 10;
            this.lbNombres.Text = "Nombre y Apellido :";
            // 
            // DGClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.DGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DGClientes.DoubleBuffered = true;
            this.DGClientes.EnableHeadersVisualStyles = false;
            this.DGClientes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.DGClientes.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.DGClientes.Location = new System.Drawing.Point(27, 258);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGClientes.Size = new System.Drawing.Size(712, 232);
            this.DGClientes.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre y Apellido";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DNI";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contacto";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Credito";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ver Status";
            this.Column5.Name = "Column5";
            // 
            // TxtClientes
            // 
            this.TxtClientes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtClientes.BackColor = System.Drawing.Color.Silver;
            this.TxtClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtClientes.BackgroundImage")));
            this.TxtClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtClientes.Icon = ((System.Drawing.Image)(resources.GetObject("TxtClientes.Icon")));
            this.TxtClientes.Location = new System.Drawing.Point(27, 199);
            this.TxtClientes.Name = "TxtClientes";
            this.TxtClientes.Size = new System.Drawing.Size(250, 42);
            this.TxtClientes.TabIndex = 8;
            this.TxtClientes.text = "";
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
            this.bunifuTileButton1.Location = new System.Drawing.Point(27, 26);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton1.TabIndex = 7;
            // 
            // btnHistorialPago
            // 
            this.btnHistorialPago.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHistorialPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorialPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHistorialPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistorialPago.BorderRadius = 0;
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
            this.btnHistorialPago.IconZoom = 80D;
            this.btnHistorialPago.IsTab = true;
            this.btnHistorialPago.Location = new System.Drawing.Point(552, 100);
            this.btnHistorialPago.Name = "btnHistorialPago";
            this.btnHistorialPago.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHistorialPago.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnHistorialPago.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHistorialPago.selected = false;
            this.btnHistorialPago.Size = new System.Drawing.Size(187, 55);
            this.btnHistorialPago.TabIndex = 13;
            this.btnHistorialPago.Text = "              PAGOS";
            this.btnHistorialPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialPago.Textcolor = System.Drawing.Color.Silver;
            this.btnHistorialPago.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnContacto
            // 
            this.btnContacto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContacto.BorderRadius = 0;
            this.btnContacto.ButtonText = "              LLAMADAS";
            this.btnContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContacto.DisabledColor = System.Drawing.Color.Gray;
            this.btnContacto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContacto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnContacto.Iconimage")));
            this.btnContacto.Iconimage_right = null;
            this.btnContacto.Iconimage_right_Selected = null;
            this.btnContacto.Iconimage_Selected = null;
            this.btnContacto.IconMarginLeft = 0;
            this.btnContacto.IconMarginRight = 0;
            this.btnContacto.IconRightVisible = true;
            this.btnContacto.IconRightZoom = 0D;
            this.btnContacto.IconVisible = true;
            this.btnContacto.IconZoom = 80D;
            this.btnContacto.IsTab = true;
            this.btnContacto.Location = new System.Drawing.Point(552, 26);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnContacto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnContacto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnContacto.selected = false;
            this.btnContacto.Size = new System.Drawing.Size(187, 51);
            this.btnContacto.TabIndex = 14;
            this.btnContacto.Text = "              LLAMADAS";
            this.btnContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacto.Textcolor = System.Drawing.Color.Silver;
            this.btnContacto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // controlDeCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.btnContacto);
            this.Controls.Add(this.btnHistorialPago);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.DGClientes);
            this.Controls.Add(this.TxtClientes);
            this.Controls.Add(this.bunifuTileButton1);
            this.Name = "controlDeCreditos";
            this.Size = new System.Drawing.Size(767, 517);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNombres;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private Bunifu.Framework.UI.BunifuTextbox TxtClientes;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHistorialPago;
        private Bunifu.Framework.UI.BunifuFlatButton btnContacto;
    }
}
