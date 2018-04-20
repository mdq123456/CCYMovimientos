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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.TxtCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DGPagos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnReImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel12);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 60);
            this.panel1.TabIndex = 35;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(28, 7);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(300, 47);
            this.bunifuCustomLabel12.TabIndex = 76;
            this.bunifuCustomLabel12.Text = "Historial de Pagos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(878, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 60);
            this.panel2.TabIndex = 3;
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
            this.TxtCliente.Location = new System.Drawing.Point(104, 87);
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGPagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGPagos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk});
            this.DGPagos.DoubleBuffered = true;
            this.DGPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGPagos.EnableHeadersVisualStyles = false;
            this.DGPagos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.DGPagos.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.DGPagos.Location = new System.Drawing.Point(18, 173);
            this.DGPagos.Name = "DGPagos";
            this.DGPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGPagos.Size = new System.Drawing.Size(888, 355);
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 101);
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
            this.btnReImprimir.Location = new System.Drawing.Point(865, 90);
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
            // HistorialPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(922, 549);
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
            ((System.ComponentModel.ISupportInitialize)(this.DGPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCliente;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGPagos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnReImprimir;
    }
}