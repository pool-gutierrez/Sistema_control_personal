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
    public partial class Principal_emp : Form
    {
        public Principal_emp()
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
                bunimenu.Width = 99;
                panelmenu.Width = 119;
                separador.Width = 60;
                btnmant.Width = 60;
                btnusuarios.Width = 60;
                btninfo.Width = 60;
                btncerrarsesion.Width = 60;
                panel_usuario.Width = 60;
            }
            else
            {
                bunimenu.Width = 272;
                panelmenu.Width = 292;
                separador.Width = 232;
                btnmant.Width = 232;
                btnusuarios.Width = 232;
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
            btnusuarios.Location = new Point(20, 215);
            btninfo.Location = new Point(20, 261);

            panelusu.Hide();
            panelinfo.Hide();

            if (panelmant.Visible == false)
            {
                btnmant.Location=new Point(20, 131);
                btnusuarios.Location = new Point(20, 177);
                btninfo.Location = new Point(20, 223);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            btnmant.Location = new Point(20, 131);
            btnusuarios.Location = new Point(20, 177);
            btninfo.Location = new Point(20, 223);
            panelmant.Hide();
            panelusu.Hide();
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
            btninfo.Location = new Point(20, 263);

            panelmant.Hide();
            panelinfo.Hide();

            if (panelusu.Visible == false)
            {
                btnmant.Location = new Point(20, 131);
                btnusuarios.Location = new Point(20, 177);
                btninfo.Location = new Point(20, 223);
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
            btninfo.Location = new Point(20, 223);
            panelinfo.Location = new Point(66, 263);

            panelmant.Hide();
            panelusu.Hide();

            if (panelinfo.Visible == false)
            {
                btnmant.Location = new Point(20, 131);
                btnusuarios.Location = new Point(20, 177);
                btninfo.Location = new Point(20, 223);
            }
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            Reporte_asistencia_emp pr = new Reporte_asistencia_emp();
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            Form fh = pr as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelprincipal.Controls.Add(fh);
            this.panelprincipal.Tag = fh;
            pr.codigo = Convert.ToInt32(lblcod.Text);
            fh.Show();
        }

        private void btnadminusu_Click(object sender, EventArgs e)
        {
            Adm_cuentapersonal ct = new Adm_cuentapersonal();
            if (this.panelprincipal.Controls.Count > 0)
                this.panelprincipal.Controls.RemoveAt(0);
            Form fh = ct as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelprincipal.Controls.Add(fh);
            this.panelprincipal.Tag = fh;
            ct.id_emp = Convert.ToInt32(lblcod.Text);
            fh.Show();
        }

        private void hora_fecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Abrirhijo(new Infosistema());
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
