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
    public class Nempleado
    {
        DAOempleado daoemp = new DAOempleado();
        //metodo listar
        public DataTable ListarEmp()
        {
            return daoemp.ListarEmpleado();
        }

        public DataTable ListarEmp2()
        {
            return daoemp.ListarEmpleado2();
        }

        public DataTable ListarEmpAct()
        {
            return daoemp.ListarEmpleadoActivo();
        }

        public DataTable ListarEmpInac()
        {
            return daoemp.ListarEmpleadoInactivo();
        }

        public void RegistrarEmp(Empleado objempleado)
        {
            daoemp.RegistrarEmpleados(objempleado);
        }

        public DataTable ValDni(Empleado e)
        {
            return daoemp.ValidarDni(e);
        }

        public DataTable BuscarID(Empleado e)
        {
            return daoemp.BuscarIDemp(e);
        }

        public DataTable BuscarDia(Empleado e, String dia)
        {
            return daoemp.BuscarDiaemp(e, dia);
        }

        public DataTable FiltrarEmp(Empleado e)
        {
            return daoemp.FiltrarEmpleado(e);
        }

        public void ActualizarEmp(Empleado objempleadoM)
        {
            daoemp.ActualizarEmpleados(objempleadoM);
        }

        public DataTable BuscarEmp(Empleado objempleB)
        {
            return daoemp.BuscarEmpleado(objempleB);
        }

        public void BajaEmp(Empleado objempleadoM)
        {
            daoemp.BajaEmpleado(objempleadoM);
        }

        public void AltaEmp(Empleado objempleadoM)
        {
            daoemp.BajaEmpleado(objempleadoM);
        }

        public void EliminarEmp(Empleado objempleadoM)
        {
            daoemp.EliminarEmpleado(objempleadoM);
        }

        public DataTable Comboemp()
        {
            return daoemp.ComboEmpleado();
        }

        public DataTable Contartur(Empleado e)
        {
            return daoemp.ContarEmptur(e);
        }

        public DataTable Contarhor(Empleado e)
        {
            return daoemp.ContarEmphor(e);
        }

        public DataTable Contardep(Empleado e)
        {
            return daoemp.ContarEmpdep(e);
        }

        public DataTable Contarcar(Empleado e)
        {
            return daoemp.ContarEmpcar(e);
        }

        public DataTable Listaractfiltro(Empleado e)
        {
            return daoemp.Listaractfiltro(e);
        }

        public DataTable Listarinactfiltro(Empleado e)
        {
            return daoemp.Listarinactfiltro(e);
        }
    }
}
