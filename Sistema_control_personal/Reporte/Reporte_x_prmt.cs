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
    public partial class Reporte_x_prmt : Form
    {
        public Reporte_x_prmt()
        {
            InitializeComponent();
        }

        public int cargo { get; set; }
        public String desc { get; set; }

        private void Reporte_x_prmt_Load(object sender, EventArgs e)
        {
            try
            {
                this.sp_reporte_asisxprmtTableAdapter.Fill(this.DataSetPrincipal.sp_reporte_asisxprmt, cargo, desc);
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.sp_reporte_asisxprmt' Puede moverla o quitarla según sea necesario. 
        }
    }
}
