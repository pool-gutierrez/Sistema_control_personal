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
    public partial class Reporte_general : Form
    {
        public Reporte_general()
        {
            InitializeComponent();
        }

        private void Reporte_general_Load(object sender, EventArgs e)
        {
            try
            {
                this.sp_reporte_asisgenTableAdapter.Fill(this.DataSetPrincipal.sp_reporte_asisgen);
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.sp_reporte_asisgen' Puede moverla o quitarla según sea necesario.
            
        }
    }
}
