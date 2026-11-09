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
    public partial class Adm_departamento : Form
    {
        Ndepartamento ndep = new Ndepartamento();
        Departamento dep = new Departamento();
        Cargo car = new Cargo();
        Ncargo ncar = new Ncargo();
        public Adm_departamento()
        {
            InitializeComponent();
            txtcod.ReadOnly = true;
        }

        private void Departamento_Load(object sender, EventArgs e)
        {
            dgvdep.DataSource = ndep.ListarDep();
        }

        private void Limpiar()
        {
            txtnombre.Text = "";
            txtdesc.Text = "";
            txtnum.Text = "";
        }

        private void CargarDep()
        {
            dgvdep.DataSource = ndep.ListarDep();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtdesc.Text) || string.IsNullOrEmpty(txtnum.Text))
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombre.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea registrar un nuevo departamento?",
                    "Nuevo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dep.nombredep_d = txtnombre.Text;
                        dep.descripciondep_d = txtdesc.Text;
                        dep.numtrabajadores_d = Convert.ToInt32(txtnum.Text);
                        ndep.Registrardep(dep);

                        MessageBox.Show("Departamento registrado con éxito.", "Departamento registrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDep();
                        Limpiar();
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        MessageBox.Show("Error de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    txtnombre.Focus();
                }
            }
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtdesc.Text) || string.IsNullOrEmpty(txtnum.Text))
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombre.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea modificar el departamento?",
                    "Nueva modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dep.iddepartam_d = Convert.ToInt32(txtcod.Text);
                        dep.nombredep_d = txtnombre.Text;
                        dep.descripciondep_d = txtdesc.Text;
                        dep.numtrabajadores_d = Convert.ToInt32(txtnum.Text);
                        ndep.Actualizardep(dep);
                        MessageBox.Show("Departamento modificado con éxito.", "Departamento modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDep();
                        Limpiar();
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        MessageBox.Show("Error de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    txtnombre.Focus();
                }
            }
        }

        private void dgvdep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcod.Text = dgvdep.CurrentRow.Cells[0].Value.ToString();
                dep.iddepartam_d = Convert.ToInt32(txtcod.Text);
                DataTable dt = new DataTable();
                dt = ndep.ConsultarDep(dep);
                txtnombre.Text = dt.Rows[0][1].ToString();
                txtdesc.Text = dt.Rows[0][2].ToString();
                txtnum.Text = dt.Rows[0][3].ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Error de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
