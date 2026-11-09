namespace Sistema_control_personal
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panelbarra = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnmax = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.bunimenu = new System.Windows.Forms.Panel();
            this.btnempleados = new System.Windows.Forms.Button();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.panel_cerrar = new System.Windows.Forms.Panel();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.panel_usuario = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblcodi = new System.Windows.Forms.Label();
            this.lblusu = new System.Windows.Forms.Label();
            this.btninfo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.btninformacion = new System.Windows.Forms.Button();
            this.panelmant = new System.Windows.Forms.Panel();
            this.btnturno = new System.Windows.Forms.Button();
            this.btncargo = new System.Windows.Forms.Button();
            this.btndepart = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.btnhorario = new System.Windows.Forms.Button();
            this.btnconsultas = new System.Windows.Forms.Button();
            this.separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelconsultas = new System.Windows.Forms.Panel();
            this.btninforme = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.btnmant = new System.Windows.Forms.Button();
            this.panelusu = new System.Windows.Forms.Panel();
            this.btncuenta = new System.Windows.Forms.Button();
            this.btnadminusu = new System.Windows.Forms.Button();
            this.panelemp = new System.Windows.Forms.Panel();
            this.btnalta = new System.Windows.Forms.Button();
            this.btnbaja = new System.Windows.Forms.Button();
            this.bunicurva = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buniida = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panelinformacion = new System.Windows.Forms.Panel();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunivuelta = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.hora_fecha = new System.Windows.Forms.Timer(this.components);
            this.curvaprincipal = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelbarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelmenu.SuspendLayout();
            this.bunimenu.SuspendLayout();
            this.panel_cerrar.SuspendLayout();
            this.panel_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelinfo.SuspendLayout();
            this.panelmant.SuspendLayout();
            this.panelconsultas.SuspendLayout();
            this.panelusu.SuspendLayout();
            this.panelemp.SuspendLayout();
            this.panelinformacion.SuspendLayout();
            this.panelprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.bunimenu.AutoScroll = true;
            this.bunimenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.bunimenu.Controls.Add(this.btnempleados);
            this.bunimenu.Controls.Add(this.btnusuarios);
            this.bunimenu.Controls.Add(this.panel_cerrar);
            this.bunimenu.Controls.Add(this.panel_usuario);
            this.bunimenu.Controls.Add(this.btninfo);
            this.bunimenu.Controls.Add(this.btnmenu);
            this.bunimenu.Controls.Add(this.pictureBox2);
            this.bunimenu.Controls.Add(this.panelinfo);
            this.bunimenu.Controls.Add(this.panelmant);
            this.bunimenu.Controls.Add(this.btnconsultas);
            this.bunimenu.Controls.Add(this.separador);
            this.bunimenu.Controls.Add(this.panelconsultas);
            this.bunimenu.Controls.Add(this.btnmant);
            this.bunimenu.Controls.Add(this.panelusu);
            this.bunimenu.Controls.Add(this.panelemp);
            this.bunivuelta.SetDecoration(this.bunimenu, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.bunimenu, BunifuAnimatorNS.DecorationType.None);
            this.bunimenu.Location = new System.Drawing.Point(10, 0);
            this.bunimenu.Name = "bunimenu";
            this.bunimenu.Size = new System.Drawing.Size(272, 804);
            this.bunimenu.TabIndex = 0;
            // 
            // btnempleados
            // 
            this.btnempleados.BackColor = System.Drawing.Color.DarkCyan;
            this.btnempleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnempleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnempleados, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnempleados, BunifuAnimatorNS.DecorationType.None);
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.Color.White;
            this.btnempleados.Image = ((System.Drawing.Image)(resources.GetObject("btnempleados.Image")));
            this.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.Location = new System.Drawing.Point(20, 499);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(232, 40);
            this.btnempleados.TabIndex = 9;
            this.btnempleados.Text = "   Empleados";
            this.btnempleados.UseVisualStyleBackColor = false;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
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
            this.btnusuarios.Location = new System.Drawing.Point(20, 375);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(232, 40);
            this.btnusuarios.TabIndex = 8;
            this.btnusuarios.Text = " Usuarios";
            this.btnusuarios.UseVisualStyleBackColor = false;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // panel_cerrar
            // 
            this.panel_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.panel_cerrar.Controls.Add(this.btncerrarsesion);
            this.bunivuelta.SetDecoration(this.panel_cerrar, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panel_cerrar, BunifuAnimatorNS.DecorationType.None);
            this.panel_cerrar.Location = new System.Drawing.Point(20, 976);
            this.panel_cerrar.Name = "panel_cerrar";
            this.panel_cerrar.Size = new System.Drawing.Size(232, 50);
            this.panel_cerrar.TabIndex = 27;
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
            this.btncerrarsesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btncerrarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btncerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrarsesion.ForeColor = System.Drawing.Color.White;
            this.btncerrarsesion.Image = ((System.Drawing.Image)(resources.GetObject("btncerrarsesion.Image")));
            this.btncerrarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrarsesion.Location = new System.Drawing.Point(0, 2);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(232, 40);
            this.btncerrarsesion.TabIndex = 23;
            this.btncerrarsesion.Text = "       Cerrar sesión";
            this.btncerrarsesion.UseVisualStyleBackColor = false;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // panel_usuario
            // 
            this.panel_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.panel_usuario.Controls.Add(this.pictureBox3);
            this.panel_usuario.Controls.Add(this.lblcodi);
            this.panel_usuario.Controls.Add(this.lblusu);
            this.bunivuelta.SetDecoration(this.panel_usuario, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panel_usuario, BunifuAnimatorNS.DecorationType.None);
            this.panel_usuario.Location = new System.Drawing.Point(20, 905);
            this.panel_usuario.Name = "panel_usuario";
            this.panel_usuario.Size = new System.Drawing.Size(232, 65);
            this.panel_usuario.TabIndex = 26;
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
            // lblcodi
            // 
            this.lblcodi.AutoSize = true;
            this.buniida.SetDecoration(this.lblcodi, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.lblcodi, BunifuAnimatorNS.DecorationType.None);
            this.lblcodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodi.ForeColor = System.Drawing.Color.White;
            this.lblcodi.Location = new System.Drawing.Point(59, 32);
            this.lblcodi.Name = "lblcodi";
            this.lblcodi.Size = new System.Drawing.Size(65, 20);
            this.lblcodi.TabIndex = 25;
            this.lblcodi.Text = "Código";
            // 
            // lblusu
            // 
            this.lblusu.AutoSize = true;
            this.buniida.SetDecoration(this.lblusu, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.lblusu, BunifuAnimatorNS.DecorationType.None);
            this.lblusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusu.ForeColor = System.Drawing.Color.White;
            this.lblusu.Location = new System.Drawing.Point(59, 12);
            this.lblusu.Name = "lblusu";
            this.lblusu.Size = new System.Drawing.Size(160, 20);
            this.lblusu.TabIndex = 24;
            this.lblusu.Text = "Nombre de usuario";
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
            this.btninfo.Location = new System.Drawing.Point(20, 747);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(232, 40);
            this.btninfo.TabIndex = 22;
            this.btninfo.Text = "     Información";
            this.btninfo.UseVisualStyleBackColor = false;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
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
            // panelinfo
            // 
            this.panelinfo.BackColor = System.Drawing.Color.Transparent;
            this.panelinfo.Controls.Add(this.btninformacion);
            this.bunivuelta.SetDecoration(this.panelinfo, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelinfo, BunifuAnimatorNS.DecorationType.None);
            this.panelinfo.Location = new System.Drawing.Point(66, 787);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(193, 46);
            this.panelinfo.TabIndex = 14;
            // 
            // btninformacion
            // 
            this.btninformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btninformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btninformacion, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btninformacion, BunifuAnimatorNS.DecorationType.None);
            this.btninformacion.FlatAppearance.BorderSize = 0;
            this.btninformacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btninformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btninformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.ForeColor = System.Drawing.Color.White;
            this.btninformacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninformacion.Location = new System.Drawing.Point(0, 0);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(186, 40);
            this.btninformacion.TabIndex = 8;
            this.btninformacion.Text = "Del sistema";
            this.btninformacion.UseVisualStyleBackColor = false;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // panelmant
            // 
            this.panelmant.BackColor = System.Drawing.Color.Transparent;
            this.panelmant.Controls.Add(this.btnturno);
            this.panelmant.Controls.Add(this.btncargo);
            this.panelmant.Controls.Add(this.btndepart);
            this.panelmant.Controls.Add(this.btnemp);
            this.panelmant.Controls.Add(this.btnhorario);
            this.bunivuelta.SetDecoration(this.panelmant, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelmant, BunifuAnimatorNS.DecorationType.None);
            this.panelmant.Location = new System.Drawing.Point(66, 171);
            this.panelmant.Name = "panelmant";
            this.panelmant.Size = new System.Drawing.Size(193, 207);
            this.panelmant.TabIndex = 10;
            // 
            // btnturno
            // 
            this.btnturno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnturno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnturno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnturno, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnturno, BunifuAnimatorNS.DecorationType.None);
            this.btnturno.FlatAppearance.BorderSize = 0;
            this.btnturno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnturno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnturno.ForeColor = System.Drawing.Color.White;
            this.btnturno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnturno.Location = new System.Drawing.Point(0, 40);
            this.btnturno.Name = "btnturno";
            this.btnturno.Size = new System.Drawing.Size(186, 40);
            this.btnturno.TabIndex = 14;
            this.btnturno.Text = "Turno";
            this.btnturno.UseVisualStyleBackColor = false;
            this.btnturno.Click += new System.EventHandler(this.btnturno_Click);
            // 
            // btncargo
            // 
            this.btncargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btncargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btncargo, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btncargo, BunifuAnimatorNS.DecorationType.None);
            this.btncargo.FlatAppearance.BorderSize = 0;
            this.btncargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btncargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btncargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargo.ForeColor = System.Drawing.Color.White;
            this.btncargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncargo.Location = new System.Drawing.Point(0, 160);
            this.btncargo.Name = "btncargo";
            this.btncargo.Size = new System.Drawing.Size(186, 40);
            this.btncargo.TabIndex = 13;
            this.btncargo.Text = "Cargo";
            this.btncargo.UseVisualStyleBackColor = false;
            this.btncargo.Click += new System.EventHandler(this.btncargo_Click);
            // 
            // btndepart
            // 
            this.btndepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btndepart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndepart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btndepart, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btndepart, BunifuAnimatorNS.DecorationType.None);
            this.btndepart.FlatAppearance.BorderSize = 0;
            this.btndepart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btndepart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndepart.ForeColor = System.Drawing.Color.White;
            this.btndepart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndepart.Location = new System.Drawing.Point(0, 120);
            this.btndepart.Name = "btndepart";
            this.btndepart.Size = new System.Drawing.Size(186, 40);
            this.btndepart.TabIndex = 12;
            this.btndepart.Text = "Departamento";
            this.btndepart.UseVisualStyleBackColor = false;
            this.btndepart.Click += new System.EventHandler(this.btndepart_Click_1);
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
            this.btnemp.Text = "Empleado";
            this.btnemp.UseVisualStyleBackColor = false;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // btnhorario
            // 
            this.btnhorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnhorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnhorario, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnhorario, BunifuAnimatorNS.DecorationType.None);
            this.btnhorario.FlatAppearance.BorderSize = 0;
            this.btnhorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnhorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnhorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhorario.ForeColor = System.Drawing.Color.White;
            this.btnhorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhorario.Location = new System.Drawing.Point(0, 80);
            this.btnhorario.Name = "btnhorario";
            this.btnhorario.Size = new System.Drawing.Size(186, 40);
            this.btnhorario.TabIndex = 9;
            this.btnhorario.Text = "Horario";
            this.btnhorario.UseVisualStyleBackColor = false;
            this.btnhorario.Click += new System.EventHandler(this.btnhorario_Click);
            // 
            // btnconsultas
            // 
            this.btnconsultas.BackColor = System.Drawing.Color.DarkCyan;
            this.btnconsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnconsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnconsultas, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnconsultas, BunifuAnimatorNS.DecorationType.None);
            this.btnconsultas.FlatAppearance.BorderSize = 0;
            this.btnconsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnconsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnconsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultas.ForeColor = System.Drawing.Color.White;
            this.btnconsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnconsultas.Image")));
            this.btnconsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultas.Location = new System.Drawing.Point(20, 623);
            this.btnconsultas.Name = "btnconsultas";
            this.btnconsultas.Size = new System.Drawing.Size(232, 40);
            this.btnconsultas.TabIndex = 10;
            this.btnconsultas.Text = "   Consultas";
            this.btnconsultas.UseVisualStyleBackColor = false;
            this.btnconsultas.Click += new System.EventHandler(this.btnconsultas_Click);
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
            // panelconsultas
            // 
            this.panelconsultas.BackColor = System.Drawing.Color.Transparent;
            this.panelconsultas.Controls.Add(this.btninforme);
            this.panelconsultas.Controls.Add(this.btnreporte);
            this.bunivuelta.SetDecoration(this.panelconsultas, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelconsultas, BunifuAnimatorNS.DecorationType.None);
            this.panelconsultas.Location = new System.Drawing.Point(66, 663);
            this.panelconsultas.Name = "panelconsultas";
            this.panelconsultas.Size = new System.Drawing.Size(193, 87);
            this.panelconsultas.TabIndex = 13;
            // 
            // btninforme
            // 
            this.btninforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btninforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btninforme, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btninforme, BunifuAnimatorNS.DecorationType.None);
            this.btninforme.FlatAppearance.BorderSize = 0;
            this.btninforme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btninforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btninforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninforme.ForeColor = System.Drawing.Color.White;
            this.btninforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninforme.Location = new System.Drawing.Point(0, 40);
            this.btninforme.Name = "btninforme";
            this.btninforme.Size = new System.Drawing.Size(186, 40);
            this.btninforme.TabIndex = 10;
            this.btninforme.Text = "Informe general";
            this.btninforme.UseVisualStyleBackColor = false;
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // btnreporte
            // 
            this.btnreporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnreporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnreporte, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnreporte, BunifuAnimatorNS.DecorationType.None);
            this.btnreporte.FlatAppearance.BorderSize = 0;
            this.btnreporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnreporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.Location = new System.Drawing.Point(0, 0);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(186, 40);
            this.btnreporte.TabIndex = 8;
            this.btnreporte.Text = "Reporte asistencias";
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
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
            this.btnmant.Location = new System.Drawing.Point(20, 131);
            this.btnmant.Name = "btnmant";
            this.btnmant.Size = new System.Drawing.Size(232, 40);
            this.btnmant.TabIndex = 7;
            this.btnmant.Text = "      Mantenimiento";
            this.btnmant.UseVisualStyleBackColor = false;
            this.btnmant.Click += new System.EventHandler(this.btnmant_Click);
            // 
            // panelusu
            // 
            this.panelusu.BackColor = System.Drawing.Color.Transparent;
            this.panelusu.Controls.Add(this.btncuenta);
            this.panelusu.Controls.Add(this.btnadminusu);
            this.bunivuelta.SetDecoration(this.panelusu, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelusu, BunifuAnimatorNS.DecorationType.None);
            this.panelusu.Location = new System.Drawing.Point(66, 415);
            this.panelusu.Name = "panelusu";
            this.panelusu.Size = new System.Drawing.Size(193, 88);
            this.panelusu.TabIndex = 13;
            // 
            // btncuenta
            // 
            this.btncuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btncuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btncuenta, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btncuenta, BunifuAnimatorNS.DecorationType.None);
            this.btncuenta.FlatAppearance.BorderSize = 0;
            this.btncuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btncuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btncuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuenta.ForeColor = System.Drawing.Color.White;
            this.btncuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncuenta.Location = new System.Drawing.Point(0, 40);
            this.btncuenta.Name = "btncuenta";
            this.btncuenta.Size = new System.Drawing.Size(186, 40);
            this.btncuenta.TabIndex = 9;
            this.btncuenta.Text = "Cuenta personal";
            this.btncuenta.UseVisualStyleBackColor = false;
            this.btncuenta.Click += new System.EventHandler(this.btncuenta_Click);
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
            this.btnadminusu.Text = "Cuentas empleados";
            this.btnadminusu.UseVisualStyleBackColor = false;
            this.btnadminusu.Click += new System.EventHandler(this.btnadminusu_Click);
            // 
            // panelemp
            // 
            this.panelemp.BackColor = System.Drawing.Color.Transparent;
            this.panelemp.Controls.Add(this.btnalta);
            this.panelemp.Controls.Add(this.btnbaja);
            this.bunivuelta.SetDecoration(this.panelemp, BunifuAnimatorNS.DecorationType.None);
            this.buniida.SetDecoration(this.panelemp, BunifuAnimatorNS.DecorationType.None);
            this.panelemp.Location = new System.Drawing.Point(66, 539);
            this.panelemp.Name = "panelemp";
            this.panelemp.Size = new System.Drawing.Size(193, 89);
            this.panelemp.TabIndex = 14;
            // 
            // btnalta
            // 
            this.btnalta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnalta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnalta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnalta, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnalta, BunifuAnimatorNS.DecorationType.None);
            this.btnalta.FlatAppearance.BorderSize = 0;
            this.btnalta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnalta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalta.ForeColor = System.Drawing.Color.White;
            this.btnalta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalta.Location = new System.Drawing.Point(0, 0);
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(186, 40);
            this.btnalta.TabIndex = 8;
            this.btnalta.Text = "En alta";
            this.btnalta.UseVisualStyleBackColor = false;
            this.btnalta.Click += new System.EventHandler(this.btnalta_Click);
            // 
            // btnbaja
            // 
            this.btnbaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buniida.SetDecoration(this.btnbaja, BunifuAnimatorNS.DecorationType.None);
            this.bunivuelta.SetDecoration(this.btnbaja, BunifuAnimatorNS.DecorationType.None);
            this.btnbaja.FlatAppearance.BorderSize = 0;
            this.btnbaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnbaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnbaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaja.ForeColor = System.Drawing.Color.White;
            this.btnbaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbaja.Location = new System.Drawing.Point(0, 40);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(186, 40);
            this.btnbaja.TabIndex = 9;
            this.btnbaja.Text = "En baja";
            this.btnbaja.UseVisualStyleBackColor = false;
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
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
            this.pictureBox4.Location = new System.Drawing.Point(257, 100);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(629, 597);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
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
            // Principal
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
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelbarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.bunimenu.ResumeLayout(false);
            this.panel_cerrar.ResumeLayout(false);
            this.panel_usuario.ResumeLayout(false);
            this.panel_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelinfo.ResumeLayout(false);
            this.panelmant.ResumeLayout(false);
            this.panelconsultas.ResumeLayout(false);
            this.panelusu.ResumeLayout(false);
            this.panelemp.ResumeLayout(false);
            this.panelinformacion.ResumeLayout(false);
            this.panelinformacion.PerformLayout();
            this.panelprincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbarra;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnsalir;
        private Bunifu.Framework.UI.BunifuSeparator separador;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnmant;
        private System.Windows.Forms.Button btnconsultas;
        private System.Windows.Forms.Button btncerrarsesion;
        private System.Windows.Forms.Button btninfo;
        private Bunifu.Framework.UI.BunifuElipse bunicurva;
        private BunifuAnimatorNS.BunifuTransition buniida;
        private BunifuAnimatorNS.BunifuTransition bunivuelta;
        private System.Windows.Forms.Panel panelmant;
        private System.Windows.Forms.Button btnhorario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelinformacion;
        private System.Windows.Forms.Panel panelemp;
        private System.Windows.Forms.Button btnalta;
        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.Panel panelconsultas;
        private System.Windows.Forms.Button btninforme;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Panel panelusu;
        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.Timer hora_fecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private Bunifu.Framework.UI.BunifuElipse curvaprincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel bunimenu;
        private System.Windows.Forms.Panel panel_usuario;
        public System.Windows.Forms.Label lblcodi;
        public System.Windows.Forms.Label lblusu;
        public System.Windows.Forms.Button btnadminusu;
        public System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.Panel panel_cerrar;
        private System.Windows.Forms.Button btnturno;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Button btndepart;
        public System.Windows.Forms.Button btncargo;
        public System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.Button btncuenta;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}