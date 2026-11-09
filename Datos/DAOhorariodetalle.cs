using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DAOhorariodetalle
    {
        SqlCommand cmdHorarioD = new SqlCommand();
        SqlConnection cone = new SqlConnection();
        public Conexion Conec = new Conexion();

        public void RegistrarHorariodetalle(HorarioDetalle objhorarioD)
        {
            cmdHorarioD.Connection = Conec.AbrirConexion();
            cmdHorarioD.CommandText = "sp_registrar_detalle";
            cmdHorarioD.CommandType = CommandType.StoredProcedure;
            cmdHorarioD.Parameters.AddWithValue("@id_dias_laborales", objhorarioD.iddiaslab_dh);
            cmdHorarioD.Parameters.AddWithValue("@id_horario", objhorarioD.idhorario_dh);
            cmdHorarioD.ExecuteNonQuery();
            cmdHorarioD.Parameters.Clear();
        }

        public DataTable BuscarDetalle(HorarioDetalle objdet)
        {
            using (SqlCommand cmd = new SqlCommand("sp_buscar_detalle", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_horario", objdet.idhorario_dh);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public void ActualizarHorariodetalle(HorarioDetalle objhord)
        {
            cmdHorarioD.Connection = Conec.AbrirConexion();
            cmdHorarioD.CommandText = "sp_actualizar_detalle";
            cmdHorarioD.CommandType = CommandType.StoredProcedure;
            cmdHorarioD.Parameters.AddWithValue("@id_horario", objhord.idhorario_dh);
            cmdHorarioD.ExecuteNonQuery();
            cmdHorarioD.Parameters.Clear();
        }
    }
}
