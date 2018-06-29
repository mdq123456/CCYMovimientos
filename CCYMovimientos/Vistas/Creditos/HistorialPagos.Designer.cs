namespace CCYMovimientos.Vistas.Creditos
{
    partial class HistorialPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialPagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DGPagos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnReImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DGFormas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGFormas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuCustomLabel12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 60);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(864, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 60);
            this.panel2.TabIndex = 135;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(9, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(57, 56);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 134;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(66, 7);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(300, 47);
            this.bunifuCustomLabel12.TabIndex = 76;
            this.bunifuCustomLabel12.Text = "Historial de Pagos";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCliente.Enabled = false;
            this.TxtCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.ForeColor = System.Drawing.Color.Black;
            this.TxtCliente.HintForeColor = System.Drawing.Color.Black;
            this.TxtCliente.HintText = "";
            this.TxtCliente.isPassword = false;
            this.TxtCliente.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtCliente.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtCliente.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtCliente.LineThickness = 4;
            this.TxtCliente.Location = new System.Drawing.Point(104, 74);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(596, 41);
            this.TxtCliente.TabIndex = 103;
            this.TxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DGPagos
            // 
            this.DGPagos.AllowUserToAddRows = false;
            this.DGPagos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGPagos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGPagos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk});
            this.DGPagos.DoubleBuffered = true;
            this.DGPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGPagos.EnableHeadersVisualStyles = false;
            this.DGPagos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.DGPagos.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.DGPagos.Location = new System.Drawing.Point(18, 150);
            this.DGPagos.Name = "DGPagos";
            this.DGPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGPagos.Size = new System.Drawing.Size(888, 278);
            this.DGPagos.TabIndex = 102;
            this.DGPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPagos_CellClick);
            // 
            // Chk
            // 
            this.Chk.HeaderText = "";
            this.Chk.Name = "Chk";
            this.Chk.Width = 5;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 88);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel2.TabIndex = 101;
            this.bunifuCustomLabel2.Text = "Cliente :";
            // 
            // btnReImprimir
            // 
            this.btnReImprimir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnReImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnReImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReImprimir.BorderRadius = 5;
            this.btnReImprimir.ButtonText = "";
            this.btnReImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReImprimir.DisabledColor = System.Drawing.Color.Gray;
            this.btnReImprimir.Enabled = false;
            this.btnReImprimir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReImprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReImprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReImprimir.Iconimage")));
            this.btnReImprimir.Iconimage_right = null;
            this.btnReImprimir.Iconimage_right_Selected = null;
            this.btnReImprimir.Iconimage_Selected = null;
            this.btnReImprimir.IconMarginLeft = 0;
            this.btnReImprimir.IconMarginRight = 0;
            this.btnReImprimir.IconRightVisible = true;
            this.btnReImprimir.IconRightZoom = 0D;
            this.btnReImprimir.IconVisible = true;
            this.btnReImprimir.IconZoom = 70D;
            this.btnReImprimir.IsTab = true;
            this.btnReImprimir.Location = new System.Drawing.Point(865, 77);
            this.btnReImprimir.Name = "btnReImprimir";
            this.btnReImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnReImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(67)))));
            this.btnReImprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReImprimir.selected = false;
            this.btnReImprimir.Size = new System.Drawing.Size(41, 38);
            this.btnReImprimir.TabIndex = 104;
            this.btnReImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReImprimir.Textcolor = System.Drawing.Color.Silver;
            this.btnReImprimir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReImprimir.Click += new System.EventHandler(this.btnReImprimir_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(755, 88);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 21);
            this.bunifuCustomLabel1.TabIndex = 105;
            this.bunifuCustomLabel1.Text = "Re-Impresion";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 119);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(172, 30);
            this.bunifuCustomLabel5.TabIndex = 133;
            this.bunifuCustomLabel5.Text = "Pagos del Cliente";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(14, 436);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(161, 30);
            this.bunifuCustomLabel3.TabIndex = 135;
            this.bunifuCustomLabel3.Text = "Formas de Pago";
            // 
            // DGFormas
            // 
            this.DGFormas.AllowUserToAddRows = false;
            this.DGFormas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGFormas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGFormas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGFormas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGFormas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGFormas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGFormas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGFormas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGFormas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFormas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.DGFormas.DoubleBuffered = true;
            this.DGFormas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGFormas.EnableHeadersVisualStyles = false;
            this.DGFormas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.DGFormas.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.DGFormas.Location = new System.Drawing.Point(20, 467);
            this.DGFormas.Name = "DGFormas";
            this.DGFormas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGFormas.Size = new System.Drawing.Size(888, 148);
            this.DGFormas.TabIndex = 134;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 5;
            // 
            // HistorialPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(922, 631);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.DGFormas);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnReImprimir);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.DGPagos);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistorialPagos";
            this.Load += new System.EventHandler(this.HistorialPagos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGFormas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCliente;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGPagos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnReImprimir;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGFormas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}