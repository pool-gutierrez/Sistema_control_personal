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
    public partial class Adm_empleado : Form
    {
        Empleado emp = new Empleado();
        Nempleado nemp = new Nempleado();

        Departamento dep = new Departamento();
        Ndepartamento ndep = new Ndepartamento();

        Cargo car = new Cargo();
        Ncargo ncar = new Ncargo();

        Turno tur = new Turno();
        Nturno ntur = new Nturno();

        Horario hor = new Horario();
        Nhorario nhor = new Nhorario();

        public Adm_empleado()
        {
            InitializeComponent();
            txtcod.ReadOnly = true;
            lblinfodni.Text = "";
            lblinfotel.Text = "";
            lblinfocell.Text = "";
        }

        private void Registro_empleado_Load(object sender, EventArgs e)
        {
            ListarEmpleados();;
            ListarDepartamento();
            ListarCargo();
            ListarTurno();
            ListarHorario();
            ListarSexo();
        }

        private void ListarEmpleados()
        {
            Nempleado nemp = new Nempleado();
            dgvempleado.DataSource = nemp.ListarEmp();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //Validar dni
            Empleado emp2 = new Empleado();
            Nempleado nemp2 = new Nempleado();
            emp2.dni_emp = txtdni.Text;
            DataTable dtable = new DataTable();
            dtable = nemp2.ValDni(emp2);

            if (string.IsNullOrEmpty(txtapepat.Text) || string.IsNullOrEmpty(txtapemat.Text)
                || string.IsNullOrEmpty(txtnombres.Text) || string.IsNullOrEmpty(txtdni.Text)
                || cmbsexo.SelectedIndex == 0 || string.IsNullOrEmpty(txttelfijo.Text)
                || string.IsNullOrEmpty(txtcelular.Text) || string.IsNullOrEmpty(txtdireccion.Text)
                || string.IsNullOrEmpty(txtciudad.Text) || string.IsNullOrEmpty(txtdistrito.Text))
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombres.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea registrar un nuevo empleado?",
                    "Registro nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (dtable.Rows.Count > 0)
                    {
                        MessageBox.Show("El dni ingresado existe o el empleado ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            emp.ape_pat_emp = txtapepat.Text;
                            emp.ape_mat_emp = txtapemat.Text;
                            emp.nombres_emp = txtnombres.Text;
                            emp.dni_emp = txtdni.Text;
                            emp.sexo_emp = Convert.ToString(cmbsexo.SelectedItem);
                            emp.telfijo_emp = txttelfijo.Text;
                            emp.celular_emp = txtcelular.Text;
                            emp.dir_emp = txtdireccion.Text;
                            emp.ciudad_emp = txtciudad.Text;
                            emp.distrito_emp = txtdistrito.Text;
                            emp.estado_emp = "Activo";
                            emp.id_turno = Convert.ToInt32(cmbturno.SelectedValue);
                            emp.id_horario = Convert.ToInt32(cmbhorario.SelectedValue);
                            emp.id_departamento = Convert.ToInt32(cmbdep.SelectedValue);
                            emp.id_cargo = Convert.ToInt32(cmbcargo.SelectedValue);
                            nemp.RegistrarEmp(emp);

                            //Buscar id_empleado
                            Empleado emp3 = new Empleado();
                            Nempleado nemp3 = new Nempleado();
                            emp3.dni_emp = txtdni.Text;
                            DataTable dtable2 = new DataTable();
                            dtable2 = nemp3.BuscarID(emp3);
                            //Registrar Usuario
                            Usuario usu = new Usuario();
                            Nusuario nusu = new Nusuario();
                            usu.nombreusu_u = txtapepat.Text;
                            usu.contraseña_u = txtdni.Text;
                            usu.privilegios_u = 1;
                            usu.idempleado_u = Convert.ToInt32(dtable2.Rows[0][0]);
                            nusu.RegistrarUsu(usu);
                            MessageBox.Show("Empleado registrado con éxito.", "Empleado registrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarEmpleados();
                            Limpiar();
                            txtapepat.Focus();
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex);
                            MessageBox.Show("Datos incompatibles: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    txtapepat.Focus();
                }  
            }
        }

        private void ListarDepartamento()
        {
            cmbdep.DataSource = ndep.ListarDep();
            cmbdep.DisplayMember = "Nombre";
            cmbdep.ValueMember = "ID_departam";
        }

        private void ListarCargo()
        {
            cmbcargo.DataSource = ncar.ListarCar();
            cmbcargo.DisplayMember = "Nombre";
            cmbcargo.ValueMember = "ID_cargo";
        }

        private void ListarTurno()
        {
            cmbturno.DataSource = ntur.ListarTur();
            cmbturno.DisplayMember = "Tipo";
            cmbturno.ValueMember = "ID_turno";
        }

        private void ListarHorario()
        {
            cmbhorario.DataSource = nhor.ListarHor();
            cmbhorario.DisplayMember = "Descripcion";
            cmbhorario.ValueMember = "ID_horario";
        }

        private void ListarSexo()
        {
            cmbsexo.Items.Clear();
            cmbsexo.Items.Insert(0, "Seleccione Sexo");
            cmbsexo.Items.Add("Masculino");
            cmbsexo.Items.Add("Femenino");
            cmbsexo.SelectedIndex = 0;
        }

        private void Limpiar()
        {
            txtapepat.Text = "";
            txtapemat.Text = "";
            txtnombres.Text = "";
            txtdni.Text = "";
            cmbsexo.SelectedIndex=0;
            txttelfijo.Text = "";
            txtcelular.Text = "";
            txtdireccion.Text = "";
            txtciudad.Text = "";
            txtdistrito.Text = "";
            cmbdep.SelectedIndex = 0;
            cmbcargo.SelectedIndex = 0;
            cmbturno.SelectedIndex = 0;
            cmbhorario.SelectedIndex = 0;
            lblinfodni.Text = "";
            lblinfotel.Text = "";
            lblinfocell.Text = "";
            txtcod.Text = "";
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                lblinfodni.Text = "";
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                    lblinfodni.Text = "El DNI está compuesto solo de números.";
                }
            }      
        }

        private void dgvempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcod.Text = dgvempleado.CurrentRow.Cells[0].Value.ToString();
                Empleado emp1 = new Empleado();
                Nempleado nemp1 = new Nempleado();
                emp1.id_empleado = Convert.ToInt32(txtcod.Text);
                DataTable dtable2 = new DataTable();
                dtable2 = nemp1.BuscarEmp(emp1);
                txtapemat.Text = dtable2.Rows[0][1].ToString();
                txtapepat.Text = dtable2.Rows[0][2].ToString();
                txtnombres.Text = dtable2.Rows[0][3].ToString();
                txtdni.Text = dtable2.Rows[0][4].ToString();
                cmbsexo.SelectedItem = dtable2.Rows[0][5].ToString();
                txttelfijo.Text = dtable2.Rows[0][6].ToString();
                txtcelular.Text = dtable2.Rows[0][7].ToString();
                txtdireccion.Text = dtable2.Rows[0][8].ToString();
                txtciudad.Text = dtable2.Rows[0][9].ToString();
                txtdistrito.Text = dtable2.Rows[0][10].ToString();
                cmbturno.SelectedValue = Convert.ToInt32(dtable2.Rows[0][12]);
                cmbhorario.SelectedValue = Convert.ToInt32(dtable2.Rows[0][13]);
                cmbdep.SelectedValue = Convert.ToInt32(dtable2.Rows[0][14]);
                cmbcargo.SelectedValue = Convert.ToInt32(dtable2.Rows[0][15]);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Error de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtapepat.Text) || string.IsNullOrEmpty(txtapemat.Text)
                || string.IsNullOrEmpty(txtnombres.Text) || string.IsNullOrEmpty(txtdni.Text)
                || cmbsexo.SelectedIndex == 0 || string.IsNullOrEmpty(txttelfijo.Text)
                || string.IsNullOrEmpty(txtcelular.Text) || string.IsNullOrEmpty(txtdireccion.Text)
                || string.IsNullOrEmpty(txtciudad.Text) || string.IsNullOrEmpty(txtdistrito.Text)
                || string.IsNullOrEmpty(txtcod.Text))
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombres.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea actualizar los datos del empleado?",
                    "Actualizar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        emp.id_empleado = Convert.ToInt32(txtcod.Text);
                        emp.ape_pat_emp = txtapepat.Text;
                        emp.ape_mat_emp = txtapemat.Text;
                        emp.nombres_emp = txtnombres.Text;
                        emp.dni_emp = txtdni.Text;
                        emp.sexo_emp = Convert.ToString(cmbsexo.SelectedItem);
                        emp.telfijo_emp = txttelfijo.Text;
                        emp.celular_emp = txtcelular.Text;
                        emp.dir_emp = txtdireccion.Text;
                        emp.ciudad_emp = txtciudad.Text;
                        emp.distrito_emp = txtdistrito.Text;
                        emp.id_turno = Convert.ToInt32(cmbturno.SelectedValue);
                        emp.id_horario = Convert.ToInt32(cmbhorario.SelectedValue);
                        emp.id_departamento = Convert.ToInt32(cmbdep.SelectedValue);
                        emp.id_cargo = Convert.ToInt32(cmbcargo.SelectedValue);
                        nemp.ActualizarEmp(emp);
                        MessageBox.Show("Empleado Actualizado con éxito.", "Empleado Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarEmpleados();
                        Limpiar();
                        txtapepat.Focus();
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        MessageBox.Show("Datos incompatibles: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    txtapepat.Focus();
                }
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
                        MessageBox.Show("Empleado dado de baja con éxito.", "Empleado en baja!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarEmpleados();
                        Limpiar();
                        txtapepat.Focus();
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        MessageBox.Show("Datos incompatibles: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    txtapepat.Focus();
                }
            }             
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcod.Text))
            {
                MessageBox.Show("Seleccione un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar al empleado? \nEl empleado se eliminará permanentemente del sistema, así mismo el usuario asignado a él.",
                    "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Usuario usu = new Usuario();
                        Nusuario nusu = new Nusuario();
                        emp.id_empleado = Convert.ToInt32(txtcod.Text);
                        int id = Convert.ToInt32(txtcod.Text);
                        nusu.Eliminarusu(id);
                        nemp.EliminarEmp(emp);
                        MessageBox.Show("Empleado eliminado con éxito.", "Empleado eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarEmpleados();
                        Limpiar();
                        txtapepat.Focus();
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        MessageBox.Show("No se pudo eliminar al empleado: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    Limpiar();
                }
            }
        }

        private void txttelfijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                lblinfotel.Text = "";
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    lblinfotel.Text = "El teléfono está compuesto solo de números.";
                }
            } 
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                lblinfocell.Text = "";
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    lblinfocell.Text = "El celular está compuesto solo de números.";
                }
            } 
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
