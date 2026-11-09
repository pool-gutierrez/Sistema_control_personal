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
    public class DAOasistencia
    {
        SqlCommand cmdAsistencia = new SqlCommand();
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection cone = new SqlConnection();
        public Conexion Conec = new Conexion();

        public DataTable ListarAsistencia()
        {
            try
            {
                cmdAsistencia.Connection = new SqlConnection(Conexion.cn);
                cmdAsistencia.CommandText = "sp_listar_asis";
                cmdAsistencia.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdAsistencia);
                dt = new DataTable("asistencia");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public void RegistrarEntrada(Asistencia objasis)
        {
            cmdAsistencia.Connection = Conec.AbrirConexion();
            cmdAsistencia.CommandText = "sp_registrar_entrada";
            cmdAsistencia.CommandType = CommandType.StoredProcedure;
            cmdAsistencia.Parameters.AddWithValue("@Hora_entrada", objasis.hentrada_a);
            cmdAsistencia.Parameters.AddWithValue("@Hora_salida", objasis.hsalida_a);
            cmdAsistencia.Parameters.AddWithValue("@Fecha", objasis.fecha_a);
            cmdAsistencia.Parameters.AddWithValue("@Descripcion", objasis.descripcion_a);
            cmdAsistencia.Parameters.AddWithValue("@ID_empleado", objasis.idempleado_a);
            cmdAsistencia.ExecuteNonQuery();
            cmdAsistencia.Parameters.Clear();
        }

        public void RegistrarSalida(Asistencia objasis)
        {
            cmdAsistencia.Connection = Conec.AbrirConexion();
            cmdAsistencia.CommandText = "sp_registrar_salida";
            cmdAsistencia.CommandType = CommandType.StoredProcedure;
            cmdAsistencia.Parameters.AddWithValue("@Hora_salida", objasis.hsalida_a);
            cmdAsistencia.Parameters.AddWithValue("@Fecha", objasis.fecha_a);
            cmdAsistencia.Parameters.AddWithValue("@ID_empleado", objasis.idempleado_a);
            cmdAsistencia.ExecuteNonQuery();
            cmdAsistencia.Parameters.Clear();
            cmdAsistencia.Connection = Conec.CerrarConexion();
        }

        public DataTable ValidarEntrada(Asistencia a)
        {
            using (SqlCommand cmd = new SqlCommand("sp_validar_entrada", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", a.fecha_a);
                cmd.Parameters.AddWithValue("@ID_empleado", a.idempleado_a);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable ValidarSalida(Asistencia a)
        {
            using (SqlCommand cmd = new SqlCommand("sp_validar_salida", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Hora_salida", a.hsalida_a);
                cmd.Parameters.AddWithValue("@Fecha", a.fecha_a);
                cmd.Parameters.AddWithValue("@ID_empleado", a.idempleado_a);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable ValidarHorario(int idemp)
        {
            using (SqlCommand cmd = new SqlCommand("sp_validar_horario", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_empleado", idemp);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable AsistenciaEmpleado(Asistencia a)
        {
            try
            {
                cmdAsistencia.Connection = new SqlConnection(Conexion.cn);
                cmdAsistencia.CommandText = "sp_consultar_rep";
                cmdAsistencia.Parameters.AddWithValue("@id_emp", a.idempleado_a);
                cmdAsistencia.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdAsistencia);
                dt = new DataTable("asit");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public DataTable FiltrarAsistencia(String idemp, String idcar, String desc)
        {
            using (SqlCommand cmd = new SqlCommand("sp_filtrar_asis", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idemp", idemp);
                cmd.Parameters.AddWithValue("@idcargo", idcar);
                cmd.Parameters.AddWithValue("@descripcion", desc);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable FiltrarAsistenciaFecha(String f1, String f2)
        {
            using (SqlCommand cmd = new SqlCommand("sp_filtrar_asisfecha", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha1", f1);
                cmd.Parameters.AddWithValue("@fecha2", f2);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable FiltrarAsistenciaEmpFecha(int id, String f1, String f2)
        {
            using (SqlCommand cmd = new SqlCommand("sp_filtrar_empasisfecha", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idemp", id);
                cmd.Parameters.AddWithValue("@fecha1", f1);
                cmd.Parameters.AddWithValue("@fecha2", f2);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public void BorrarAsistencias(String f1, String f2)
        {
            cmdAsistencia.Connection = Conec.AbrirConexion();
            cmdAsistencia.CommandText = "sp_borrar_reportesxfecha";
            cmdAsistencia.CommandType = CommandType.StoredProcedure;
            cmdAsistencia.Parameters.AddWithValue("@fecha1", f1);
            cmdAsistencia.Parameters.AddWithValue("@fecha2", f2);
            cmdAsistencia.ExecuteNonQuery();
            cmdAsistencia.Parameters.Clear();
            cmdAsistencia.Connection = Conec.CerrarConexion();
        }
    }
}
