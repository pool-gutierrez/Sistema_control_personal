using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Entidades;
using Datos;

namespace Negocio
{
    public class Ndepartamento
    {
        DAOdepartamento daodep = new DAOdepartamento();
        public DataTable ListarDep()
        {
            return daodep.ListarDepartamento();
        }

        public void Registrardep(Departamento d)
        {
            daodep.RegistrarDepartamento(d);
        }

        public void Actualizardep(Departamento d)
        {
            daodep.ActualizarDepartamento(d);
        }

        public DataTable ConsultarDep(Departamento d)
        {
            return daodep.ConsultarDepartamento(d);
        }
    }
}
