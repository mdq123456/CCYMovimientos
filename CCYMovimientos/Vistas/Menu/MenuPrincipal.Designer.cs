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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCreditos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFondos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuLeftAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelesAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuLeft.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
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
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelesAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(192, 16);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            this.btnCreditos.IconMarginLeft = 0;
            this.btnCreditos.IconMarginRight = 0;
            this.btnCreditos.IconRightVisible = true;
            this.btnCreditos.IconRightZoom = 0D;
            this.btnCreditos.IconVisible = true;
            this.btnCreditos.IconZoom = 55D;
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
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "              VENTAS";
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
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 55D;
            this.btnVentas.IsTab = true;
            this.btnVentas.Location = new System.Drawing.Point(0, 172);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(240, 51);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "              VENTAS";
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
            this.btnFondos.ButtonText = "              FONDOS";
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
            this.btnFondos.IconMarginLeft = 0;
            this.btnFondos.IconMarginRight = 0;
            this.btnFondos.IconRightVisible = true;
            this.btnFondos.IconRightZoom = 0D;
            this.btnFondos.IconVisible = true;
            this.btnFondos.IconZoom = 55D;
            this.btnFondos.IsTab = true;
            this.btnFondos.Location = new System.Drawing.Point(0, 115);
            this.btnFondos.Name = "btnFondos";
            this.btnFondos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnFondos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnFondos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFondos.selected = false;
            this.btnFondos.Size = new System.Drawing.Size(240, 51);
            this.btnFondos.TabIndex = 2;
            this.btnFondos.Text = "              FONDOS";
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
            this.btnClientes.ButtonText = "              CLIENTES";
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
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 55D;
            this.btnClientes.IsTab = true;
            this.btnClientes.Location = new System.Drawing.Point(0, 60);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnClientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(240, 51);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "              CLIENTES";
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
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMin);
            this.panelesAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.menuLeftAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(378, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(44, 60);
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
            this.btnMin.Size = new System.Drawing.Size(25, 25);
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
            this.panel2.Location = new System.Drawing.Point(422, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 60);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.Resize += new System.EventHandler(this.MenuPrincipal_Resize);
            this.menuLeft.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Panel panelMenu;
    }
}