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
    public class DAOempleado
    {
        //sqlcomand permite trabajar con comando sql
        SqlCommand cmdEmpleado = new SqlCommand();
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection cone = new SqlConnection();
        public Conexion Conec = new Conexion();
        //Crear métodos: Listar, Insertar, Actualizar, Eliminar
        //Funcion
        public DataTable ListarEmpleado()
        {
            try
            {
                cmdEmpleado.Connection = new SqlConnection(Conexion.cn);
                cmdEmpleado.CommandText = "sp_listar_emp";
                cmdEmpleado.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdEmpleado);
                dt = new DataTable("empleado");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public DataTable ListarEmpleado2()
        {
            try
            {
                cmdEmpleado.Connection = new SqlConnection(Conexion.cn);
                cmdEmpleado.CommandText = "sp_listar_emp2";
                cmdEmpleado.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdEmpleado);
                dt = new DataTable("empleado2");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public DataTable ListarEmpleadoActivo()
        {
            try
            {
                cmdEmpleado.Connection = new SqlConnection(Conexion.cn);
                cmdEmpleado.CommandText = "sp_listar_empactivo";
                cmdEmpleado.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdEmpleado);
                dt = new DataTable("empleadoactivo");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public DataTable ListarEmpleadoInactivo()
        {
            try
            {
                cmdEmpleado.Connection = new SqlConnection(Conexion.cn);
                cmdEmpleado.CommandText = "sp_listar_empinactivo";
                cmdEmpleado.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdEmpleado);
                dt = new DataTable("empleadoinactivo");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public void RegistrarEmpleados(Empleado objempleado)
        {
                cmdEmpleado.Connection = Conec.AbrirConexion();
                cmdEmpleado.CommandText = "sp_registrar_emp";
                cmdEmpleado.CommandType = CommandType.StoredProcedure;
                cmdEmpleado.Parameters.AddWithValue("@Ape_paterno", objempleado.ape_pat_emp);
                cmdEmpleado.Parameters.AddWithValue("@Ape_materno", objempleado.ape_mat_emp);
                cmdEmpleado.Parameters.AddWithValue("@Nombres", objempleado.nombres_emp);
                cmdEmpleado.Parameters.AddWithValue("@Dni", objempleado.dni_emp);
                cmdEmpleado.Parameters.AddWithValue("@Sexo", objempleado.sexo_emp);
                cmdEmpleado.Parameters.AddWithValue("@Tel_fijo", objempleado.telfijo_emp);
                cmdEmpleado.Parameters.AddWithValue("@Celular", objempleado.celular_emp);
                cmdEmpleado.Parameters.AddWithValue("@Direccion", objempleado.dir_emp);
                cmdEmpleado.Parameters.AddWithValue("@Ciudad", objempleado.ciudad_emp);
                cmdEmpleado.Parameters.AddWithValue("@Distrito", objempleado.distrito_emp);
                cmdEmpleado.Parameters.AddWithValue("@Estado", objempleado.estado_emp);
                cmdEmpleado.Parameters.AddWithValue("@ID_turno", objempleado.id_turno);
                cmdEmpleado.Parameters.AddWithValue("@ID_horario", objempleado.id_horario);
                cmdEmpleado.Parameters.AddWithValue("@ID_departam", objempleado.id_departamento);
                cmdEmpleado.Parameters.AddWithValue("@ID_cargo", objempleado.id_cargo);
                cmdEmpleado.ExecuteNonQuery();
                cmdEmpleado.Parameters.Clear();
        }

        public DataTable ValidarDni(Empleado e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_validar_dni", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dni", e.dni_emp);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable BuscarIDemp(Empleado e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_buscar_idemp", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dni", e.dni_emp);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable BuscarDiaemp(Empleado e, String dia)
        {
            using (SqlCommand cmd = new SqlCommand("sp_buscar_dia", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_empleado", e.id_empleado);
                cmd.Parameters.AddWithValue("@Dia", dia);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable FiltrarEmpleado(Empleado e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_buscar_emp", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_empleado", e.id_empleado);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable BuscarEmpleado(Empleado objempleB)
        {
            using (SqlCommand cmd = new SqlCommand("sp_buscar_empleado", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_emp", objempleB.id_empleado);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public void ActualizarEmpleados(Empleado objempleadoM)
        {
            cmdEmpleado.Connection = Conec.AbrirConexion();
            cmdEmpleado.CommandText = "sp_actualizar_emp";
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            cmdEmpleado.Parameters.AddWithValue("@id_emp", objempleadoM.id_empleado);
            cmdEmpleado.Parameters.AddWithValue("@Ape_paterno", objempleadoM.ape_pat_emp);
            cmdEmpleado.Parameters.AddWithValue("@Ape_materno", objempleadoM.ape_mat_emp);
            cmdEmpleado.Parameters.AddWithValue("@Nombres", objempleadoM.nombres_emp);
            cmdEmpleado.Parameters.AddWithValue("@Dni", objempleadoM.dni_emp);
            cmdEmpleado.Parameters.AddWithValue("@Sexo", objempleadoM.sexo_emp);
            cmdEmpleado.Parameters.AddWithValue("@Tel_fijo", objempleadoM.telfijo_emp);
            cmdEmpleado.Parameters.AddWithValue("@Celular", objempleadoM.celular_emp);
            cmdEmpleado.Parameters.AddWithValue("@Direccion", objempleadoM.dir_emp);
            cmdEmpleado.Parameters.AddWithValue("@Ciudad", objempleadoM.ciudad_emp);
            cmdEmpleado.Parameters.AddWithValue("@Distrito", objempleadoM.distrito_emp);
            cmdEmpleado.Parameters.AddWithValue("@ID_turno", objempleadoM.id_turno);
            cmdEmpleado.Parameters.AddWithValue("@ID_horario", objempleadoM.id_horario);
            cmdEmpleado.Parameters.AddWithValue("@ID_departam", objempleadoM.id_departamento);
            cmdEmpleado.Parameters.AddWithValue("@ID_cargo", objempleadoM.id_cargo);
            cmdEmpleado.ExecuteNonQuery();
            cmdEmpleado.Parameters.Clear();
        }

        public void BajaEmpleado(Empleado objempleadoM)
        {
            cmdEmpleado.Connection = Conec.AbrirConexion();
            cmdEmpleado.CommandText = "sp_baja_emp";
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            cmdEmpleado.Parameters.AddWithValue("@id_emp", objempleadoM.id_empleado);
            cmdEmpleado.Parameters.AddWithValue("@Estado", objempleadoM.estado_emp);
            cmdEmpleado.ExecuteNonQuery();
            cmdEmpleado.Parameters.Clear();
        }

        public void AltaEmpleado(Empleado objempleadoM)
        {
            cmdEmpleado.Connection = Conec.AbrirConexion();
            cmdEmpleado.CommandText = "sp_alta_emp";
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            cmdEmpleado.Parameters.AddWithValue("@id_emp", objempleadoM.id_empleado);
            cmdEmpleado.Parameters.AddWithValue("@Estado", objempleadoM.estado_emp);
            cmdEmpleado.ExecuteNonQuery();
            cmdEmpleado.Parameters.Clear();
        }

        public void EliminarEmpleado(Empleado objempleadoM)
        {
            cmdEmpleado.Connection = Conec.AbrirConexion();
            cmdEmpleado.CommandText = "sp_eliminar_emp";
            cmdEmpleado.CommandType = CommandType.StoredProcedure;
            cmdEmpleado.Parameters.AddWithValue("@id_emp", objempleadoM.id_empleado);
            cmdEmpleado.ExecuteNonQuery();
            cmdEmpleado.Parameters.Clear();
        }

        public DataTable ComboEmpleado()
        {
            try
            {
                cmdEmpleado.Connection = new SqlConnection(Conexion.cn);
                cmdEmpleado.CommandText = "sp_select_emp";
                cmdEmpleado.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmdEmpleado);
                dt = new DataTable("empleado");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                Console.Write(ex);
            }
            return dt;
        }

        public DataTable ContarEmptur(Empleado e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_contar_emptur", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idturno", e.id_turno);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable ContarEmphor(Empleado e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_contar_emphor", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idhorario", e.id_horario);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable ContarEmpdep(Empleado e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_contar_empdep", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddep", e.id_departamento);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable ContarEmpcar(Empleado e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_contar_empcar", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcar", e.id_cargo);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable Listaractfiltro(Empleado e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_listar_actfiltro", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcargo", e.id_cargo);
                cmd.Parameters.AddWithValue("@iddep", e.id_departamento);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable Listarinactfiltro(Empleado e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_listar_inacfiltro", cone))
            {
                cmd.Connection = new SqlConnection(Conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcargo", e.id_cargo);
                cmd.Parameters.AddWithValue("@iddep", e.id_departamento);
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
