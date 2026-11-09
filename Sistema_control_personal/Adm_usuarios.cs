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
    public partial class Adm_usuarios : Form
    {
        Usuario usu = new Usuario();
        Nusuario nusu = new Nusuario();

        Empleado emp = new Empleado();
        Nempleado nemp = new Nempleado();
        public Adm_usuarios()
        {
            InitializeComponent();
            txtcod.ReadOnly = true;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ListarEmp();
            ListarUsuario();
            ListarPriv();
        }

        private void dgvemp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtemp.Text = dgvemp.CurrentRow.Cells[0].Value.ToString();
        }

        private void ListarEmp()
        {
            dgvemp.DataSource = nemp.ListarEmp2();
        }

        private void ListarUsuario()
        {
            dgvusuario.DataSource = nusu.ListarUsu();
        }

        private void Limpiar()
        {
            txtnombre.Text = "";
            txtcontra.Text = "";
            txtcontraval.Text = "";
            txtcod.Text = "";
            txtemp.Text = "";
            cmbpriv.SelectedIndex = 0;
        }

        private void ListarPriv()
        {
            cmbpriv.Items.Clear();
            cmbpriv.Items.Insert(0, "Seleccione un privilegio");
            cmbpriv.Items.Add("1");
            cmbpriv.Items.Add("2");
            cmbpriv.Items.Add("3");
            cmbpriv.SelectedIndex = 0;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtemp.Text) || string.IsNullOrEmpty(txtnombre.Text)
               || string.IsNullOrEmpty(txtcontra.Text) || cmbpriv.SelectedIndex == 0)
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemp.Focus();
            }
            else
            {
                if(txtcontra.Text == txtcontraval.Text)
                {
                    //validar que no se repitan usuarios y empleados
                    usu.idempleado_u = Convert.ToInt32(txtemp.Text);
                    DataTable data = new DataTable();
                    data = nusu.ValidarUsu(usu);
                    if(data.Rows.Count > 0)
                    {
                        MessageBox.Show("Ya existe un usuario para el empleado asignado.", "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtemp.Focus();
                    }
                    else
                    {
                        usu.nombreusu_u = txtnombre.Text;
                        DataTable dtt = new DataTable();
                        dtt = nusu.ValidarnomUsu(usu);
                        if (dtt.Rows.Count > 0)
                        {
                            MessageBox.Show("Ya existe el nombre de usuario.", "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtnombre.Focus();
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("¿Está seguro que desea registrar un nuevo turno?",
                            "Nuevo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    usu.nombreusu_u = txtnombre.Text;
                                    usu.contraseña_u = txtcontra.Text;
                                    usu.privilegios_u = Convert.ToInt32(cmbpriv.SelectedItem);
                                    usu.idempleado_u = Convert.ToInt32(txtemp.Text);
                                    nusu.RegistrarUsu(usu);
                                    ListarUsuario();
                                    MessageBox.Show("Usuario registrado con éxito.", "Usuario registrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                txtemp.Focus();
                            }
                        }  
                    }      
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcontraval.Focus();
                }  
            }
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtemp.Text) || string.IsNullOrEmpty(txtnombre.Text)
               || string.IsNullOrEmpty(txtcontra.Text) || cmbpriv.SelectedIndex == 0)
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemp.Focus();
            }
            else
            {
                if (txtcontra.Text == txtcontraval.Text)
                {
                    DialogResult result = MessageBox.Show("¿Está seguro que desea modificar el usuario?",
                    "Nueva modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            usu.idempleado_u = Convert.ToInt32(txtcod.Text);
                            usu.nombreusu_u = txtnombre.Text;
                            usu.contraseña_u = txtcontra.Text;
                            usu.privilegios_u = Convert.ToInt32(cmbpriv.SelectedItem);
                            usu.idempleado_u = Convert.ToInt32(txtcod.Text);
                            nusu.ActualizarUsu(usu);
                            ListarUsuario();
                            MessageBox.Show("Usuario actualizado con éxito.", "Usuario modificado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcontraval.Focus();
                }
            }
        }

        private void dgvusuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcod.Text = dgvusuario.CurrentRow.Cells[0].Value.ToString();
                usu.idusuario_u = Convert.ToInt32(txtcod.Text);
                DataTable dt = new DataTable();
                dt = nusu.ConsultarUsu(usu);

                txtnombre.Text = dt.Rows[0][1].ToString();
                txtcontra.Text = dt.Rows[0][2].ToString();
                txtcontraval.Text = dt.Rows[0][2].ToString();
                cmbpriv.SelectedItem = dt.Rows[0][3].ToString();
                txtemp.Text = dt.Rows[0][4].ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Error de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcod.Text))
            {
                MessageBox.Show("Seleccione un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemp.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el usuario seleccionado? \nEl empleado asignado a este usuario se quedará sin acceso al sistema.",
                "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        usu.idusuario_u = Convert.ToInt32(txtcod.Text);
                        nusu.Eliminarusuid(usu);
                        ListarUsuario();
                        MessageBox.Show("Usuario eliminado con éxito. \nRecuerde que el empleado asignado a este usuario ya no cuenta con acceso al sistema", 
                            "Usuario eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
