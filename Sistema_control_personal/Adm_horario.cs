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
    public partial class Adm_horario : Form
    {
        Horario hor = new Horario();
        Nhorario nhor = new Nhorario();

        Turno tur = new Turno();
        Nturno ntur = new Nturno();

        public Adm_horario()
        {
            InitializeComponent();
            txtcodigo.ReadOnly = true;
        }

        private void Registro_horario_Load(object sender, EventArgs e)
        {
            ListarHorario();
        }

        private void ListarHorario()
        {
            dgvhorario.DataSource = nhor.ListarHor();
            ListarTurno();
        }

        private void ListarTurno()
        {
            cmbturno.DataSource = ntur.ListarTur();
            cmbturno.DisplayMember = "Tipo";
            cmbturno.ValueMember = "ID_turno";
        }

        private void Limpiar()
        {
            txtinicio.Text = "";
            txtsalida.Text = "";
            txtinidesc.Text = "";
            txtfindesc.Text = "";
            cmbturno.SelectedIndex = 0;
            txtdescrip.Text = "";
            txtcodigo.Text = "";
            chklunes.Checked = false;
            chkmartes.Checked = false;
            chkmiercoles.Checked = false;
            chkjueves.Checked = false;
            chkviernes.Checked = false;
            chksabado.Checked = false;
            txtcodigo.Text = "";
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtinicio.Text) || string.IsNullOrEmpty(txtsalida.Text)
                || string.IsNullOrEmpty(txtinidesc.Text) || string.IsNullOrEmpty(txtfindesc.Text)
                || string.IsNullOrEmpty(txtdescrip.Text))
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtinicio.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea registrar un nuevo horario?",
                    "Nuevo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        hor.inicio_h = txtinicio.Text;
                        hor.fin_h = txtsalida.Text;
                        hor.iniciodescan_h = txtinidesc.Text;
                        hor.findescan_h = txtfindesc.Text;
                        hor.descripcion_h = txtdescrip.Text;
                        hor.idturno_h = Convert.ToInt32(cmbturno.SelectedValue);
                        nhor.RegistrarHor(hor);

                        HorarioDetalle HorDet = new HorarioDetalle();
                        Nhorariodetalle Nhordeta = new Nhorariodetalle();
                        Nhorario nHorDet = new Nhorario();
                        DataTable dtablemax = new DataTable();
                        dtablemax = nHorDet.BuscaridHor();

                        hor.idhorario_h = Convert.ToInt32(dtablemax.Rows[0][0]);

                        HorarioDetalle hord = new HorarioDetalle();
                        Nhorariodetalle Nhord = new Nhorariodetalle();
                        if (chklunes.Checked == true)
                        {
                            HorDet.idhorario_dh = Convert.ToInt32(dtablemax.Rows[0][0]);
                            HorDet.iddiaslab_dh = 7000;
                            Nhordeta.RegistrarHordet(HorDet);
                        }
                        if (chkmartes.Checked == true)
                        {
                            HorDet.idhorario_dh = Convert.ToInt32(dtablemax.Rows[0][0]);
                            HorDet.iddiaslab_dh = 7001;
                            Nhordeta.RegistrarHordet(HorDet);
                        }
                        if (chkmiercoles.Checked == true)
                        {
                            HorDet.idhorario_dh = Convert.ToInt32(dtablemax.Rows[0][0]);
                            HorDet.iddiaslab_dh = 7002;
                            Nhordeta.RegistrarHordet(HorDet);
                        }
                        if (chkjueves.Checked == true)
                        {
                            HorDet.idhorario_dh = Convert.ToInt32(dtablemax.Rows[0][0]);
                            HorDet.iddiaslab_dh = 7003;
                            Nhordeta.RegistrarHordet(HorDet);
                        }
                        if (chkviernes.Checked == true)
                        {
                            HorDet.idhorario_dh = Convert.ToInt32(dtablemax.Rows[0][0]);
                            HorDet.iddiaslab_dh = 7004;
                            Nhordeta.RegistrarHordet(HorDet);
                        }
                        if (chksabado.Checked == true)
                        {
                            HorDet.idhorario_dh = Convert.ToInt32(dtablemax.Rows[0][0]);
                            HorDet.iddiaslab_dh = 7005;
                            Nhordeta.RegistrarHordet(HorDet);
                        }

                        MessageBox.Show("Horario registrado con éxito.", "Horario registrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarHorario();
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
                    txtinicio.Focus();
                }
            }
        }

        private void dgvhorario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dgvhorario.CurrentRow.Cells[0].Value.ToString();
                Horario hor1 = new Horario();
                Nhorario nhor2 = new Nhorario();
                hor1.idhorario_h = Convert.ToInt32(txtcodigo.Text);
                DataTable dtable2 = new DataTable();
                dtable2 = nhor2.BuscarHor(hor1);

                txtinicio.Text = dtable2.Rows[0][1].ToString();
                txtsalida.Text = dtable2.Rows[0][2].ToString();
                txtinidesc.Text = dtable2.Rows[0][3].ToString();
                txtfindesc.Text = dtable2.Rows[0][4].ToString();
                txtdescrip.Text = dtable2.Rows[0][5].ToString();
                cmbturno.SelectedValue = Convert.ToInt32(dtable2.Rows[0][6]);

                HorarioDetalle hd = new HorarioDetalle();
                Nhorariodetalle nhd = new Nhorariodetalle();
                hd.idhorario_dh = Convert.ToInt32(txtcodigo.Text);
                DataTable dtable3 = new DataTable();
                dtable3 = nhd.BuscarDet(hd);
                for (int i = 0; i < dtable3.Rows.Count; i++)
                {
                    if (dtable3.Rows.Count == 1)
                    {
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7000)
                        {
                            chklunes.Checked = true;
                            chkmartes.Checked = false;
                            chkmiercoles.Checked = false;
                            chkjueves.Checked = false;
                            chkviernes.Checked = false;
                            chksabado.Checked = false;
                        }
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7001)
                        {
                            chkmartes.Checked = true;
                            chklunes.Checked = false;
                            chkmiercoles.Checked = false;
                            chkjueves.Checked = false;
                            chkviernes.Checked = false;
                            chksabado.Checked = false;
                        }
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7002)
                        {
                            chkmiercoles.Checked = true;
                            chklunes.Checked = false;
                            chkmartes.Checked = false;
                            chkjueves.Checked = false;
                            chkviernes.Checked = false;
                            chksabado.Checked = false;
                        }
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7003)
                        {
                            chkjueves.Checked = true;
                            chklunes.Checked = false;
                            chkmartes.Checked = false;
                            chkmiercoles.Checked = false;
                            chkviernes.Checked = false;
                            chksabado.Checked = false;
                        }
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7004)
                        {
                            chkviernes.Checked = true;
                            chklunes.Checked = false;
                            chkmartes.Checked = false;
                            chkmiercoles.Checked = false;
                            chkjueves.Checked = false;
                            chksabado.Checked = false;
                        }
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7005)
                        {
                            chksabado.Checked = true;
                            chklunes.Checked = false;
                            chkmartes.Checked = false;
                            chkmiercoles.Checked = false;
                            chkjueves.Checked = false;
                            chkviernes.Checked = false;
                        }
                    }
                    else 
                    {
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7000)
                        {
                            chklunes.Checked = true;
                            chkmartes.Checked = false;
                            chkmiercoles.Checked = false;
                            chkjueves.Checked = false;
                            chkviernes.Checked = false;
                            chksabado.Checked = false;
                        }
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7001)
                        {
                            chkmartes.Checked = true;
                            chkmiercoles.Checked = false;
                            chkjueves.Checked = false;
                            chkviernes.Checked = false;
                            chksabado.Checked = false;
                        }
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7002)
                        {
                            chkmiercoles.Checked = true;
                            chkjueves.Checked = false;
                            chkviernes.Checked = false;
                            chksabado.Checked = false;
                        }
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7003)
                        {
                            chkjueves.Checked = true;
                            chkviernes.Checked = false;
                            chksabado.Checked = false;
                        }
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7004)
                        {
                            chkviernes.Checked = true;
                            chksabado.Checked = false;
                        }
                        if (Convert.ToInt32(dtable3.Rows[i][0]) == 7005)
                        {
                            chksabado.Checked = true;
                        }
                    } 
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Error de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtinicio.Text) || string.IsNullOrEmpty(txtsalida.Text)
                || string.IsNullOrEmpty(txtinidesc.Text) || string.IsNullOrEmpty(txtfindesc.Text)
                || string.IsNullOrEmpty(txtdescrip.Text))
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtinicio.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea modificar el horario?",
                    "Modificación nueva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        hor.idhorario_h = Convert.ToInt32(txtcodigo.Text);
                        hor.inicio_h = txtinicio.Text;
                        hor.fin_h = txtsalida.Text;
                        hor.iniciodescan_h = txtinidesc.Text;
                        hor.findescan_h = txtfindesc.Text;
                        hor.descripcion_h = txtdescrip.Text;
                        hor.idturno_h = Convert.ToInt32(cmbturno.SelectedValue);
                        nhor.ActualizarHor(hor);

                        HorarioDetalle Hode = new HorarioDetalle();
                        Nhorariodetalle Nhode = new Nhorariodetalle();
                        Hode.idhorario_dh = Convert.ToInt32(txtcodigo.Text);
                        Nhode.ActualizarHordet(Hode);
                        int codigo = Convert.ToInt32(txtcodigo.Text);
                        if (chklunes.Checked == true)
                        {
                            Hode.idhorario_dh = codigo;
                            Hode.iddiaslab_dh = 7000;
                            Nhode.RegistrarHordet(Hode);
                        }
                        if (chkmartes.Checked == true)
                        {
                            Hode.idhorario_dh = codigo;
                            Hode.iddiaslab_dh = 7001;
                            Nhode.RegistrarHordet(Hode);
                        }
                        if (chkmiercoles.Checked == true)
                        {
                            Hode.idhorario_dh = codigo;
                            Hode.iddiaslab_dh = 7002;
                            Nhode.RegistrarHordet(Hode);
                        }
                        if (chkjueves.Checked == true)
                        {
                            Hode.idhorario_dh = codigo;
                            Hode.iddiaslab_dh = 7003;
                            Nhode.RegistrarHordet(Hode);
                        }
                        if (chkviernes.Checked == true)
                        {
                            Hode.idhorario_dh = codigo;
                            Hode.iddiaslab_dh = 7004;
                            Nhode.RegistrarHordet(Hode);
                        }
                        if (chksabado.Checked == true)
                        {
                            Hode.idhorario_dh = codigo;
                            Hode.iddiaslab_dh = 7005;
                            Nhode.RegistrarHordet(Hode);
                        }
                        MessageBox.Show("Horario actualizado con éxito.", "Horario actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarHorario();
                        Limpiar();
                        txtinicio.Focus();
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        MessageBox.Show("Error de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    txtinicio.Focus();
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
