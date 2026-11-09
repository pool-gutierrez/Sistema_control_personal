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
    public class Ncargo
    {
        DAOcargo daocar = new DAOcargo();
        public DataTable ListarCar()
        {
            return daocar.ListarCargo();
        }

        public void RegistrarCar(Cargo c)
        {
            daocar.RegistrarCargo(c);
        }

        public void ActualizarCar(Cargo c)
        {
            daocar.ActualizarCargo(c);
        }

        public DataTable ConsultarCar(Cargo c)
        {
            return daocar.ConsultarCargo(c);
        }
    }
}
