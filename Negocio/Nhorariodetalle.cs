using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Negocio
{
    public class Nhorariodetalle
    {
        DAOhorariodetalle daohord = new DAOhorariodetalle();
        public void RegistrarHordet(HorarioDetalle objhorarioD)
        {
            daohord.RegistrarHorariodetalle(objhorarioD);
        }

        public DataTable BuscarDet(HorarioDetalle objdet)
        {
            return daohord.BuscarDetalle(objdet);
        }

        public void ActualizarHordet(HorarioDetalle objhord)
        {
            daohord.ActualizarHorariodetalle(objhord);
        }
    }
}
