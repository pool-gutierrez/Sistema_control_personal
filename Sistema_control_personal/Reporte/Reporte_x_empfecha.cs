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
    public partial class Reporte_x_empfecha : Form
    {
        public Reporte_x_empfecha()
        {
            InitializeComponent();
        }

        public int idemp { get; set; }
        public DateTime f1 {get; set;}
        public DateTime f2 { get; set; }

        private void Reporte_x_empfecha_Load(object sender, EventArgs e)
        {
            try
            {
                this.sp_reporte_empasisxfechaTableAdapter.Fill(this.DataSetPrincipal.sp_reporte_empasisxfecha, idemp, f1, f2);
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                this.reportViewer1.RefreshReport();
            }
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.sp_reporte_empasisxfecha' Puede moverla o quitarla según sea necesario.
        }
    }
}
