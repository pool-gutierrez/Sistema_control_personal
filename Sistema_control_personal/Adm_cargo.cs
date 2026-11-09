using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Sistema_control_personal
{
    public partial class Adm_cargo : Form
    {
        Ndepartamento ndep = new Ndepartamento();
        Ncargo ncar = new Ncargo();
        Cargo car = new Cargo();

        public Adm_cargo()
        {
            InitializeComponent();
            txtcod.ReadOnly = true;
        }

        private void Adm_cargos_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarDep();
            CargarCargo();
        }

        private void CargarCombo()
        {
            cmbdep.DataSource = ndep.ListarDep();
            cmbdep.DisplayMember = "Nombre";
            cmbdep.ValueMember = "ID_departam";
        }

        private void CargarDep()
        {
            dgvdep.DataSource = ndep.ListarDep();
        }

        private void CargarCargo()
        {
            dgvcargo.DataSource = ncar.ListarCar();
        }

        private void Limpiar()
        {
            txtnombre.Text = "";
            txtdesc.Text = "";
            cmbdep.SelectedIndex = 0;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtdesc.Text))
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombre.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea registrar un nuevo cargo?",
                    "Nuevo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        car.nombrecar_c = txtnombre.Text;
                        car.descripcioncar_c = txtdesc.Text;
                        car.iddep_c = Convert.ToInt32(cmbdep.SelectedValue);
                        ncar.RegistrarCar(car);

                        MessageBox.Show("Cargo registrado con éxito.", "Horario registrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCargo();
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtdesc.Text))
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombre.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea modificar el cargo?",
                    "Nueva modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        car.idcargo_c = Convert.ToInt32(txtcod.Text);
                        car.nombrecar_c = txtnombre.Text;
                        car.descripcioncar_c = txtdesc.Text;
                        car.iddep_c = Convert.ToInt32(cmbdep.SelectedValue);
                        ncar.RegistrarCar(car);

                        MessageBox.Show("Cargo modificado con éxito.", "Cargo modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarCargo();
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

        private void dgvcargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcod.Text = dgvcargo.CurrentRow.Cells[0].Value.ToString();
                car.idcargo_c = Convert.ToInt32(txtcod.Text);
                DataTable dt = new DataTable();
                dt = ncar.ConsultarCar(car);
                txtnombre.Text = dt.Rows[0][1].ToString();
                txtdesc.Text = dt.Rows[0][2].ToString();
                cmbdep.SelectedValue = Convert.ToInt32(dt.Rows[0][3]);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Error de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
