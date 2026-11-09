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
    public partial class Emp_alta : Form
    {
        Empleado emp = new Empleado();
        Nempleado nemp = new Nempleado();
        Departamento dep = new Departamento();
        Ndepartamento ndep = new Ndepartamento();
        Cargo car = new Cargo();
        Ncargo ncar = new Ncargo();
        DataTable dt = new DataTable();
        public Emp_alta()
        {
            InitializeComponent();
            txtcod.ReadOnly = true;
        }

        private void Emp_alta_Load(object sender, EventArgs e)
        {
            ListarEmpleados();
            CargarDep();
            CargarCargo();
        }

        private void ListarEmpleados()
        {
            dgvempact.DataSource = nemp.ListarEmpAct();
        }

        private void Limpiar()
        {
            txtcod.Text = "";
            cmbdep.SelectedIndex = 0;
            cmbcargo.SelectedIndex = 0;
        }

        private void CargarDep()
        {
            dt = ndep.ListarDep();
            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione un departamento";
            dt.Rows.InsertAt(fila, 0);
            cmbdep.DisplayMember = "Nombre";
            cmbdep.ValueMember = "ID_departam";
            cmbdep.DataSource = dt;
        }

        private void CargarCargo()
        {
            dt = ncar.ListarCar();
            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione un cargo";
            dt.Rows.InsertAt(fila, 0);
            cmbcargo.DisplayMember = "Nombre";
            cmbcargo.ValueMember = "ID_cargo";
            cmbcargo.DataSource = dt;
        }

        private void dgvempinac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcod.Text = dgvempact.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Error de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbaja_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcod.Text))
            {
                MessageBox.Show("Seleccione un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea dar de baja al empleado?", "Baja de empleado",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        emp.id_empleado = Convert.ToInt32(txtcod.Text);
                        emp.estado_emp = "Inactivo";
                        nemp.BajaEmp(emp);
                        ListarEmpleados();
                        MessageBox.Show("Empleado dado de baja con éxito.", "Empleado en baja!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        txtcod.Focus();
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        MessageBox.Show("Datos incompatibles: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    txtcod.Focus();
                }
            }             
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmbdep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdep.SelectedIndex == 0)
            {
                ListarEmpleados();
            }
            else
            {
                emp.id_cargo = Convert.ToInt32("0");
                emp.id_departamento = Convert.ToInt32(cmbdep.SelectedValue);
                dgvempact.DataSource = nemp.Listaractfiltro(emp);
            }
        }

        private void cmbcargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcargo.SelectedIndex == 0)
            {
                ListarEmpleados();
            }
            else
            {
                emp.id_cargo = Convert.ToInt32(cmbcargo.SelectedValue);
                emp.id_departamento = Convert.ToInt32("0");
                dgvempact.DataSource = nemp.Listaractfiltro(emp);
            }
        }
    }
}
