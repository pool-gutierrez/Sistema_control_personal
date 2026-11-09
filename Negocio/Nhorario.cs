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
    public class Nhorario
    {
        DAOhorario daohor = new DAOhorario();
        public DataTable ListarHor()
        {
            return daohor.ListarHorario();
        }

        public void RegistrarHor(Horario objhorario)
        {
            daohor.RegistrarHorario(objhorario);
        }

        public DataTable BuscaridHor()
        {
            return daohor.BuscaridHorario();
        }

        public void ActualizarHor(Horario objhorarioM)
        {
            daohor.ActualizarHorario(objhorarioM);
        }

        public DataTable BuscarHor(Horario objhoraB)
        {
            return daohor.BuscarHorario(objhoraB);
        }
    }
}
