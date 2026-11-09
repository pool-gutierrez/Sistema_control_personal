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
    public class Nasistencia
    {
        DAOasistencia daoasis = new DAOasistencia();

        public DataTable ListarAsis()
        {
            return daoasis.ListarAsistencia();
        }

        public void RegistrarEnt(Asistencia objasis)
        {
            daoasis.RegistrarEntrada(objasis);
        }

        public void RegistrarSal(Asistencia objasis)
        {
            daoasis.RegistrarSalida(objasis);
        }

        public DataTable ValidarEnt(Asistencia a)
        {
            return daoasis.ValidarEntrada(a);
        }

        public DataTable ValidarSal(Asistencia a)
        {
            return daoasis.ValidarSalida(a);
        }

        public DataTable ValidarHor(int idemp)
        {
            return daoasis.ValidarHorario(idemp);
        }

        public DataTable AsistenciaEmp(Asistencia a)
        {
            return daoasis.AsistenciaEmpleado(a);
        }

        public DataTable FiltrarAsis(String idemp, String idcar, String desc)
        {
            return daoasis.FiltrarAsistencia(idemp, idcar, desc);
        }

        public DataTable FiltrarAsisFecha(String f1, String f2)
        {
            return daoasis.FiltrarAsistenciaFecha(f1, f2);
        }

        public DataTable FiltrarAsisEmpFecha(int id, String f1, String f2)
        {
            return daoasis.FiltrarAsistenciaEmpFecha(id, f1, f2);
        }

        public void BorrarAsis(String f1, String f2)
        {
            daoasis.BorrarAsistencias(f1, f2);
        }
    }
}
