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
    public class DAOdepartamento
    {
        SqlCommand cmddepartamento = new SqlCommand();
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection cone = new SqlConnection();
        public Conexion Conec = new Conexion();

        public DataTable ListarDepartamento()
        {
            try
            {
                cmddepartamento.Connection = new SqlConnection(Conexion.cn);
                cmddepartamento.CommandText = "sp_listar_dep";
                cmddepartamento.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmddepartamento);
                dt = new DataTable("departamento");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public void RegistrarDepartamento(Departamento obj)
        {
            cmddepartamento.Connection = Conec.AbrirConexion();
            cmddepartamento.CommandText = "sp_registrar_departamento";
            cmddepartamento.CommandType = CommandType.StoredProcedure;
            cmddepartamento.Parameters.AddWithValue("@nombre", obj.nombredep_d);
            cmddepartamento.Parameters.AddWithValue("@descripcion", obj.descripciondep_d);
            cmddepartamento.Parameters.AddWithValue("@num_trab", obj.numtrabajadores_d);
            cmddepartamento.ExecuteNonQuery();
            cmddepartamento.Parameters.Clear();
        }

        public void ActualizarDepartamento(Departamento obj)
        {
            cmddepartamento.Connection = Conec.AbrirConexion();
            cmddepartamento.CommandText = "sp_actualizar_departamento";
            cmddepartamento.CommandType = CommandType.StoredProcedure;
            cmddepartamento.Parameters.AddWithValue("@id_departam", obj.iddepartam_d);
            cmddepartamento.Parameters.AddWithValue("@nombre", obj.nombredep_d);
            cmddepartamento.Parameters.AddWithValue("@descripcion", obj.descripciondep_d);
            cmddepartamento.Parameters.AddWithValue("@num_trab", obj.numtrabajadores_d);
            cmddepartamento.ExecuteNonQuery();
            cmddepartamento.Parameters.Clear();
        }

        public DataTable ConsultarDepartamento(Departamento d)
        {
            using (SqlCommand cmd = new SqlCommand("sp_buscar_departamento", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_departamento", d.iddepartam_d);
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
