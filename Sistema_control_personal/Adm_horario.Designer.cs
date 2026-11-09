namespace Sistema_control_personal
{
    partial class Adm_horario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnact = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.cmbturno = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsalida = new System.Windows.Forms.MaskedTextBox();
            this.txtinicio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtfindesc = new System.Windows.Forms.MaskedTextBox();
            this.txtinidesc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chksabado = new System.Windows.Forms.CheckBox();
            this.chkviernes = new System.Windows.Forms.CheckBox();
            this.chkjueves = new System.Windows.Forms.CheckBox();
            this.chkmiercoles = new System.Windows.Forms.CheckBox();
            this.chkmartes = new System.Windows.Forms.CheckBox();
            this.chklunes = new System.Windows.Forms.CheckBox();
            this.dgvhorario = new System.Windows.Forms.DataGridView();
            this.idempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inidesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.btnact);
            this.groupBox4.Controls.Add(this.txtcodigo);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox4.Location = new System.Drawing.Point(369, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 80);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mantenimiento";
            // 
            // btnact
            // 
            this.btnact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnact.FlatAppearance.BorderSize = 0;
            this.btnact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnact.ForeColor = System.Drawing.Color.White;
            this.btnact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnact.Location = new System.Drawing.Point(244, 22);
            this.btnact.Name = "btnact";
            this.btnact.Size = new System.Drawing.Size(125, 40);
            this.btnact.TabIndex = 39;
            this.btnact.Text = "Actualizar";
            this.btnact.UseVisualStyleBackColor = false;
            this.btnact.Click += new System.EventHandler(this.btnact_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.txtcodigo.Location = new System.Drawing.Point(96, 29);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(136, 26);
            this.txtcodigo.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label12.Location = new System.Drawing.Point(21, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Código";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btnregistrar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox3.Location = new System.Drawing.Point(188, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 80);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrar.FlatAppearance.BorderSize = 0;
            this.btnregistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.Color.White;
            this.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistrar.Location = new System.Drawing.Point(18, 22);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(125, 40);
            this.btnregistrar.TabIndex = 10;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtdescrip);
            this.groupBox2.Controls.Add(this.cmbturno);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox2.Location = new System.Drawing.Point(29, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1045, 79);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Complementos";
            // 
            // txtdescrip
            // 
            this.txtdescrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdescrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.txtdescrip.Location = new System.Drawing.Point(154, 30);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(517, 26);
            this.txtdescrip.TabIndex = 40;
            // 
            // cmbturno
            // 
            this.cmbturno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbturno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbturno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.cmbturno.FormattingEnabled = true;
            this.cmbturno.Location = new System.Drawing.Point(760, 28);
            this.cmbturno.Name = "cmbturno";
            this.cmbturno.Size = new System.Drawing.Size(236, 28);
            this.cmbturno.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label20.Location = new System.Drawing.Point(699, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 20);
            this.label20.TabIndex = 24;
            this.label20.Text = "Turno";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label21.Location = new System.Drawing.Point(45, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 20);
            this.label21.TabIndex = 23;
            this.label21.Text = "Descripción";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtsalida);
            this.groupBox1.Controls.Add(this.txtinicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox1.Location = new System.Drawing.Point(29, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 83);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horario laborable";
            // 
            // txtsalida
            // 
            this.txtsalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsalida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtsalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.txtsalida.Location = new System.Drawing.Point(627, 35);
            this.txtsalida.Mask = "00:00:00";
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(369, 26);
            this.txtsalida.TabIndex = 36;
            // 
            // txtinicio
            // 
            this.txtinicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtinicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.txtinicio.Location = new System.Drawing.Point(170, 35);
            this.txtinicio.Mask = "00:00:00";
            this.txtinicio.Name = "txtinicio";
            this.txtinicio.Size = new System.Drawing.Size(309, 26);
            this.txtinicio.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(496, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Hora de salida";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hora de inicio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 50);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "MANTENIMIENTO DE HORARIO";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.txtfindesc);
            this.groupBox5.Controls.Add(this.txtinidesc);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox5.Location = new System.Drawing.Point(29, 174);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1045, 83);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Horario de descanso";
            // 
            // txtfindesc
            // 
            this.txtfindesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfindesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtfindesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfindesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.txtfindesc.Location = new System.Drawing.Point(627, 36);
            this.txtfindesc.Mask = "00 :00:00  ";
            this.txtfindesc.Name = "txtfindesc";
            this.txtfindesc.Size = new System.Drawing.Size(369, 26);
            this.txtfindesc.TabIndex = 38;
            // 
            // txtinidesc
            // 
            this.txtinidesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtinidesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtinidesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinidesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.txtinidesc.Location = new System.Drawing.Point(185, 36);
            this.txtinidesc.Mask = "00:00:00";
            this.txtinidesc.Name = "txtinidesc";
            this.txtinidesc.Size = new System.Drawing.Size(294, 26);
            this.txtinidesc.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(496, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fin descanso";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label7.Location = new System.Drawing.Point(45, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Inicio descanso";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.chksabado);
            this.groupBox6.Controls.Add(this.chkviernes);
            this.groupBox6.Controls.Add(this.chkjueves);
            this.groupBox6.Controls.Add(this.chkmiercoles);
            this.groupBox6.Controls.Add(this.chkmartes);
            this.groupBox6.Controls.Add(this.chklunes);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox6.Location = new System.Drawing.Point(29, 369);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1045, 67);
            this.groupBox6.TabIndex = 50;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Días laborables (Seleccione los días que le asignará al horario)";
            // 
            // chksabado
            // 
            this.chksabado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chksabado.AutoSize = true;
            this.chksabado.Location = new System.Drawing.Point(908, 26);
            this.chksabado.Name = "chksabado";
            this.chksabado.Size = new System.Drawing.Size(84, 24);
            this.chksabado.TabIndex = 5;
            this.chksabado.Text = "Sábado";
            this.chksabado.UseVisualStyleBackColor = true;
            // 
            // chkviernes
            // 
            this.chkviernes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkviernes.AutoSize = true;
            this.chkviernes.Location = new System.Drawing.Point(729, 26);
            this.chkviernes.Name = "chkviernes";
            this.chkviernes.Size = new System.Drawing.Size(82, 24);
            this.chkviernes.TabIndex = 4;
            this.chkviernes.Text = "Viernes";
            this.chkviernes.UseVisualStyleBackColor = true;
            // 
            // chkjueves
            // 
            this.chkjueves.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkjueves.AutoSize = true;
            this.chkjueves.Location = new System.Drawing.Point(563, 26);
            this.chkjueves.Name = "chkjueves";
            this.chkjueves.Size = new System.Drawing.Size(78, 24);
            this.chkjueves.TabIndex = 3;
            this.chkjueves.Text = "Jueves";
            this.chkjueves.UseVisualStyleBackColor = true;
            // 
            // chkmiercoles
            // 
            this.chkmiercoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkmiercoles.AutoSize = true;
            this.chkmiercoles.Location = new System.Drawing.Point(374, 26);
            this.chkmiercoles.Name = "chkmiercoles";
            this.chkmiercoles.Size = new System.Drawing.Size(95, 24);
            this.chkmiercoles.TabIndex = 2;
            this.chkmiercoles.Text = "Miércoles";
            this.chkmiercoles.UseVisualStyleBackColor = true;
            // 
            // chkmartes
            // 
            this.chkmartes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkmartes.AutoSize = true;
            this.chkmartes.Location = new System.Drawing.Point(203, 26);
            this.chkmartes.Name = "chkmartes";
            this.chkmartes.Size = new System.Drawing.Size(77, 24);
            this.chkmartes.TabIndex = 1;
            this.chkmartes.Text = "Martes";
            this.chkmartes.UseVisualStyleBackColor = true;
            // 
            // chklunes
            // 
            this.chklunes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chklunes.AutoSize = true;
            this.chklunes.Location = new System.Drawing.Point(49, 26);
            this.chklunes.Name = "chklunes";
            this.chklunes.Size = new System.Drawing.Size(72, 24);
            this.chklunes.TabIndex = 0;
            this.chklunes.Text = "Lunes";
            this.chklunes.UseVisualStyleBackColor = true;
            // 
            // dgvhorario
            // 
            this.dgvhorario.AllowUserToAddRows = false;
            this.dgvhorario.AllowUserToDeleteRows = false;
            this.dgvhorario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dgvhorario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvhorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvhorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhorario.BackgroundColor = System.Drawing.Color.White;
            this.dgvhorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvhorario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvhorario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvhorario.ColumnHeadersHeight = 40;
            this.dgvhorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvhorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempleado,
            this.inicio,
            this.salida,
            this.inidesc,
            this.findesc,
            this.descripcion,
            this.turno});
            this.dgvhorario.EnableHeadersVisualStyles = false;
            this.dgvhorario.GridColor = System.Drawing.Color.DarkCyan;
            this.dgvhorario.Location = new System.Drawing.Point(29, 555);
            this.dgvhorario.Name = "dgvhorario";
            this.dgvhorario.ReadOnly = true;
            this.dgvhorario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhorario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvhorario.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dgvhorario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvhorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhorario.Size = new System.Drawing.Size(1045, 221);
            this.dgvhorario.TabIndex = 54;
            this.dgvhorario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhorario_CellClick);
            // 
            // idempleado
            // 
            this.idempleado.DataPropertyName = "ID_horario";
            this.idempleado.HeaderText = "Código";
            this.idempleado.Name = "idempleado";
            this.idempleado.ReadOnly = true;
            // 
            // inicio
            // 
            this.inicio.DataPropertyName = "Hora_inicio";
            this.inicio.HeaderText = "Inicio";
            this.inicio.Name = "inicio";
            this.inicio.ReadOnly = true;
            // 
            // salida
            // 
            this.salida.DataPropertyName = "Hora_salida";
            this.salida.HeaderText = "Salida";
            this.salida.Name = "salida";
            this.salida.ReadOnly = true;
            // 
            // inidesc
            // 
            this.inidesc.DataPropertyName = "Inicio_descan";
            this.inidesc.HeaderText = "Inicio descanso";
            this.inidesc.Name = "inidesc";
            this.inidesc.ReadOnly = true;
            // 
            // findesc
            // 
            this.findesc.DataPropertyName = "Fin_descan";
            this.findesc.HeaderText = "Fin descanso";
            this.findesc.Name = "findesc";
            this.findesc.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // turno
            // 
            this.turno.DataPropertyName = "Tipo";
            this.turno.HeaderText = "Turno";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox7.Controls.Add(this.btnlimpiar);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox7.Location = new System.Drawing.Point(778, 456);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(161, 80);
            this.groupBox7.TabIndex = 51;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Limpiar";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpiar.Location = new System.Drawing.Point(18, 22);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(125, 40);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Adm_horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1108, 804);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.dgvhorario);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adm_horario";
            this.Text = "Registro_horario";
            this.Load += new System.EventHandler(this.Registro_horario_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnact;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbturno;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chksabado;
        private System.Windows.Forms.CheckBox chkviernes;
        private System.Windows.Forms.CheckBox chkjueves;
        private System.Windows.Forms.CheckBox chkmiercoles;
        private System.Windows.Forms.CheckBox chkmartes;
        private System.Windows.Forms.CheckBox chklunes;
        private System.Windows.Forms.DataGridView dgvhorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn inidesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn findesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.MaskedTextBox txtinicio;
        private System.Windows.Forms.MaskedTextBox txtsalida;
        private System.Windows.Forms.MaskedTextBox txtfindesc;
        private System.Windows.Forms.MaskedTextBox txtinidesc;
    }
}