using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private int idusuario;
        private String nombreusu;
        private String contraseña;
        private int privilegios;
        private int idempleado;

        public int idusuario_u
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        public String nombreusu_u
        {
            get { return nombreusu; }
            set { nombreusu = value; }
        }

        public String contraseña_u
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public int privilegios_u
        {
            get { return privilegios; }
            set { privilegios = value; }
        }

        public int idempleado_u
        {
            get { return idempleado; }
            set { idempleado = value; }
        }

        public Usuario() 
        {}

        public Usuario(int idusuario_u, String nombreusu_u, String contraseña_u, int privilegios_u, int idempleado_u)
        {
            this.idusuario_u = idusuario_u;
            this.nombreusu_u = nombreusu_u;
            this.contraseña_u = contraseña_u;
            this.privilegios_u = privilegios_u;
            this.idempleado_u = idempleado_u;
        }
    }
}
