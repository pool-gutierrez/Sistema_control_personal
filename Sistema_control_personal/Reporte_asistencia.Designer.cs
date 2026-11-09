namespace Sistema_control_personal
{
    partial class Reporte_asistencia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btncargo = new System.Windows.Forms.Button();
            this.cmbcargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btndescripcion = new System.Windows.Forms.Button();
            this.cmbdescripcion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnempleado = new System.Windows.Forms.Button();
            this.cmbemp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btntodos = new System.Windows.Forms.Button();
            this.btngeneral = new System.Windows.Forms.Button();
            this.txtasis = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvasistencia = new System.Windows.Forms.DataGridView();
            this.idemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apepaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpicinicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.dtpicfinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnfecha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvasistencia)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 50);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "REPORTE DE ASISTENCIAS";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox5.Controls.Add(this.btncargo);
            this.groupBox5.Controls.Add(this.cmbcargo);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox5.Location = new System.Drawing.Point(669, 597);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(407, 83);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reporte por cargo específico";
            // 
            // btncargo
            // 
            this.btncargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btncargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncargo.FlatAppearance.BorderSize = 0;
            this.btncargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btncargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btncargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargo.ForeColor = System.Drawing.Color.White;
            this.btncargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncargo.Location = new System.Drawing.Point(266, 24);
            this.btncargo.Name = "btncargo";
            this.btncargo.Size = new System.Drawing.Size(119, 40);
            this.btncargo.TabIndex = 40;
            this.btncargo.Text = "Imprimir";
            this.btncargo.UseVisualStyleBackColor = false;
            this.btncargo.Click += new System.EventHandler(this.btncargo_Click);
            // 
            // cmbcargo
            // 
            this.cmbcargo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbcargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.cmbcargo.FormattingEnabled = true;
            this.cmbcargo.Location = new System.Drawing.Point(73, 31);
            this.cmbcargo.Name = "cmbcargo";
            this.cmbcargo.Size = new System.Drawing.Size(180, 28);
            this.cmbcargo.TabIndex = 38;
            this.cmbcargo.SelectedIndexChanged += new System.EventHandler(this.cmbcargo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(14, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cargo";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.btndescripcion);
            this.groupBox3.Controls.Add(this.cmbdescripcion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox3.Location = new System.Drawing.Point(669, 508);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 83);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reporte por descripción de asistencia";
            // 
            // btndescripcion
            // 
            this.btndescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btndescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndescripcion.FlatAppearance.BorderSize = 0;
            this.btndescripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btndescripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescripcion.ForeColor = System.Drawing.Color.White;
            this.btndescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndescripcion.Location = new System.Drawing.Point(266, 24);
            this.btndescripcion.Name = "btndescripcion";
            this.btndescripcion.Size = new System.Drawing.Size(119, 40);
            this.btndescripcion.TabIndex = 41;
            this.btndescripcion.Text = "Imprimir";
            this.btndescripcion.UseVisualStyleBackColor = false;
            this.btndescripcion.Click += new System.EventHandler(this.btndescripcion_Click);
            // 
            // cmbdescripcion
            // 
            this.cmbdescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbdescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.cmbdescripcion.FormattingEnabled = true;
            this.cmbdescripcion.Location = new System.Drawing.Point(119, 31);
            this.cmbdescripcion.Name = "cmbdescripcion";
            this.cmbdescripcion.Size = new System.Drawing.Size(134, 28);
            this.cmbdescripcion.TabIndex = 38;
            this.cmbdescripcion.SelectedIndexChanged += new System.EventHandler(this.cmbdescripcion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descripción";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.btnempleado);
            this.groupBox2.Controls.Add(this.cmbemp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox2.Location = new System.Drawing.Point(31, 597);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 83);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte por empleado especifico";
            // 
            // btnempleado
            // 
            this.btnempleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnempleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnempleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnempleado.FlatAppearance.BorderSize = 0;
            this.btnempleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnempleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleado.ForeColor = System.Drawing.Color.White;
            this.btnempleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleado.Location = new System.Drawing.Point(484, 22);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(119, 40);
            this.btnempleado.TabIndex = 39;
            this.btnempleado.Text = "Imprimir";
            this.btnempleado.UseVisualStyleBackColor = false;
            this.btnempleado.Click += new System.EventHandler(this.btnempleado_Click);
            // 
            // cmbemp
            // 
            this.cmbemp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.cmbemp.FormattingEnabled = true;
            this.cmbemp.Location = new System.Drawing.Point(103, 29);
            this.cmbemp.Name = "cmbemp";
            this.cmbemp.Size = new System.Drawing.Size(370, 28);
            this.cmbemp.TabIndex = 38;
            this.cmbemp.SelectedIndexChanged += new System.EventHandler(this.cmbemp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(14, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Empleado";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox4.Controls.Add(this.btntodos);
            this.groupBox4.Controls.Add(this.btngeneral);
            this.groupBox4.Controls.Add(this.txtasis);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox4.Location = new System.Drawing.Point(31, 508);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(624, 83);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reporte general";
            // 
            // btntodos
            // 
            this.btntodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btntodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntodos.FlatAppearance.BorderSize = 0;
            this.btntodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btntodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btntodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntodos.ForeColor = System.Drawing.Color.White;
            this.btntodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntodos.Location = new System.Drawing.Point(421, 24);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(182, 40);
            this.btntodos.TabIndex = 39;
            this.btntodos.Text = "Todos los registros";
            this.btntodos.UseVisualStyleBackColor = false;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // btngeneral
            // 
            this.btngeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btngeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeneral.FlatAppearance.BorderSize = 0;
            this.btngeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btngeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btngeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneral.ForeColor = System.Drawing.Color.White;
            this.btngeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngeneral.Location = new System.Drawing.Point(290, 24);
            this.btngeneral.Name = "btngeneral";
            this.btngeneral.Size = new System.Drawing.Size(119, 40);
            this.btngeneral.TabIndex = 38;
            this.btngeneral.Text = "Imprimir";
            this.btngeneral.UseVisualStyleBackColor = false;
            this.btngeneral.Click += new System.EventHandler(this.btngeneral_Click);
            // 
            // txtasis
            // 
            this.txtasis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtasis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.txtasis.Location = new System.Drawing.Point(185, 31);
            this.txtasis.Name = "txtasis";
            this.txtasis.Size = new System.Drawing.Size(94, 26);
            this.txtasis.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label12.Location = new System.Drawing.Point(14, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Número de registros";
            // 
            // dgvasistencia
            // 
            this.dgvasistencia.AllowUserToAddRows = false;
            this.dgvasistencia.AllowUserToDeleteRows = false;
            this.dgvasistencia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dgvasistencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvasistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvasistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvasistencia.BackgroundColor = System.Drawing.Color.White;
            this.dgvasistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvasistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvasistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvasistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvasistencia.ColumnHeadersHeight = 40;
            this.dgvasistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvasistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idemp,
            this.apepaterno,
            this.ape_materno,
            this.nom,
            this.entrada,
            this.salida,
            this.fecha,
            this.descripcion,
            this.horas});
            this.dgvasistencia.EnableHeadersVisualStyles = false;
            this.dgvasistencia.GridColor = System.Drawing.Color.DarkCyan;
            this.dgvasistencia.Location = new System.Drawing.Point(31, 81);
            this.dgvasistencia.Name = "dgvasistencia";
            this.dgvasistencia.ReadOnly = true;
            this.dgvasistencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvasistencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvasistencia.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dgvasistencia.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvasistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvasistencia.Size = new System.Drawing.Size(1045, 407);
            this.dgvasistencia.TabIndex = 55;
            // 
            // idemp
            // 
            this.idemp.DataPropertyName = "ID_empleado";
            this.idemp.HeaderText = "Código empleado";
            this.idemp.Name = "idemp";
            this.idemp.ReadOnly = true;
            // 
            // apepaterno
            // 
            this.apepaterno.DataPropertyName = "Ape_paterno";
            this.apepaterno.HeaderText = "Apellido paterno";
            this.apepaterno.Name = "apepaterno";
            this.apepaterno.ReadOnly = true;
            // 
            // ape_materno
            // 
            this.ape_materno.DataPropertyName = "Ape_materno";
            this.ape_materno.HeaderText = "Apellido materno";
            this.ape_materno.Name = "ape_materno";
            this.ape_materno.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "Nombres";
            this.nom.HeaderText = "Nombres";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // entrada
            // 
            this.entrada.DataPropertyName = "Hora_entrada";
            this.entrada.HeaderText = "Hora entrada";
            this.entrada.Name = "entrada";
            this.entrada.ReadOnly = true;
            // 
            // salida
            // 
            this.salida.DataPropertyName = "Hora_salida";
            this.salida.HeaderText = "Hora salida";
            this.salida.Name = "salida";
            this.salida.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // horas
            // 
            this.horas.DataPropertyName = "Horas_trabajadas";
            this.horas.HeaderText = "Horas trabajadas";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label7.Location = new System.Drawing.Point(14, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha inicio";
            // 
            // dtpicinicio
            // 
            this.dtpicinicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.dtpicinicio.CalendarMonthBackground = System.Drawing.Color.DarkCyan;
            this.dtpicinicio.CustomFormat = "yyyy/MM/dd";
            this.dtpicinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicinicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicinicio.Location = new System.Drawing.Point(123, 32);
            this.dtpicinicio.Name = "dtpicinicio";
            this.dtpicinicio.Size = new System.Drawing.Size(165, 26);
            this.dtpicinicio.TabIndex = 24;
            this.dtpicinicio.Value = new System.DateTime(2020, 1, 19, 0, 0, 0, 0);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox7.Controls.Add(this.btnfiltrar);
            this.groupBox7.Controls.Add(this.dtpicfinal);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.btnborrar);
            this.groupBox7.Controls.Add(this.btnfecha);
            this.groupBox7.Controls.Add(this.dtpicinicio);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox7.Location = new System.Drawing.Point(31, 686);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1045, 83);
            this.groupBox7.TabIndex = 57;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Reporte por intervalo de fechas";
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnfiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfiltrar.FlatAppearance.BorderSize = 0;
            this.btnfiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnfiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnfiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrar.ForeColor = System.Drawing.Color.White;
            this.btnfiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfiltrar.Location = new System.Drawing.Point(575, 26);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(119, 40);
            this.btnfiltrar.TabIndex = 44;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = false;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // dtpicfinal
            // 
            this.dtpicfinal.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.dtpicfinal.CalendarMonthBackground = System.Drawing.Color.DarkCyan;
            this.dtpicfinal.CustomFormat = "yyyy/MM/dd";
            this.dtpicfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicfinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicfinal.Location = new System.Drawing.Point(405, 32);
            this.dtpicfinal.Name = "dtpicfinal";
            this.dtpicfinal.Size = new System.Drawing.Size(155, 26);
            this.dtpicfinal.TabIndex = 43;
            this.dtpicfinal.Value = new System.DateTime(2020, 1, 19, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(301, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha final";
            // 
            // btnborrar
            // 
            this.btnborrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnborrar.FlatAppearance.BorderSize = 0;
            this.btnborrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.White;
            this.btnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrar.Location = new System.Drawing.Point(841, 26);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(182, 40);
            this.btnborrar.TabIndex = 41;
            this.btnborrar.Text = "Borrar registros";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnfecha
            // 
            this.btnfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnfecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfecha.FlatAppearance.BorderSize = 0;
            this.btnfecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnfecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnfecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecha.ForeColor = System.Drawing.Color.White;
            this.btnfecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfecha.Location = new System.Drawing.Point(708, 26);
            this.btnfecha.Name = "btnfecha";
            this.btnfecha.Size = new System.Drawing.Size(119, 40);
            this.btnfecha.TabIndex = 40;
            this.btnfecha.Text = "Imprimir";
            this.btnfecha.UseVisualStyleBackColor = false;
            this.btnfecha.Click += new System.EventHandler(this.btnfecha_Click);
            // 
            // Reporte_asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1108, 804);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvasistencia);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_asistencia";
            this.Text = "Reporte_asistencia";
            this.Load += new System.EventHandler(this.Reporte_asistencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvasistencia)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbcargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.Button btngeneral;
        private System.Windows.Forms.TextBox txtasis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvasistencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpicinicio;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btncargo;
        private System.Windows.Forms.Button btndescripcion;
        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnfecha;
        private System.Windows.Forms.DateTimePicker dtpicfinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn apepaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.Button btnfiltrar;
    }
}