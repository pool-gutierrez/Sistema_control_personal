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
    public class DAOhorario
    {
        SqlCommand cmdHorario = new SqlCommand();
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection cone = new SqlConnection();
        public Conexion Conec = new Conexion();

        public DataTable ListarHorario()
        {
            try
            {
                cmdHorario.Connection = new SqlConnection(Conexion.cn);
                cmdHorario.CommandText = "sp_listar_hor";
                cmdHorario.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdHorario);
                dt = new DataTable("horario");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public void RegistrarHorario(Horario objhorario)
        {
            cmdHorario.Connection = Conec.AbrirConexion();
            cmdHorario.CommandText = "sp_registrar_horario";
            cmdHorario.CommandType = CommandType.StoredProcedure;
            cmdHorario.Parameters.AddWithValue("@Hora_inicio", objhorario.inicio_h);
            cmdHorario.Parameters.AddWithValue("@Hora_salida", objhorario.fin_h);
            cmdHorario.Parameters.AddWithValue("@Inicio_descan", objhorario.iniciodescan_h);
            cmdHorario.Parameters.AddWithValue("@Fin_descan", objhorario.findescan_h);
            cmdHorario.Parameters.AddWithValue("@Descripcion", objhorario.descripcion_h);
            cmdHorario.Parameters.AddWithValue("@ID_turno", objhorario.idturno_h);
            cmdHorario.ExecuteNonQuery();
            cmdHorario.Parameters.Clear();
        }

        public DataTable BuscaridHorario()
        {
            try
            {
                cmdHorario.Connection = new SqlConnection(Conexion.cn);
                cmdHorario.CommandText = "sp_buscar_idhor";
                cmdHorario.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdHorario);
                dt = new DataTable("horario");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public void ActualizarHorario(Horario objhorarioM)
        {
            cmdHorario.Connection = Conec.AbrirConexion();
            cmdHorario.CommandText = "sp_actualizar_horario";
            cmdHorario.CommandType = CommandType.StoredProcedure;
            cmdHorario.Parameters.AddWithValue("@id_horario", objhorarioM.idhorario_h);
            cmdHorario.Parameters.AddWithValue("@Hora_inicio", objhorarioM.inicio_h);
            cmdHorario.Parameters.AddWithValue("@Hora_salida", objhorarioM.fin_h);
            cmdHorario.Parameters.AddWithValue("@Inicio_descan", objhorarioM.iniciodescan_h);
            cmdHorario.Parameters.AddWithValue("@Fin_descan", objhorarioM.findescan_h);
            cmdHorario.Parameters.AddWithValue("@Descripcion", objhorarioM.descripcion_h);
            cmdHorario.Parameters.AddWithValue("@ID_turno", objhorarioM.idturno_h);
            cmdHorario.ExecuteNonQuery();
            cmdHorario.Parameters.Clear();
        }

        public DataTable BuscarHorario(Horario objhoraB)
        {
            using (SqlCommand cmd = new SqlCommand("sp_buscar_horario", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_horario", objhoraB.idhorario_h);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }
    }
}
