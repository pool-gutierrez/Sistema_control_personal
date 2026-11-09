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
    public class DAOcargo
    {
        SqlCommand cmdcargo = new SqlCommand();
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection cone = new SqlConnection();
        public Conexion Conec = new Conexion();
        public DataTable ListarCargo()
        {
            try
            {
                cmdcargo.Connection = new SqlConnection(Conexion.cn);
                cmdcargo.CommandText = "sp_listar_car";
                cmdcargo.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdcargo);
                dt = new DataTable("cargo");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public void RegistrarCargo(Cargo obj)
        {
            cmdcargo.Connection = Conec.AbrirConexion();
            cmdcargo.CommandText = "sp_registrar_cargo";
            cmdcargo.CommandType = CommandType.StoredProcedure;
            cmdcargo.Parameters.AddWithValue("@nombre", obj.nombrecar_c);
            cmdcargo.Parameters.AddWithValue("@descripcion", obj.descripcioncar_c);
            cmdcargo.Parameters.AddWithValue("@id_dep", obj.iddep_c);
            cmdcargo.ExecuteNonQuery();
            cmdcargo.Parameters.Clear();
        }

        public void ActualizarCargo(Cargo obj)
        {
            cmdcargo.Connection = Conec.AbrirConexion();
            cmdcargo.CommandText = "sp_actualizar_cargo";
            cmdcargo.CommandType = CommandType.StoredProcedure;
            cmdcargo.Parameters.AddWithValue("@id_cargo", obj.idcargo_c);
            cmdcargo.Parameters.AddWithValue("@nombre", obj.nombrecar_c);
            cmdcargo.Parameters.AddWithValue("@descripcion", obj.descripcioncar_c);
            cmdcargo.Parameters.AddWithValue("@id_dep", obj.iddep_c);
            cmdcargo.ExecuteNonQuery();
            cmdcargo.Parameters.Clear();
        }

        public DataTable ConsultarCargo(Cargo c)
        {
            using (SqlCommand cmd = new SqlCommand("sp_buscar_cargo", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cargo", c.idcargo_c);
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
