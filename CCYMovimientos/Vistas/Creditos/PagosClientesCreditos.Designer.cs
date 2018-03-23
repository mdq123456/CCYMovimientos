namespace CCYMovimientos.Vistas.Creditos
{
    partial class PagosClientesCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagosClientesCreditos));
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChActivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cboFechaPago = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtConcepto = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtNroCheque = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboFecha2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cboFecha1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbl3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txt4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSaldoTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtImporte = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DGCreditos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.lbl90 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Importe = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCreditos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.ChActivo);
            this.panel3.Controls.Add(this.cboFechaPago);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.TxtConcepto);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.TxtNroCheque);
            this.panel3.Controls.Add(this.lbl5);
            this.panel3.Controls.Add(this.lbl4);
            this.panel3.Controls.Add(this.cboFecha2);
            this.panel3.Controls.Add(this.cboFecha1);
            this.panel3.Controls.Add(this.lbl3);
            this.panel3.Controls.Add(this.lbl2);
            this.panel3.Controls.Add(this.Txt1);
            this.panel3.Controls.Add(this.lbl1);
            this.panel3.Controls.Add(this.Txt2);
            this.panel3.Controls.Add(this.Txt4);
            this.panel3.Controls.Add(this.bunifuCustomLabel7);
            this.panel3.Controls.Add(this.TxtSaldoTotal);
            this.panel3.Controls.Add(this.TxtCliente);
            this.panel3.Controls.Add(this.TxtImporte);
            this.panel3.Controls.Add(this.DGCreditos);
            this.panel3.Controls.Add(this.cboFormaPago);
            this.panel3.Controls.Add(this.lbl90);
            this.panel3.Controls.Add(this.Importe);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(992, 680);
            this.panel3.TabIndex = 35;
            // 
            // ChActivo
            // 
            this.ChActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChActivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChActivo.Checked = false;
            this.ChActivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.ChActivo.ForeColor = System.Drawing.Color.White;
            this.ChActivo.Location = new System.Drawing.Point(343, 60);
            this.ChActivo.Name = "ChActivo";
            this.ChActivo.Size = new System.Drawing.Size(20, 20);
            this.ChActivo.TabIndex = 119;
            this.ChActivo.OnChange += new System.EventHandler(this.ChActivo_OnChange);
            // 
            // cboFechaPago
            // 
            this.cboFechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.cboFechaPago.BorderRadius = 0;
            this.cboFechaPago.ForeColor = System.Drawing.Color.White;
            this.cboFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cboFechaPago.FormatCustom = null;
            this.cboFechaPago.Location = new System.Drawing.Point(188, 232);
            this.cboFechaPago.Name = "cboFechaPago";
            this.cboFechaPago.Size = new System.Drawing.Size(234, 36);
            this.cboFechaPago.TabIndex = 9;
            this.cboFechaPago.Value = new System.DateTime(2017, 11, 3, 17, 21, 40, 929);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(40, 239);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(116, 21);
            this.bunifuCustomLabel3.TabIndex = 103;
            this.bunifuCustomLabel3.Text = "Fecha de Pago :";
            // 
            // TxtConcepto
            // 
            this.TxtConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConcepto.Location = new System.Drawing.Point(188, 275);
            this.TxtConcepto.Name = "TxtConcepto";
            this.TxtConcepto.Size = new System.Drawing.Size(762, 49);
            this.TxtConcepto.TabIndex = 10;
            this.TxtConcepto.Text = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 280);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(83, 21);
            this.bunifuCustomLabel1.TabIndex = 101;
            this.bunifuCustomLabel1.Text = "Concepto :";
            // 
            // TxtNroCheque
            // 
            this.TxtNroCheque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNroCheque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNroCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroCheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNroCheque.HintForeColor = System.Drawing.Color.Empty;
            this.TxtNroCheque.HintText = "";
            this.TxtNroCheque.isPassword = false;
            this.TxtNroCheque.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtNroCheque.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtNroCheque.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtNroCheque.LineThickness = 4;
            this.TxtNroCheque.Location = new System.Drawing.Point(753, 183);
            this.TxtNroCheque.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNroCheque.Name = "TxtNroCheque";
            this.TxtNroCheque.Size = new System.Drawing.Size(198, 41);
            this.TxtNroCheque.TabIndex = 8;
            this.TxtNroCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNroCheque.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(629, 198);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(122, 21);
            this.lbl5.TabIndex = 99;
            this.lbl5.Text = "Nro de Cheque :";
            this.lbl5.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(40, 198);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(98, 21);
            this.lbl4.TabIndex = 98;
            this.lbl4.Text = "Beneficiario :";
            this.lbl4.Visible = false;
            // 
            // cboFecha2
            // 
            this.cboFecha2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFecha2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.cboFecha2.BorderRadius = 0;
            this.cboFecha2.ForeColor = System.Drawing.Color.White;
            this.cboFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cboFecha2.FormatCustom = null;
            this.cboFecha2.Location = new System.Drawing.Point(726, 142);
            this.cboFecha2.Name = "cboFecha2";
            this.cboFecha2.Size = new System.Drawing.Size(225, 36);
            this.cboFecha2.TabIndex = 5;
            this.cboFecha2.Value = new System.DateTime(2017, 11, 3, 17, 21, 40, 929);
            this.cboFecha2.Visible = false;
            // 
            // cboFecha1
            // 
            this.cboFecha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.cboFecha1.BorderRadius = 0;
            this.cboFecha1.ForeColor = System.Drawing.Color.White;
            this.cboFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cboFecha1.FormatCustom = null;
            this.cboFecha1.Location = new System.Drawing.Point(188, 142);
            this.cboFecha1.Name = "cboFecha1";
            this.cboFecha1.Size = new System.Drawing.Size(234, 36);
            this.cboFecha1.TabIndex = 4;
            this.cboFecha1.Value = new System.DateTime(2017, 11, 3, 17, 21, 40, 929);
            this.cboFecha1.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(598, 149);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(125, 21);
            this.lbl3.TabIndex = 97;
            this.lbl3.Text = "Fecha de Cobro :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(40, 149);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(137, 21);
            this.lbl2.TabIndex = 96;
            this.lbl2.Text = "Fecha de Emision :";
            this.lbl2.Visible = false;
            // 
            // Txt1
            // 
            this.Txt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt1.HintForeColor = System.Drawing.Color.Empty;
            this.Txt1.HintText = "";
            this.Txt1.isPassword = false;
            this.Txt1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.Txt1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.Txt1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.Txt1.LineThickness = 4;
            this.Txt1.Location = new System.Drawing.Point(188, 91);
            this.Txt1.Margin = new System.Windows.Forms.Padding(4);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(593, 41);
            this.Txt1.TabIndex = 3;
            this.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt1.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(40, 106);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 21);
            this.lbl1.TabIndex = 95;
            this.lbl1.Text = "Banco :";
            this.lbl1.Visible = false;
            // 
            // Txt2
            // 
            this.Txt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Txt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt2.HintForeColor = System.Drawing.Color.Empty;
            this.Txt2.HintText = "";
            this.Txt2.isPassword = false;
            this.Txt2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.Txt2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.Txt2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.Txt2.LineThickness = 4;
            this.Txt2.Location = new System.Drawing.Point(188, 137);
            this.Txt2.Margin = new System.Windows.Forms.Padding(4);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(234, 41);
            this.Txt2.TabIndex = 6;
            this.Txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt2.Visible = false;
            // 
            // Txt4
            // 
            this.Txt4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt4.HintForeColor = System.Drawing.Color.Empty;
            this.Txt4.HintText = "";
            this.Txt4.isPassword = false;
            this.Txt4.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.Txt4.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.Txt4.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.Txt4.LineThickness = 4;
            this.Txt4.Location = new System.Drawing.Point(188, 182);
            this.Txt4.Margin = new System.Windows.Forms.Padding(4);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(261, 41);
            this.Txt4.TabIndex = 7;
            this.Txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt4.Visible = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(694, 334);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(136, 25);
            this.bunifuCustomLabel7.TabIndex = 60;
            this.bunifuCustomLabel7.Text = "Saldo Total $ :";
            // 
            // TxtSaldoTotal
            // 
            this.TxtSaldoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSaldoTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSaldoTotal.Enabled = false;
            this.TxtSaldoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaldoTotal.ForeColor = System.Drawing.Color.Black;
            this.TxtSaldoTotal.HintForeColor = System.Drawing.Color.Black;
            this.TxtSaldoTotal.HintText = "";
            this.TxtSaldoTotal.isPassword = false;
            this.TxtSaldoTotal.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtSaldoTotal.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtSaldoTotal.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtSaldoTotal.LineThickness = 4;
            this.TxtSaldoTotal.Location = new System.Drawing.Point(832, 327);
            this.TxtSaldoTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSaldoTotal.Name = "TxtSaldoTotal";
            this.TxtSaldoTotal.Size = new System.Drawing.Size(119, 41);
            this.TxtSaldoTotal.TabIndex = 59;
            this.TxtSaldoTotal.Text = "0";
            this.TxtSaldoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtCliente
            // 
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
            this.TxtCliente.Location = new System.Drawing.Point(188, 3);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(596, 41);
            this.TxtCliente.TabIndex = 100;
            this.TxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtImporte.Enabled = false;
            this.TxtImporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporte.ForeColor = System.Drawing.Color.Black;
            this.TxtImporte.HintForeColor = System.Drawing.Color.Black;
            this.TxtImporte.HintText = "";
            this.TxtImporte.isPassword = false;
            this.TxtImporte.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtImporte.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.TxtImporte.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.TxtImporte.LineThickness = 4;
            this.TxtImporte.Location = new System.Drawing.Point(188, 46);
            this.TxtImporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(137, 41);
            this.TxtImporte.TabIndex = 1;
            this.TxtImporte.Text = "0";
            this.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DGCreditos
            // 
            this.DGCreditos.AllowUserToAddRows = false;
            this.DGCreditos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGCreditos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGCreditos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGCreditos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGCreditos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGCreditos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCreditos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk});
            this.DGCreditos.DoubleBuffered = true;
            this.DGCreditos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGCreditos.EnableHeadersVisualStyles = false;
            this.DGCreditos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.DGCreditos.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.DGCreditos.Location = new System.Drawing.Point(44, 372);
            this.DGCreditos.Name = "DGCreditos";
            this.DGCreditos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCreditos.Size = new System.Drawing.Size(907, 224);
            this.DGCreditos.TabIndex = 62;
            this.DGCreditos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCreditos_CellClick);
            // 
            // Chk
            // 
            this.Chk.HeaderText = "";
            this.Chk.Name = "Chk";
            this.Chk.Width = 5;
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFormaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.cboFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPago.ForeColor = System.Drawing.Color.White;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(729, 53);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(225, 33);
            this.cboFormaPago.TabIndex = 2;
            this.cboFormaPago.SelectedValueChanged += new System.EventHandler(this.cboFormaPago_SelectedValueChanged);
            // 
            // lbl90
            // 
            this.lbl90.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl90.AutoSize = true;
            this.lbl90.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl90.Location = new System.Drawing.Point(602, 59);
            this.lbl90.Name = "lbl90";
            this.lbl90.Size = new System.Drawing.Size(121, 21);
            this.lbl90.TabIndex = 48;
            this.lbl90.Text = "Forma de Pago :";
            // 
            // Importe
            // 
            this.Importe.AutoSize = true;
            this.Importe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Importe.Location = new System.Drawing.Point(40, 59);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(85, 21);
            this.Importe.TabIndex = 37;
            this.Importe.Text = "Importe $ :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 20;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnGuardar.Location = new System.Drawing.Point(773, 612);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(181, 41);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.btnCancelar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(64)))), ((int)(((byte)(48)))));
            this.btnCancelar.Location = new System.Drawing.Point(632, 612);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 41);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(40, 17);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel2.TabIndex = 28;
            this.bunifuCustomLabel2.Text = "Cliente :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel12);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 60);
            this.panel1.TabIndex = 34;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(28, 7);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(302, 47);
            this.bunifuCustomLabel12.TabIndex = 76;
            this.bunifuCustomLabel12.Text = "Pagos de Créditos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(948, 0);
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
            // PagosClientesCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(992, 740);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagosClientesCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagosClientesCreditos";
            this.Load += new System.EventHandler(this.PagosClientesCreditos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCreditos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl90;
        private Bunifu.Framework.UI.BunifuCustomLabel Importe;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtSaldoTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DGCreditos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCliente;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtImporte;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtNroCheque;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl5;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl4;
        private Bunifu.Framework.UI.BunifuDatepicker cboFecha2;
        private Bunifu.Framework.UI.BunifuDatepicker cboFecha1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl3;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.RichTextBox TxtConcepto;
        private Bunifu.Framework.UI.BunifuDatepicker cboFechaPago;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCheckbox ChActivo;
    }
}