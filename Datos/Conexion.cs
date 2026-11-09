using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        public static string cn = "Data Source=.;Initial Catalog=bd_control_personal;Integrated Security=True";
        public SqlConnection conec = new SqlConnection(cn);

        public SqlConnection AbrirConexion()
        {
            if (conec.State == ConnectionState.Closed)
            {
                conec.Open();
            }
            return conec;
        }

        public SqlConnection CerrarConexion()
        {
            if (conec.State == ConnectionState.Open)
            {
                conec.Close();
            }
            return conec;
        } 
    }
}
