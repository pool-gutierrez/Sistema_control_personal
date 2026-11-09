namespace Sistema_control_personal
{
    partial class Principal_emp
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_emp));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunicurva = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buniida = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelbarra = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.panelinformacion = new System.Windows.Forms.Panel();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.bunimenu = new System.Windows.Forms.Panel();
            this.panel_usuario = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.btninfo = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnmant = new System.Windows.Forms.Button();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.panelmant = new System.Windows.Forms.Panel();
            this.btnemp = new System.Windows.Forms.Button();
            this.panelusu = new System.Windows.Forms.Panel();
            this.btnadminusu = new System.Windows.Forms.Button();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.bunivuelta = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.hora_fecha = new System.Windows.Forms.Timer(this.components);
            this.curvaprincipal = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelbarra.SuspendLayout();
            this.panelinformacion.SuspendLayout();
            this.panelprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelmenu.SuspendLayout();
            this.bunimenu.SuspendLayout();
            this.panel_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelmant.SuspendLayout();
            this.panelusu.SuspendLayout();
            this.panelinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunicurva
            // 
            this.bunicurva.ElipseRadius = 7;
            this.bunicurva.TargetControl = this;
            // 
            // buniida
            // 
            this.buniida.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.buniida.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
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
            animation1.TransparencyCoeff = 1F;
            this.buniida.DefaultAnimation = animation1;
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniida.SetDecoration(this.btnsalir, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnsalir, BunifuAnimatorNS.DecorationType.None);
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(1369, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(31, 25);
            this.btnsalir.TabIndex = 17;
            this.btnsalir.Text = "x";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniida.SetDecoration(this.btnmin, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnmin, BunifuAnimatorNS.DecorationType.None);
            this.btnmin.FlatAppearance.BorderSize = 0;
            this.btnmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.White;
            this.btnmin.Location = new System.Drawing.Point(1310, 0);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(31, 25);
            this.btnmin.TabIndex = 18;
            this.btnmin.Text = "─";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniida.SetDecoration(this.btnmax, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnmax, BunifuAnimatorNS.DecorationType.None);
            this.btnmax.FlatAppearance.BorderSize = 0;
            this.btnmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmax.ForeColor = System.Drawing.Color.White;
            this.btnmax.Location = new System.Drawing.Point(1339, 0);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(31, 25);
            this.btnmax.TabIndex = 19;
            this.btnmax.Text = "■";
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniida.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panelbarra
            // 
            this.panelbarra.BackColor = System.Drawing.Color.DarkCyan;
            this.panelbarra.Controls.Add(this.pictureBox1);
            this.panelbarra.Controls.Add(this.btnmax);
            this.panelbarra.Controls.Add(this.btnmin);
            this.panelbarra.Controls.Add(this.btnsalir);
            this.panelbarra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunivuelta.SetDecoration(this.panelbarra, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelbarra, BunifuAnimatorNS.DecorationType.None);
            this.panelbarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbarra.Location = new System.Drawing.Point(0, 0);
            this.panelbarra.Name = "panelbarra";
            this.panelbarra.Size = new System.Drawing.Size(1400, 25);
            this.panelbarra.TabIndex = 0;
            this.panelbarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelbarra_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.buniida.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(461, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Copyright © 2019 Gutierrez - Rodriguez. Todos los derechos reservados.";
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.buniida.SetDecoration(this.lblhora, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.lblhora, BunifuAnimatorNS.DecorationType.None);
            this.lblhora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.White;
            this.lblhora.Location = new System.Drawing.Point(1257, 4);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(55, 16);
            this.lblhora.TabIndex = 22;
            this.lblhora.Text = "11:11:11";
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.buniida.SetDecoration(this.lblfecha, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.lblfecha, BunifuAnimatorNS.DecorationType.None);
            this.lblfecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.White;
            this.lblfecha.Location = new System.Drawing.Point(1327, 4);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(70, 16);
            this.lblfecha.TabIndex = 23;
            this.lblfecha.Text = "11/11/2019";
            // 
            // panelinformacion
            // 
            this.panelinformacion.BackColor = System.Drawing.Color.DarkCyan;
            this.panelinformacion.Controls.Add(this.lblfecha);
            this.panelinformacion.Controls.Add(this.lblhora);
            this.panelinformacion.Controls.Add(this.label4);
            this.bunivuelta.SetDecoration(this.panelinformacion, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelinformacion, BunifuAnimatorNS.DecorationType.None);
            this.panelinformacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelinformacion.Location = new System.Drawing.Point(0, 829);
            this.panelinformacion.Name = "panelinformacion";
            this.panelinformacion.Size = new System.Drawing.Size(1400, 25);
            this.panelinformacion.TabIndex = 22;
            // 
            // panelprincipal
            // 
            this.panelprincipal.BackColor = System.Drawing.Color.White;
            this.panelprincipal.Controls.Add(this.pictureBox4);
            this.bunivuelta.SetDecoration(this.panelprincipal, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelprincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprincipal.Location = new System.Drawing.Point(292, 25);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(1108, 804);
            this.panelprincipal.TabIndex = 23;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniida.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Location = new System.Drawing.Point(240, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(629, 597);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.DarkCyan;
            this.panelmenu.Controls.Add(this.bunimenu);
            this.bunivuelta.SetDecoration(this.panelmenu, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelmenu, BunifuAnimatorNS.DecorationType.None);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 25);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(292, 804);
            this.panelmenu.TabIndex = 1;
            // 
            // bunimenu
            // 
            this.bunimenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunimenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.bunimenu.Controls.Add(this.panel_usuario);
            this.bunimenu.Controls.Add(this.btninfo);
            this.bunimenu.Controls.Add(this.btnmenu);
            this.bunimenu.Controls.Add(this.pictureBox2);
            this.bunimenu.Controls.Add(this.separador);
            this.bunimenu.Controls.Add(this.btnmant);
            this.bunimenu.Controls.Add(this.btnusuarios);
            this.bunimenu.Controls.Add(this.btncerrarsesion);
            this.bunimenu.Controls.Add(this.panelmant);
            this.bunimenu.Controls.Add(this.panelusu);
            this.bunimenu.Controls.Add(this.panelinfo);
            this.bunivuelta.SetDecoration(this.bunimenu, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.bunimenu, BunifuAnimatorNS.DecorationType.None);
            this.bunimenu.Location = new System.Drawing.Point(10, 0);
            this.bunimenu.Name = "bunimenu";
            this.bunimenu.Size = new System.Drawing.Size(272, 804);
            this.bunimenu.TabIndex = 0;
            // 
            // panel_usuario
            // 
            this.panel_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.panel_usuario.Controls.Add(this.pictureBox3);
            this.panel_usuario.Controls.Add(this.lblcod);
            this.panel_usuario.Controls.Add(this.lblusuario);
            this.bunivuelta.SetDecoration(this.panel_usuario, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panel_usuario, BunifuAnimatorNS.DecorationType.None);
            this.panel_usuario.Location = new System.Drawing.Point(20, 678);
            this.panel_usuario.Name = "panel_usuario";
            this.panel_usuario.Size = new System.Drawing.Size(232, 65);
            this.panel_usuario.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buniida.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Location = new System.Drawing.Point(12, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 37);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.buniida.SetDecoration(this.lblcod, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.lblcod, BunifuAnimatorNS.DecorationType.None);
            this.lblcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod.ForeColor = System.Drawing.Color.White;
            this.lblcod.Location = new System.Drawing.Point(59, 32);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(65, 20);
            this.lblcod.TabIndex = 25;
            this.lblcod.Text = "Código";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.buniida.SetDecoration(this.lblusuario, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.lblusuario, BunifuAnimatorNS.DecorationType.None);
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(59, 12);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(160, 20);
            this.lblusuario.TabIndex = 24;
            this.lblusuario.Text = "Nombre de usuario";
            // 
            // btninfo
            // 
            this.btninfo.BackColor = System.Drawing.Color.DarkCyan;
            this.btninfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btninfo, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btninfo, BunifuAnimatorNS.DecorationType.None);
            this.btninfo.FlatAppearance.BorderSize = 0;
            this.btninfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btninfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btninfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninfo.ForeColor = System.Drawing.Color.White;
            this.btninfo.Image = ((System.Drawing.Image)(resources.GetObject("btninfo.Image")));
            this.btninfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninfo.Location = new System.Drawing.Point(20, 301);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(232, 40);
            this.btninfo.TabIndex = 22;
            this.btninfo.Text = "     Información";
            this.btninfo.UseVisualStyleBackColor = false;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.Transparent;
            this.btnmenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmenu.BackgroundImage")));
            this.btnmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnmenu, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnmenu, BunifuAnimatorNS.DecorationType.None);
            this.btnmenu.FlatAppearance.BorderSize = 0;
            this.btnmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenu.Location = new System.Drawing.Point(20, 32);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(60, 37);
            this.btnmenu.TabIndex = 20;
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.buniida.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(82, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // separador
            // 
            this.separador.BackColor = System.Drawing.Color.Transparent;
            this.bunivuelta.SetDecoration(this.separador, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.separador, BunifuAnimatorNS.DecorationType.None);
            this.separador.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.separador.LineThickness = 1;
            this.separador.Location = new System.Drawing.Point(20, 93);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(232, 21);
            this.separador.TabIndex = 2;
            this.separador.Transparency = 255;
            this.separador.Vertical = false;
            // 
            // btnmant
            // 
            this.btnmant.BackColor = System.Drawing.Color.DarkCyan;
            this.btnmant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnmant, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnmant, BunifuAnimatorNS.DecorationType.None);
            this.btnmant.FlatAppearance.BorderSize = 0;
            this.btnmant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnmant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnmant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmant.ForeColor = System.Drawing.Color.White;
            this.btnmant.Image = ((System.Drawing.Image)(resources.GetObject("btnmant.Image")));
            this.btnmant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmant.Location = new System.Drawing.Point(20, 129);
            this.btnmant.Name = "btnmant";
            this.btnmant.Size = new System.Drawing.Size(232, 40);
            this.btnmant.TabIndex = 7;
            this.btnmant.Text = "    Consultas";
            this.btnmant.UseVisualStyleBackColor = false;
            this.btnmant.Click += new System.EventHandler(this.btnmant_Click);
            // 
            // btnusuarios
            // 
            this.btnusuarios.BackColor = System.Drawing.Color.DarkCyan;
            this.btnusuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnusuarios, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnusuarios, BunifuAnimatorNS.DecorationType.None);
            this.btnusuarios.FlatAppearance.BorderSize = 0;
            this.btnusuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnusuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.Color.White;
            this.btnusuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnusuarios.Image")));
            this.btnusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuarios.Location = new System.Drawing.Point(20, 215);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(232, 40);
            this.btnusuarios.TabIndex = 8;
            this.btnusuarios.Text = " Usuario";
            this.btnusuarios.UseVisualStyleBackColor = false;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncerrarsesion.BackColor = System.Drawing.Color.Crimson;
            this.btncerrarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btncerrarsesion, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btncerrarsesion, BunifuAnimatorNS.DecorationType.None);
            this.btncerrarsesion.FlatAppearance.BorderSize = 0;
            this.btncerrarsesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btncerrarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btncerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrarsesion.ForeColor = System.Drawing.Color.White;
            this.btncerrarsesion.Image = ((System.Drawing.Image)(resources.GetObject("btncerrarsesion.Image")));
            this.btncerrarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrarsesion.Location = new System.Drawing.Point(20, 749);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(232, 40);
            this.btncerrarsesion.TabIndex = 23;
            this.btncerrarsesion.Text = "       Cerrar sesión";
            this.btncerrarsesion.UseVisualStyleBackColor = false;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // panelmant
            // 
            this.panelmant.BackColor = System.Drawing.Color.Transparent;
            this.panelmant.Controls.Add(this.btnemp);
            this.bunivuelta.SetDecoration(this.panelmant, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelmant, BunifuAnimatorNS.DecorationType.None);
            this.panelmant.Location = new System.Drawing.Point(66, 169);
            this.panelmant.Name = "panelmant";
            this.panelmant.Size = new System.Drawing.Size(193, 47);
            this.panelmant.TabIndex = 10;
            // 
            // btnemp
            // 
            this.btnemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnemp, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnemp, BunifuAnimatorNS.DecorationType.None);
            this.btnemp.FlatAppearance.BorderSize = 0;
            this.btnemp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.ForeColor = System.Drawing.Color.White;
            this.btnemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemp.Location = new System.Drawing.Point(0, 0);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(186, 40);
            this.btnemp.TabIndex = 8;
            this.btnemp.Text = "Asistencias";
            this.btnemp.UseVisualStyleBackColor = false;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // panelusu
            // 
            this.panelusu.BackColor = System.Drawing.Color.Transparent;
            this.panelusu.Controls.Add(this.btnadminusu);
            this.bunivuelta.SetDecoration(this.panelusu, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelusu, BunifuAnimatorNS.DecorationType.None);
            this.panelusu.Location = new System.Drawing.Point(66, 255);
            this.panelusu.Name = "panelusu";
            this.panelusu.Size = new System.Drawing.Size(193, 47);
            this.panelusu.TabIndex = 13;
            // 
            // btnadminusu
            // 
            this.btnadminusu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnadminusu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadminusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnadminusu, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnadminusu, BunifuAnimatorNS.DecorationType.None);
            this.btnadminusu.FlatAppearance.BorderSize = 0;
            this.btnadminusu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnadminusu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnadminusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadminusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminusu.ForeColor = System.Drawing.Color.White;
            this.btnadminusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadminusu.Location = new System.Drawing.Point(0, 0);
            this.btnadminusu.Name = "btnadminusu";
            this.btnadminusu.Size = new System.Drawing.Size(186, 40);
            this.btnadminusu.TabIndex = 8;
            this.btnadminusu.Text = "Editar";
            this.btnadminusu.UseVisualStyleBackColor = false;
            this.btnadminusu.Click += new System.EventHandler(this.btnadminusu_Click);
            // 
            // panelinfo
            // 
            this.panelinfo.BackColor = System.Drawing.Color.Transparent;
            this.panelinfo.Controls.Add(this.button7);
            this.bunivuelta.SetDecoration(this.panelinfo, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelinfo, BunifuAnimatorNS.DecorationType.None);
            this.panelinfo.Location = new System.Drawing.Point(66, 341);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(193, 46);
            this.panelinfo.TabIndex = 14;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 40);
            this.button7.TabIndex = 8;
            this.button7.Text = "Del sistema";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // bunivuelta
            // 
            this.bunivuelta.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunivuelta.Cursor = null;
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
            animation2.TransparencyCoeff = 1F;
            this.bunivuelta.DefaultAnimation = animation2;
            // 
            // hora_fecha
            // 
            this.hora_fecha.Enabled = true;
            this.hora_fecha.Tick += new System.EventHandler(this.hora_fecha_Tick);
            // 
            // curvaprincipal
            // 
            this.curvaprincipal.ElipseRadius = 10;
            this.curvaprincipal.TargetControl = this;
            // 
            // Principal_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 854);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panelinformacion);
            this.Controls.Add(this.panelbarra);
            this.buniida.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal_emp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelbarra.ResumeLayout(false);
            this.panelinformacion.ResumeLayout(false);
            this.panelinformacion.PerformLayout();
            this.panelprincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.bunimenu.ResumeLayout(false);
            this.panel_usuario.ResumeLayout(false);
            this.panel_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelmant.ResumeLayout(false);
            this.panelusu.ResumeLayout(false);
            this.panelinfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunicurva;
        private BunifuAnimatorNS.BunifuTransition buniida;
        private BunifuAnimatorNS.BunifuTransition bunivuelta;
        private System.Windows.Forms.Timer hora_fecha;
        private Bunifu.Framework.UI.BunifuElipse curvaprincipal;
        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel bunimenu;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panelmant;
        private System.Windows.Forms.Button btnemp;
        private Bunifu.Framework.UI.BunifuSeparator separador;
        private System.Windows.Forms.Button btnmant;
        private System.Windows.Forms.Panel panelusu;
        private System.Windows.Forms.Button btnadminusu;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.Button btncerrarsesion;
        private System.Windows.Forms.Panel panelinformacion;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelbarra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panel_usuario;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label lblcod;
        public System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}