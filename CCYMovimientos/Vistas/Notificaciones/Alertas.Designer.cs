namespace CCYMovimientos.Vistas.Notificaciones
{
    partial class Alertas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alertas));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNuevoCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblMsj = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timeOut = new System.Windows.Forms.Timer(this.components);
            this.timeShow = new System.Windows.Forms.Timer(this.components);
            this.timeClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNuevoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoCliente.BorderRadius = 0;
            this.btnNuevoCliente.ButtonText = "";
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Arrow;
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
            this.btnNuevoCliente.IconZoom = 100D;
            this.btnNuevoCliente.IsTab = true;
            this.btnNuevoCliente.Location = new System.Drawing.Point(16, 16);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNuevoCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNuevoCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoCliente.selected = false;
            this.btnNuevoCliente.Size = new System.Drawing.Size(52, 50);
            this.btnNuevoCliente.TabIndex = 74;
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.Textcolor = System.Drawing.Color.Silver;
            this.btnNuevoCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(753, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 75;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMsj
            // 
            this.lblMsj.AutoSize = true;
            this.lblMsj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsj.ForeColor = System.Drawing.Color.White;
            this.lblMsj.Location = new System.Drawing.Point(74, 25);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(68, 21);
            this.lblMsj.TabIndex = 102;
            this.lblMsj.Text = "Mensaje";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timeOut
            // 
            this.timeOut.Enabled = true;
            this.timeOut.Interval = 5000;
            this.timeOut.Tick += new System.EventHandler(this.timeOut_Tick);
            // 
            // timeShow
            // 
            this.timeShow.Tick += new System.EventHandler(this.timeShow_Tick);
            // 
            // timeClose
            // 
            this.timeClose.Tick += new System.EventHandler(this.timeClose_Tick);
            // 
            // Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(778, 81);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNuevoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alertas";
            this.Opacity = 0.95D;
            this.Text = "Alertas";
            this.Load += new System.EventHandler(this.Alertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoCliente;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMsj;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timeOut;
        private System.Windows.Forms.Timer timeShow;
        private System.Windows.Forms.Timer timeClose;
    }
}