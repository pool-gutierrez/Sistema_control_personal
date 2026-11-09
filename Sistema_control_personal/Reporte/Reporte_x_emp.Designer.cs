namespace Sistema_control_personal.Reporte
{
    partial class Reporte_x_emp
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_x_emp));
            this.sp_reporte_asisxempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new Sistema_control_personal.Reporte.DataSetPrincipal();
            this.parametro1 = new System.Windows.Forms.Label();
            this.parametro2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_reporte_asisxempTableAdapter = new Sistema_control_personal.Reporte.DataSetPrincipalTableAdapters.sp_reporte_asisxempTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_asisxempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_reporte_asisxempBindingSource
            // 
            this.sp_reporte_asisxempBindingSource.DataMember = "sp_reporte_asisxemp";
            this.sp_reporte_asisxempBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametro1
            // 
            this.parametro1.AutoSize = true;
            this.parametro1.ForeColor = System.Drawing.Color.White;
            this.parametro1.Location = new System.Drawing.Point(926, 24);
            this.parametro1.Name = "parametro1";
            this.parametro1.Size = new System.Drawing.Size(35, 13);
            this.parametro1.TabIndex = 0;
            this.parametro1.Text = "label1";
            // 
            // parametro2
            // 
            this.parametro2.AutoSize = true;
            this.parametro2.ForeColor = System.Drawing.Color.White;
            this.parametro2.Location = new System.Drawing.Point(1001, 24);
            this.parametro2.Name = "parametro2";
            this.parametro2.Size = new System.Drawing.Size(35, 13);
            this.parametro2.TabIndex = 1;
            this.parametro2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.parametro2);
            this.panel1.Controls.Add(this.parametro1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 50);
            this.panel1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "REPORTE DE ASISTENCIAS";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_reporte_asisxempBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_control_personal.Reporte.Rep_asisxemp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1092, 715);
            this.reportViewer1.TabIndex = 52;
            // 
            // sp_reporte_asisxempTableAdapter
            // 
            this.sp_reporte_asisxempTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_x_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 765);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_x_emp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de asistencia por empleado";
            this.Load += new System.EventHandler(this.Reporte_x_emp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_asisxempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label parametro2;
        public System.Windows.Forms.Label parametro1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_reporte_asisxempBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.sp_reporte_asisxempTableAdapter sp_reporte_asisxempTableAdapter;
    }
}