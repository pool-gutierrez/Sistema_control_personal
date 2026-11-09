using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio;
using Entidades;

namespace Sistema_control_personal
{
    public partial class Login : Form
    {
        Usuario usu = new Usuario();
        Nusuario nusu = new Nusuario();
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelbarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Registro_asistencia asis = new Registro_asistencia();
            this.Hide();
            asis.Show();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtusu_Enter(object sender, EventArgs e)
        {
            if (txtusu.Text == "Ingrese su nombre de usuario")
            {
                txtusu.Text = "";
                txtusu.ForeColor = Color.DarkCyan;
            }
        }

        private void txtusu_Leave(object sender, EventArgs e)
        {
            if (txtusu.Text == "")
            {
                txtusu.Text = "Ingrese su nombre de usuario";
                txtusu.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Ingrese su contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.DarkCyan;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Ingrese su contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnsesion_Click(object sender, EventArgs e)
        {
            String usuario = txtusu.Text;
            String password = txtpass.Text;

            DataTable dt = new DataTable();
            usu.nombreusu_u = usuario;
            usu.contraseña_u = password;
            dt = nusu.Logsistema(usu);
            if (string.IsNullOrEmpty(txtusu.Text) || string.IsNullOrEmpty(txtpass.Text))
            {
                error();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bienvenido " + usuario, "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                    {
                        Principal men = new Principal();
                        this.Hide();
                        men.lblusu.Text = dt.Rows[0][0].ToString();
                        men.lblcodi.Text = dt.Rows[0][3].ToString();
                        men.Show();
                    }
                    if (Convert.ToInt32(dt.Rows[0][2]) == 2)
                    {
                        Principal men = new Principal();
                        this.Hide();
                        men.lblusu.Text = dt.Rows[0][0].ToString();
                        men.lblcodi.Text = dt.Rows[0][3].ToString();
                        men.btnadminusu.Enabled = false;
                        men.btnadminusu.Enabled = false;
                        men.btnemp.Enabled = false;
                        men.btncargo.Enabled = false;
                        men.btndepart.Enabled = false;
                        men.btndepart.Enabled = false;
                        men.btnempleados.Enabled = false;
                        men.Show();
                    }
                    if (Convert.ToInt32(dt.Rows[0][2]) == 3)
                    { 
                        Principal_emp prn = new Principal_emp();
                        this.Hide();
                        prn.lblusuario.Text = dt.Rows[0][0].ToString();
                        prn.lblcod.Text = dt.Rows[0][3].ToString();
                        prn.Show();
                    }
                }
                else
                {
                    error();
                }
            }
        }

        private void error()
        {
            MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtusu.Text = "Ingrese su nombre de usuario";
            txtusu.ForeColor = Color.Silver;
            txtpass.Text = "Ingrese su contraseña";
            txtpass.ForeColor = Color.Silver;
            txtpass.UseSystemPasswordChar = false;
        }
        private void panelbarra2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                String usuario = txtusu.Text;
                String password = txtpass.Text;

                DataTable dt = new DataTable();
                usu.nombreusu_u = usuario;
                usu.contraseña_u = password;
                dt = nusu.Logsistema(usu);
                if (string.IsNullOrEmpty(txtusu.Text) || string.IsNullOrEmpty(txtpass.Text))
                {
                    error();
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Bienvenido " + usuario, "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                        {
                            Principal men = new Principal();
                            this.Hide();
                            men.lblusu.Text = dt.Rows[0][0].ToString();
                            men.lblcodi.Text = dt.Rows[0][3].ToString();
                            men.Show();
                        }
                        if (Convert.ToInt32(dt.Rows[0][2]) == 2)
                        {
                            Principal men = new Principal();
                            this.Hide();
                            men.lblusu.Text = dt.Rows[0][0].ToString();
                            men.lblcodi.Text = dt.Rows[0][3].ToString();
                            men.btnadminusu.Enabled = false;
                            men.btnadminusu.Enabled = false;
                            men.btnemp.Enabled = false;
                            men.btncargo.Enabled = false;
                            men.btndepart.Enabled = false;
                            men.btndepart.Enabled = false;
                            men.btnempleados.Enabled = false;
                            men.Show();
                        }
                        if (Convert.ToInt32(dt.Rows[0][2]) == 3)
                        {
                            Principal_emp prn = new Principal_emp();
                            this.Hide();
                            prn.lblusuario.Text = dt.Rows[0][0].ToString();
                            prn.lblcod.Text = dt.Rows[0][3].ToString();
                            prn.Show();
                        }
                    }
                    else
                    {
                        error();
                    }
                }
            }
        }
    }
}
