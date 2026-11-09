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
    public partial class Adm_cuentapersonal : Form
    {
        public Adm_cuentapersonal()
        {
            InitializeComponent();
            txtapepat.ReadOnly = true;
            txtapemat.ReadOnly = true;
            txtnom.ReadOnly = true;
            txtdni.ReadOnly = true;
            txtemp.ReadOnly = true;
            txtnombre.ReadOnly = true;
            lblinfo.Text = "";
            txtpass.UseSystemPasswordChar = true;
            txtpassnew.UseSystemPasswordChar = true;
            txtpassv.UseSystemPasswordChar = true;
            txtcontra.UseSystemPasswordChar = true;
            txtcontrav.UseSystemPasswordChar = true;
        }

        public int id_emp { get; set; }

        private void Adm_cuentapersonal_Load(object sender, EventArgs e)
        {
            txtemp.Text = id_emp.ToString();
            CargarEmp();
            CargarNomUsu();
        }

        private void CargarEmp()
        {
            Empleado emp = new Empleado();
            Nempleado nemp = new Nempleado();
            emp.id_empleado = Convert.ToInt32(txtemp.Text);
            DataTable dt = new DataTable();
            dt = nemp.BuscarEmp(emp);
            txtapepat.Text = dt.Rows[0][1].ToString();
            txtapemat.Text = dt.Rows[0][2].ToString();
            txtnom.Text = dt.Rows[0][3].ToString();
            txtdni.Text = dt.Rows[0][4].ToString();
        }

        private void CargarNomUsu()
        {
            Usuario usu = new Usuario();
            usu.idempleado_u = Convert.ToInt32(txtemp.Text);
            Nusuario nusu = new Nusuario();
            DataTable dt = new DataTable();
            dt = nusu.ValidarUsu(usu);
            txtnombre.Text = dt.Rows[0][1].ToString();
        }

        private void Limpiar()
        {
            txtnomusu.Text = "";
            txtcontra.Text = "";
            txtcontrav.Text = "";
            txtpass.Text = "";
            txtpassnew.Text = "";
            txtpassv.Text = "";
        }

        private void txtnomusu_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtnomusu.Text != "")
            {
                Usuario usu = new Usuario();
                usu.nombreusu_u = txtnomusu.Text;
                Nusuario nusu = new Nusuario();
                DataTable dt = new DataTable();
                dt = nusu.ValidarnomUsu(usu);
                if (dt.Rows.Count > 0)
                {
                    lblinfo.ForeColor = Color.Red;
                    lblinfo.Text = "El nombre de usuario no está disponible.";
                }
                else
                {
                    lblinfo.ForeColor = Color.Green;
                    lblinfo.Text = "Nombre de usuario disponible.";
                }
            }
            else
            {
                lblinfo.Text = "";
            }
        }

        private void btnnombre_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            Nusuario nusu = new Nusuario();
            if (string.IsNullOrEmpty(txtnomusu.Text) || string.IsNullOrEmpty(txtcontra.Text)
               || string.IsNullOrEmpty(txtcontrav.Text))
            {
                MessageBox.Show("Ingrese bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnomusu.Focus();
            }
            else
            {
                if (lblinfo.Text == "El nombre de usuario no está disponible.")
                {
                    MessageBox.Show("El nombre de usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnomusu.Focus();
                }
                else 
                {
                    if (txtcontra.Text == txtcontrav.Text)
                    {
                        DataTable dt = new DataTable();
                        usu.idempleado_u = Convert.ToInt32(txtemp.Text);
                        usu.contraseña_u = txtcontra.Text;
                        dt = nusu.ValidarAsis(usu);
                        if (dt.Rows.Count > 0)
                        {
                            DialogResult result = MessageBox.Show("¿Está seguro que desea modificar el nombre de usuario?",
                                "Cambiar nombre de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    usu.idempleado_u = Convert.ToInt32(txtemp.Text);
                                    usu.contraseña_u = txtcontra.Text;
                                    usu.nombreusu_u = txtnomusu.Text;
                                    nusu.Actualizarnomusu(usu);
                                    CargarNomUsu();
                                    MessageBox.Show("Nombre de usuario actualizado con éxito. \nCierre sesión para confirmar los cambios.",
                                        "Usuario actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                txtnomusu.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcontra.Focus();
                    }
                } 
            }
        }

        private void btncontra_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            Nusuario nusu = new Nusuario();
            if (string.IsNullOrEmpty(txtpass.Text) || string.IsNullOrEmpty(txtpassnew.Text)
               || string.IsNullOrEmpty(txtpassv.Text))
            {
                MessageBox.Show("Ingrese bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnomusu.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                usu.idempleado_u = Convert.ToInt32(txtemp.Text);
                usu.contraseña_u = txtpass.Text;
                dt = nusu.ValidarAsis(usu);
                if (dt.Rows.Count > 0)
                {
                    if(txtpassnew.Text == txtpassv.Text)
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro que desea cambiar su contraseña?",
                        "Contraseña nueva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                usu.idempleado_u = Convert.ToInt32(txtemp.Text);
                                usu.contraseña_u = txtpass.Text;
                                String pass = txtpassnew.Text;
                                nusu.Actualizarcontra(usu, pass);
                                CargarNomUsu();
                                MessageBox.Show("Contraseña actualizada con éxito. \nCierre sesión para confirmar los cambios.",
                                    "Usuario actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            txtnomusu.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpassnew.Focus();
                    }   
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
