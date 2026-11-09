namespace Sistema_control_personal
{
    partial class Registro_asistencia
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_asistencia));
            this.panelbarra = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnmax = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panelhora = new System.Windows.Forms.Panel();
            this.lblfechareal = new System.Windows.Forms.Label();
            this.lbldia = new System.Windows.Forms.Label();
            this.lblfec = new System.Windows.Forms.Label();
            this.lblseg = new System.Windows.Forms.Label();
            this.lbllhoramin = new System.Windows.Forms.Label();
            this.reloj = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.btnentrada = new System.Windows.Forms.Button();
            this.btnsalida = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txthor = new System.Windows.Forms.TextBox();
            this.txtemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelsesion = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsesion = new System.Windows.Forms.Button();
            this.btncon = new System.Windows.Forms.Button();
            this.timerasistencia = new System.Windows.Forms.Timer(this.components);
            this.curvaasis = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.curvafecha = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.paneldatos = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelbarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelhora.SuspendLayout();
            this.panelsesion.SuspendLayout();
            this.paneldatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panelbarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbarra.ForeColor = System.Drawing.Color.White;
            this.panelbarra.Location = new System.Drawing.Point(0, 0);
            this.panelbarra.Name = "panelbarra";
            this.panelbarra.Size = new System.Drawing.Size(806, 25);
            this.panelbarra.TabIndex = 0;
            this.panelbarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelbarra_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmax.FlatAppearance.BorderSize = 0;
            this.btnmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmax.ForeColor = System.Drawing.Color.White;
            this.btnmax.Location = new System.Drawing.Point(745, -1);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(31, 25);
            this.btnmax.TabIndex = 16;
            this.btnmax.Text = "■";
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmin.FlatAppearance.BorderSize = 0;
            this.btnmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.White;
            this.btnmin.Location = new System.Drawing.Point(716, -1);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(31, 25);
            this.btnmin.TabIndex = 15;
            this.btnmin.Text = "─";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(775, -1);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(31, 25);
            this.btnsalir.TabIndex = 14;
            this.btnsalir.Text = "x";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // panelhora
            // 
            this.panelhora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelhora.BackColor = System.Drawing.Color.DimGray;
            this.panelhora.Controls.Add(this.lblfechareal);
            this.panelhora.Controls.Add(this.lbldia);
            this.panelhora.Controls.Add(this.lblfec);
            this.panelhora.Controls.Add(this.lblseg);
            this.panelhora.Controls.Add(this.lbllhoramin);
            this.panelhora.Controls.Add(this.reloj);
            this.panelhora.Controls.Add(this.lblfecha);
            this.panelhora.Controls.Add(this.lblhora);
            this.panelhora.Location = new System.Drawing.Point(64, 80);
            this.panelhora.Name = "panelhora";
            this.panelhora.Size = new System.Drawing.Size(668, 250);
            this.panelhora.TabIndex = 1;
            // 
            // lblfechareal
            // 
            this.lblfechareal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfechareal.AutoSize = true;
            this.lblfechareal.BackColor = System.Drawing.Color.Transparent;
            this.lblfechareal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechareal.ForeColor = System.Drawing.Color.DimGray;
            this.lblfechareal.Location = new System.Drawing.Point(237, 194);
            this.lblfechareal.Name = "lblfechareal";
            this.lblfechareal.Size = new System.Drawing.Size(99, 20);
            this.lblfechareal.TabIndex = 6;
            this.lblfechareal.Text = "11/11/2019";
            // 
            // lbldia
            // 
            this.lbldia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldia.AutoSize = true;
            this.lbldia.BackColor = System.Drawing.Color.DimGray;
            this.lbldia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldia.ForeColor = System.Drawing.Color.DimGray;
            this.lbldia.Location = new System.Drawing.Point(79, 194);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(99, 20);
            this.lbldia.TabIndex = 5;
            this.lbldia.Text = "11/11/2019";
            // 
            // lblfec
            // 
            this.lblfec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfec.AutoSize = true;
            this.lblfec.BackColor = System.Drawing.Color.Transparent;
            this.lblfec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfec.ForeColor = System.Drawing.Color.White;
            this.lblfec.Location = new System.Drawing.Point(482, 148);
            this.lblfec.Name = "lblfec";
            this.lblfec.Size = new System.Drawing.Size(99, 20);
            this.lblfec.TabIndex = 4;
            this.lblfec.Text = "11/11/2019";
            // 
            // lblseg
            // 
            this.lblseg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblseg.AutoSize = true;
            this.lblseg.BackColor = System.Drawing.Color.Transparent;
            this.lblseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseg.ForeColor = System.Drawing.Color.Gold;
            this.lblseg.Location = new System.Drawing.Point(505, 69);
            this.lblseg.Name = "lblseg";
            this.lblseg.Size = new System.Drawing.Size(51, 37);
            this.lblseg.TabIndex = 3;
            this.lblseg.Text = "11";
            // 
            // lbllhoramin
            // 
            this.lbllhoramin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbllhoramin.AutoSize = true;
            this.lbllhoramin.BackColor = System.Drawing.Color.Transparent;
            this.lbllhoramin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllhoramin.ForeColor = System.Drawing.Color.White;
            this.lbllhoramin.Location = new System.Drawing.Point(475, 104);
            this.lbllhoramin.Name = "lbllhoramin";
            this.lbllhoramin.Size = new System.Drawing.Size(117, 42);
            this.lbllhoramin.TabIndex = 2;
            this.lbllhoramin.Text = "11:11";
            // 
            // reloj
            // 
            this.reloj.animated = false;
            this.reloj.animationIterval = 5;
            this.reloj.animationSpeed = 300;
            this.reloj.BackColor = System.Drawing.Color.Transparent;
            this.reloj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reloj.BackgroundImage")));
            this.reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.reloj.ForeColor = System.Drawing.Color.Transparent;
            this.reloj.LabelVisible = false;
            this.reloj.LineProgressThickness = 8;
            this.reloj.LineThickness = 10;
            this.reloj.Location = new System.Drawing.Point(443, 37);
            this.reloj.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.reloj.MaxValue = 60;
            this.reloj.Name = "reloj";
            this.reloj.ProgressBackColor = System.Drawing.Color.Silver;
            this.reloj.ProgressColor = System.Drawing.Color.Gold;
            this.reloj.Size = new System.Drawing.Size(177, 177);
            this.reloj.TabIndex = 0;
            this.reloj.Value = 0;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Copperplate Gothic Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Gold;
            this.lblfecha.Location = new System.Drawing.Point(59, 133);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(334, 48);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "11/11/2019";
            // 
            // lblhora
            // 
            this.lblhora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.Gold;
            this.lblhora.Location = new System.Drawing.Point(51, 54);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(355, 91);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "11:11:11";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtcod
            // 
            this.txtcod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcod.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.Color.DarkGray;
            this.txtcod.Location = new System.Drawing.Point(137, 31);
            this.txtcod.MaxLength = 4;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(215, 26);
            this.txtcod.TabIndex = 4;
            this.txtcod.Text = "Ingrese su código";
            this.txtcod.Enter += new System.EventHandler(this.txtcod_Enter);
            this.txtcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcod_KeyPress);
            this.txtcod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcod_KeyUp);
            this.txtcod.Leave += new System.EventHandler(this.txtcod_Leave);
            // 
            // txtcontra
            // 
            this.txtcontra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcontra.BackColor = System.Drawing.Color.Gainsboro;
            this.txtcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontra.ForeColor = System.Drawing.Color.DarkGray;
            this.txtcontra.Location = new System.Drawing.Point(137, 69);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(215, 26);
            this.txtcontra.TabIndex = 5;
            this.txtcontra.Text = "Ingrese su contraseña";
            this.txtcontra.Enter += new System.EventHandler(this.txtcontra_Enter);
            this.txtcontra.Leave += new System.EventHandler(this.txtcontra_Leave);
            // 
            // btnentrada
            // 
            this.btnentrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnentrada.BackColor = System.Drawing.Color.DarkCyan;
            this.btnentrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrada.FlatAppearance.BorderSize = 0;
            this.btnentrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnentrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnentrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrada.ForeColor = System.Drawing.Color.White;
            this.btnentrada.Location = new System.Drawing.Point(370, 24);
            this.btnentrada.Name = "btnentrada";
            this.btnentrada.Size = new System.Drawing.Size(127, 33);
            this.btnentrada.TabIndex = 6;
            this.btnentrada.Text = "Entrada";
            this.btnentrada.UseVisualStyleBackColor = false;
            this.btnentrada.Click += new System.EventHandler(this.btnentrada_Click);
            // 
            // btnsalida
            // 
            this.btnsalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsalida.BackColor = System.Drawing.Color.DarkCyan;
            this.btnsalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalida.FlatAppearance.BorderSize = 0;
            this.btnsalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnsalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnsalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalida.ForeColor = System.Drawing.Color.White;
            this.btnsalida.Location = new System.Drawing.Point(370, 63);
            this.btnsalida.Name = "btnsalida";
            this.btnsalida.Size = new System.Drawing.Size(127, 33);
            this.btnsalida.TabIndex = 7;
            this.btnsalida.Text = "Salida";
            this.btnsalida.UseVisualStyleBackColor = false;
            this.btnsalida.Click += new System.EventHandler(this.btnsalida_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(30, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 2);
            this.panel3.TabIndex = 8;
            // 
            // txthor
            // 
            this.txthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthor.BackColor = System.Drawing.Color.Gainsboro;
            this.txthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthor.ForeColor = System.Drawing.Color.DarkCyan;
            this.txthor.Location = new System.Drawing.Point(204, 176);
            this.txthor.Name = "txthor";
            this.txthor.Size = new System.Drawing.Size(372, 26);
            this.txthor.TabIndex = 12;
            // 
            // txtemp
            // 
            this.txtemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemp.BackColor = System.Drawing.Color.Gainsboro;
            this.txtemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemp.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtemp.Location = new System.Drawing.Point(204, 137);
            this.txtemp.Name = "txtemp";
            this.txtemp.Size = new System.Drawing.Size(372, 26);
            this.txtemp.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Horario";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Empleado";
            // 
            // panelsesion
            // 
            this.panelsesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.panelsesion.Controls.Add(this.label5);
            this.panelsesion.Controls.Add(this.btnsesion);
            this.panelsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelsesion.Location = new System.Drawing.Point(64, 618);
            this.panelsesion.Name = "panelsesion";
            this.panelsesion.Size = new System.Drawing.Size(668, 73);
            this.panelsesion.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(237, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Inicie sesión como empleado o usuario administrador";
            // 
            // btnsesion
            // 
            this.btnsesion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsesion.BackColor = System.Drawing.Color.DarkCyan;
            this.btnsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsesion.FlatAppearance.BorderSize = 0;
            this.btnsesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsesion.ForeColor = System.Drawing.Color.White;
            this.btnsesion.Location = new System.Drawing.Point(21, 21);
            this.btnsesion.Name = "btnsesion";
            this.btnsesion.Size = new System.Drawing.Size(177, 33);
            this.btnsesion.TabIndex = 14;
            this.btnsesion.Text = "Iniciar sesión";
            this.btnsesion.UseVisualStyleBackColor = false;
            this.btnsesion.Click += new System.EventHandler(this.btnsesion_Click);
            // 
            // btncon
            // 
            this.btncon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncon.BackColor = System.Drawing.Color.DarkCyan;
            this.btncon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncon.FlatAppearance.BorderSize = 0;
            this.btncon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btncon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btncon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncon.ForeColor = System.Drawing.Color.White;
            this.btncon.Location = new System.Drawing.Point(514, 22);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(132, 73);
            this.btncon.TabIndex = 13;
            this.btncon.Text = "Consultar código";
            this.btncon.UseVisualStyleBackColor = false;
            this.btncon.Click += new System.EventHandler(this.btncon_Click);
            // 
            // timerasistencia
            // 
            this.timerasistencia.Enabled = true;
            this.timerasistencia.Tick += new System.EventHandler(this.timerasistencia_Tick);
            // 
            // curvaasis
            // 
            this.curvaasis.ElipseRadius = 10;
            this.curvaasis.TargetControl = this;
            // 
            // curvafecha
            // 
            this.curvafecha.ElipseRadius = 10;
            this.curvafecha.TargetControl = this.panelhora;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.panelsesion;
            // 
            // paneldatos
            // 
            this.paneldatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paneldatos.BackColor = System.Drawing.Color.DimGray;
            this.paneldatos.Controls.Add(this.btncon);
            this.paneldatos.Controls.Add(this.btnentrada);
            this.paneldatos.Controls.Add(this.label1);
            this.paneldatos.Controls.Add(this.label4);
            this.paneldatos.Controls.Add(this.label2);
            this.paneldatos.Controls.Add(this.label3);
            this.paneldatos.Controls.Add(this.btnsalida);
            this.paneldatos.Controls.Add(this.txthor);
            this.paneldatos.Controls.Add(this.txtcontra);
            this.paneldatos.Controls.Add(this.panel3);
            this.paneldatos.Controls.Add(this.txtcod);
            this.paneldatos.Controls.Add(this.txtemp);
            this.paneldatos.Location = new System.Drawing.Point(64, 362);
            this.paneldatos.Name = "paneldatos";
            this.paneldatos.Size = new System.Drawing.Size(668, 226);
            this.paneldatos.TabIndex = 5;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.paneldatos;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(806, 762);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Registro_asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 762);
            this.Controls.Add(this.paneldatos);
            this.Controls.Add(this.panelsesion);
            this.Controls.Add(this.panelhora);
            this.Controls.Add(this.panelbarra);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelbarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelhora.ResumeLayout(false);
            this.panelhora.PerformLayout();
            this.panelsesion.ResumeLayout(false);
            this.panelsesion.PerformLayout();
            this.paneldatos.ResumeLayout(false);
            this.paneldatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbarra;
        private System.Windows.Forms.Panel panelhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Button btnentrada;
        private System.Windows.Forms.Button btnsalida;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txthor;
        private System.Windows.Forms.TextBox txtemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelsesion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsesion;
        private System.Windows.Forms.Button btncon;
        private System.Windows.Forms.Timer timerasistencia;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnsalir;
        private Bunifu.Framework.UI.BunifuElipse curvaasis;
        private Bunifu.Framework.UI.BunifuElipse curvafecha;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar reloj;
        private System.Windows.Forms.Label lblfec;
        private System.Windows.Forms.Label lblseg;
        private System.Windows.Forms.Label lbllhoramin;
        private System.Windows.Forms.Panel paneldatos;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Label lblfechareal;
    }
}

