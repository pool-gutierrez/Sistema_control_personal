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
    public partial class Informe_general : Form
    {
        Empleado emp = new Empleado();
        Nempleado nemp = new Nempleado();
        Nturno ntur = new Nturno();
        Nhorario nhor = new Nhorario();
        Ndepartamento ndep = new Ndepartamento();
        Ncargo ncar = new Ncargo();
        DataTable dt = new DataTable();

        public Informe_general()
        {
            InitializeComponent();
        }

        private void Informe_general_Load(object sender, EventArgs e)
        {
            Cargaremp();
            Cargarempact();
            Cargarempinac();
            Cargarcmbturno();
            Cargarturno();
            Cargarcmbhorario();
            Cargarhorario();
            Cargarcmbdep();
            Cargardep();
            Cargarcmbcar();
            Cargarcargo();
        }

        private void Cargaremp()
        {
            dt = nemp.ListarEmp();
            txtemp.Text = dt.Rows.Count.ToString();
        }

        private void Cargarempact()
        {
            dt = nemp.ListarEmpAct();
            txtempact.Text = dt.Rows.Count.ToString();
        }

        private void Cargarempinac()
        {
            dt = nemp.ListarEmpInac();
            txtempinac.Text = dt.Rows.Count.ToString();
        }

        private void Cargarcmbturno()
        {
            dt = ntur.ListarTur();
            DataRow fila = dt.NewRow();
            fila["Tipo"] = "Seleccione un turno";
            dt.Rows.InsertAt(fila, 0);
            cmbturno.DisplayMember = "Tipo";
            cmbturno.ValueMember = "ID_turno";
            cmbturno.DataSource = dt;
        }

        private void Cargarturno()
        {
            dt = ntur.ListarTur();
            txttur.Text = dt.Rows.Count.ToString();  
        }

        private void cmbturno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbturno.SelectedIndex == 0)
            {
                txtemptur.Text = "";
            }
            else
            {
                emp.id_turno = Convert.ToInt32(cmbturno.SelectedValue);
                dt = nemp.Contartur(emp);
                txtemptur.Text = dt.Rows[0][0].ToString();
            }
        }

        private void Cargarcmbhorario()
        {
            dt = nhor.ListarHor();
            DataRow fila = dt.NewRow();
            fila["Descripcion"] = "Seleccione un horario";
            dt.Rows.InsertAt(fila, 0);
            cmbhorario.DisplayMember = "Descripcion";
            cmbhorario.ValueMember = "ID_horario";
            cmbhorario.DataSource = dt;
        }

        private void Cargarhorario()
        {
            dt = nhor.ListarHor();
            txthor.Text = dt.Rows.Count.ToString();
        }

        private void cmbhorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbhorario.SelectedIndex == 0)
            {
                txtemphor.Text = "";
            }
            else
            {
                emp.id_horario = Convert.ToInt32(cmbhorario.SelectedValue);
                dt = nemp.Contarhor(emp);
                txtemphor.Text = dt.Rows[0][0].ToString();
            }
        }

        private void Cargarcmbdep()
        {
            dt = ndep.ListarDep();
            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione un departamento";
            dt.Rows.InsertAt(fila, 0);
            cmbdep.DisplayMember = "Nombre";
            cmbdep.ValueMember = "ID_departam";
            cmbdep.DataSource = dt;
        }

        private void Cargardep()
        {
            dt = ndep.ListarDep();
            txtdep.Text = dt.Rows.Count.ToString();
        }

        private void cmbdep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdep.SelectedIndex == 0)
            {
                txtempdep.Text = "";
            }
            else
            {
                emp.id_departamento = Convert.ToInt32(cmbdep.SelectedValue);
                dt = nemp.Contardep(emp);
                txtempdep.Text = dt.Rows[0][0].ToString();
            }
        }

        private void Cargarcmbcar()
        {
            dt = ncar.ListarCar();
            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione un cargo";
            dt.Rows.InsertAt(fila, 0);
            cmbcargo.DisplayMember = "Nombre";
            cmbcargo.ValueMember = "ID_cargo";
            cmbcargo.DataSource = dt;
        }

        private void Cargarcargo()
        {
            dt = ncar.ListarCar();
            txtcar.Text = dt.Rows.Count.ToString();
        }

        private void cmbcargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcargo.SelectedIndex == 0)
            {
                txtempcar.Text = "";
            }
            else
            {
                emp.id_cargo = Convert.ToInt32(cmbcargo.SelectedValue);
                dt = nemp.Contarcar(emp);
                txtempcar.Text = dt.Rows[0][0].ToString();
            }
        }

        private void Limpiar()
        {
            cmbcargo.SelectedIndex = 0;
            cmbdep.SelectedIndex = 0;
            cmbturno.SelectedIndex = 0;
            cmbhorario.SelectedIndex = 0;
            txtempcar.Text = "";
            txtempdep.Text = "";
            txtemphor.Text = "";
            txtemptur.Text = "";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
