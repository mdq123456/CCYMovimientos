namespace CCYMovimientos.Vistas.Menu
{
    partial class MenuPrincipal
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.menuLeft = new System.Windows.Forms.Panel();
            this.btnHVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCreditos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFondos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuLeftAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTitulo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelesAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuLeft.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // menuLeft
            // 
            this.menuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.menuLeft.Controls.Add(this.btnHVentas);
            this.menuLeft.Controls.Add(this.btnCerrarSesion);
            this.menuLeft.Controls.Add(this.panel4);
            this.menuLeft.Controls.Add(this.btnCreditos);
            this.menuLeft.Controls.Add(this.btnVentas);
            this.menuLeft.Controls.Add(this.btnFondos);
            this.menuLeft.Controls.Add(this.btnClientes);
            this.panelesAnimator.SetDecoration(this.menuLeft, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.menuLeft, BunifuAnimatorNS.DecorationType.None);
            this.menuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLeft.Location = new System.Drawing.Point(0, 0);
            this.menuLeft.Name = "menuLeft";
            this.menuLeft.Size = new System.Drawing.Size(234, 416);
            this.menuLeft.TabIndex = 0;
            // 
            // btnHVentas
            // 
            this.btnHVentas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHVentas.BorderRadius = 0;
            this.btnHVentas.ButtonText = "         HISTORIAL VENTAS";
            this.btnHVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelesAnimator.SetDecoration(this.btnHVentas, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnHVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnHVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnHVentas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHVentas.Iconimage")));
            this.btnHVentas.Iconimage_right = null;
            this.btnHVentas.Iconimage_right_Selected = null;
            this.btnHVentas.Iconimage_Selected = null;
            this.btnHVentas.IconMarginLeft = 20;
            this.btnHVentas.IconMarginRight = 0;
            this.btnHVentas.IconRightVisible = true;
            this.btnHVentas.IconRightZoom = 0D;
            this.btnHVentas.IconVisible = true;
            this.btnHVentas.IconZoom = 90D;
            this.btnHVentas.IsTab = true;
            this.btnHVentas.Location = new System.Drawing.Point(0, 286);
            this.btnHVentas.Name = "btnHVentas";
            this.btnHVentas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnHVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHVentas.selected = false;
            this.btnHVentas.Size = new System.Drawing.Size(240, 51);
            this.btnHVentas.TabIndex = 7;
            this.btnHVentas.Text = "         HISTORIAL VENTAS";
            this.btnHVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHVentas.Textcolor = System.Drawing.Color.Silver;
            this.btnHVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHVentas.Click += new System.EventHandler(this.btnHVentas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.BorderRadius = 0;
            this.btnCerrarSesion.ButtonText = "         CERRAR SESION";
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelesAnimator.SetDecoration(this.btnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarSesion.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Iconimage")));
            this.btnCerrarSesion.Iconimage_right = null;
            this.btnCerrarSesion.Iconimage_right_Selected = null;
            this.btnCerrarSesion.Iconimage_Selected = null;
            this.btnCerrarSesion.IconMarginLeft = 20;
            this.btnCerrarSesion.IconMarginRight = 0;
            this.btnCerrarSesion.IconRightVisible = true;
            this.btnCerrarSesion.IconRightZoom = 0D;
            this.btnCerrarSesion.IconVisible = true;
            this.btnCerrarSesion.IconZoom = 90D;
            this.btnCerrarSesion.IsTab = true;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 361);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnCerrarSesion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnCerrarSesion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.selected = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(240, 51);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "         CERRAR SESION";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Textcolor = System.Drawing.Color.Silver;
            this.btnCerrarSesion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel4.Controls.Add(this.btnMenu);
            this.panelesAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 60);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.btnCreditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreditos.BorderRadius = 0;
            this.btnCreditos.ButtonText = "              CREDITOS";
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelesAnimator.SetDecoration(this.btnCreditos, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnCreditos, BunifuAnimatorNS.DecorationType.None);
            this.btnCreditos.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreditos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreditos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreditos.Iconimage")));
            this.btnCreditos.Iconimage_right = null;
            this.btnCreditos.Iconimage_right_Selected = null;
            this.btnCreditos.Iconimage_Selected = null;
            this.btnCreditos.IconMarginLeft = 20;
            this.btnCreditos.IconMarginRight = 0;
            this.btnCreditos.IconRightVisible = true;
            this.btnCreditos.IconRightZoom = 0D;
            this.btnCreditos.IconVisible = true;
            this.btnCreditos.IconZoom = 60D;
            this.btnCreditos.IsTab = true;
            this.btnCreditos.Location = new System.Drawing.Point(0, 229);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnCreditos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnCreditos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreditos.selected = false;
            this.btnCreditos.Size = new System.Drawing.Size(240, 51);
            this.btnCreditos.TabIndex = 4;
            this.btnCreditos.Text = "              CREDITOS";
            this.btnCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditos.Textcolor = System.Drawing.Color.Silver;
            this.btnCreditos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Visible = false;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "         VENTAS";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelesAnimator.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage")));
            this.btnVentas.Iconimage_right = null;
            this.btnVentas.Iconimage_right_Selected = null;
            this.btnVentas.Iconimage_Selected = null;
            this.btnVentas.IconMarginLeft = 20;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 90D;
            this.btnVentas.IsTab = true;
            this.btnVentas.Location = new System.Drawing.Point(0, 172);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(240, 51);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "         VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Textcolor = System.Drawing.Color.Silver;
            this.btnVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnFondos
            // 
            this.btnFondos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.btnFondos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnFondos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFondos.BorderRadius = 0;
            this.btnFondos.ButtonText = "         FONDOS";
            this.btnFondos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelesAnimator.SetDecoration(this.btnFondos, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnFondos, BunifuAnimatorNS.DecorationType.None);
            this.btnFondos.DisabledColor = System.Drawing.Color.Gray;
            this.btnFondos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFondos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFondos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFondos.Iconimage")));
            this.btnFondos.Iconimage_right = null;
            this.btnFondos.Iconimage_right_Selected = null;
            this.btnFondos.Iconimage_Selected = null;
            this.btnFondos.IconMarginLeft = 20;
            this.btnFondos.IconMarginRight = 0;
            this.btnFondos.IconRightVisible = true;
            this.btnFondos.IconRightZoom = 0D;
            this.btnFondos.IconVisible = true;
            this.btnFondos.IconZoom = 90D;
            this.btnFondos.IsTab = true;
            this.btnFondos.Location = new System.Drawing.Point(0, 115);
            this.btnFondos.Name = "btnFondos";
            this.btnFondos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnFondos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnFondos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFondos.selected = false;
            this.btnFondos.Size = new System.Drawing.Size(240, 51);
            this.btnFondos.TabIndex = 2;
            this.btnFondos.Text = "         FONDOS";
            this.btnFondos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFondos.Textcolor = System.Drawing.Color.Silver;
            this.btnFondos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFondos.Click += new System.EventHandler(this.btnFondo_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "         CLIENTES";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelesAnimator.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 20;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 90D;
            this.btnClientes.IsTab = true;
            this.btnClientes.Location = new System.Drawing.Point(0, 60);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnClientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(240, 51);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "         CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.Silver;
            this.btnClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // Drag
            // 
            this.Drag.Fixed = true;
            this.Drag.Horizontal = true;
            this.Drag.TargetControl = null;
            this.Drag.Vertical = true;
            // 
            // menuLeftAnimator
            // 
            this.menuLeftAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.menuLeftAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.menuLeftAnimator.DefaultAnimation = animation2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panelesAnimator.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.btnTitulo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panelesAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(234, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 60);
            this.panel1.TabIndex = 3;
            // 
            // btnTitulo
            // 
            this.btnTitulo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTitulo.BorderRadius = 0;
            this.btnTitulo.ButtonText = "";
            this.btnTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelesAnimator.SetDecoration(this.btnTitulo, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnTitulo, BunifuAnimatorNS.DecorationType.None);
            this.btnTitulo.DisabledColor = System.Drawing.Color.Gray;
            this.btnTitulo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitulo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTitulo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTitulo.Iconimage")));
            this.btnTitulo.Iconimage_right = null;
            this.btnTitulo.Iconimage_right_Selected = null;
            this.btnTitulo.Iconimage_Selected = null;
            this.btnTitulo.IconMarginLeft = 0;
            this.btnTitulo.IconMarginRight = 0;
            this.btnTitulo.IconRightVisible = true;
            this.btnTitulo.IconRightZoom = 0D;
            this.btnTitulo.IconVisible = true;
            this.btnTitulo.IconZoom = 60D;
            this.btnTitulo.IsTab = true;
            this.btnTitulo.Location = new System.Drawing.Point(3, 5);
            this.btnTitulo.Name = "btnTitulo";
            this.btnTitulo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnTitulo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnTitulo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTitulo.selected = false;
            this.btnTitulo.Size = new System.Drawing.Size(56, 51);
            this.btnTitulo.TabIndex = 75;
            this.btnTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitulo.Textcolor = System.Drawing.Color.Silver;
            this.btnTitulo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitulo.Click += new System.EventHandler(this.btnTitulo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.menuLeftAnimator.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.panelesAnimator.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Location = new System.Drawing.Point(59, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(343, 47);
            this.lblTitulo.TabIndex = 74;
            this.lblTitulo.Text = " Construcciones NEA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMin);
            this.panelesAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(350, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(58, 60);
            this.panel3.TabIndex = 4;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panelesAnimator.SetDecoration(this.btnMin, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnMin, BunifuAnimatorNS.DecorationType.None);
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(13, 13);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panelesAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(408, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 60);
            this.panel2.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.panelesAnimator.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(234, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(466, 356);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.Visible = false;
            // 
            // panelesAnimator
            // 
            this.panelesAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.panelesAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelesAnimator.DefaultAnimation = animation1;
            this.panelesAnimator.Interval = 0;
            this.panelesAnimator.TimeStep = 0.1F;
            // 
            // btnMenu
            // 
            this.btnMenu.Activecolor = System.Drawing.Color.Transparent;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.ButtonText = "";
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelesAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenu.Iconimage")));
            this.btnMenu.Iconimage_right = null;
            this.btnMenu.Iconimage_right_Selected = null;
            this.btnMenu.Iconimage_Selected = null;
            this.btnMenu.IconMarginLeft = 35;
            this.btnMenu.IconMarginRight = 0;
            this.btnMenu.IconRightVisible = true;
            this.btnMenu.IconRightZoom = 0D;
            this.btnMenu.IconVisible = true;
            this.btnMenu.IconZoom = 60D;
            this.btnMenu.IsTab = true;
            this.btnMenu.Location = new System.Drawing.Point(150, 7);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenu.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenu.selected = false;
            this.btnMenu.Size = new System.Drawing.Size(81, 51);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenu.Textcolor = System.Drawing.Color.Silver;
            this.btnMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(700, 416);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuLeft);
            this.menuLeftAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelesAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.Resize += new System.EventHandler(this.MenuPrincipal_Resize);
            this.menuLeft.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel menuLeft;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuDragControl Drag;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreditos;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnFondos;
        private BunifuAnimatorNS.BunifuTransition menuLeftAnimator;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition panelesAnimator;
        
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrarSesion;
        private Bunifu.Framework.UI.BunifuFlatButton btnHVentas;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuFlatButton btnTitulo;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenu;
    }
}