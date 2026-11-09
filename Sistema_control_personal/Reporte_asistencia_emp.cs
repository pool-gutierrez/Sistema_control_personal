using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Sistema_control_personal
{
    public partial class Reporte_asistencia_emp : Form
    {
        Asistencia asis = new Asistencia();
        Nasistencia nasis = new Nasistencia();
        public Reporte_asistencia_emp()
        {
            InitializeComponent();
        }

        public int codigo { get; set; }

        private void Rep_asist_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        public void CargarTabla()
        {
            DataTable dt = new DataTable();
            Asistencia asis = new Asistencia();
            Nasistencia nasis = new Nasistencia();

            asis.idempleado_a = Convert.ToInt32(codigo);
            dt = nasis.AsistenciaEmp(asis);
            dgvasistencia.DataSource = dt;
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            Reporte.Reporte_x_emp rp = new Reporte.Reporte_x_emp();
            rp.id_emp = Convert.ToInt32(codigo);
            rp.Show();
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            String f1 = dtpicinicio.Value.ToString("yyyy/MM/dd");
            String f2 = dtpicfinal.Value.ToString("yyyy/MM/dd");
            dgvasistencia.DataSource = nasis.FiltrarAsisEmpFecha(codigo, f1, f2);
        }

        private void btntodo_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnfecha_Click(object sender, EventArgs e)
        {
            String f1 = dtpicinicio.Value.ToString("yyyy/MM/dd");
            String f2 = dtpicfinal.Value.ToString("yyyy/MM/dd");
            Reporte.Reporte_x_empfecha rp = new Reporte.Reporte_x_empfecha();
            rp.idemp = codigo;
            rp.f1 = Convert.ToDateTime(f1);
            rp.f2 = Convert.ToDateTime(f2);
            rp.Show();
        }
    }
}
