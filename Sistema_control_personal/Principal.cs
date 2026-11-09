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

namespace Sistema_control_personal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            bunimenu.AutoScroll = false;
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

        private void Abrirhijo(object formhijo)
        {
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelprincipal.Controls.Add(fh);
            this.panelprincipal.Tag = fh;
            fh.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del sistema?",
                    "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Registro_asistencia ra = new Registro_asistencia();
                this.Hide();
                ra.Show();
            }
            else if (result == DialogResult.No)
            {
            } 
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

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if(bunimenu.Width == 272) {
                //bunimenu.Visible = false;
                bunimenu.Width = 99;
                panelmenu.Width = 119;
                separador.Width = 60;
                btnmant.Width = 60;
                btnusuarios.Width = 60;
                btnempleados.Width = 60;
                btnconsultas.Width = 60;
                btninfo.Width = 60;
                btncerrarsesion.Width = 60;
                panel_usuario.Width = 60;
            }
            else
            {
                //bunimenu.Visible = false;
                bunimenu.Width = 272;
                panelmenu.Width = 292;
                separador.Width = 232;
                btnmant.Width = 232;
                btnusuarios.Width = 232;
                btnempleados.Width = 232;
                btnconsultas.Width = 232;
                btninfo.Width = 232;
                btncerrarsesion.Width = 232;
                panel_usuario.Width = 232;
            }
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                    "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            else if (result == DialogResult.No)
            {

            }    
        }

        private void btnmant_Click(object sender, EventArgs e)
        {
            if(panelmant.Visible==true)
            {
                panelmant.Visible = false;
            }
            else
            {
                panelmant.Visible = true;
            }

            btnmant.Location = new Point(20, 131);
            panelmant.Location = new Point(66, 171);
            btnusuarios.Location = new Point(20, 377);
            btnempleados.Location = new Point(20, 423);
            btnconsultas.Location = new Point(20, 469);
            btninfo.Location = new Point(20, 515);

            panelusu.Hide();
            panelemp.Hide();
            panelconsultas.Hide();
            panelinfo.Hide();

            if (panelmant.Visible == false)
            {
                btnmant.Location=new Point(20, 131);
                btnusuarios.Location = new Point(20, 177);
                btnempleados.Location = new Point(20, 223);
                btnconsultas.Location = new Point(20, 269);
                btninfo.Location = new Point(20, 315);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            btnmant.Location = new Point(20, 131);
            btnusuarios.Location = new Point(20, 177);
            btnempleados.Location = new Point(20, 223);
            btnconsultas.Location = new Point(20, 269);
            btninfo.Location = new Point(20, 315);
            panel_usuario.Location = new Point(20, 673);
            panel_cerrar.Location = new Point(20, 744);
            panelmant.Hide();
            panelusu.Hide();
            panelemp.Hide();
            panelconsultas.Hide();
            panelinfo.Hide();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            if (panelusu.Visible == true)
            {
                panelusu.Visible = false;
            }
            else
            {
                panelusu.Visible = true;
            }

            btnmant.Location = new Point(20, 131);
            btnusuarios.Location = new Point(20, 177);
            panelusu.Location = new Point(66, 217);
            btnempleados.Location = new Point(20, 303);
            btnconsultas.Location = new Point(20, 349);
            btninfo.Location = new Point(20, 395);

            panelmant.Hide();
            panelemp.Hide();
            panelconsultas.Hide();
            panelinfo.Hide();

            if (panelusu.Visible == false)
            {
                btnmant.Location = new Point(20, 131);
                btnusuarios.Location = new Point(20, 177);
                btnempleados.Location = new Point(20, 223);
                btnconsultas.Location = new Point(20, 269);
                btninfo.Location = new Point(20, 315);
            }
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            if (panelemp.Visible == true)
            {
                panelemp.Visible = false;
            }
            else
            {
                panelemp.Visible = true;
            }

            btnmant.Location = new Point(20, 131);
            btnusuarios.Location = new Point(20, 177);
            btnempleados.Location = new Point(20, 223);
            panelemp.Location = new Point(66, 263);
            btnconsultas.Location = new Point(20, 349);
            btninfo.Location = new Point(20, 395);

            panelmant.Hide();
            panelusu.Hide();
            panelconsultas.Hide();
            panelinfo.Hide();

            if (panelemp.Visible == false)
            {
                btnmant.Location = new Point(20, 131);
                btnusuarios.Location = new Point(20, 177);
                btnempleados.Location = new Point(20, 223);
                btnconsultas.Location = new Point(20, 269);
                btninfo.Location = new Point(20, 315);
            }
        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            if (panelconsultas.Visible == true)
            {
                panelconsultas.Visible = false;
            }
            else
            {
                panelconsultas.Visible = true;
            }

            btnmant.Location = new Point(20, 131);
            btnusuarios.Location = new Point(20, 177);
            btnempleados.Location = new Point(20, 223);
            btnconsultas.Location = new Point(20, 269);
            panelconsultas.Location = new Point(66, 309);
            btninfo.Location = new Point(20, 395);

            panelmant.Hide();
            panelusu.Hide();
            panelemp.Hide();
            panelinfo.Hide();

            if (panelconsultas.Visible == false)
            {
                btnmant.Location = new Point(20, 131);
                btnusuarios.Location = new Point(20, 177);
                btnempleados.Location = new Point(20, 223);
                btnconsultas.Location = new Point(20, 269);
                btninfo.Location = new Point(20, 315);
            }
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            if (panelinfo.Visible == true)
            {
                panelinfo.Visible = false;
            }
            else
            {
                panelinfo.Visible = true;
            }

            btnmant.Location = new Point(20, 131);
            btnusuarios.Location = new Point(20, 177);
            btnempleados.Location = new Point(20, 223);
            btnconsultas.Location = new Point(20, 269);
            btninfo.Location = new Point(20, 315);
            panelinfo.Location = new Point(66, 355);

            panelmant.Hide();
            panelusu.Hide();
            panelemp.Hide();
            panelconsultas.Hide();

            if (panelinfo.Visible == false)
            {
                btnmant.Location = new Point(20, 131);
                btnusuarios.Location = new Point(20, 177);
                btnempleados.Location = new Point(20, 223);
                btnconsultas.Location = new Point(20, 269);
                btninfo.Location = new Point(20, 315);
            }
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Adm_empleado());  
        }

        private void btnhorario_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Adm_horario());  
        }

        private void btndepart_Click_1(object sender, EventArgs e)
        {
            Abrirhijo(new Adm_departamento());
        }

        private void btnadminusu_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Adm_usuarios());
        }

        private void hora_fecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Adm_cargo());
        }

        private void btncuenta_Click(object sender, EventArgs e)
        {
            Adm_cuentapersonal ct = new Adm_cuentapersonal();
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            Form fh = ct as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelprincipal.Controls.Add(fh);
            this.panelprincipal.Tag = fh;
            ct.id_emp = Convert.ToInt32(lblcodi.Text);
            fh.Show();
        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Emp_alta());
        }

        private void btnbaja_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Emp_baja());
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Reporte_asistencia());
        }

        private void btninforme_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Informe_general());
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Infosistema());
        }

        private void btnturno_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Adm_turno());
        }
    }
}
