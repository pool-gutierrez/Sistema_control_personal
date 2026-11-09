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
    public partial class Consulta_cod : Form
    {
        public Consulta_cod()
        {
            InitializeComponent();
            txtcodcon.ReadOnly = true;
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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtdni_Enter(object sender, EventArgs e)
        {
            if (txtdni.Text == "Ingrese su DNI")
            {
                txtdni.Text = "";
                txtdni.ForeColor = Color.DarkCyan;
            }
        }

        private void txtdni_Leave(object sender, EventArgs e)
        {
            if (txtdni.Text == "")
            {
                txtdni.Text = "Ingrese su DNI";
                txtdni.ForeColor = Color.DimGray;
            }
        }

        private void txtcodcon_Enter(object sender, EventArgs e)
        {
            if (txtcodcon.Text == "Su código es...")
            {
                txtcodcon.Text = "";
                txtcodcon.ForeColor = Color.DarkCyan;
            }
        }

        private void txtcodcon_Leave(object sender, EventArgs e)
        {
            if (txtcodcon.Text == "")
            {
                txtcodcon.Text = "Su código es...";
                txtcodcon.ForeColor = Color.DimGray;
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            Nempleado nemp = new Nempleado();

            String dni = txtdni.Text;

            DataTable dt = new DataTable();
            emp.dni_emp = dni;
            dt = nemp.BuscarID(emp);

            if (string.IsNullOrEmpty(txtdni.Text))
            {
                MessageBox.Show("Ingrese su DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    //emp.id_empleado = Convert.ToInt32(dt.Rows[0][0]);
                    txtcodcon.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("Su dni es erróneo o no existe en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
        }
    }
}
