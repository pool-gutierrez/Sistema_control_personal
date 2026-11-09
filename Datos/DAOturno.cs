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
    public class DAOturno
    {
        SqlCommand cmdTurno = new SqlCommand();
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection cone = new SqlConnection();
        public Conexion Conec = new Conexion();
        public DataTable ListarTurno()
        {
            try
            {
                cmdTurno.Connection = new SqlConnection(Conexion.cn);
                cmdTurno.CommandText = "sp_listar_tur";
                cmdTurno.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdTurno);
                dt = new DataTable("turno");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public void RegistrarTurno(Turno t)
        {
            cmdTurno.Connection = Conec.AbrirConexion();
            cmdTurno.CommandText = "sp_registrar_turno";
            cmdTurno.CommandType = CommandType.StoredProcedure;
            cmdTurno.Parameters.AddWithValue("@tipo", t.tipo_t);
            cmdTurno.Parameters.AddWithValue("@entrada", t.horaentrada_t);
            cmdTurno.Parameters.AddWithValue("@salida", t.horasalida_t);
            cmdTurno.ExecuteNonQuery();
            cmdTurno.Parameters.Clear();
        }

        public void ActualizarTurno(Turno t)
        {
            cmdTurno.Connection = Conec.AbrirConexion();
            cmdTurno.CommandText = "sp_actualizar_turno";
            cmdTurno.CommandType = CommandType.StoredProcedure;
            cmdTurno.Parameters.AddWithValue("@id_turno", t.idturno_t);
            cmdTurno.Parameters.AddWithValue("@tipo", t.tipo_t);
            cmdTurno.Parameters.AddWithValue("@entrada", t.horaentrada_t);
            cmdTurno.Parameters.AddWithValue("@salida", t.horasalida_t);
            cmdTurno.ExecuteNonQuery();
            cmdTurno.Parameters.Clear();
        }

        public DataTable ConsultarTurno(Turno t)
        {
            using (SqlCommand cmd = new SqlCommand("sp_buscar_turno", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_turno", t.idturno_t);
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
