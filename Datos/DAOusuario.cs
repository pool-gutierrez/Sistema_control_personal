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
    public class DAOusuario
    {
        SqlCommand cmdUusario = new SqlCommand();
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection cone = new SqlConnection();
        public Conexion Conec = new Conexion();
        public DataTable ListarUsuario()
        {
            try
            {
                cmdUusario.Connection = new SqlConnection(Conexion.cn);
                cmdUusario.CommandText = "sp_listar_usu";
                cmdUusario.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdUusario);
                dt = new DataTable("usuario");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public DataTable Login(Usuario u)
        {
            using (SqlCommand cmd = new SqlCommand("sp_select_usu", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", u.nombreusu_u);
                cmd.Parameters.AddWithValue("@Contraseña", u.contraseña_u);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable ValidarAsistencia(Usuario u)
        {
            using (SqlCommand cmd = new SqlCommand("sp_validar_asis", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_empleado", u.idempleado_u);
                cmd.Parameters.AddWithValue("@Contraseña", u.contraseña_u);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public void RegistrarUsuario(Usuario objusu)
        {
            cmdUusario.Connection = Conec.AbrirConexion();
            cmdUusario.CommandText = "sp_registrar_usu";
            cmdUusario.CommandType = CommandType.StoredProcedure;
            cmdUusario.Parameters.AddWithValue("@Nombre", objusu.nombreusu_u);
            cmdUusario.Parameters.AddWithValue("@Contraseña", objusu.contraseña_u);
            cmdUusario.Parameters.AddWithValue("@Nivel_privil", objusu.privilegios_u);
            cmdUusario.Parameters.AddWithValue("@ID_empleado", objusu.idempleado_u);
            cmdUusario.ExecuteNonQuery();
            cmdUusario.Parameters.Clear();
        }

        public void ActualizarUsuario(Usuario objusu)
        {
            cmdUusario.Connection = Conec.AbrirConexion();
            cmdUusario.CommandText = "sp_actualizar_usu";
            cmdUusario.CommandType = CommandType.StoredProcedure;
            cmdUusario.Parameters.AddWithValue("@id_usu", objusu.idusuario_u);
            cmdUusario.Parameters.AddWithValue("@Nombre", objusu.nombreusu_u);
            cmdUusario.Parameters.AddWithValue("@Contraseña", objusu.contraseña_u);
            cmdUusario.Parameters.AddWithValue("@Nivel_privil", objusu.privilegios_u);
            cmdUusario.Parameters.AddWithValue("@ID_empleado", objusu.idempleado_u);
            cmdUusario.ExecuteNonQuery();
            cmdUusario.Parameters.Clear();
        }

        public void Eliminarusuario(int id)
        {
            cmdUusario.Connection = Conec.AbrirConexion();
            cmdUusario.CommandText = "sp_eliminar_usu";
            cmdUusario.CommandType = CommandType.StoredProcedure;
            cmdUusario.Parameters.AddWithValue("@id_emp", id);
            cmdUusario.ExecuteNonQuery();
            cmdUusario.Parameters.Clear();
        }

        public void EliminarUsu_id(Usuario u)
        {
            cmdUusario.Connection = Conec.AbrirConexion();
            cmdUusario.CommandText = "sp_eliminar_usuario";
            cmdUusario.CommandType = CommandType.StoredProcedure;
            cmdUusario.Parameters.AddWithValue("@id_usu", u.idusuario_u);
            cmdUusario.ExecuteNonQuery();
            cmdUusario.Parameters.Clear();
        }

        public DataTable ConsultarUsuario(Usuario u)
        {
            using (SqlCommand cmd = new SqlCommand("sp_buscar_usuario", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_usuario", u.idusuario_u);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable ValidarUsuario(Usuario u)
        {
            using (SqlCommand cmd = new SqlCommand("sp_validar_usuario", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_emp", u.idempleado_u);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable ValidarNomUsuario(Usuario u)
        {
            using (SqlCommand cmd = new SqlCommand("sp_validar_nomusu", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", u.nombreusu_u);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public void Actualizarnomusu(Usuario objusu)
        {
            cmdUusario.Connection = Conec.AbrirConexion();
            cmdUusario.CommandText = "sp_actualizar_nomusu";
            cmdUusario.CommandType = CommandType.StoredProcedure;
            cmdUusario.Parameters.AddWithValue("@idemp", objusu.idempleado_u);
            cmdUusario.Parameters.AddWithValue("@Contraseña", objusu.contraseña_u);
            cmdUusario.Parameters.AddWithValue("@Nombre", objusu.nombreusu_u);
            cmdUusario.ExecuteNonQuery();
            cmdUusario.Parameters.Clear();
        }

        public void Actualizarcontra(Usuario objusu, String pass)
        {
            cmdUusario.Connection = Conec.AbrirConexion();
            cmdUusario.CommandText = "sp_actualizar_contra";
            cmdUusario.CommandType = CommandType.StoredProcedure;
            cmdUusario.Parameters.AddWithValue("@idemp", objusu.idempleado_u);
            cmdUusario.Parameters.AddWithValue("@contraseña", objusu.contraseña_u);
            cmdUusario.Parameters.AddWithValue("@contranew", pass);
            cmdUusario.ExecuteNonQuery();
            cmdUusario.Parameters.Clear();
        }
    }
}
