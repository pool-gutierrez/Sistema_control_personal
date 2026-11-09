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
    public partial class Reporte_asistencia : Form
    {
        Asistencia asis = new Asistencia();
        Nasistencia nasis = new Nasistencia();
        Empleado emp = new Empleado();
        Nempleado nemp = new Nempleado();
        Cargo car = new Cargo();
        Ncargo ncar = new Ncargo();
        DataTable dt = new DataTable();

        public Reporte_asistencia()
        {
            InitializeComponent();
        }

        private void Reporte_asistencia_Load(object sender, EventArgs e)
        {
            CargarAsistencia();
            CargarEmpleado();
            Cargarcmbdescripcion();
            Cargarcargo();
            ContarAsistencia();
        }

        private void CargarAsistencia()
        {
            dgvasistencia.DataSource = nasis.ListarAsis();
        }

        private void CargarEmpleado()
        {
            dt = nemp.Comboemp();
            DataRow fila = dt.NewRow();
            fila["Nombres"] = "Seleccione un empleado";
            dt.Rows.InsertAt(fila, 0);
            cmbemp.DisplayMember = "Nombres";
            cmbemp.ValueMember = "ID_empleado";
            cmbemp.DataSource = dt;
        }

        private void Cargarcmbdescripcion()
        {
            cmbdescripcion.Items.Clear();
            cmbdescripcion.Items.Insert(0, "Seleccione");
            cmbdescripcion.Items.Add("Asistió");
            cmbdescripcion.Items.Add("Tardanza");
            cmbdescripcion.Items.Add("Faltó");
            cmbdescripcion.SelectedIndex = 0;
        }

        private void Cargarcargo()
        {
            dt = ncar.ListarCar();
            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione un cargo";
            dt.Rows.InsertAt(fila, 0);
            cmbcargo.DisplayMember = "Nombre";
            cmbcargo.ValueMember = "ID_cargo";
            cmbcargo.DataSource = dt;
        }

        private void ContarAsistencia()
        {
            dt = nasis.ListarAsis();
            txtasis.Text = dt.Rows.Count.ToString();
        }

        private void cmbemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbemp.SelectedIndex == 0)
            {
                CargarAsistencia();
            }
            else
            {
                String idemp = cmbemp.SelectedValue.ToString();
                String idcar = "";
                String desc = "";
                dgvasistencia.DataSource = nasis.FiltrarAsis(idemp, idcar, desc);
            }
        }

        private void cmbdescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdescripcion.SelectedIndex == 0)
            {
                CargarAsistencia();
            }
            else
            {
                String idemp = "";
                String idcar = "";
                String desc = cmbdescripcion.SelectedItem.ToString();
                dgvasistencia.DataSource = nasis.FiltrarAsis(idemp, idcar, desc);
            }
        }

        private void cmbcargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcargo.SelectedIndex == 0)
            {
                CargarAsistencia();
            }
            else
            {
                String idemp = "";
                String idcar = cmbcargo.SelectedValue.ToString();
                String desc = "";
                dgvasistencia.DataSource = nasis.FiltrarAsis(idemp, idcar, desc);
            }
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            String f1 = dtpicinicio.Value.ToString("yyyy/MM/dd");
            String f2 = dtpicfinal.Value.ToString("yyyy/MM/dd");
            dgvasistencia.DataSource = nasis.FiltrarAsisFecha(f1, f2);
        }

        private void btnfecha_Click(object sender, EventArgs e)
        {
            String f1 = dtpicinicio.Value.ToString("yyyy/MM/dd");
            String f2 = dtpicfinal.Value.ToString("yyyy/MM/dd");
            Reporte.Reporte_x_fecha rp = new Reporte.Reporte_x_fecha();
            rp.f1 = Convert.ToDateTime(f1);
            rp.f2 = Convert.ToDateTime(f2);
            rp.Show();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            if (cmbemp.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reporte.Reporte_x_emp rp = new Reporte.Reporte_x_emp();
                rp.id_emp = Convert.ToInt32(cmbemp.SelectedValue);
                rp.Show();
            }
        }

        private void btndescripcion_Click(object sender, EventArgs e)
        {
            if (cmbdescripcion.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reporte.Reporte_x_prmt rp = new Reporte.Reporte_x_prmt();
                rp.desc = cmbdescripcion.SelectedItem.ToString();
                rp.cargo = Convert.ToInt32("0");
                rp.Show();
            }
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            if (cmbcargo.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un cargo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reporte.Reporte_x_prmt rp = new Reporte.Reporte_x_prmt();
                rp.desc = "";
                rp.cargo = Convert.ToInt32(cmbcargo.SelectedValue);
                rp.Show();
            }
        }

        private void btngeneral_Click(object sender, EventArgs e)
        {
            Reporte.Reporte_general rp = new Reporte.Reporte_general();
            rp.Show();
        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            CargarAsistencia();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar los registros seleccionados? \nUn vez eliminados los registros ya no podrá volver a recuperarlos.",
                    "Eliminar registros de asistencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                String f1 = dtpicinicio.Value.ToString("yyyy/MM/dd");
                String f2 = dtpicfinal.Value.ToString("yyyy/MM/dd");
                nasis.BorrarAsis(f1, f2);
                CargarAsistencia();
                MessageBox.Show("Registros eliminados con éxito.", "Registros eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                CargarAsistencia();
            }
            
        }
    }
}
