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
    public class Nusuario
    {
        DAOusuario daousu = new DAOusuario();
        public DataTable ListarUsu()
        {
            return daousu.ListarUsuario();
        }

        public DataTable Logsistema(Usuario obju)
        {
            return daousu.Login(obju);
        }

        public void RegistrarUsu(Usuario u)
        {
            daousu.RegistrarUsuario(u);
        }

        public DataTable ValidarAsis(Usuario obju)
        {
            return daousu.ValidarAsistencia(obju);
        }

        public void Eliminarusu(int id)
        {
            daousu.Eliminarusuario(id);
        }

        public void Eliminarusuid(Usuario u)
        {
            daousu.EliminarUsu_id(u);
        }

        public DataTable ConsultarUsu(Usuario u)
        {
            return daousu.ConsultarUsuario(u);
        }

        public void ActualizarUsu(Usuario u)
        {
            daousu.ActualizarUsuario(u);
        }

        public DataTable ValidarUsu(Usuario u)
        {
            return daousu.ValidarUsuario(u);
        }

        public DataTable ValidarnomUsu(Usuario u)
        {
            return daousu.ValidarNomUsuario(u);
        }

        public void Actualizarnomusu(Usuario u)
        {
            daousu.Actualizarnomusu(u);
        }

        public void Actualizarcontra(Usuario u, String pass)
        {
            daousu.Actualizarcontra(u, pass);
        }
    }
}
