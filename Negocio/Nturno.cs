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
    public class Nturno
    {
        DAOturno daotur = new DAOturno();
        public DataTable ListarTur()
        {
            return daotur.ListarTurno();
        }

        public void RegistrarTur(Turno t)
        {
            daotur.RegistrarTurno(t);
        }

        public void ActualizarTurn(Turno t)
        {
            daotur.ActualizarTurno(t);
        }

        public DataTable ConsultarTur(Turno t)
        {
            return daotur.ConsultarTurno(t);
        }
    }
}
