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
    public partial class Adm_turno : Form
    {
        Turno tr = new Turno();
        Nturno ntr = new Nturno();
        public Adm_turno()
        {
            InitializeComponent();
            txtcodigo.ReadOnly = true;
        }

        private void ListarTurno()
        {
            dgvturno.DataSource = ntr.ListarTur();
        }

        private void Limpiar()
        {
            txtcodigo.Text = "";
            txtinicio.Text = "";
            txtsalida.Text = "";
            txttipo.Text = "";
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtinicio.Text) || string.IsNullOrEmpty(txtsalida.Text)
               || string.IsNullOrEmpty(txttipo.Text))
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtinicio.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea registrar un nuevo turno?",
                    "Nuevo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        tr.tipo_t = txttipo.Text;
                        tr.horaentrada_t = txtinicio.Text;
                        tr.horasalida_t = txtsalida.Text;
                        ntr.RegistrarTur(tr);

                        MessageBox.Show("Turno registrado con éxito.", "Turno registrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarTurno();
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
                    txttipo.Focus();
                }
            }
        }

        private void Adm_turno_Load(object sender, EventArgs e)
        {
            ListarTurno();
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtinicio.Text) || string.IsNullOrEmpty(txtsalida.Text)
               || string.IsNullOrEmpty(txttipo.Text))
            {
                MessageBox.Show("Ingrese o seleccione bien los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtinicio.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea modificar el turno?",
                    "Nuevo modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        tr.idturno_t = Convert.ToInt32(txtcodigo.Text);
                        tr.tipo_t = txttipo.Text;
                        tr.horaentrada_t = txtinicio.Text;
                        tr.horasalida_t = txtsalida.Text;
                        ntr.ActualizarTurn(tr);

                        MessageBox.Show("Turno actualizado con éxito.", "Turno actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarTurno();
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
                    txttipo.Focus();
                }
            }
        }

        private void dgvturno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dgvturno.CurrentRow.Cells[0].Value.ToString();
                tr.idturno_t = Convert.ToInt32(txtcodigo.Text);
                DataTable dt = new DataTable();
                dt = ntr.ConsultarTur(tr);

                txttipo.Text = dt.Rows[0][1].ToString();
                txtinicio.Text = dt.Rows[0][2].ToString();
                txtsalida.Text = dt.Rows[0][3].ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Error de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
