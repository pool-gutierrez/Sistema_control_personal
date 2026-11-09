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
using Entidades;
using Negocio;

namespace Sistema_control_personal
{
    public partial class Registro_asistencia : Form
    {
        Asistencia asis = new Asistencia();
        Nasistencia nasis = new Nasistencia();

        Usuario usu = new Usuario();
        Nusuario nusu = new Nusuario();

        public Registro_asistencia()
        {
            InitializeComponent();
            txtemp.ReadOnly = true;
            txthor.ReadOnly = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void timerasistencia_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblfechareal.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lbldia.Text = DateTime.Now.ToString("dddd");
            reloj.MaxValue = 60;
            if (reloj.Value <= 60){
                reloj.Value = Convert.ToInt32(DateTime.Now.ToString("ss"));
            }else{
                reloj.Value = 0;
            }
            lblseg.Text = DateTime.Now.ToString("ss");
            lbllhoramin.Text = DateTime.Now.ToString("HH:mm");
            lblfec.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panelbarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtcod_Enter(object sender, EventArgs e)
        {
            if (txtcod.Text == "Ingrese su código")
            {
                txtcod.Text = "";
                txtcod.ForeColor = Color.DarkCyan;
            }
        }

        private void txtcod_Leave(object sender, EventArgs e)
        {
            if (txtcod.Text == "")
            {
                txtcod.Text = "Ingrese su código";
                txtcod.ForeColor = Color.DarkGray;
            }
        }

        private void txtcontra_Enter(object sender, EventArgs e)
        {
            if (txtcontra.Text == "Ingrese su contraseña")
            {
                txtcontra.Text = "";
                txtcontra.ForeColor = Color.DarkCyan;
                txtcontra.UseSystemPasswordChar = true;
            }
        }

        private void txtcontra_Leave(object sender, EventArgs e)
        {
            if (txtcontra.Text == "")
            {
                txtcontra.Text = "Ingrese su contraseña";
                txtcontra.ForeColor = Color.DarkGray;
                txtcontra.UseSystemPasswordChar = false;
            }
        }

        private void btncon_Click(object sender, EventArgs e)
        {
            Consulta_cod con = new Consulta_cod();
            con.Show();
        }

        private void btnsesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Limpiar()
        {
            txtcod.Text = "Ingrese su código";
            txtcod.ForeColor = Color.DarkGray;
            txtcontra.Text = "Ingrese su contraseña";
            txtcontra.ForeColor = Color.DarkGray;
            txtcontra.UseSystemPasswordChar = false;
            txtemp.Text = "";
            txthor.Text = "";
        }

        private void error()
        {
            MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtcod.Text = "Ingrese su código";
            txtcod.ForeColor = Color.DarkGray;
            txtcontra.Text = "Ingrese su contraseña";
            txtcontra.ForeColor = Color.DarkGray;
            txtcontra.UseSystemPasswordChar = false;
            txtemp.Text = "";
            txthor.Text = "";
        }

        private void btnentrada_Click(object sender, EventArgs e)
        {
            if (txtcod.Text == "Ingrese su código" || txtcontra.Text == "Ingrese su contraseña")
            {
                MessageBox.Show("Ingrese bien sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcod.Focus();
            }
            else
            {
                //validar que el usuario exista
                int codigo = Convert.ToInt32(txtcod.Text);
                String contra = txtcontra.Text;
                DataTable dt = new DataTable();
                usu.idempleado_u = codigo;
                usu.contraseña_u = contra;
                dt = nusu.ValidarAsis(usu);
                if (dt.Rows.Count > 0)
                {
                    //limitar un registro al dia
                    Asistencia asis = new Asistencia();
                    Nasistencia nasis = new Nasistencia();
                    asis.fecha_a = lblfechareal.Text;
                    asis.idempleado_a = Convert.ToInt32(txtcod.Text);
                    DataTable dta = new DataTable();
                    dta = nasis.ValidarEnt(asis);
                    if (dta.Rows.Count > 0)
                    {
                        MessageBox.Show("Usted ya no puede registrar su hora de entrada otra vez.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();
                    }
                    else 
                    {
                        //validar si el empleado trabaja hoy
                        Empleado emp = new Empleado();
                        Nempleado nemp = new Nempleado();
                        emp.id_empleado = Convert.ToInt32(txtcod.Text);
                        String dia = lbldia.Text;
                        DataTable dtable = new DataTable();
                        dtable = nemp.BuscarDia(emp, dia);
                        if (dtable.Rows.Count > 0)
                        {
                            //Validar si llegó tarde o temprano
                            Asistencia asist = new Asistencia();
                            Nasistencia nasist = new Nasistencia();
                            int codemp = Convert.ToInt32(txtcod.Text);
                            DataTable datat = new DataTable();
                            datat = nasist.ValidarHor(codemp);
                            DateTime horaentrada = Convert.ToDateTime(datat.Rows[0][0].ToString());
                            DateTime horaregistro = Convert.ToDateTime(lblhora.Text);
                            if (horaregistro > horaentrada)
                            {
                                try
                                {
                                    asis.hentrada_a = lblhora.Text;
                                    asis.hsalida_a = "00:00:00";
                                    asis.fecha_a = lblfechareal.Text;
                                    asis.descripcion_a = "Tardanza";
                                    asis.idempleado_a = Convert.ToInt32(txtcod.Text);
                                    nasis.RegistrarEnt(asis);
                                    MessageBox.Show("Hora de entrada registrada con éxito.", "Asistencia registrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                }
                                catch (Exception ex)
                                {
                                    Console.Write(ex);
                                    MessageBox.Show("Datos incompatibles: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                try
                                {
                                    asis.hentrada_a = lblhora.Text;
                                    asis.hsalida_a = "00:00:00";
                                    asis.fecha_a = lblfechareal.Text;
                                    asis.descripcion_a = "Asistió";
                                    asis.idempleado_a = Convert.ToInt32(txtcod.Text);
                                    nasis.RegistrarEnt(asis);
                                    MessageBox.Show("Hora de entrada registrada con éxito.", "Asistencia registrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                }
                                catch (Exception ex)
                                {
                                    Console.Write(ex);
                                    MessageBox.Show("Datos incompatibles: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }    
                        }
                        else
                        {
                            MessageBox.Show("Usted no debería marcar asistencia hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpiar();
                        }
                    }
                }
                else
                {
                    error();
                }          
            }
        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            if (txtcod.Text == "Ingrese su código" || txtcontra.Text == "Ingrese su contraseña")
            {
                MessageBox.Show("Ingrese bien sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcod.Focus();
            }
            else
            {
                //Validar usuario
                int codigo = Convert.ToInt32(txtcod.Text);
                String contra = txtcontra.Text;
                DataTable dt = new DataTable();
                usu.idempleado_u = codigo;
                usu.contraseña_u = contra;
                dt = nusu.ValidarAsis(usu);
                if (dt.Rows.Count > 0)
                {
                    //Validar si el empleado puede registrar su salida
                    Asistencia asis1 = new Asistencia();
                    Nasistencia nasis1 = new Nasistencia();
                    asis1.hsalida_a = "00:00:00:00";
                    asis1.fecha_a = lblfechareal.Text;
                    asis1.idempleado_a = Convert.ToInt32(txtcod.Text);
                    DataTable dta = new DataTable();
                    dta = nasis1.ValidarSal(asis1);
                    if (dta.Rows.Count > 0)
                    {
                        try
                        {
                            asis.hsalida_a = lblhora.Text;
                            asis.fecha_a = lblfechareal.Text;
                            asis.idempleado_a = Convert.ToInt32(txtcod.Text);
                            nasis.RegistrarSal(asis);
                            MessageBox.Show("Hora de Salida registrada con éxito.", "Asistencia registrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex);
                            MessageBox.Show("Datos incompatibles: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usted ya ha registrado su hora de salida o por lo contrario, aún no lo ha hecho.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();
                    }            
                }
                else
                {
                    error();
                }
            }
        }

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
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
                    MessageBox.Show("Su código está compuesto solo de números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }     
        }

        private void txtcod_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtcod.Text != "") 
            {
                Empleado emp = new Empleado();
                Nempleado nemp = new Nempleado();
                String cod = txtcod.Text;
                DataTable dt = new DataTable();
                emp.id_empleado = Convert.ToInt32(cod);
                dt = nemp.FiltrarEmp(emp);
                if (dt.Rows.Count > 0)
                {
                    //emp.id_empleado = Convert.ToInt32(dt.Rows[0][0]);
                    txtemp.Text = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                    txthor.Text = dt.Rows[0][3].ToString();
                }
                else
                {
                    txtemp.Text = "";
                    txthor.Text = "";
                }
            }
            else 
            {
                txtemp.Text = "";
                txthor.Text = "";
            }
        }
    }
}
