namespace Sistema_control_personal
{
    partial class Reporte_asistencia_emp
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
            this.btnempleado = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btntodo = new System.Windows.Forms.Button();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.dtpicfinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfecha = new System.Windows.Forms.Button();
            this.dtpicinicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvasistencia)).BeginInit();
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
            this.panel1.TabIndex = 51;
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
            this.btnempleado.Location = new System.Drawing.Point(869, 527);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(182, 40);
            this.btnempleado.TabIndex = 57;
            this.btnempleado.Text = "Imprimir todo";
            this.btnempleado.UseVisualStyleBackColor = false;
            this.btnempleado.Click += new System.EventHandler(this.btnempleado_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox7.Controls.Add(this.btntodo);
            this.groupBox7.Controls.Add(this.btnfiltrar);
            this.groupBox7.Controls.Add(this.dtpicfinal);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.btnfecha);
            this.groupBox7.Controls.Add(this.dtpicinicio);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.groupBox7.Location = new System.Drawing.Point(26, 587);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1045, 83);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Reporte por intervalo de fechas";
            // 
            // btntodo
            // 
            this.btntodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btntodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntodo.FlatAppearance.BorderSize = 0;
            this.btntodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btntodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btntodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntodo.ForeColor = System.Drawing.Color.White;
            this.btntodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntodo.Location = new System.Drawing.Point(843, 25);
            this.btntodo.Name = "btntodo";
            this.btntodo.Size = new System.Drawing.Size(182, 40);
            this.btntodo.TabIndex = 45;
            this.btntodo.Text = "Todas las fechas";
            this.btntodo.UseVisualStyleBackColor = false;
            this.btntodo.Click += new System.EventHandler(this.btntodo_Click);
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
            this.btnfiltrar.Location = new System.Drawing.Point(575, 25);
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
            this.btnfecha.Location = new System.Drawing.Point(708, 25);
            this.btnfecha.Name = "btnfecha";
            this.btnfecha.Size = new System.Drawing.Size(119, 40);
            this.btnfecha.TabIndex = 40;
            this.btnfecha.Text = "Imprimir";
            this.btnfecha.UseVisualStyleBackColor = false;
            this.btnfecha.Click += new System.EventHandler(this.btnfecha_Click);
            // 
            // dtpicinicio
            // 
            this.dtpicinicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.dtpicinicio.CalendarMonthBackground = System.Drawing.Color.DarkCyan;
            this.dtpicinicio.CustomFormat = "yyyy/MM/dd";
            this.dtpicinicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicinicio.Location = new System.Drawing.Point(123, 32);
            this.dtpicinicio.Name = "dtpicinicio";
            this.dtpicinicio.Size = new System.Drawing.Size(165, 26);
            this.dtpicinicio.TabIndex = 24;
            this.dtpicinicio.Value = new System.DateTime(2020, 1, 19, 0, 0, 0, 0);
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
            this.dgvasistencia.Location = new System.Drawing.Point(26, 161);
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
            this.dgvasistencia.Size = new System.Drawing.Size(1045, 332);
            this.dgvasistencia.TabIndex = 59;
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
            // Reporte_asistencia_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1108, 804);
            this.Controls.Add(this.dgvasistencia);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnempleado);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_asistencia_emp";
            this.Text = "Rep_asist";
            this.Load += new System.EventHandler(this.Rep_asist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvasistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.DateTimePicker dtpicfinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnfecha;
        private System.Windows.Forms.DateTimePicker dtpicinicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btntodo;
        private System.Windows.Forms.DataGridView dgvasistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn apepaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
    }
}