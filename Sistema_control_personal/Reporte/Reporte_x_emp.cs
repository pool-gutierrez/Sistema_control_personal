using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_control_personal.Reporte
{
    public partial class Reporte_x_emp : Form
    {
        public Reporte_x_emp()
        {
            InitializeComponent();
        }

        public int id_emp { get; set; }

        private void Reporte_x_emp_Load(object sender, EventArgs e)
        {
            parametro2.Text = parametro1.Text;
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.sp_reporte_asisxemp' Puede moverla o quitarla según sea necesario.
            try 
            {
                this.sp_reporte_asisxempTableAdapter.Fill(this.DataSetPrincipal.sp_reporte_asisxemp, id_emp);
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
